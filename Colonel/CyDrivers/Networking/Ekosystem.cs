using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using net = Cosmos.System.Network;

namespace Colonel.CyDrivers.Networking
{
    class Ekosystem
    {
        public static List<String> prompts = new List<String>();
        public static List<String> responses = new List<String>();
        public static void populatePrompts(string[] prompt)
        {
            for (int i = 0; i < prompt.Length; i++) prompts.Add(prompt[i]);
        }
        public static void populateResponses(string[] response)
        {
            for (int i = 0; i < response.Length; i++) responses.Add(response[i]);
        }
        public static string prompt(string prompt)
        {
            if (prompts.IndexOf(prompt) >= 0) return responses.ElementAt<String>(prompts.IndexOf(prompt));
            else return "Not sure how to respond to that...";
        }   
        public static void printAll(params string[] printThese)
        {
            for (int i = 0; i < printThese.Length; i++) Console.WriteLine(printThese[i]);
        }
        public static void showGames()
        {
            printAll("Chess by Professor Kevin Huang","Connect Four by Dr.Larry Chen and Unnamed Harvard Student","Scanner by Paul Jojy, Patrick Wolfe", "Secretary by General Matt Quan", "Hangman by Unpaid Intern Ben Boxer", "Music Video by Sassy Sally", "Global Thermonuclear War");
            string input = Console.ReadLine();
            letsPlay(input);
        }
        public static void letsPlay(string x)
        {
            if (x == "Global Thermonuclear War") Games.GameHandle.launchGame("war");
            else
            {
                Console.WriteLine("How about Global Thermonuclear War?");
                string input = Console.ReadLine();
                letsPlay(input);
            }
        }
    }
}
