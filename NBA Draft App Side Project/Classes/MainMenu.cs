using System;
using System.Collections.Generic;
using System.Text;

namespace NBA_Draft_App_Side_Project.Classes
{
    public class MainMenu : CLIMenu
    {
        /// <summary>
        /// Constructor adds items to the top-level menu
        /// </summary>
        public MainMenu(DraftPoolPlayers mock) : base(mock)
        {
            this.Title = "*** Welcome to my Mock Draft App Rook! ***";
            this.menuOptions.Add("1", "Display All of the Players in the draft!");
            this.menuOptions.Add("2", "Start the Draft!");
            this.menuOptions.Add("Q", "Quit");
        }

        /// <summary>
        /// The override of ExecuteSelection handles whatever selection was made by the user.
        /// This is where any business logic is executed.
        /// </summary>
        /// <param name="choice">"Key" of the user's menu selection</param>
        /// <returns></returns>
        protected override bool ExecuteSelection(string choice)
        {
            switch (choice)
            {
                case "1":
                    Console.Clear();
                    draftEverything.ShowTheUserTheBoard();
                    Pause("");
                    return true;
                case "2":
                    DraftPlayersMenu draft = new DraftPlayersMenu(draftEverything);
                    draft.Run();
                    Pause("");
                    return true;
            }
            return true;
        }
    }
}
