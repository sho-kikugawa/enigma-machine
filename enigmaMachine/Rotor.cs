using System;
using System.Collections.Generic;

namespace enigmaMachine
{
    class Rotor
    {
        private List<int> mapping;
        private int pinOffset = 0;
        private int maxPins = 0;
        Random rng;

        /**
         * Creator a reflector rotor
         */
        public Rotor(int PinCount)
        {
            mapping = new List<int>();
            maxPins = PinCount;

            for(int i = 0; i < PinCount; i++)
                mapping.Add((PinCount -1) - i);
        }

        /**
         * Create a rotor with a randomized wiring
         */
        public Rotor(int PinCount, int Seed)
        {
            mapping = new List<int>();
            rng = new Random(Seed);
            maxPins = PinCount;

            for (int i = 0; i < PinCount; i++)
            {
                mapping.Add(i);
            }

            Shuffle(mapping);
        }

        /**
         * Sets the offset of the rotor
         */
        public void SetOffset(int Pin)
        {
            if (Pin > maxPins || Pin < 0)
                return;
            pinOffset = Pin;
        }

        /**
         * Gets the current position of the rotor
         */
        public int GetPosition()
        {
            return pinOffset;
        }

        /**
         * Advances a rotor one position. If it the rotor position goes over
         * the maximum number of pins, reset the position.
         */
        public void AdvanceRotor()
        {
            pinOffset++;
            if (pinOffset >= maxPins)
                pinOffset = 0;
        }
        
        /**
         * Given a pin on the right side, return where it's "wired" up to on
         * the left side.
         */
        public int GetPin_RtoL(int Pin)
        {
            Pin = Pin + pinOffset;
            Pin = Pin % maxPins;
            return mapping[Pin];
        }

        /**
         * Given a pin on the left side, return where it's "wired" up to on
         * the right side.
         */
        public int GetPin_LtoR(int Pin)
        {
            Pin = mapping.IndexOf(Pin) - pinOffset + maxPins;
            Pin = Pin % maxPins;
            return Pin;
        }

        /**
         * Shuffles the contents of a list. 
         */
        private void Shuffle<T>(IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
