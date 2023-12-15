﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emne3_PpUke5
{
    internal class Pokemon
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public Pokemon(string name, int health) 
        {
            Name = name;
            Health = health; 
        }

        public void ShowPokemon()
        {
            Console.WriteLine($"Name: {Name} HP:{Health}");
        }
    }
}
