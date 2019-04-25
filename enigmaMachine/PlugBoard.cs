using System;
using System.Linq;
using System.Collections.Generic;

namespace enigmaMachine
{
    /**
     * Implements the plug board feature of the Enigma machine. This affects 
     * the input and outputs from the rotor housing.
     */
    class PlugBoard
    {
        private Dictionary<string, string> mapping;
        private Random rng;

        /**
         * Constructor for the plug board. It needs:
         * Seed {int} - Seed for the random number generator.
         * CharList {List<string>} - A List containing the "plugs" to use in
         *      the plug board.
         */
        public PlugBoard(int Seed, List<string> CharList)
        {
            mapping = new Dictionary<string, string>();
            rng = new Random(Seed);

            foreach (string entry in CharList)
                mapping.Add(entry, entry);
        }

        /**
         * Returns a rewired letter. Checks to see if the input exists in the
         * dictionary map first as a key. If it does, return the mapped output
         * otherwise return the input.
         */
        public string GetRewiredLetter(string Input)
        {
            Input = Input.ToUpper();
            if (mapping.ContainsKey(Input))
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
            string[] keys = mapping.Keys.ToArray();

            for (int i = 0; i < keys.Length; i++)
            {
                string firstLetter = keys[i];
                string secondLetter = keys[rng.Next(keys.Length)];
                ChangeWiring(firstLetter, secondLetter);
            }
        }
    }
}
