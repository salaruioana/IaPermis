/*************************************************************************
* Fișier:          QuestionRepository.cs
* Autor:           David Bianca
* Data:            Mai 2026
* Proiect:         IaPermis – Chestionare Auto
* Funcționalitate: Gestionează citirea întrebărilor din fișier XML
*                  și filtrarea lor pe categorii.
*************************************************************************/

using QuizAppCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;

namespace QuizAppData
{
    /// <summary>
    /// Implementare a IQuestionRepository care citeste intrebarile
    /// dintr-un fisier XML serializat de pe disc.
    /// </summary>
    public class QuestionRepository : IQuestionRepository
    {
        private string _xmlPath;

        /// <summary>
        /// Initializeaza repository-ul cu calea catre fisierul XML de intrebari.
        /// </summary>
        /// <param name="xmlPath">Calea absoluta sau relativa catre fisierul XML.</param>
        public QuestionRepository(string xmlPath)
        {
            _xmlPath = xmlPath;
        }

        /// <summary>
        /// Citeste si returneaza toate intrebarile din fisierul XML.
        /// Daca fisierul lipseste sau este corupt, returneaza o lista goala.
        /// </summary>
        /// <returns>Lista tuturor obiectelor Question deserializate din XML.</returns>
        public List<Question> GetAll()
        {
            List<Question> list = new List<Question>();
            try
            {
                // Verificam daca fisierul exista inainte de a incerca citirea
                if (!File.Exists(_xmlPath))
                {
                    throw new FileNotFoundException("Fisierul XML cu intrebari lipseste!");
                }

                // Deserializam lista de intrebari din XML
                XmlSerializer serializer = new XmlSerializer(typeof(List<Question>));
                using (StreamReader reader = new StreamReader(_xmlPath))
                {
                    list = (List<Question>)serializer.Deserialize(reader);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la citirea intrebarilor XML: " + ex.Message);
            }
            return list;
        }

        /// <summary>
        /// Returneaza intrebarile filtrate dupa categoria specificata.
        /// Daca parametrul este gol sau null, returneaza toate intrebarile.
        /// </summary>
        /// <param name="cat">Categoria dorita.</param>
        /// <returns>Lista de intrebari din categoria respectiva.</returns>
        public List<Question> GetByCategory(string cat)
        {
            // Daca nu s-a specificat o categorie, returnam toate intrebarile
            if (string.IsNullOrEmpty(cat)) return GetAll();
            List<Question> filtered = new List<Question>();
            foreach (var q in GetAll())
            {
                if (q.Category == cat) filtered.Add(q);
            }
            return filtered;
        }
    }
}
