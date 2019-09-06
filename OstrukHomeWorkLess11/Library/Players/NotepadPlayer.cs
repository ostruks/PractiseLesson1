﻿using System;

namespace Library.Players
{
    public class NotepadPlayer : IPlayer
    {
        public string Name { get; set; }
        public int[] Numbers { get; set; }

        public NotepadPlayer(string Name)
        {
            this.Name = Name;
            Numbers = new int[100];
        }

        public bool Guess(FruitBasket basket)
        {
            int i = 0;
            Random random = new Random();

            while (i < 100)
            {
                Numbers[i] = random.Next(0, 1000);
                foreach(var a in Numbers)
                {
                    if(a == Numbers[i])
                    {
                        Numbers[i] = random.Next(0, 1000);
                    }
                }
                if (Numbers[i] == basket.Weight)
                {
                    return true;
                }
                i++;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Player {Name}";
        }
    }
}
