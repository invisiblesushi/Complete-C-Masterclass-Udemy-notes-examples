using System;

namespace EventsAndMulticastDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create audio system, rendering engine
            AudioSystem audioSystem = new AudioSystem();
            RenderingEngine renderingEngine = new RenderingEngine();

            //Create two players and give them id's
            Player player1 = new Player("SteelCow");
            Player player2 = new Player("DoggoSilva");
            Player player3 = new Player("DragonDog");

            GameEventManager.TriggerGameStart();

            Console.WriteLine("Game is runnign, press any key to end the game");

            Console.Read();

            GameEventManager.TriggerGameOver();

            /*
            //Start the audio system and rendering engine
            audioSystem.StartGame();
            renderingEngine.StartGame();

            //Spawn player
            player1.StartGame();
            player2.StartGame();

            //Shut donw the rendering engine and audio system
            renderingEngine.GameOver();
            audioSystem.GameOver();

            //Remove the players
            player1.GameOver();
            player2.GameOver();
            */




        }
    }
}
