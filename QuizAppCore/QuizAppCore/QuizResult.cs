/*************************************************************************
* Fișier:          QuizResult.cs
* Autor:           David Bianca
* Data:            Mai 2026
* Proiect:         IaPermis – Chestionare Auto
* Funcționalitate: Gestionează rezultatul final al unui quiz și
*                  calculează procentajul obținut.
*************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAppCore
{
    /// <summary>
    /// Reprezinta rezultatul complet al unui quiz sustinut de utilizator,
    /// incluzand scorul, numarul de intrebari, statusul de promovare si data.
    /// </summary>
    public class QuizResult
    {
        /// <summary>Numarul de raspunsuri corecte obtinute in test.</summary>
        public int Score { get; set; }

        /// <summary>Numarul total de intrebari din testul sustinut.</summary>
        public int TotalQuestions { get; set; }

        /// <summary>True daca utilizatorul a promovat testul (minim 22 corecte).</summary>
        public bool Passed { get; set; }

        /// <summary>Data si ora la care a fost finalizat testul.</summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Calculeaza procentajul de raspunsuri corecte din totalul intrebarilor.
        /// </summary>
        /// <returns>Procentul obtinut (0-100). Returneaza 0 daca nu exista intrebari.</returns>
        public double GetPercentage()
        {
            // Evitam impartirea la zero daca testul nu are intrebari
            if (TotalQuestions == 0) return 0;
            return ((double)Score / TotalQuestions) * 100;
        }
    }
}