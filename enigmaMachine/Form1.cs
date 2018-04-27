using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enigmaMachine
{
    public partial class Form1 : Form
    {
        const int PIN_COUNT = 26;
        const int ROTOR_COUNT = 4;
        private RotorHousing machine;
        private List<String> charMapping;
        private List<NumericUpDown> rotorPositions;
        private List<Label> lampLabels;
        private List<Button> keyboardButtons;
        private List<ComboBox> plugBoardPins;
        private PlugBoard plugBoard;

        public Form1()
        {
            InitializeComponent();
            charMapping = new List<string>();

            for (int i = 0; i < PIN_COUNT; i++)
            {
                charMapping.Add(((char)(0x41 + i)).ToString());
            }

            setupRotors();
            setupLampLabels();
            setupKeyboardButtons();
            setupPlugBoard();

            rngSeedUpDown.Maximum = int.MaxValue;
            rngSeedUpDown.Value = new Random().Next();

            machine = new RotorHousing(PIN_COUNT, ROTOR_COUNT, (int)rngSeedUpDown.Value, charMapping);
            plugBoard = new PlugBoard((int)rngSeedUpDown.Value, charMapping);
            plugBoard.ShuffleWiring();
        }

        /* GUI elements with multiple versions of the same thing are grouped for dynamic handling. 
           This makes it so a ton of handlers are avoided. */

        private void setupRotors()
        {
            rotorPositions = new List<NumericUpDown>();
            rotorPositions.Add(rotor1PositionUpDown);
            rotorPositions.Add(rotor2PositionUpDown);
            rotorPositions.Add(rotor3PositionUpDown);
            rotorPositions.Add(rotor4PositionUpDown);

            foreach(NumericUpDown rotor in rotorPositions)
            {
                rotor.Maximum = PIN_COUNT;
                rotor.Leave += Rotor_Leave;
            }
                
        }

        private void setupLampLabels()
        {
            lampLabels = new List<Label>();
            lampLabels.Add(ALightLabel);
            lampLabels.Add(BLightLabel);
            lampLabels.Add(CLightLabel);
            lampLabels.Add(DLightLabel);
            lampLabels.Add(ELightLabel);
            lampLabels.Add(FLightLabel);
            lampLabels.Add(GLightLabel);
            lampLabels.Add(HLightLabel);
            lampLabels.Add(ILightLabel);
            lampLabels.Add(JLightLabel);
            lampLabels.Add(KLightLabel);
            lampLabels.Add(LLightLabel);
            lampLabels.Add(MLightLabel);
            lampLabels.Add(NLightLabel);
            lampLabels.Add(OLightLabel);
            lampLabels.Add(PLightLabel);
            lampLabels.Add(QLightLabel);
            lampLabels.Add(RLightLabel);
            lampLabels.Add(SLightLabel);
            lampLabels.Add(TLightLabel);
            lampLabels.Add(ULightLabel);
            lampLabels.Add(VLightLabel);
            lampLabels.Add(WLightLabel);
            lampLabels.Add(XLightLabel);
            lampLabels.Add(YLightLabel);
            lampLabels.Add(ZLightLabel);
        }

        private void setupKeyboardButtons()
        {
            keyboardButtons = new List<Button>();

            keyboardButtons.Add(AKeyButton);
            keyboardButtons.Add(BKeyButton);
            keyboardButtons.Add(CKeyButton);
            keyboardButtons.Add(DKeyButton);
            keyboardButtons.Add(EKeyButton);
            keyboardButtons.Add(FKeyButton);
            keyboardButtons.Add(GKeyButton);
            keyboardButtons.Add(HKeyButton);
            keyboardButtons.Add(IKeyButton);
            keyboardButtons.Add(JKeyButton);
            keyboardButtons.Add(KKeyButton);
            keyboardButtons.Add(LKeyButton);
            keyboardButtons.Add(MKeyButton);
            keyboardButtons.Add(NKeyButton);
            keyboardButtons.Add(OKeyButton);
            keyboardButtons.Add(PKeyButton);
            keyboardButtons.Add(QKeyButton);
            keyboardButtons.Add(RKeyButton);
            keyboardButtons.Add(SKeyButton);
            keyboardButtons.Add(TKeyButton);
            keyboardButtons.Add(UKeyButton);
            keyboardButtons.Add(VKeyButton);
            keyboardButtons.Add(WKeyButton);
            keyboardButtons.Add(XKeyButton);
            keyboardButtons.Add(YKeyButton);
            keyboardButtons.Add(ZKeyButton);

            foreach(Button keyButton in keyboardButtons)
            {
                keyButton.Click += KeyButton_Click;
            }
        }

        private void setupPlugBoard()
        {
            plugBoardPins = new List<ComboBox>();
            plugBoardPins.Add(APlugBoardComboBox);
            plugBoardPins.Add(BPlugBoardComboBox);
            plugBoardPins.Add(CPlugBoardComboBox);
            plugBoardPins.Add(DPlugBoardComboBox);
            plugBoardPins.Add(EPlugBoardComboBox);
            plugBoardPins.Add(FPlugBoardComboBox);
            plugBoardPins.Add(GPlugBoardComboBox);
            plugBoardPins.Add(HPlugBoardComboBox);
            plugBoardPins.Add(IPlugBoardComboBox);
            plugBoardPins.Add(JPlugBoardComboBox);
            plugBoardPins.Add(KPlugBoardComboBox);
            plugBoardPins.Add(LPlugBoardComboBox);
            plugBoardPins.Add(MPlugBoardComboBox);
            plugBoardPins.Add(NPlugBoardComboBox);
            plugBoardPins.Add(OPlugBoardComboBox);
            plugBoardPins.Add(PPlugBoardComboBox);
            plugBoardPins.Add(QPlugBoardComboBox);
            plugBoardPins.Add(RPlugBoardComboBox);
            plugBoardPins.Add(SPlugBoardComboBox);
            plugBoardPins.Add(TPlugBoardComboBox);
            plugBoardPins.Add(UPlugBoardComboBox);
            plugBoardPins.Add(VPlugBoardComboBox);
            plugBoardPins.Add(WPlugBoardComboBox);
            plugBoardPins.Add(XPlugBoardComboBox);
            plugBoardPins.Add(YPlugBoardComboBox);
            plugBoardPins.Add(ZPlugBoardComboBox);

            for (int i = 0; i < plugBoardPins.Count; i++)
            {
                plugBoardPins[i].SelectedIndex = i;
                plugBoardPins[i].SelectedValueChanged += PlugBoardPin_SelectedValueChanged;
            }
        }
 
        private void Rotor_Leave(object sender, EventArgs e)
        {
            int rotorIndex = rotorPositions.IndexOf((NumericUpDown)sender);
            rotorPositions[rotorIndex].BackColor = Color.Salmon;
        }

        private void KeyButton_Click(object sender, EventArgs e)
        {
            int keyIndex = keyboardButtons.IndexOf((Button)sender);
            Button keyButton = keyboardButtons[keyIndex];
            string keyLetter = keyButton.Name.Substring(0, 1);
            keyLetter = plugBoard.GetRewiredLetter(keyLetter);
            encodeKeyPress(keyLetter);
        }

        private void PlugBoardPin_SelectedValueChanged(object sender, EventArgs e)
        {
            int origin = plugBoardPins.IndexOf((ComboBox)sender);
            int dest = plugBoardPins[origin].SelectedIndex;

            plugBoard.ChangeWiring(IntToLetter(origin), IntToLetter(dest));
            updatePlugBoardGui();
        }

        /* Single GUI event handlers (not part of a set) */

        private void scrambleButton_Click(object sender, EventArgs e)
        {
            string inputText = inputTextBox.Text.ToUpper();
            string outputText = "";
            if (plugBoardCheckbox.Checked)
            {
                inputText = runPlugBoard(inputText);
            }

            outputText = scrambleInput(inputText);

            if (plugBoardCheckbox.Checked)
            {
                outputText = runPlugBoard(outputText);
            }

            outputTextBox.Text = outputText;
        }

        private void setRotorButton_Click(object sender, EventArgs e)
        {
            for (int rotor = 0; rotor < rotorPositions.Count; rotor++)
            {
                machine.ChangeRotorPosition(rotor, (int)rotorPositions[rotor].Value);
                rotorPositions[rotor].BackColor = SystemColors.Window;
            }
            resetLights();
        }

        private void rngSeedUpDown_ValueChanged(object sender, EventArgs e)
        {
            machine = new RotorHousing(PIN_COUNT, ROTOR_COUNT, (int)rngSeedUpDown.Value, charMapping);
            foreach (NumericUpDown rotor in rotorPositions)
                rotor.BackColor = SystemColors.Window;
        }

        private void randomizePlugBoardButton_Click(object sender, EventArgs e)
        {
            plugBoard = new PlugBoard((int)rngSeedUpDown.Value, charMapping);
            plugBoard.ShuffleWiring();
            updatePlugBoardGui();
            resetLights();
        }

        private void resetPlugBoardButton_Click(object sender, EventArgs e)
        {
            plugBoard = new PlugBoard((int)rngSeedUpDown.Value, charMapping); ;
            updatePlugBoardGui();
            resetLights();
        }

        private void inputMethodTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inputMethodTabControl.SelectedIndex == 1)
                updatePlugBoardGui();
        }

        /* Utility Functions */

        private void encodeKeyPress(string Key)
        {
            int lampIdx = 0;
            resetLights();
            Key = plugBoard.GetRewiredLetter(Key);
            lampIdx = LetterToInt(scrambleInput(Key));
            lampLabels[lampIdx].BackColor = Color.Yellow;
        }

        private string scrambleInput(string Input)
        {
            string output = machine.Scramble(Input);
            for (int rotor = 0; rotor < rotorPositions.Count; rotor++)
                rotorPositions[rotor].Value = machine.GetRotorPosition(rotor);
            return output;
        }

        private string runPlugBoard(string Input)
        {
            string swappedInput = "";

            for (int i = 0; i < Input.Length; i++)
            {
                swappedInput += plugBoard.GetRewiredLetter(Input[i].ToString());
            }

            return swappedInput;
        }

        private int LetterToInt(string Letter)
        {
            return (int)((char)Letter[0] - 0x41);
        }

        private string IntToLetter(int LetterCode)
        {
            return ((char)(0x41 + LetterCode)).ToString();
        }

        private void updatePlugBoardGui()
        {
            for(int i = 0; i < plugBoardPins.Count; i++)
            {
                string letter = ((char)(i + 0x41)).ToString();
                plugBoardPins[i].SelectedIndex = LetterToInt(plugBoard.GetRewiredLetter(letter));
            }
        }

        private void resetLights()
        {
            foreach(Label lamp in lampLabels)
                lamp.BackColor = Color.Gray;
        }

    }
}
