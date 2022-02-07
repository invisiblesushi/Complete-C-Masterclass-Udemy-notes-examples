using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndMulticastDelegates
{
    class Player
    {
        public string PlayerName { get; set; }

        public Player(string name)
        {
            this.PlayerName = name;

            //Subscribe to OnGameStart and OnGameOver events
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }

        //At start of the game, spawn the player
        private void StartGame()
        {
            Console.WriteLine("Spawning player with ID : " + PlayerName);
        }

        private void GameOver()
        {
            Console.WriteLine("Removing player with ID : " + PlayerName);
        }




    }
}
