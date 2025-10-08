using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InloggOvning
{
    internal class Messages_animation
    {
        public static void WelcomeBack()
        {
            string textWelBack = $"\nVälkommen åter!";
            foreach (char c in textWelBack)
            {
                Console.Write(c);
                Thread.Sleep(25);
            }
        }
        public static void LogInAnimation()
        {
            Console.WriteLine();
            string[] animation = { "|", "/", "-", "\\" };
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("\r" + animation[i % animation.Length] + " ");
                Thread.Sleep(150); // liten paus så man ser rörelsen
            }
            Console.Write("\r"); // rensa raden
        }
    }
}
