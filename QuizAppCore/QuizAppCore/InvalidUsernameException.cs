/*************************************************************************
* Fișier:          InvalidPasswordExceptions.cs
* Autor:           David Bianca
* Data:            Mai 2026
* Proiect:         IaPermis – Chestionare Auto
* Funcționalitate: Definește excepția personalizată pentru nume de
*                  utilizator invalide.
*************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAppCore
{
    /// <summary>
    /// Exceptie personalizata aruncata cand username-ul introdus
    /// nu respecta regulile de validare ale aplicatiei
    /// (lungime, caractere speciale interzise etc.).
    /// </summary>
    public class InvalidUsernameException : Exception
    {
        /// <summary>
        /// Initializeaza exceptia cu un mesaj descriptiv despre motivul respingerii username-ului.
        /// </summary>
        /// <param name="message">Mesajul care explica de ce username-ul este invalid.</param>
        public InvalidUsernameException(string message) : base(message)
        {
        }
    }
}
