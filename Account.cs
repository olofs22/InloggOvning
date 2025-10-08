using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InloggOvning
{
    internal class Account
    {
        public bool runAccount = true;
        private string userName;
        public string userInputUserName;
        private string userPassword;
        public string userInputPassWord;
        public bool LoggedIn = false;

        public void Register()
        {
            while (runAccount)
            {
                string textName = "\nVälj ett användarnamn: ";
                foreach (char c in textName)
                {
                    Console.Write(c);
                    Thread.Sleep(25);
                }
                userName = Console.ReadLine();

                string textPassword = "\nVälj ett Lösenord: ";
                foreach (char c in textPassword)
                {
                    Console.Write(c);
                    Thread.Sleep(25);
                }

                userPassword = "";

                while (true)
                {
                    var key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Enter) break;
                    if (key.Key == ConsoleKey.Backspace && userPassword.Length > 0)
                    {
                        userPassword = userPassword[..^1];
                        Console.Write("\b \b");
                    }
                    else if (!char.IsControl(key.KeyChar))
                    {
                        userPassword += key.KeyChar;
                        Console.Write("*");
                    }
                }
                Console.WriteLine();

                if (userPassword.Length >= 6 &&
                    userPassword.Any(char.IsUpper) &&
                    userPassword.Any(char.IsDigit) &&
                    userPassword.Any(ch => !char.IsLetterOrDigit(ch)))
                    
                {
                    runAccount = false;
                }
                else
                {
                    string textFel = "\nLösenordet måste ha minst 6 tecken, 1 stor bokstav, 1 siffra och ett specialtecken.";
                    foreach (char c in textFel)
                    {
                        Console.Write(c);
                        Thread.Sleep(25);
                    }
                    
                }
            }
        }
        public void Login()
        {
            string textInUser = "\nAnvändarnamn: ";
            foreach (char c in textInUser)
            {
                Console.Write(c);
                Thread.Sleep(25);
            }

            userInputUserName = Console.ReadLine();

            string textInPass = "\nLösenord: ";
            foreach (char c in textInPass)
            {
                Console.Write(c);
                Thread.Sleep(25);
            }

            userInputPassWord = "";

            while (true)
            {
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter) break;
                if (key.Key == ConsoleKey.Backspace && userInputPassWord.Length > 0)
                {
                    userInputPassWord = userInputPassWord[..^1];
                    Console.Write("\b \b");
                }
                else if (!char.IsControl(key.KeyChar))
                {
                    userInputPassWord += key.KeyChar;
                    Console.Write("*");
                }
            }
            Console.WriteLine();

            

            if (userInputUserName == userName && userPassword == userInputPassWord)
            {
                runAccount = false;

                string textWelUs = $"\nVälkommen {userName}!";
                foreach (char c in textWelUs)
                {
                    Console.Write(c);
                    Thread.Sleep(25);
                }

                LoggedIn = true;

                Messages_animation.LogInAnimation();
            }
            else
            {
                string textFelAL = "\nFelaktigt användarnamn eller lösenord";

                foreach (char c in textFelAL)
                {
                    Console.Write(c);
                    Thread.Sleep(25);
                }
            }
        }
    }
}
