namespace InloggOvning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            bool progRun = true;

            MenuHelper menuHelper = new MenuHelper();

            Account userAccount = new Account();

            userAccount.LoggedIn = false;

            while (progRun)
            {
                menuHelper.Menu();

                string menuOpt = Console.ReadLine();

                switch (menuOpt.ToUpper())
                {
                    case "A":
                        userAccount.Login();
                        break;
                    case "B":
                        userAccount.Register();
                        break;
                    case "C":
                        progRun = false;
                        Messages_animation.WelcomeBack();
                        break;
                }
            }
        }
    }
}
