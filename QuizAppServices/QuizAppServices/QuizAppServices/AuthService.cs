/*************************************************************************
* Fișier:          AuthService.cs
* Autor:           David Bianca
* Data:            Mai 2026
* Proiect:         IaPermis – Chestionare Auto
* Funcționalitate: Gestionează autentificarea, înregistrarea și
*                  sesiunea utilizatorilor aplicației.
*************************************************************************/

using QuizAppCore;
using QuizAppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAppServices
{
    public class AuthService
    {
        // Referință către repository-ul de utilizatori
        private UserRepository _userRepo;

        /// <summary>
        /// Utilizatorul autentificat în sesiunea curentă.
        /// Este null dacă niciun utilizator nu este logat.
        /// </summary>
        public User CurrentLoggedInUser { get; private set; }

        /// <summary>
        /// Inițializează serviciul de autentificare cu repository-ul de utilizatori.
        /// </summary>
        /// <param name="userRepo">Repository-ul care gestionează utilizatorii.</param>
        public AuthService(UserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        /// <summary>
        /// Înregistrează un utilizator nou după validarea username-ului și parolei.
        /// Returnează true dacă înregistrarea a reușit, false dacă username-ul există deja.
        /// </summary>
        /// <param name="username">Numele de utilizator ales.</param>
        /// <param name="password">Parola aleasă de utilizator.</param>
        /// <returns>True dacă contul a fost creat cu succes, false dacă username-ul e ocupat.</returns>
        public bool Register(string username, string password)
        {
            // Validări pentru username
            if (string.IsNullOrWhiteSpace(username))
                throw new InvalidUsernameException("Numele de utilizator nu poate fi gol.");

            if (username.Length < 3)
                throw new InvalidUsernameException("Numele de utilizator este prea scurt! Minim 3 caractere.");

            if (username.Length > 20)
                throw new InvalidUsernameException("Numele de utilizator este prea lung! Maxim 20 caractere.");

            if (username.Contains("#") || username.Contains("@") || username.Contains("!"))
                throw new InvalidUsernameException("Numele de utilizator nu poate conține caractere speciale (#, @, !).");

            // Validări pentru parolă
            if (string.IsNullOrWhiteSpace(password))
                throw new InvalidPasswordExceptions("Parola nu poate fi goală.");

            if (password.Length < 4)
                throw new InvalidPasswordExceptions("Parola este prea scurtă! Minim 4 caractere.");

            // Verifică dacă username-ul este deja folosit
            foreach (var u in _userRepo.GetAllUsers())
            {
                if (u.Username == username)
                    return false; 
            }

            // Creează și salvează noul utilizator
            User newUser = new User(username, password);
            _userRepo.AddUser(newUser);
            return true;
        }

        /// <summary>
        /// Autentifică un utilizator pe baza username-ului și parolei.
        /// Dacă autentificarea reușește, setează CurrentLoggedInUser.
        /// </summary>
        /// <param name="username">Numele de utilizator introdus.</param>
        /// <param name="password">Parola introdusă.</param>
        /// <returns>True dacă datele sunt corecte, false în caz contrar.</returns>
        public bool Login(string username, string password)
        {
            foreach (var u in _userRepo.GetAllUsers())
            {
                // Setăm utilizatorul activ în sesiunea curentă
                if (u.Username == username && u.Password == password)
                {
                    CurrentLoggedInUser = u; 
                    return true; 
                }
            } 
            // User sau parola incorecte
            return false;
        }

        /// <summary>
        /// Deconectează utilizatorul curent, resetând sesiunea activă.
        /// </summary>
        public void Logout()
        {
            CurrentLoggedInUser = null;
        }

        /// <summary>
        /// Salvează un rezultat de quiz în istoricul utilizatorului curent logat.
        /// Nu face nimic dacă niciun utilizator nu este autentificat.
        /// </summary>
        /// <param name="result">Rezultatul quiz-ului de adăugat în istoric.</param>
        public void SaveScoreForCurrentUser(QuizResult result)
        {
            if (CurrentLoggedInUser != null)
            {
                CurrentLoggedInUser.ScoreHistory.Add(result);
            }
        }
    }
}
