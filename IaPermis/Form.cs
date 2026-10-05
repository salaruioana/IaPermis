/*************************************************************************
* Fișier:          FormMain.cs *
* Autor:           Șalaru Ioana – Interfață Grafică & Help *
* Data:            Mai 2026 *
* Proiect:         IaPermis – Chestionare Auto *
* Funcționalitate: Navigare între panouri, timer countdown, *
*                  font dinamic răspunsuri, afișare poză, *
*                  colorare rezultat final. *
*                  Integrare cu QuizAppCore, QuizAppData, *
*                  QuizAppServices. *
 ************************************************************************ */

using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

using QuizAppCore;
using QuizAppData;
using QuizAppServices;

namespace IaPermis
{
    public partial class FormMain : Form
    {
        // variabile de stare internă

        private string _currentUser = "";      // setat după login
        private int _totalQuestions = 26;      // total întrebări în sesiune
        private int _wrongAnswers = 0;         // greșeli în sesiunea curentă
        private int _secondsLeft = 30;         // secunde rămase per întrebare
        private bool _answerSelected = false;  // true după ce s-a ales un răspuns
        private bool _processingAnswer = false;// previne dublu-click în delay-ul de 700ms

        private System.Windows.Forms.Timer _questionTimer;

        // ── Servicii din DLL-uri ──
        private AuthService _authService;
        private QuizController _quizController;
        private StatisticsService _statsService;

        private static readonly string UsersFilePath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.txt");
        private static readonly string QuestionsXmlPath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "questions.xml");
        private static readonly string StatsFilePath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "statistics.txt");

        /// <summary>
        /// Constructor principal al formularului.
        /// Initializeaza serviciile, timer-ul si afiseaza panoul de login.
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            InitializeServices();
            SetupTimer();

            // Ascundem toate panourile si aducem login-ul in prim-plan
            foreach (var p in AllPanels)
                p.Visible = false;
            panelLogin.Visible = true;
            panelLogin.BringToFront();
        }

        /// <summary>
        /// Inițializează serviciile din DLL-uri.
        /// AuthService, QuestionRepository si StatisticsService.
        /// QuizController ramane null pana la autentificare.
        /// </summary>
        private void InitializeServices()
        {
            try
            {
                var userRepo = new UserRepository(UsersFilePath);
                _authService = new AuthService(userRepo);

                var questionRepo = new QuestionRepository(QuestionsXmlPath);
                _statsService = new StatisticsService(StatsFilePath);

                // QuizController se instanțiază după login (are nevoie de User)
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Eroare la inițializarea aplicației:\n{ex.Message}",
                    "Eroare critică",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Returneaza array-ul cu toate panourile din formular,
        /// folosit pentru tranzitii si pentru a ascunde toate panourile simultan.
        /// </summary>
        private Panel[] AllPanels => new Panel[]
        {
            panelLogin, panelRegister, panelMenu,
            panelStatistics, panelQuiz, panelResults
        };

        /// <summary>
        /// Realizeaza o tranzitie fade-out / fade-in intre panouri.
        /// Ascunde toate panourile, face vizibil doar target-ul si animeaza opacitatea.
        /// </summary>
        /// <param name="target">Panoul care trebuie afisat dupa tranzitie.</param>
        private async Task ShowPanel(Panel target)
        {
            // Fade out: scadem opacitatea pana la 0
            for (double op = 1.0; op >= 0.0; op -= 0.08)
            {
                this.Opacity = op;
                await Task.Delay(8);
            }

            // Ascundem toate panourile si il afisam doar pe cel dorit
            foreach (var p in AllPanels)
                p.Visible = false;

            target.Visible = true;
            target.BringToFront();

            // Fade in: crestem opacitatea inapoi la 1
            for (double op = 0.0; op <= 1.0; op += 0.08)
            {
                this.Opacity = op;
                await Task.Delay(8);
            }
            this.Opacity = 1.0;
        }

        /// <summary>
        /// Configureaza timer-ul de intrebare: interval de 1 secunda
        /// si asociaza handler-ul de tick.
        /// </summary>
        private void SetupTimer()
        {
            _questionTimer = new System.Windows.Forms.Timer();
            _questionTimer.Interval = 1000;
            _questionTimer.Tick += QuestionTimer_Tick;
        }

        /// <summary>
        /// Handler apelat la fiecare secunda de catre timer.
        /// Decrementeaza cronometrul si trateaza expirarea timpului.
        /// </summary>
        private void QuestionTimer_Tick(object sender, EventArgs e)
        {
            _secondsLeft--;
            UpdateTimerDisplay();

            if (_secondsLeft <= 0)
            {
                _questionTimer.Stop();
                OnTimeExpired();
            }
        }

        /// <summary>
        /// Actualizeaza label-ul cu timpul ramas si ii schimba culoarea
        /// in functie de urgenta: verde > 15s, portocaliu > 7s, rosu <= 7s.
        /// </summary>
        private void UpdateTimerDisplay()
        {
            labelQuizTimeValue.Text = $"{_secondsLeft}s";

            if (_secondsLeft > 15)
                labelQuizTimeValue.ForeColor = Color.DarkGreen;
            else if (_secondsLeft > 7)
                labelQuizTimeValue.ForeColor = Color.DarkOrange;
            else
                labelQuizTimeValue.ForeColor = Color.Crimson;
        }

        /// <summary>
        /// Tratarea expirarii timpului pentru o intrebare.
        /// Trimite un index invalid (-1) ca raspuns gresit si verifica limita de greseli.
        /// </summary>
        private void OnTimeExpired()
        {
            // Index -1 → IsCorrect returneaza false → raspuns gresit automat
            if (_quizController != null)
                _quizController.AnswerQuestion(-1); // index invalid → IsCorrect returnează false

            _wrongAnswers++;
            labelQuizWrongAnswers.Text = $"Greșeli: {_wrongAnswers}/3";

            // Daca s-au acumulat 3 greseli, quiz-ul se termina imediat
            if (_wrongAnswers >= 3)
            {
                EndQuiz();
                return;
            }

            NextQuestion();
        }

        /// <summary>
        /// Reseteaza si porneste timer-ul pentru o intrebare noua.
        /// </summary>
        private void StartQuestionTimer()
        {
            _secondsLeft = 30;
            UpdateTimerDisplay();
            _questionTimer.Start();
        }

        // ── Logica de quiz ──

        /// <summary>
        /// Incarca si afiseaza intrebarea curenta din sesiune:
        /// text, variante de raspuns, imagine si progress bar.
        /// Reseteaza starea de raspuns si porneste timer-ul.
        /// </summary>
        private async void LoadQuestion()
        {
            _answerSelected = false;
            _processingAnswer = false;
            buttonQuizNext.Enabled = false;

            Question q = null;
            try
            {
                q = _quizController?.GetCurrentQuestion();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la încărcarea întrebării:\n{ex.Message}",
                    "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                await ShowPanel(panelMenu);
                return;
            }

            // Daca nu mai sunt intrebari, finalizam quiz-ul
            if (q == null)
            {
                EndQuiz();
                return;
            }

            int currentDisplayIndex = _quizController.CurrentQuestionIndex;
            int total = _quizController.TotalQuestions;

            progressBarQuiz.Maximum = total;
            progressBarQuiz.Value = currentDisplayIndex;

            labelQuizQuestionNumber.Text = $"Număr: {currentDisplayIndex + 1}/{total}";
            labelQuizWrongAnswers.Text = $"Greșeli: {_wrongAnswers}/3";

            // Afisam textul intrebarii
            labelQuizQuestion.Text = q.Text;
            labelQuizQuestion.Visible = true;
            labelQuizQuestion.BringToFront();

            // Populam butoanele cu variantele de raspuns
            SetAnswerButtons(q.Options);

            // Incarcam imaginea asociata (daca exista)
            LoadQuestionImage(q.ImagePath);

            StartQuestionTimer();
            labelQuizQuestion.Visible = true;
            labelQuizQuestion.BringToFront();
            panelQuiz.Refresh();
        }

        /// <summary>
        /// Seteaza textul si vizibilitatea butoanelor de raspuns
        /// in functie de variantele disponibile pentru intrebarea curenta.
        /// Ajusteaza si dimensiunea fontului in functie de lungimea textului.
        /// </summary>
        /// <param name="answers">Array-ul cu variantele de raspuns.</param>
        private void SetAnswerButtons(string[] answers)
        {
            Button[] buttons = { buttonQuizAnswer1, buttonQuizAnswer2,
                                  buttonQuizAnswer3, buttonQuizAnswer4 };

            for (int i = 0; i < buttons.Length; i++)
            {
                if (i < answers.Length && !string.IsNullOrEmpty(answers[i]))
                {
                    // Varianta exista — o afisam si o activam
                    buttons[i].Text = answers[i];
                    buttons[i].Enabled = true;
                    buttons[i].Visible = true;
                    buttons[i].BackColor = Color.LightCyan;
                    AdjustButtonFont(buttons[i]);
                }
                else
                {
                    // Varianta lipseste — ascundem butonul
                    buttons[i].Text = "";
                    buttons[i].Enabled = false;
                    buttons[i].Visible = false;
                }
            }
        }

        /// <summary>
        /// Ajusteaza dimensiunea fontului unui buton de raspuns
        /// in functie de lungimea textului, pentru a evita trunchierile.
        /// </summary>
        /// <param name="btn">Butonul caruia i se ajusteaza fontul.</param>
        private void AdjustButtonFont(Button btn)
        {
            int len = btn.Text.Length;
            float fontSize;

            // Cu cat textul e mai lung, cu atat fontul e mai mic
            if (len <= 20) fontSize = 11f;
            else if (len <= 50) fontSize = 9f;
            else if (len <= 100) fontSize = 7.5f;
            else fontSize = 6f;

            btn.Font = new Font("Microsoft Sans Serif", fontSize);
        }

        /// <summary>
        /// Incarca imaginea asociata intrebarii in pictureBoxQuiz.
        /// Daca nu exista imagine, ascunde picture box-ul si mareste spatiul pentru text.
        /// Prinde exceptiile de fisier lipsa fara sa opreasca aplicatia.
        /// </summary>
        /// <param name="imagePath">Calea relativa sau absoluta catre imagine.</param>
        private void LoadQuestionImage(string imagePath)
        {
            pictureBoxQuiz.Image = null;

            // Fara imagine — extindem label-ul intrebarii pe toata inaltimea disponibila
            if (string.IsNullOrEmpty(imagePath))
            {
                pictureBoxQuiz.Visible = false;
                labelQuizQuestion.Size = new Size(530, 150);
                labelQuizQuestion.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold);
            }
            else
            {
                // Cu imagine — micsoram label-ul si afisam picture box-ul
                pictureBoxQuiz.Visible = true;
                labelQuizQuestion.Size = new Size(530, 78); 
                labelQuizQuestion.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold);

                try
                {
                    string fullPath = Path.IsPathRooted(imagePath)
                        ? imagePath
                        : Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagePath);

                    if (File.Exists(fullPath))
                    {
                        // Citim imaginea din stream pentru a nu bloca fisierul pe disc
                        using (var stream = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                        {
                            pictureBoxQuiz.Image = Image.FromStream(stream);
                        }
                        pictureBoxQuiz.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
                catch { /* Imaginea lipseste sau e corupta — continuam fara ea */ }
            }
            labelQuizQuestion.BringToFront();
        }

        /// <summary>
        /// Opreste timer-ul curent si incarca urmatoarea intrebare.
        /// </summary>
        private void NextQuestion()
        {
            _questionTimer.Stop();
            LoadQuestion();
        }

        /// <summary>
        /// Finalizeaza sesiunea de quiz: opreste timer-ul, calculeaza rezultatul,
        /// il salveaza in istoricul utilizatorului si afiseaza panoul de rezultate.
        /// </summary>
        private async void EndQuiz()
        {
            _questionTimer.Stop();

            QuizResult result = null;
            try
            {
                result = _quizController?.FinishQuiz();

                // Salvăm rezultatul în istoricul utilizatorului curent
                if (result != null)
                    _authService?.SaveScoreForCurrentUser(result);

                // Actualizăm statisticile
                if (result != null && _authService?.CurrentLoggedInUser != null)
                    _statsService?.AddResult(_authService.CurrentLoggedInUser.Username, result);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la finalizarea quiz-ului:\n{ex.Message}",
                    "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int score = result?.Score ?? 0;
            ShowResults(score, result?.TotalQuestions ?? _totalQuestions);
            await ShowPanel(panelResults);
        }

        /// <summary>
        /// Afiseaza rezultatul final in panoul de rezultate.
        /// Coloreaza fundalul in verde (promovat) sau rosu (picat)
        /// in functie de pragul de 22 de raspunsuri corecte.
        /// </summary>
        /// <param name="score">Numarul de raspunsuri corecte obtinute.</param>
        /// <param name="total">Numarul total de intrebari din sesiune.</param>
        private void ShowResults(int score, int total)
        {
            labelResultsNumber.Text = $"Rezultat: {score}/{total}";
            labelResultsHiUser.Text = $"Salut, {_currentUser}!";

            bool passed = score >= 22;

            if (passed)
            {
                groupBoxResults.BackColor = Color.YellowGreen;
                labelResultsMessage.Text = "Felicitări, ai trecut!";
                labelResultsMessage.ForeColor = Color.DarkGreen;
            }
            else
            {
                groupBoxResults.BackColor = Color.Crimson;
                labelResultsMessage.Text = "Ai picat, mai învață..";
                labelResultsMessage.ForeColor = Color.White;
            }
        }

        //  HANDLERS PANEL LOGIN

        /// <summary>
        /// Valideaza campurile de login si autentifica utilizatorul.
        /// In caz de succes, navigheaza catre panoul de meniu principal.
        /// </summary>
        private async void buttonLoginAutentificare_Click(object sender, EventArgs e)
        {
            string user = textBoxLoginUser.Text.Trim();
            string pass = textBoxLoginPassword.Text;

            // Verificam ca ambele campuri sunt completate
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Completează utilizatorul și parola!", "Atenție",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool ok = _authService.Login(user, pass);
                if (!ok)
                {
                    MessageBox.Show("Utilizator sau parolă incorecte!", "Eroare",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Login reusit — setam utilizatorul curent si navigam la meniu
                _currentUser = user;
                labelHiUser.Text = $"Salut, {_currentUser}!";
                await ShowPanel(panelMenu);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la autentificare:\n{ex.Message}", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Navigheaza catre panoul de inregistrare cont nou.
        /// </summary>
        private async void buttonLoginCreateAccount_Click(object sender, EventArgs e)
        {
            await ShowPanel(panelRegister);
        }

        /// <summary>
        /// Deschide fisierul de ajutor CHM al aplicatiei.
        /// </summary>
        private void buttonLoginHelp_Click(object sender, EventArgs e)
        {
            ShowHelp("autentificare.htm");
        }

        //  HANDLERS PANEL REGISTER

        /// <summary>
        /// Valideaza datele introduse, creeaza contul nou si logheaza automat utilizatorul.
        /// Prinde exceptiile specifice pentru username si parola invalide.
        /// </summary>
        private async void buttonRegister_Click(object sender, EventArgs e)
        {
            string user = textBoxRegisterUser.Text.Trim();
            string pass = textBoxRegisterPassword.Text;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Completează toate câmpurile!", "Atenție",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool ok = _authService.Register(user, pass);
                if (!ok)
                {
                    MessageBox.Show("Există deja un cont cu acest utilizator!", "Atenție",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // După înregistrare reușită, logăm automat
                _authService.Login(user, pass);
                _currentUser = user;

                MessageBox.Show("Cont creat cu succes!", "Succes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                labelHiUser.Text = $"Salut, {_currentUser}!";
                await ShowPanel(panelMenu);
            }
            catch (InvalidPasswordExceptions ex)
            {
                MessageBox.Show(ex.Message, "Parolă invalidă",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (InvalidUsernameException ex)
            {
                // Excepția specifică definită (caractere speciale, username scurt)
                MessageBox.Show(ex.Message, "Utilizator invalid",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la crearea contului:\n{ex.Message}", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Deschide fisierul de ajutor din panoul de inregistrare.
        /// </summary>
        private void buttonRegisterHelp_Click(object sender, EventArgs e)
        {
            ShowHelp("crearecont.htm");
        }

        //  HANDLERS PANEL MENU

        // <summary>
        /// Initializeaza un quiz nou cu selectie aleatorie si navigheaza la panoul de quiz.
        /// Verifica sesiunea activa si reseteaza starea locala a greselilor.
        /// </summary>
        private async void buttonMenuStartQuiz_Click(object sender, EventArgs e)
        {
            try
            {
                User loggedUser = _authService.CurrentLoggedInUser;
                if (loggedUser == null)
                {
                    MessageBox.Show("Sesiunea a expirat. Te rugăm să te autentifici din nou.",
                        "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Logout();
                    return;
                }

                var questionRepo = new QuestionRepository("questions.xml");
                _quizController = new QuizController(questionRepo, loggedUser);

                // Pornim quiz-ul fără filtrare pe categorie (toate întrebările)
                _quizController.StartQuiz("");

                // Resetăm starea locală
                _wrongAnswers = 0;
                _totalQuestions = 26;

                await ShowPanel(panelQuiz);

                LoadQuestion();
                panelQuiz.Refresh();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la pornirea quiz-ului:\n{ex.Message}", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Incarca statisticile utilizatorului curent si navigheaza la panoul de statistici.
        /// </summary>
        private async void buttonMenuStatistics_Click(object sender, EventArgs e)
        {
            LoadStatistics();
            await ShowPanel(panelStatistics);
        }

        /// <summary>
        /// Deconecteaza utilizatorul curent si revine la ecranul de login.
        /// </summary>
        private void buttonMenuLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        /// <summary>
        /// Deschide fisierul de ajutor din meniul principal.
        /// </summary>
        private void buttonMenuHelp_Click(object sender, EventArgs e)
        {
            ShowHelp("meniuprincipal.htm");
        }

        //  HANDLERS PANEL STATISTICS

        /// <summary>
        /// Incarca si afiseaza rata de trecere si scorul mediu
        /// pentru utilizatorul autentificat in momentul curent.
        /// </summary>
        private void LoadStatistics()
        {
            labelStatisticsUser.Text = $"Utilizator: {_currentUser}";

            try
            {
                User loggedUser = _authService?.CurrentLoggedInUser;

                var history = _statsService.GetHistory(loggedUser.Username);

                // Daca nu exista istoric, afisam placeholder-uri
                if (loggedUser == null || history.Count == 0)
                {
                    labelStatisticsPassRate.Text = "Rata de trecere: -- %";
                    labelStatisticsAverage.Text = "Scor mediu: --/26";
                    return;
                }

                // Calculam si afisam statisticile din serviciu
                double passRate = _statsService.GetPassRate(loggedUser.Username);
                double avgScore = _statsService.GetAvgScore(loggedUser.Username);

                labelStatisticsPassRate.Text = $"Rata de trecere: {passRate:F1} %";
                labelStatisticsAverage.Text = $"Scor mediu: {avgScore:F1}/26";
            }
            catch (Exception ex)
            {
                labelStatisticsPassRate.Text = "Rata de trecere: eroare";
                labelStatisticsAverage.Text = "Scor mediu: eroare";
                Console.WriteLine($"Eroare statistici: {ex.Message}");
            }
        }

        /// <summary>
        /// Navigheaza inapoi la meniul principal din panoul de statistici.
        /// </summary>
        private async void buttonStatisticsBack_Click(object sender, EventArgs e)
        {
            await ShowPanel(panelMenu);
        }

        /// <summary>
        /// Deconecteaza utilizatorul din panoul de statistici.
        /// </summary>
        private void buttonStatisticsLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        /// <summary>
        /// Deschide fisierul de ajutor din panoul de statistici.
        /// </summary>
        private void buttonStatisticsHelp_Click(object sender, EventArgs e)
        {
            ShowHelp("statistici.htm");
        }

        //  HANDLERS PANEL QUIZ

        // Fiecare buton de raspuns apeleaza HandleAnswer cu indexul corespunzator
        private void buttonQuizAnswer1_Click(object sender, EventArgs e) => HandleAnswer(0);
        private void buttonQuizAnswer2_Click(object sender, EventArgs e) => HandleAnswer(1);
        private void buttonQuizAnswer3_Click(object sender, EventArgs e) => HandleAnswer(2);
        private void buttonQuizAnswer4_Click(object sender, EventArgs e) => HandleAnswer(3);

        /// <summary>
        /// Proceseaza raspunsul ales de utilizator: opreste timer-ul,
        /// ofera feedback vizual (verde/rosu), actualizeaza greselile
        /// si activeaza butonul de continuare dupa 700ms.
        /// </summary>
        /// <param name="answerIndex">Indexul variantei alese (0-based).</param>
        private async void HandleAnswer(int answerIndex)
        {
            // previne dublu-click sau click după ce s-a ales deja un răspuns
            if (_processingAnswer || _answerSelected)
                return;

            _processingAnswer = true;
            _questionTimer.Stop();
            _answerSelected = true;

            bool correct = false;
            try
            {
                // Obținem răspunsul corect ÎNAINTE de SubmitAnswer
                Question currentQ = _quizController?.GetCurrentQuestion();
                correct = currentQ?.IsCorrect(answerIndex) ?? false;

                // Trimitem răspunsul la sesiune (avansează CurrentIndex intern)
                _quizController?.AnswerQuestion(answerIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la procesarea răspunsului:\n{ex.Message}",
                    "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _processingAnswer = false;
                return;
            }

            Button[] buttons = { buttonQuizAnswer1, buttonQuizAnswer2,
                                  buttonQuizAnswer3, buttonQuizAnswer4 };

            // Dezactivează toate butoanele în timpul feedback-ului
            foreach (var btn in buttons)
                btn.Enabled = false;

            // Feedback vizual: verde = corect, roșu = greșit
            buttons[answerIndex].BackColor = correct ? Color.LightGreen : Color.LightCoral;

            if (!correct)
            {
                _wrongAnswers++;
                labelQuizWrongAnswers.Text = $"Greșeli: {_wrongAnswers}/3";
            }

            await Task.Delay(700);

            // Resetează culorile
            foreach (var btn in buttons)
                btn.BackColor = Color.LightCyan;

            _processingAnswer = false;

            // dacă 3 greșeli → quiz terminat imediat, fără a mai activa "Continuă"
            if (_wrongAnswers >= 3)
            {
                EndQuiz();
                return;
            }

            // Activează "Continuă" abia după procesarea răspunsului
            buttonQuizNext.Enabled = true;
        }

        /// <summary>
        /// Handler pentru butonul "Continua".
        /// Verifica ca un raspuns a fost selectat, apoi incarca urmatoarea intrebare.
        /// </summary>
        private void buttonQuizNext_Click(object sender, EventArgs e)
        {
            // nu se poate da Continuă fără răspuns
            if (!_answerSelected)
            {
                MessageBox.Show("Selectează un răspuns înainte de a continua!",
                    "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // dezactivăm butonul imediat ca să nu se poată apăsa de două ori
            buttonQuizNext.Enabled = false;
            NextQuestion();
        }

        /// <summary>
        /// Afiseaza o confirmare si paraseste quiz-ul fara a salva progresul.
        /// Reseteaza controller-ul si revine la meniu.
        /// </summary>
        private async void buttonQuizLeave_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Ești sigur că vrei să părăsești chestionarul?\nProgresul nu va fi salvat.",
                "Confirmare",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _questionTimer.Stop();
                _quizController = null; // resetăm controller-ul
                await ShowPanel(panelMenu);
            }
        }

        /// <summary>
        /// Deschide fisierul de ajutor din panoul de quiz.
        /// </summary>
        private void buttonQuizHelp_Click(object sender, EventArgs e)
        {
            ShowHelp("chestionar.htm");
        }

        //  HANDLERS PANEL RESULTS

        /// <summary>
        /// Navigheaza inapoi la meniul principal din panoul de rezultate.
        /// </summary>
        private async void buttonResultsBackToMenu_Click(object sender, EventArgs e)
        {
            await ShowPanel(panelMenu);
        }

        /// <summary>
        /// Incarca statisticile si navigheaza la panoul de statistici din rezultate.
        /// </summary>
        private async void buttonResultsSeeStatistics_Click(object sender, EventArgs e)
        {
            LoadStatistics();
            await ShowPanel(panelStatistics);
        }

        /// <summary>
        /// Deconecteaza utilizatorul din panoul de rezultate.
        /// </summary>
        private void buttonResultsLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        /// <summary>
        /// Deschide fisierul de ajutor din panoul de rezultate.
        /// </summary>
        private void buttonResultsHelp_Click(object sender, EventArgs e)
        {
            ShowHelp("rezultate.htm");
        }

        //  UTILITARE COMUNE

        /// <summary>
        /// Deconecteaza utilizatorul curent: opreste timer-ul, reseteaza toate campurile
        /// si navigheaza la ecranul de login.
        /// </summary>
        private async void Logout()
        {
            _questionTimer.Stop();
            _authService?.Logout();
            _quizController = null;
            _currentUser = "";
            textBoxLoginUser.Text = "";
            textBoxLoginPassword.Text = "";
            await ShowPanel(panelLogin);
        }

        /// <summary>
        /// Deschide fisierul de ajutor CHM al aplicatiei.
        /// Daca fisierul lipseste, afiseaza un mesaj de avertizare.
        /// </summary>
        private void ShowHelp(string topic = "index.htm")
        {
            string helpPath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "IaPermisHelp.chm");

            if (File.Exists(helpPath))
                System.Windows.Forms.Help.ShowHelp(this, helpPath, HelpNavigator.Topic, topic);
            else
                MessageBox.Show("Fișierul de ajutor nu a fost găsit!", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}