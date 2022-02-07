using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndMulticastDelegates
{
    class GameEventManager
    {
        //a new delegate type called GameEvent
        public delegate void GameEvent();

        //Create two delegates variables called OnGameStart and OnGameOver
        //Events are forced to behave like a list += / -=, can only add or remove methods from it
        public static event GameEvent OnGameStart, OnGameOver;

        //A static method to trigger OnGameStart
        public static void TriggerGameStart()
        {
            //Check if OnGameStart event is not empty, meaning that other methods already subscribed to it
            if (OnGameStart != null)
            {
                Console.WriteLine("The game has started....");
                //Call the OnGameStart that will trigger all the methods subscribed to this event
                OnGameStart();
            }
        }


        //A static method to trigger OnGameOver
        public static void TriggerGameOver()
        {
            if (OnGameOver != null)
            {
                Console.WriteLine("The game is over");
                //Call the OnGameOver that will trigger all the methods subscribed to this event
                OnGameOver();
            }
        }

    } 
}
