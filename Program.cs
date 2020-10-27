namespace AirplaneApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                MainMenu mainMenu = new MainMenu();
                showMenu = MainMenu.DisplayMainMenu();
            }
        }
    }
}
