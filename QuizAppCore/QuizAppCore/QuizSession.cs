/*************************************************************************
* Fișier:          QuizSession.cs
* Autor:           David Bianca
* Data:            Mai 2026
* Proiect:         IaPermis – Chestionare Auto
* Funcționalitate: Gestionează sesiunea activă de quiz, răspunsurile
*                  utilizatorului și calculul scorului.
*************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAppCore
{
    /// <summary>
    /// Gestioneaza o sesiune activa de quiz: lista de intrebari,
    /// indexul curent, scorul acumulat si timpul ramas.
    /// </summary>
    public class QuizSession
    {
        /// <summary>Lista intrebarilor selectate pentru sesiunea curenta.</summary>
        public List<Question> Questions { get; set; } = new List<Question>();

        /// <summary>Indexul intrebarii la care se afla utilizatorul in acest moment.</summary>
        public int CurrentIndex { get; set; }

        /// <summary>Numarul de raspunsuri corecte acumulate pana in prezent.</summary>
        public int Score { get; set; }

        /// <summary>Timpul ramas in sesiune, exprimat in secunde.</summary>
        public int TimeLeft { get; set; }

        /// <summary>
        /// Initializeaza sesiunea, resetand indexul si scorul la zero.
        /// Trebuie apelata inainte de prima intrebare.
        /// </summary>
        public void Start()
        {
            // Resetam pozitia si scorul pentru o sesiune curata
            CurrentIndex = 0;
            Score = 0;
        }

        /// <summary>
        /// Inregistreaza raspunsul utilizatorului pentru intrebarea curenta
        /// si avanseaza la urmatoarea intrebare.
        /// </summary>
        /// <param name="idx">Indexul variantei alese de utilizator (0-based).</param>
        public void SubmitAnswer(int idx)
        {
            // Verificam ca mai exista intrebari la care sa se raspunda
            if (CurrentIndex >= Questions.Count)
                throw new InvalidOperationException("Nu mai exista intrebari de raspuns.");

            if (Questions[CurrentIndex].IsCorrect(idx))
            {
                Score++;
            }

            CurrentIndex++;
        }

        /// <summary>
        /// Finalizeaza sesiunea si construieste obiectul cu rezultatul final.
        /// Promovarea se obtine cu minim 22 de raspunsuri corecte din 26.
        /// </summary>
        /// <returns>Obiectul QuizResult cu scorul, totalul si statusul de promovare.</returns>
        public QuizResult GetResult()
        {
            return new QuizResult
            {
                Score = this.Score,
                TotalQuestions = Questions.Count,
                Passed = (Score >= 22), // Pragul de promovare: 22 din 26
                Date = DateTime.Now
            };
        }
    }
}