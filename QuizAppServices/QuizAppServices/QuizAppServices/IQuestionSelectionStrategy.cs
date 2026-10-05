/*************************************************************************
* Fișier:          IQuestionSelectionStrategy.cs
* Autor:           David Bianca
* Data:            Mai 2026
* Proiect:         IaPermis – Chestionare Auto
* Funcționalitate: Definește strategia de selecție a întrebărilor
*                  pentru quiz.
*************************************************************************/

using QuizAppCore;
using System.Collections.Generic;

namespace QuizAppServices
{
    /// <summary>
    /// Interfață care definește contractul pentru strategiile de selecție a întrebărilor.
    /// Permite schimbarea modului de selectare fără a modifica restul aplicației.
    /// </summary>
    public interface IQuestionSelectionStrategy
    {
        /// <summary>
        /// Selectează un subset de întrebări din lista completă disponibilă.
        /// </summary>
        /// <param name="all">Lista tuturor întrebărilor disponibile.</param>
        /// <returns>Lista de întrebări selectate pentru quiz.</returns>
        List<Question> Select(List<Question> all);
    }
}