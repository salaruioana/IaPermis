/*************************************************************************
 * Autor: David Bianca
 * Proiect: QuizApp
 * Fișier: StatisticsService.cs
 * Descriere: Clasa gestionează statisticile utilizatorilor,
 * inclusiv salvarea, încărcarea și calcularea rezultatelor testelor.
 *************************************************************************/

using QuizAppCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace QuizAppServices
{
    public class StatisticsService
    {
        // Dicționar care mapeaza fiecare username la lista sa de rezultate
        private Dictionary<string, List<QuizResult>> _data
            = new Dictionary<string, List<QuizResult>>();

        private readonly string _filePath;

        /// <summary>
        /// Initializeaza serviciul de statistici si incarca datele existente din fisier.
        /// </summary>
        /// <param name="filePath">Calea fisierului de statistici. Implicit: "statistics.txt".</param>
        public StatisticsService(string filePath = "statistics.txt")
        {
            _filePath = filePath;
            Load(); // încarcă datele existente la instanțiere
        }

        /// <summary>
        /// Adauga un rezultat nou pentru utilizatorul specificat si salveaza imediat in fisier.
        /// </summary>
        /// <param name="username">Numele utilizatorului caruia i se atribuie rezultatul.</param>
        /// <param name="result">Obiectul QuizResult de adaugat.</param>
        public void AddResult(string username, QuizResult result)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Username-ul nu poate fi gol.");

            if (result == null)
                throw new ArgumentNullException(nameof(result), "Rezultatul nu poate fi null.");

            // Daca utilizatorul nu are inca o lista, o cream
            if (!_data.ContainsKey(username))
                _data[username] = new List<QuizResult>();

            _data[username].Add(result);
            Save();
        }

        /// <summary>
        /// Calculeaza procentul de teste promovate pentru un utilizator dat.
        /// </summary>
        /// <param name="username">Numele utilizatorului.</param>
        /// <returns>Procentul de promovare (0–100). Returneaza 0 daca nu exista date.</returns>
        public double GetPassRate(string username)
        {
            if (!_data.ContainsKey(username) || _data[username].Count == 0)
                return 0;

            // Numarăm cate teste au fost promovate
            int passed = _data[username].Count(r => r.Passed);
            return ((double)passed / _data[username].Count) * 100;
        }

        /// <summary>
        /// Calculeaza scorul mediu obtinut de un utilizator in toate testele sustinute.
        /// </summary>
        /// <param name="username">Numele utilizatorului.</param>
        /// <returns>Media scorurilor. Returneaza 0 daca nu exista date.</returns>
        public double GetAvgScore(string username)
        {
            if (!_data.ContainsKey(username) || _data[username].Count == 0)
                return 0;

            return _data[username].Average(r => r.Score);
        }

        /// <summary>
        /// Returneaza numarul total de teste sustinute de un utilizator.
        /// </summary>
        /// <param name="username">Numele utilizatorului.</param>
        /// <returns>Numarul de incercari. Returneaza 0 daca utilizatorul nu exista.</returns>
        public int GetTotalAttempts(string username)
        {
            if (!_data.ContainsKey(username)) return 0;
            return _data[username].Count;
        }

      
        private void Save()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(_filePath, false))
                {
                    foreach (var kvp in _data)
                    {
                        foreach (var r in kvp.Value)
                        {
                            sw.WriteLine(string.Join("\t",
                                kvp.Key,
                                r.Score,
                                r.TotalQuestions,
                                r.Passed,
                                r.Date.ToString("o"))); 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la salvarea statisticilor: " + ex.Message);
            }
        }

        /// <summary>
        /// Încarcă statisticile din fișierul text în dicționarul intern.
        /// Dacă fișierul nu există, pornește cu date goale fără eroare.
        /// </summary>
        private void Load()
        {
            // Resetăm datele înainte de încărcare
            _data.Clear();

            if (!File.Exists(_filePath))
                return;

            try
            {
                using (StreamReader sr = new StreamReader(_filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        // Separăm câmpurile liniei după tab
                        string[] toks = line.Split('\t');

                        // Ignorăm liniile incomplete sau corupte
                        if (toks.Length < 5) continue;

                        string username = toks[0];
                        var result = new QuizResult
                        {
                            Score = int.Parse(toks[1]),
                            TotalQuestions = int.Parse(toks[2]),
                            Passed = bool.Parse(toks[3]),
                            Date = DateTime.Parse(toks[4])
                        };


                        // Creăm lista pentru utilizator dacă nu există deja
                        if (!_data.ContainsKey(username))
                            _data[username] = new List<QuizResult>();

                        _data[username].Add(result);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la citirea statisticilor: " + ex.Message);
            }
        }

        /// <summary>
        /// Returnează istoricul complet al rezultatelor unui utilizator,
        /// sortat descrescător după dată (cel mai recent primul).
        /// </summary>
        /// <param name="username">Numele utilizatorului.</param>
        /// <returns>Listă de QuizResult sortată. Listă goală dacă utilizatorul nu există.</returns>
        public List<QuizResult> GetHistory(string username)
        {
            if (!_data.ContainsKey(username))
                return new List<QuizResult>();

            // Sortăm descrescător — cel mai recent test apare primul
            return _data[username]
                .OrderByDescending(r => r.Date)
                .ToList();
        }
    }
}