using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace enigmaMachine
{
    /**
     * Implements the plug board feature of the Enigma machine. Since this
     * affects the input and output, this has to be separated from the
     * class that implements the logic for handling rotors.
     * 
     * At the moment this only supports 26 characters: A-Z.
     */
    class PlugBoard
    {
        const int PIN_COUNT = 26;
        private Dictionary<string, string> mapping;
        private Random rng;

        public PlugBoard(int Seed, bool Shuffle=false)
        {
            
            mapping = new Dictionary<string, string>();
            for (int i = 0; i < PIN_COUNT; i++)
            {
                string letter = ((char)(0x41 + i)).ToString();
                mapping.Add(letter, letter);
            }
            rng = new Random(Seed);

            if (Shuffle)
                ShuffleWiring();
        }

        /**
         * Checks to see if the input is A-Z (calls ToUpper first), then
         * returns either the remapped letter or let the input pass 
         * through
         */
        public string GetRewiredLetter(string Input)
        {
            Input = Input.ToUpper();
            if(Regex.Matches(Input, @"[A-Z]").Count > 0)
                return mapping[Input];
            return Input;
        }

        /**
         * "Wires" up a letter to another. It "disconnects" both the
         * destination letter of the input and the input's old output.
         */
        public void ChangeWiring(string Input, string NewOutput)
        {
            string oldOutput = mapping[Input];
            mapping[oldOutput] = oldOutput;

            oldOutput = mapping[NewOutput];
            mapping[oldOutput] = oldOutput;

            mapping[Input] = NewOutput;
            mapping[NewOutput] = Input;
        }

        /**
         * Shuffles the wiring around.
         */
        public void ShuffleWiring()
        {
            if (rng == null)
                throw new NullReferenceException("Plugboard RNG was not setup");

            int entries = mapping.Count;
            Dictionary<string, string>.KeyCollection keys = mapping.Keys;

            for(int i = 0; i < entries; i++)
            {
                int entry = rng.Next(entries + 1);
                int counter = 0;
                string firstLetter = IntToLetter(i % entries);
                string secondLetter = "";

                entry = (rng.Next() % entries);
                counter = 0;
                foreach (string randomKey in keys)
                {
                    secondLetter = randomKey;
                    counter++;
                    if (counter == entry)
                        break;
                }

                ChangeWiring(firstLetter, secondLetter);
            }
        }

        /**
         * Turns an integer into a single letter string. The code starts from
         * A = 0 to Z = 25.
         */
        private string IntToLetter(int LetterCode)
        {
            return ((char)(0x41 + LetterCode)).ToString();
        }
    }
}
