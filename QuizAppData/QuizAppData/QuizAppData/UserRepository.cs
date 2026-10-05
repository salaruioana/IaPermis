/*************************************************************************
* Fișier:          UserRepository.cs
* Autor:           David Bianca
* Data:            Mai 2026
* Proiect:         IaPermis – Chestionare Auto
* Funcționalitate: Gestionează salvarea și citirea utilizatorilor
*                  din fișierul cu date.
*************************************************************************/

using QuizAppCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAppData
{
    /// <summary>
    /// Clasa care gestioneaza persistenta utilizatorilor intr-un fisier text.
    /// Fiecare linie din fisier contine un utilizator in formatul:
    /// username TAB password
    /// </summary>
    public class UserRepository
    {
        private string _filePath;

        /// <summary>
        /// Initializeaza repository-ul cu calea catre fisierul de utilizatori.
        /// </summary>
        /// <param name="filePath">Calea absoluta sau relativa catre fisierul text.</param>
        public UserRepository(string filePath)
        {
            _filePath = filePath;
        }

        /// <summary>
        /// Citeste si returneaza toti utilizatorii salvati in fisier.
        /// Daca fisierul nu exista inca, returneaza o lista goala fara eroare.
        /// </summary>
        /// <returns>Lista tuturor obiectelor User incarcate din fisier.</returns>
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            try
            {
                // Daca fisierul nu exista inca, returnam o lista goala
                if (!File.Exists(_filePath))
                    return users;

                // Citim fisierul linie cu linie
                using (StreamReader sr = new StreamReader(_filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        // Fiecare linie are formatul: username \t password
                        string[] toks = line.Split('\t');

                        // Ignoram liniile incomplete sau corupte
                        if (toks.Length >= 2)
                        {
                            users.Add(new User(toks[0], toks[1]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Eroare la citire — afisam mesajul dar nu oprim aplicatia
                Console.WriteLine("Eroare la citirea fisierului de utilizatori: " + ex.Message);
            }
            return users;
        }

        /// <summary>
        /// Adauga un utilizator nou in fisier prin scriere in modul append.
        /// Nu verifica duplicatele — aceasta responsabilitate revine AuthService.
        /// </summary>
        /// <param name="newUser">Obiectul User de salvat in fisier.</param>
        public void AddUser(User newUser)
        {
            try
            {
                // Deschidem fisierul in modul append (true) pentru a nu suprascrie datele existente
                using (StreamWriter sw = new StreamWriter(_filePath, true))
                {
                    // Scriem utilizatorul in formatul: username \t password
                    sw.WriteLine(newUser.Username + "\t" + newUser.Password);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la salvarea utilizatorului nou: " + ex.Message);
            }
        }

    }
}
