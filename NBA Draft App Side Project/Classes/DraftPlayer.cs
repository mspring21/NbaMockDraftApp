using System;
using System.Collections.Generic;
using System.Text;

namespace NBA_Draft_App_Side_Project.Classes
{
    public class DraftPlayer 
    {
        List<string> picksMade = new List<string>();
        public void MakeSelectionForTeam(string choice)
        {
            DraftPoolPlayers draft = new DraftPoolPlayers();
            List<string> draftPool = draft.draftPool;
            List<string> teams = draft.Teams;
            Console.Write($"Lets get started rook! With the first pick in the NBA Draft the {teams[int.Parse(choice) - 1]} select: ");
            string input = Console.ReadLine();
            string prospect = input;

            if (prospect == "Board" || prospect == "board")
            {
                foreach (string prospects in draftPool)
                {
                    Console.WriteLine("============================================================================================");
                    Console.WriteLine();
                    Console.WriteLine(prospects);
                    Console.WriteLine();
                }
            }

                if (draft.draftPool.Contains(prospect))
                {
                    Console.WriteLine($"***With the BLANK pick in the NBA Draft the {teams[int.Parse(choice) - 1]} select {prospect}!***");
                    Console.ReadKey();
                }
                else if (!draft.draftPool.Contains(prospect))
                {
                    Console.WriteLine("Oh no.... Sorry rook that prospect isnt draft eligable... you gotta study more kid!");
                    Console.ReadKey();
                }
            picksMade.Add(teams[int.Parse(choice) - 1] + " picked " + prospect);
        }

        public void displayTheDraftChoices()
        {
            foreach(string draftPickAndTeam in picksMade)
            {
                Console.WriteLine($"{draftPickAndTeam}");
            }
        }
    }
}
