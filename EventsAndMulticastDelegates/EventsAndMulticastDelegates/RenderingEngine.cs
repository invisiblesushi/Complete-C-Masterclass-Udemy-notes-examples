using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndMulticastDelegates
{
    //RenderingEngine Class
    class RenderingEngine
    {

        public RenderingEngine()
        {
            //Subscribe to OnGameStart and OnGameOver events
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }


        //At the start of the game, we want to enable the rendering engine and start drawing the visuals
        private void StartGame()
        {
            Console.WriteLine("Rendering engine started");
            Console.WriteLine("Drawing visuals....");
        }

        //When the game is over, we want to stop out rendering engine
        private void GameOver()
        {
            Console.WriteLine("Rendering engine stopped");
        }

    }
}
