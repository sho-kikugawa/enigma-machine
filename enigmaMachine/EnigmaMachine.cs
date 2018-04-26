using System;
using System.Collections.Generic;
using System.Text;

namespace enigmaMachine
{
    class EnigmaMachine
    {
        private Rotor[] rotors;
        private List<String> charMapping;

        public EnigmaMachine(int PinCount, int RotorCount, int Seed, List<String> Mapping)
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
        public string Scramble(string InputText)
        {
            string output = "";
            byte[] inputBytes;

            InputText = InputText.ToUpper();
            inputBytes = Encoding.ASCII.GetBytes(InputText);

            for (int i = 0; i < inputBytes.Length; i++)
            {
                if (0x41 <= (int)inputBytes[i] && (int)inputBytes[i] <= 0x5A)
                {
                    int inputPin = (int)inputBytes[i] - 0x41;
                    int outPin = getRotorOutput(inputPin, 0);
                    advanceRotor(0);
                    output += charMapping[outPin];
                }
                else
                {
                    output += (char)inputBytes[i];
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
                outputPin = getRotorOutput(rotors[RotorNum].GetInToOut(InputPin), (RotorNum + 1));
                outputPin = rotors[RotorNum].GetOutToIn(outputPin);
            }
            else
            {
                outputPin = rotors[RotorNum].GetOutToIn(InputPin);
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
