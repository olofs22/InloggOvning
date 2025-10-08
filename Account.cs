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

                userPassword = Console.ReadLine();

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

            userInputPassWord = Console.ReadLine();

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

                LogInAnimation();

                
            }
            else
            {
                string textFelAL = "Felaktigt användarnamn eller lösenord";

                foreach (char c in textFelAL)
                {
                    Console.Write(c);
                    Thread.Sleep(25);
                }
            }
        }
        public void LogInAnimation()
        {
            string[] animation = { "|", "/", "-", "\\" };
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("\r\n" + animation[i % animation.Length] + " ");
                Thread.Sleep(150); // liten paus så man ser rörelsen
            }
            Console.Write("\r"); // rensa raden
        }
       
    }
}
