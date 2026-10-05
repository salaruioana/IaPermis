/*************************************************************************
* Fișier:          IQuestionRepository.cs
* Autor:           David Bianca
* Data:            Mai 2026
* Proiect:         IaPermis – Chestionare Auto
* Funcționalitate: Definește metodele necesare pentru accesarea
*                  întrebărilor din sursa de date.
*************************************************************************/

using QuizAppCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAppData
{
    /// <summary>
    /// Interfata care defineste contractul pentru accesarea intrebarilor.
    /// Permite decuplarea logicii de business de sursa concreta de date
    /// (fisier XML, baza de date, API etc.).
    /// </summary>
    public interface IQuestionRepository
    {
        /// <summary>
        /// Returneaza toate intrebarile disponibile din sursa de date.
        /// </summary>
        /// <returns>Lista completa de obiecte Question.</returns>
        List<Question> GetAll();

        /// <summary>
        /// Returneaza doar intrebarile care apartin categoriei specificate.
        /// </summary>
        /// <param name="cat">Numele categoriei dupa care se filtreaza.</param>
        /// <returns>Lista de intrebari filtrate dupa categorie.</returns>
        List<Question> GetByCategory(string cat);
    }
}
