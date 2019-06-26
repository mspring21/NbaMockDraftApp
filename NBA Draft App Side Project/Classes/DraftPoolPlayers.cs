using System;
using System.Collections.Generic;
using System.Text;

namespace NBA_Draft_App_Side_Project.Classes
{
    public class DraftPoolPlayers
    {
        public List<string> draftPool = new List<string>()
        {
            "zion williamson",
            "ja morant",
            "r.j. barrett",
            "jarret culver",
            "brandon clarke",
            "de'andre hunter",
            "cam reddish",
            "bol bol",
            "sekou doumbouya",
            "coby white",
            "darius garland",
            "bruno fernando",
            "tyler herro",
            "goga bitadze",
            "romeo langford",
            "p.j. washington",
            "nickeil alexander-walker",
            "grant williams",
            "nassir little",
            "rui hachimura",
            "kevin porter jr.",
            "jontay porter",
            "matisse thybulle",
            "cameron johnson",
            "talen horton-tucker",
            "keldon johnson",
            "chuma okeke",
            "shamorie ponds",
            "ty jerome",
            "luka samanic",

        };

        

        public void ShowTheUserTheBoard ()
        {
            foreach (string player in draftPool)
            {
                Console.WriteLine($"||{player}||");
            }
        }


        public List<string> Teams = new List<string>()
        {
            "New Orleans Pelicans",
            "Memphis Grizzles",
            "New York Knicks",
            "Los Angeles Lakers",
            "Cleveland Cavaliers",
            "Phenoix Suns",
            "Chichago Bulls",
            "Atlanta Hawks",
            "Washington Wizards",
            "Dallas Mavericks",
            "Minnesota TimberWolves",
            "Charlotte Hornets",
            "Miami Heat",
            "Sacromento Kings",
            "Boston Celtics",
            "Detroit Pistons",
            "Orlando Magic",
            "Brooklyn Nets",
            "Indiana Pacers",
            "San Antonio Spurs",
            "Los Angeles Clippers",
            "Oklahoma Thunder",
            "Utah Jazz",
            "Philadelphia 76ers",
            "Portland Trailblazers",
            "Houston Rockets",
            "Denver Nuggets",
            "Golden State Warriors",
            "Toronto Raptors",
            "Milliwakue Bucks",
        };
    }
}
