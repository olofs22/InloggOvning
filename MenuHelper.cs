using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InloggOvning
{
    public class MenuHelper
    {
       

         public void Menu()
        {
            string text = "\nVälkommen, vänligen registrera dig eller logga in!";
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(25);
            }
            string text2 = "\nA: Logga in";
            foreach (char c in text2)
            {
                Console.Write(c);
                Thread.Sleep(25);
            }
            string text3 = "\nB: Registrera dig";
            foreach (char c in text3)
            {
                Console.Write(c);
                Thread.Sleep(25);
            }
            string text4 = "\nC: Avsluta programmet";
            foreach (char c in text4)
            {
                Console.Write(c);
                Thread.Sleep(25);
            }



             
        }

    }
}
