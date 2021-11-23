﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections; // The hashtable class is in the collections
using System.Windows.Forms; // The keys class is in the Forms 

namespace Snakey
{
    class Input
    {
        //hash table used to optimize keystrokes
        private static Hashtable keyTable = new Hashtable();

        //takes a key and checks if the key press exists in the hashtable
        public static bool KeyPress(Keys key)
        {
            
            //if the key is not in the hashtable
            if (keyTable[key] == null)
            {
                // if the hashtable is empty then we return flase
                return false;
            }
            // if the hastable is not empty then we return true
            return (bool)keyTable[key];
        }

        public static void changeState(Keys key, bool state)
        {
            // this function will change state of the keys and the player with it
            // this function has two arguments Key and state
            keyTable[key] = state;
        }
    }
}
