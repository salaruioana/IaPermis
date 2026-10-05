/*************************************************************************
* Fișier:          RandomSelectionStrategy.cs
* Autor:           David Bianca
* Data:            Mai 2026
* Proiect:         IaPermis – Chestionare Auto
* Funcționalitate: Selectează aleatoriu întrebările utilizate în quiz.
*************************************************************************/

using QuizAppCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizAppServices
{
    public class RandomSelectionStrategy : IQuestionSelectionStrategy
    {
        // Numarul de intrebari de selectat pentru un quiz
        private int _count;

        /// <summary>
        /// Initializeaza strategia cu numarul dorit de intrebari.
        /// Implicit se selecteaza 26 de intrebari (standard examen auto).
        /// </summary>
        /// <param name="count">Numarul de intrebari de selectat.</param>
        public RandomSelectionStrategy(int count = 26)
        {
            _count = count;
        }

        /// <summary>
        /// Selecteaza aleatoriu un numar de intrebari din lista furnizata.
        /// Daca lista are mai putine intrebari decat numarul cerut, returneaza toate.
        /// </summary>
        /// <param name="all">Lista completa de intrebari disponibile.</param>
        /// <returns>Lista de intrebari selectate aleatoriu.</returns>
        public List<Question> Select(List<Question> all)
        {
            if (all == null || all.Count == 0)
                throw new ArgumentException("Lista de întrebări este goală.");

            // Amestecam lista folosind un numar random si luam primele _count elemente
            var rng = new Random();
            return all.OrderBy(q => rng.Next()).Take(_count).ToList();
        }
    }
}