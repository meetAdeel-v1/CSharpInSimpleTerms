﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _8StructsAndEnums
{
    public struct Player
    {
        public string Name { get; set; }
        public int YearsPlaying { get; set; }

        public Player(string name, int yearsPlaying)
        {
            Console.WriteLine("Constructor for Player struct was invoked!");
            Name = name;
            YearsPlaying = yearsPlaying;
        }
    }

    public struct Coach
    {
        public string Name { get; set; }
        public int YearsCoaching { get; set; }
    }

    public struct Coach3
    {
        public string Name { get; set; }
        public int YearsCoaching { get; set; }

        public Coach3(string name, int years)
        {
            Console.WriteLine("Constructor for Coach3 struct was invoked!");
            Name = name;
            YearsCoaching = years;
        }
    }

    public readonly struct ReadonlyPlayer
    {
        public string Name { get; } //No setter methods!
        public int TurnOrder { get; }

        public ReadonlyPlayer(string name, int turnOrder)
        {
            Console.WriteLine("Constructor for ReadonlyPlayer was invoked!");
            Name = name;
            TurnOrder = turnOrder;
        }

        //We can also declare methods in a struct as readonly. 
        //This is typically done for methods that do not change the state
        //of the struct.
        public readonly string GetCustomDisplay()
        {
            return Name + " will play in position #" + TurnOrder.ToString();
        }
    }
}
