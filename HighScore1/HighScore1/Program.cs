//Create an application with a score, highscore and a highscorePlayer.
//Create a method which has two parameters, one for the score and one for the playerName.
//When ever that method is called, it should be checked if the score of the player is higher than the highscore, if so, "New highscore is + " score" and in another line "New highscore holder is " + playerName - should be written onto the console, if not "The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer.
//Consider which variables are required globally and which ones locally.

using System; 
namespace HighScore
{
    public class Program
    {
        public static int highscore = 0;
        public static string HighscorePlayer = "No one yet"; // default value
        static void Main(string[] args)
        {   
            
            while(highscore!=100)
            {
                Console.WriteLine("Enter Player Name: ");
                string player = Console.ReadLine();
                Console.WriteLine("Enter score: ");
                int score = int.Parse(Console.ReadLine());
                ScoreCheck(score, player);
                Console.WriteLine($"Highest score is {highscore}");
                Console.WriteLine($"Highest scorer is {HighscorePlayer}");
            }

            


        }


        public static void ScoreCheck(int score, string playerName)
        {
            if(score>highscore)
            {
                HighscorePlayer = playerName;
                highscore = score; 
            }
        }
    }
}