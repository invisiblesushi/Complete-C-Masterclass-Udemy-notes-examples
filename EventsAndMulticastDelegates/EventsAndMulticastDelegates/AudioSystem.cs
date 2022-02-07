using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndMulticastDelegates
{
    class AudioSystem
    {

        public AudioSystem()
        {
            //Subscribe to OnGameStart, OnGameOver events
            //+= cause we want to add that method to that multicast delegate
            //Subscribing to it
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;


        }
        //At the start of the game, we want to enable the audio system and start playing audio clips
        private void StartGame()
        {
            Console.WriteLine("Audio system started...");
            Console.WriteLine("Playing audio...");
        }

        //When the game is over, we want to stop the audio system.
        private void GameOver()
        {
            Console.WriteLine("Audio system stopped");
        }
    }
}
