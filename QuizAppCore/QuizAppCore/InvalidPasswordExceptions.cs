/*************************************************************************
* Fișier:          InvalidPasswordExceptions.cs
* Autor:           David Bianca
* Data:            Mai 2026
* Proiect:         IaPermis – Chestionare Auto
* Funcționalitate: Definește excepția personalizată pentru parole invalide.
*************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAppCore
{
    /// <summary>
    /// Exceptie personalizata aruncata cand parola introdusa
    /// nu respecta regulile de validare ale aplicatiei.
    /// </summary>
    public class InvalidPasswordExceptions : Exception
    {
        // <summary>
        /// Initializeaza exceptia cu un mesaj descriptiv despre motivul respingerii parolei.
        /// </summary>
        /// <param name="message">Mesajul care explica de ce parola este invalida.</param>
        public InvalidPasswordExceptions(string message) : base(message)
        {
        }
    }
}
