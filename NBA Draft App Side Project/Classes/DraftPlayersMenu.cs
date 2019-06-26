using System;
using System.Collections.Generic;
using System.Text;

namespace NBA_Draft_App_Side_Project.Classes
{
     public class DraftPlayersMenu : CLIMenu
    {
        DraftPlayer pick = new DraftPlayer();

        public DraftPlayersMenu(DraftPoolPlayers mock) : base(mock)
        {
            this.Title = "*** You Are Officially on the Clock! ***";
            this.menuOptions.Add("1", "New Orleans Pelicans");
            this.menuOptions.Add("2", "Memphis Grizzles");
            this.menuOptions.Add("4", "New York Knicks");
            this.menuOptions.Add("5", "Los Angeles Lakers");
            this.menuOptions.Add("6", "Cleveland Cavaliers");
            this.menuOptions.Add("7", "Phenoix Suns");
            this.menuOptions.Add("8", "Chichago Bulls");
            this.menuOptions.Add("9", "Atlanta Hawks");
            this.menuOptions.Add("10", "Washington Wizards");
            this.menuOptions.Add("11", "Dallas Mavericks");
            this.menuOptions.Add("12", "Minnesota TimberWolves");
            this.menuOptions.Add("13", "Charlotte Hornets");
            this.menuOptions.Add("14", "Miami Heat");
            this.menuOptions.Add("15", "Sacromento Kings");
            this.menuOptions.Add("16", "Boston Celtics");
            this.menuOptions.Add("17", "Detroit Pistons");
            this.menuOptions.Add("18", "Orlando Magic");
            this.menuOptions.Add("19", "Brooklyn Nets");
            this.menuOptions.Add("20", "Indiana Pacers");
            this.menuOptions.Add("21", "San Antonio Spurs");
            this.menuOptions.Add("22", "Los Angeles Clippers");
            this.menuOptions.Add("23", "Oklahoma Thunder");
            this.menuOptions.Add("24", "Utah Jazz");
            this.menuOptions.Add("25", "Philadelphia 76ers");
            this.menuOptions.Add("26", "Portland Trailblazers");
            this.menuOptions.Add("27", "Houston Rockets");
            this.menuOptions.Add("28", "Denver Nuggets");
            this.menuOptions.Add("29", "Golden State Warriors");
            this.menuOptions.Add("30", "Milwaukee Bucks");
            this.menuOptions.Add("31", "Toronto Raptors");
            this.menuOptions.Add("Q", "Quit");
        }

        protected override bool ExecuteSelection(string choice)
        {
            switch (choice)
            {
                case "1":
                    Console.Clear();
                    pick.MakeSelectionForTeam(choice);
                    return true;
                case "2":
                    Console.Clear();
                    pick.MakeSelectionForTeam(choice);
                    return true;
                case "3":
                    Console.Clear();
                    pick.MakeSelectionForTeam(choice);
                    return true;
                case "4":
                    Console.Clear();
                    pick.MakeSelectionForTeam(choice);
                    return true;
                case "5":
                    Console.Clear();
                    pick.MakeSelectionForTeam(choice);
                    return true;
                case "6":
                    Console.Clear();
                    pick.MakeSelectionForTeam(choice);
                    return true;
                case "7":
                    Console.Clear();
                    pick.MakeSelectionForTeam(choice);
                    return true;
                case "8":
                    Console.Clear();
                    pick.MakeSelectionForTeam(choice);
                    return true;
                case "9":
                    Console.Clear();
                    pick.MakeSelectionForTeam(choice);
                    return true;
                case "10":
                    Console.Clear();
                    pick.MakeSelectionForTeam(choice);
                    return true;
                case "11":
                    Console.Clear();
                    pick.MakeSelectionForTeam(choice);
                    return true;
                case "12":
                    Console.Clear();
                    pick.MakeSelectionForTeam(choice);
                    return true;
                case "13":
                    Console.Clear();
                    pick.MakeSelectionForTeam(choice);
                    return true;
                case "14":
                    Console.Clear();
                    pick.MakeSelectionForTeam(choice);
                    return true;
                case "15":
                    Console.Clear();
                    pick.MakeSelectionForTeam(choice);
                    return true;
                case "16":
                    Console.Clear();
                    pick.MakeSelectionForTeam(choice);
                    return true;
                case "17":
                    Console.Clear();
                    pick.MakeSelectionForTeam(choice);
                    return true;
                case "18":
                    Console.Clear();
                    pick.MakeSelectionForTeam(choice);
                    return true;
                case "19":
                    Console.Clear();
                    pick.MakeSelectionForTeam(choice);
                    return true;
                case "20":
                    Console.Clear();
                    pick.MakeSelectionForTeam(choice);
                    return true;
                case "21":
                    Console.Clear();
                    pick.MakeSelectionForTeam(choice);
                    return true;
                case "22":
                    Console.Clear();
                    pick.MakeSelectionForTeam(choice);
                    return true;
                case "23":
                    Console.Clear();
                    pick.MakeSelectionForTeam(choice);
                    return true;
                case "24":
                    Console.Clear();
                    pick.MakeSelectionForTeam(choice);
                    return true;
                case "25":
                    Console.Clear();
                    pick.MakeSelectionForTeam(choice);
                    return true;
                case "26":
                    Console.Clear();
                    pick.MakeSelectionForTeam(choice);
                    return true;
                case "27":
                    Console.Clear();
                    pick.MakeSelectionForTeam(choice);
                    return true;
                case "28":
                    Console.Clear();
                    pick.MakeSelectionForTeam(choice);
                    return true;
                case "29":
                    Console.Clear();
                    pick.MakeSelectionForTeam(choice);
                    return true;
                case "30":
                    Console.Clear();
                    pick.MakeSelectionForTeam(choice);
                    return true;
                case "31":
                    Console.Clear();
                    pick.MakeSelectionForTeam(choice);
                    return true;
            }
            return true;
        }
    }
}
