using System;
using System.Collections.Generic;
using System.Text;

namespace enigmaMachine
{
    class RotorHousing
    {
        private Rotor[] rotors;
        private List<String> charMapping;

        /**
         * Creates the "rotor housing" object. It will create rotor count + 1, as
         * the last rotor needs to be a reflector.
         */
        public RotorHousing(int PinCount, int RotorCount, int Seed, List<String> Mapping)
        {
            int i;
            Random rand = new Random(Seed);
            rotors = new Rotor[RotorCount + 1];
            charMapping = Mapping;

            for (i = 0; i < RotorCount; i++)
            {
                rotors[i] = new Rotor(PinCount, rand.Next());
            }

            rotors[i] = new Rotor(PinCount);
        }

        /**
         * Scrambles text input using the rotors.
         */
        public string ScrambleText(string InputText)
        {
            string output = "";

            for (int i = 0; i < InputText.Length; i++)
            {
                string letter = InputText[i].ToString();
                int inputPin = charMapping.IndexOf(letter);

                if (inputPin > -1)
                {
                    int outPin = getRotorOutput(inputPin, 0);
                    advanceRotor(0);
                    output += charMapping[outPin];
                }
                else
                {
                    output += letter;
                }
            }

            return output;
        }

        /**
         * Changes the position of a rotor.
         */
        public void ChangeRotorPosition(int RotorNum, int Position)
        {
            rotors[RotorNum].SetOffset(Position);
        }

        /**
         * Gets the current position of a rotor.
         */
        public int GetRotorPosition(int RotorNum)
        {
            return rotors[RotorNum].GetPosition();
        }

        /**
         * Given an input pin on the first rotor, return the input pin after
         * going through the other rotors. This method is recursive.
         */
        private int getRotorOutput(int InputPin, int RotorNum)
        {
            int outputPin = 0;
            if(RotorNum < rotors.Length - 1)
            {
                outputPin = getRotorOutput(rotors[RotorNum].GetPin_RtoL(InputPin), (RotorNum + 1));
                outputPin = rotors[RotorNum].GetPin_LtoR(outputPin);
            }
            else
            {
                outputPin = rotors[RotorNum].GetPin_LtoR(InputPin);
            }
            return outputPin;
        }

        /**
         * Advances the rotors. If the rotor goes back to position 0, it 
         * advances the next rotor. This method is recursive.
         */
        private void advanceRotor(int RotorNum)
        {
            if (RotorNum == rotors.Length - 1)
                return;

            rotors[RotorNum].AdvanceRotor();
            if (rotors[RotorNum].GetPosition() == 0 && 
                RotorNum < (rotors.Length-1))
            {
                RotorNum++;
                advanceRotor(RotorNum);
            }
        }
    }
}
