/*************************************************************************
* Fișier:          User.cs
* Autor:           David Bianca
* Data:            Mai 2026
* Proiect:         IaPermis – Chestionare Auto
* Funcționalitate: Reprezintă utilizatorul aplicației și istoricul
*                  rezultatelor obținute.
*************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAppCore
{
    /// <summary>
    /// Reprezinta un utilizator inregistrat in aplicatie,
    /// cu credentialele sale si istoricul testelor sustinute.
    /// </summary>
    public class User
    {
        /// <summary>Numele de utilizator unic in cadrul aplicatiei.</summary>
        public string Username { get; set; }

        /// <summary>Parola utilizatorului stocata in text simplu.</summary>
        public string Password { get; set; }

        /// <summary>
        /// Lista cu toate rezultatele testelor sustinute de acest utilizator,
        /// in ordinea cronologica a sustinerii.
        /// </summary>
        public List<QuizResult> ScoreHistory { get; set; } = new List<QuizResult>();

        /// <summary>
        /// Initializeaza un utilizator nou cu username si parola specificate.
        /// Istoricul de scoruri este gol la creare.
        /// </summary>
        /// <param name="username">Numele de utilizator ales.</param>
        /// <param name="password">Parola aleasa de utilizator.</param>
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
