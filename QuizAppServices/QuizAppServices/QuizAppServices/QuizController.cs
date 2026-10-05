/*************************************************************************
* Fișier:          QuizController.cs
* Autor:           David Bianca
* Data:            Mai 2026
* Proiect:         IaPermis – Chestionare Auto
* Funcționalitate: Controlează desfășurarea quiz-ului, gestionarea
*                  întrebărilor și calcularea rezultatului final.
*************************************************************************/

using QuizAppCore;
using QuizAppData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizAppServices
{
    public class QuizController
    {
        // Repository-ul din care se incarca intrebarile
        private IQuestionRepository _repo;

        // Sesiunea activa a quiz-ului curent
        private QuizSession _session;

        // Utilizatorul care sustine quiz-ul
        private User _user;

        // Strategia folosita pentru selectarea intrebarilor
        private IQuestionSelectionStrategy _strategy;

        /// <summary>
        /// Indexul intrebarii curente in cadrul sesiunii active.
        /// </summary>
        public int CurrentQuestionIndex => _session.CurrentIndex;

        /// <summary>
        /// Numarul total de intrebari din sesiunea curenta.
        /// </summary>
        public int TotalQuestions => _session.Questions.Count;

        /// <summary>
        /// Initializeaza controller-ul de quiz cu dependentele necesare.
        /// Daca nu este furnizata o strategie, se foloseste selectia aleatorie implicita.
        /// </summary>
        /// <param name="repo">Repository-ul de intrebari.</param>
        /// <param name="user">Utilizatorul care sustine quiz-ul.</param>
        /// <param name="strategy">Strategia de selectie a intrebarilor (optional).</param>
        public QuizController(IQuestionRepository repo, User user,
            IQuestionSelectionStrategy strategy = null)  
        {
            _repo = repo;
            _user = user;
            _session = new QuizSession();
            // Daca nu se specifica o strategie, se foloseste cea aleatorie cu 26 de intrebari
            _strategy = strategy ?? new RandomSelectionStrategy(); 
        }

        /// <summary>
        /// Porneste un quiz nou pentru categoria specificata.
        /// Incarca intrebarile si initializeaza sesiunea.
        /// </summary>
        /// <param name="cat">Categoria intrebarilor. String gol inseamna toate categoriile.</param>
        public void StartQuiz(string cat)
        {
            // Preluam intrebarile in functie de categorie
            var all = string.IsNullOrEmpty(cat)
                ? _repo.GetAll()
                : _repo.GetByCategory(cat);

            if (all == null || all.Count == 0)
                throw new Exception("Nu s-au găsit întrebări pentru categoria selectată!");

            // Aplicam strategia de selectie
            _session.Questions = _strategy.Select(all);

            if (_session.Questions.Count == 0)
                throw new Exception("Strategia de selecție nu a returnat nicio întrebare!");

            _session.Start();
        }

        /// <summary>
        /// Inregistreaza raspunsul utilizatorului pentru intrebarea curenta.
        /// Avanseaza automat la urmatoarea intrebare.
        /// </summary>
        /// <param name="idx">Indexul variantei de raspuns alese (0-based).</param>
        public void AnswerQuestion(int idx)
        {
            if (_session == null)
                throw new InvalidOperationException("Sesiunea nu a fost inițializată.");

            if (_session.CurrentIndex >= _session.Questions.Count)
                throw new InvalidOperationException("Toate întrebările au fost deja răspunse.");

            _session.SubmitAnswer(idx);
        }

        /// <summary>
        /// Finalizeaza quiz-ul, calculeaza rezultatul si il salveaza in istoricul utilizatorului.
        /// </summary>
        /// <returns>Obiectul QuizResult cu scorul si statusul de promovare.</returns>
        public QuizResult FinishQuiz()
        {
            QuizResult result = _session.GetResult();
            _user.ScoreHistory.Add(result);
            return result;
        }

        /// <summary>
        /// Returneaza intrebarea curenta din sesiunea activa.
        /// Returneaza null daca toate intrebarile au fost parcurse.
        /// </summary>
        /// <returns>Obiectul Question curent sau null.</returns>
        public Question GetCurrentQuestion()
        {
            // Verificam ca nu am depasit numarul de intrebari
            if (_session.CurrentIndex < _session.Questions.Count)
                return _session.Questions[_session.CurrentIndex];
            return null;
        }
    }
}