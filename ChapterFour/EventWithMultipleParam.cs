using System;

/* Create a Game class that has an event PlayerScored.
 The event should pass custom event arguments containing the player'name and score .
  Write a program class that subscribes to this event and displays the players name and score when the event ends
*/
namespace Chapter4
{
    public class PlayerScoreEventArgs : EventArgs
    {
        public string PlayerName { get; }
        public int Score { get; }

        public PlayerScoreEventArgs(string playerName, int score)
        {
            PlayerName = playerName;
            Score = score;
        }
    }
    public class Game
    {
        public delegate void EventHandler(object sender, EventArgs e);
        public event EventHandler? PlayerScored;

        public void SimulatePlayerScore(string playerName, int score)
        {
            PlayerScored?.Invoke(this, new PlayerScoreEventArgs(playerName, score));
        }
    }
public class Subscribers {
    public void HandlePlayerScored(object sender, EventArgs e)
    {
        PlayerScoreEventArgs playerScoreEventArgs =  (PlayerScoreEventArgs)e;
        Console.WriteLine($"Player: {playerScoreEventArgs.PlayerName} scored {playerScoreEventArgs.Score} points");
    }
}

    public class EventWithMultipleParam
    {
        static void Main()
        {
            Game game = new Game();
            Subscribers subscribers = new Subscribers();
            game.PlayerScored += subscribers.HandlePlayerScored;
            game.SimulatePlayerScore("Md", 10);
            
        }


    }

}
