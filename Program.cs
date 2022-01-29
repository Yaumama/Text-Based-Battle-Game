// See https://aka.ms/new-console-template for more information
using System;

class Player {
    public string abilitySet = "";
    public string name = "";
    
    public void useAbility() {
        if (abilitySet == "fire") {
            Console.WriteLine(name + " used fireball which did 40 damage!");
        }
    }
}

class Match {
    public int PlayerCount;
    public Player[] players;

    public Match(int count) {
        PlayerCount = count;
        players = new Player[PlayerCount];
    }

    public void Start() {
        Console.WriteLine("Game started! There are " + PlayerCount + " players!");
    }
}

class Program {
    public static void Main(string[] args) {

        Console.WriteLine("How many players are there?");

        string? playerCount = Console.ReadLine();

        if (Int32.TryParse(playerCount, out int j)) {
            
            Console.WriteLine("You have selected " + playerCount + " players!");

            Match match = new Match(j);

            for (int i = 0; i < j; i++) {
                Player plr = new Player();

                match.players[i] = plr;

                plr.name = "Player " + (i + 1);

                Console.WriteLine("What do you want " + plr.name + "'s ability set to be?");

                string? ability = Console.ReadLine();

                if (ability != null) {
                    if (ability.ToLower() == "fire") {
                        Console.WriteLine(plr.name + " has " + ability + "!");
                        plr.abilitySet = ability;
                    } else {
                        Console.WriteLine("That is not a ability!");
                    }
                }
            }
        } else {
            Console.WriteLine("Please enter a number of players not text!");
        }
    }
}