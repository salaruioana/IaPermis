/*************************************************************************
* Fișier:          Question.cs
* Autor:           David Bianca
* Data:            Mai 2026
* Proiect:         IaPermis – Chestionare Auto
* Funcționalitate: Reprezintă o întrebare din cadrul quiz-ului auto.
*************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAppCore
{
    /// <summary>
    /// Reprezinta o intrebare din testul auto, inclusiv variantele
    /// de raspuns, raspunsul corect, categoria si imaginea asociata.
    /// </summary>
    public class Question
    {
        /// <summary>Identificatorul unic al intrebarii.</summary>
        public int Id { get; set; }

        /// <summary>Textul intrebarii afisat utilizatorului.</summary>
        public string Text { get; set; }

        /// <summary>Array cu variantele de raspuns disponibile.</summary>
        public string[] Options { get; set; }

        /// <summary>Indexul variantei corecte in array-ul Options (0-based).</summary>
        public int CorrectIndex { get; set; }

        /// <summary>Categoria din care face parte intrebarea (ex: "Regulament", "Semne").</summary>
        public string Category { get; set; }

        /// <summary>Calea catre imaginea asociata intrebarii. Poate fi null daca nu exista imagine.</summary>
        public string ImagePath { get; set; }

        /// <summary>
        /// Verifica daca indexul ales de utilizator corespunde raspunsului corect.
        /// </summary>
        /// <param name="idx">Indexul variantei selectate de utilizator (0-based).</param>
        /// <returns>True daca raspunsul este corect, false in caz contrar.</returns>
        public bool IsCorrect(int idx)
        {
            // Comparam indexul ales cu indexul raspunsului corect
            return idx == CorrectIndex;
        }
    }
}