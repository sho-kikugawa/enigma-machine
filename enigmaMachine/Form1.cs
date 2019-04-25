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
        static string[] QWERTY_LINE = {"QWERTYUIO", "ASDFGHJK", "ZXCVBNMLP"};

        private Label lastLamp;
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
            setuplampLabels();
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
                rotor.ValueChanged += Rotor_ValueChanged;
            }
                
        }

        private void setuplampLabels()
        {
            int row = 0;
            lampLabels = new List<Label>();

            setupLamp(QLightLabel, row++);
            setupLamp(ALightLabel, row++);
            setupLamp(ZLightLabel, row++);

            lastLamp = QLightLabel;
            lampLabels.Sort((x, y) => String.Compare(x.Text, y.Text));
        }

        private void setupLamp(Label BaseLabel, int Row)
        {
            const int LABEL_SPACING = 36;
            lampLabels.Add(BaseLabel);
            for (int Col = 1; Col < QWERTY_LINE[Row].Length; Col++)
            {
                Label lampLabel = new Label();
                lampLabel.Font = BaseLabel.Font;
                lampLabel.TextAlign = ContentAlignment.MiddleCenter;
                lampLabel.BackColor = Color.Gray;
                lampLabel.Parent = fullMethodTabPage;
                lampLabel.Location = new Point(BaseLabel.Location.X + (Col * LABEL_SPACING), BaseLabel.Location.Y);
                lampLabel.Size = new Size(30, 30);
                lampLabel.Text = QWERTY_LINE[Row][Col].ToString();
                lampLabel.Name = string.Format("{0}LightLabel", QWERTY_LINE[Row][Col]);
                lampLabels.Add(lampLabel);
            }
        }

        private void setupKeyboardButtons()
        {
            int row = 0;
            keyboardButtons = new List<Button>();

            setupKey(QKeyButton, row++);
            setupKey(AKeyButton, row++);
            setupKey(ZKeyButton, row++);
        }

        private void setupKey(Button BaseButton, int Row)
        {
            const int BUTTON_SPACING = 36;
            BaseButton.Click += KeyButton_Click;
            keyboardButtons.Add(BaseButton);

            for (int Col = 1; Col < QWERTY_LINE[Row].Length; Col++)
            {
                Button keyButton = new Button();
                keyButton.Font = BaseButton.Font;
                keyButton.TextAlign = ContentAlignment.MiddleCenter;
                keyButton.Parent = fullMethodTabPage;
                keyButton.Location = new Point(BaseButton.Location.X + (Col * BUTTON_SPACING), BaseButton.Location.Y);
                keyButton.Size = new Size(30, 30);
                keyButton.Text = QWERTY_LINE[Row][Col].ToString();
                keyButton.Name = string.Format("{0}KeyButton", QWERTY_LINE[Row][Col]);
                keyButton.Click += KeyButton_Click;
                keyboardButtons.Add(keyButton);
            }
        }

        private void setupPlugBoard()
        {
            const int LABEL_SPACING_X = 78;
            const int LABEL_SPACING_Y = 40;
            plugBoardPins = new List<ComboBox>();

            APlugBoardComboBox.SelectedIndex = 0;
            APlugBoardComboBox.SelectedValueChanged += PlugBoardPin_SelectedValueChanged;
            plugBoardPins.Add(APlugBoardComboBox);
            for (char letter = 'B'; letter <= 'Z'; letter++)
            {
                int col = (letter - 'A') % 6;
                int row = (letter - 'A') / 6;
                Label plugBoardLabel = new Label();
                plugBoardLabel.Font = APlugBoardLabel.Font;
                plugBoardLabel.TextAlign = ContentAlignment.MiddleCenter;
                plugBoardLabel.Parent = plugBoardGroupBox;
                plugBoardLabel.Location = new Point(APlugBoardLabel.Location.X + (col * LABEL_SPACING_X), APlugBoardLabel.Location.Y + (row * LABEL_SPACING_Y));
                plugBoardLabel.Size = new Size(24, 24);
                plugBoardLabel.Text = letter.ToString();
                plugBoardLabel.Name = string.Format("{0}PlugBoardLabel", letter);

                ComboBox plugBoardCombo = new ComboBox();
                plugBoardCombo.Parent = plugBoardGroupBox;
                plugBoardCombo.DropDownHeight = 106;
                plugBoardCombo.DropDownWidth = 42;
                plugBoardCombo.Size = new Size(42, 20);
                plugBoardCombo.Location = new Point(APlugBoardComboBox.Location.X + (col * LABEL_SPACING_X), APlugBoardComboBox.Location.Y + (row * LABEL_SPACING_Y));
                plugBoardCombo.Name = string.Format("{0}PlugBoardComboBox", letter);
                plugBoardCombo.Items.AddRange(APlugBoardComboBox.Items.Cast<object>().ToArray());
                plugBoardCombo.SelectedIndex = (letter - 'A');
                plugBoardCombo.SelectedValueChanged += PlugBoardPin_SelectedValueChanged;
                plugBoardPins.Add(plugBoardCombo);
            }
        }
 
        private void Rotor_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown rotor = (NumericUpDown)sender;
            int rotorIndex = rotorPositions.IndexOf(rotor);
            if (machine.GetRotorPosition(rotorIndex) != (int)rotor.Value)
                rotor.BackColor = Color.Salmon;
            else
                rotor.BackColor = SystemColors.Window;
        }

        private void KeyButton_Click(object sender, EventArgs e)
        {
            Button keyButton = ((Button)sender);
            string keyLetter = keyButton.Name.Substring(0, 1);
            keyLetter = plugBoard.GetRewiredLetter(keyLetter);
            int lampIdx = (char)(scrambleInput(keyLetter)[0]) - 'A';
            lastLamp.BackColor = Color.Gray;
            lastLamp = lampLabels[lampIdx];
            lampLabels[lampIdx].BackColor = Color.Yellow;
        }

        private void PlugBoardPin_SelectedValueChanged(object sender, EventArgs e)
        {
            int origin = plugBoardPins.IndexOf((ComboBox)sender);
            int dest = plugBoardPins[origin].SelectedIndex;

            char originChar = Convert.ToChar(origin + 'A');
            char destChar = Convert.ToChar(dest + 'A');

            plugBoard.ChangeWiring(originChar.ToString(), destChar.ToString());
            updatePlugBoardGui();
        }

        /* Single GUI event handlers (not part of a set) */

        private void scrambleButton_Click(object sender, EventArgs e)
        {
            string inputText = inputTextBox.Text.ToUpper();
            string outputText = "";

            settingsLabel.Text = string.Format("Settings: {0}:{1}:{2}:{3}-{4}-{5}",
                rotor4PositionUpDown.Value, rotor3PositionUpDown.Value,
                rotor2PositionUpDown.Value, rotor1PositionUpDown.Value,
                rngSeedUpDown.Value, (plugBoardCheckbox.Checked ? 1 : 0));

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
            lastLamp.BackColor = Color.Gray;
        }

        private void rngSeedUpDown_ValueChanged(object sender, EventArgs e)
        {
            machine = new RotorHousing(PIN_COUNT, ROTOR_COUNT, (int)rngSeedUpDown.Value, charMapping);
            foreach (NumericUpDown rotor in rotorPositions)
                rotor.BackColor = SystemColors.Window;
        }

        private void shufflePlugBoardButton_Click(object sender, EventArgs e)
        {
            plugBoard.ShuffleWiring();
            updatePlugBoardGui();
        }

        private void resetPlugBoardButton_Click(object sender, EventArgs e)
        {
            plugBoard = new PlugBoard((int)rngSeedUpDown.Value, charMapping);
            plugBoard.ShuffleWiring();
            updatePlugBoardGui();
        }

        private void clearPlugBoardButton_Click(object sender, EventArgs e)
        {
            plugBoard = new PlugBoard((int)rngSeedUpDown.Value, charMapping);
            updatePlugBoardGui();
        }

        private void inputMethodTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inputMethodTabControl.SelectedIndex == 1)
                updatePlugBoardGui();
        }

        /* Utility Functions */

        private string scrambleInput(string Input)
        {
            string output = machine.ScrambleText(Input);
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

        private void updatePlugBoardGui()
        {
            for(int i = 0; i < plugBoardPins.Count; i++)
            {
                string letter = ((char)(i + 'A')).ToString();
                plugBoardPins[i].SelectedIndex = (char)plugBoard.GetRewiredLetter(letter)[0] - 'A';
            }
            lastLamp.BackColor = Color.Gray;
        }
    }
}
