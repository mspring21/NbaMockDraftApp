using System;
using System.Collections.Generic;
using NBA_Draft_App_Side_Project.Classes;

namespace NBA_Draft_App_Side_Project
{
    public class Program
    {
        static void Main(string[] args)
        {
            DraftPoolPlayers start = new DraftPoolPlayers();
            MainMenu menu = new MainMenu(start);
            menu.Run();
        }
    }
}
