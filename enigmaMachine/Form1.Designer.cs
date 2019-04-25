namespace enigmaMachine
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rotor1PositionUpDown = new System.Windows.Forms.NumericUpDown();
            this.rotorSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.rngSeedLabel = new System.Windows.Forms.Label();
            this.rngSeedUpDown = new System.Windows.Forms.NumericUpDown();
            this.setRotorButton = new System.Windows.Forms.Button();
            this.rotor4PositionUpDown = new System.Windows.Forms.NumericUpDown();
            this.rotor3PositionUpDown = new System.Windows.Forms.NumericUpDown();
            this.rotor2PositionUpDown = new System.Windows.Forms.NumericUpDown();
            this.plugBoardCheckbox = new System.Windows.Forms.CheckBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.intputLabel = new System.Windows.Forms.Label();
            this.scrambleButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.inputMethodTabControl = new System.Windows.Forms.TabControl();
            this.simpleInputTabPage = new System.Windows.Forms.TabPage();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.fullMethodTabPage = new System.Windows.Forms.TabPage();
            this.plugBoardGroupBox = new System.Windows.Forms.GroupBox();
            this.clearPlugBoardButton = new System.Windows.Forms.Button();
            this.resetPlugBoardButton = new System.Windows.Forms.Button();
            this.shufflePlugBoardButton = new System.Windows.Forms.Button();
            this.APlugBoardLabel = new System.Windows.Forms.Label();
            this.APlugBoardComboBox = new System.Windows.Forms.ComboBox();
            this.ZKeyButton = new System.Windows.Forms.Button();
            this.AKeyButton = new System.Windows.Forms.Button();
            this.QKeyButton = new System.Windows.Forms.Button();
            this.ZLightLabel = new System.Windows.Forms.Label();
            this.ALightLabel = new System.Windows.Forms.Label();
            this.QLightLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rotor1PositionUpDown)).BeginInit();
            this.rotorSettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rngSeedUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotor4PositionUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotor3PositionUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotor2PositionUpDown)).BeginInit();
            this.inputMethodTabControl.SuspendLayout();
            this.simpleInputTabPage.SuspendLayout();
            this.fullMethodTabPage.SuspendLayout();
            this.plugBoardGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // rotor1PositionUpDown
            // 
            this.rotor1PositionUpDown.Location = new System.Drawing.Point(257, 19);
            this.rotor1PositionUpDown.Name = "rotor1PositionUpDown";
            this.rotor1PositionUpDown.Size = new System.Drawing.Size(64, 20);
            this.rotor1PositionUpDown.TabIndex = 4;
            // 
            // rotorSettingsGroupBox
            // 
            this.rotorSettingsGroupBox.Controls.Add(this.rngSeedLabel);
            this.rotorSettingsGroupBox.Controls.Add(this.rngSeedUpDown);
            this.rotorSettingsGroupBox.Controls.Add(this.setRotorButton);
            this.rotorSettingsGroupBox.Controls.Add(this.rotor4PositionUpDown);
            this.rotorSettingsGroupBox.Controls.Add(this.rotor3PositionUpDown);
            this.rotorSettingsGroupBox.Controls.Add(this.rotor2PositionUpDown);
            this.rotorSettingsGroupBox.Controls.Add(this.rotor1PositionUpDown);
            this.rotorSettingsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.rotorSettingsGroupBox.Name = "rotorSettingsGroupBox";
            this.rotorSettingsGroupBox.Size = new System.Drawing.Size(512, 99);
            this.rotorSettingsGroupBox.TabIndex = 1;
            this.rotorSettingsGroupBox.TabStop = false;
            this.rotorSettingsGroupBox.Text = "Rotor Positions";
            // 
            // rngSeedLabel
            // 
            this.rngSeedLabel.AutoSize = true;
            this.rngSeedLabel.Location = new System.Drawing.Point(10, 47);
            this.rngSeedLabel.Name = "rngSeedLabel";
            this.rngSeedLabel.Size = new System.Drawing.Size(35, 13);
            this.rngSeedLabel.TabIndex = 7;
            this.rngSeedLabel.Text = "Seed:";
            // 
            // rngSeedUpDown
            // 
            this.rngSeedUpDown.Location = new System.Drawing.Point(47, 45);
            this.rngSeedUpDown.Name = "rngSeedUpDown";
            this.rngSeedUpDown.Size = new System.Drawing.Size(120, 20);
            this.rngSeedUpDown.TabIndex = 6;
            this.rngSeedUpDown.ValueChanged += new System.EventHandler(this.rngSeedUpDown_ValueChanged);
            // 
            // setRotorButton
            // 
            this.setRotorButton.Location = new System.Drawing.Point(327, 16);
            this.setRotorButton.Name = "setRotorButton";
            this.setRotorButton.Size = new System.Drawing.Size(75, 23);
            this.setRotorButton.TabIndex = 5;
            this.setRotorButton.Text = "Set rotors";
            this.setRotorButton.UseVisualStyleBackColor = true;
            this.setRotorButton.Click += new System.EventHandler(this.setRotorButton_Click);
            // 
            // rotor4PositionUpDown
            // 
            this.rotor4PositionUpDown.Location = new System.Drawing.Point(47, 19);
            this.rotor4PositionUpDown.Name = "rotor4PositionUpDown";
            this.rotor4PositionUpDown.Size = new System.Drawing.Size(64, 20);
            this.rotor4PositionUpDown.TabIndex = 1;
            // 
            // rotor3PositionUpDown
            // 
            this.rotor3PositionUpDown.Location = new System.Drawing.Point(117, 19);
            this.rotor3PositionUpDown.Name = "rotor3PositionUpDown";
            this.rotor3PositionUpDown.Size = new System.Drawing.Size(64, 20);
            this.rotor3PositionUpDown.TabIndex = 2;
            // 
            // rotor2PositionUpDown
            // 
            this.rotor2PositionUpDown.Location = new System.Drawing.Point(187, 19);
            this.rotor2PositionUpDown.Name = "rotor2PositionUpDown";
            this.rotor2PositionUpDown.Size = new System.Drawing.Size(64, 20);
            this.rotor2PositionUpDown.TabIndex = 3;
            // 
            // plugBoardCheckbox
            // 
            this.plugBoardCheckbox.AutoSize = true;
            this.plugBoardCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.plugBoardCheckbox.Location = new System.Drawing.Point(3, 98);
            this.plugBoardCheckbox.Name = "plugBoardCheckbox";
            this.plugBoardCheckbox.Size = new System.Drawing.Size(80, 17);
            this.plugBoardCheckbox.TabIndex = 3;
            this.plugBoardCheckbox.Text = "Plugboard?";
            this.plugBoardCheckbox.UseVisualStyleBackColor = true;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(46, 6);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(449, 20);
            this.inputTextBox.TabIndex = 0;
            // 
            // intputLabel
            // 
            this.intputLabel.AutoSize = true;
            this.intputLabel.Location = new System.Drawing.Point(6, 9);
            this.intputLabel.Name = "intputLabel";
            this.intputLabel.Size = new System.Drawing.Size(34, 13);
            this.intputLabel.TabIndex = 4;
            this.intputLabel.Text = "Input:";
            // 
            // scrambleButton
            // 
            this.scrambleButton.Location = new System.Drawing.Point(399, 94);
            this.scrambleButton.Name = "scrambleButton";
            this.scrambleButton.Size = new System.Drawing.Size(96, 23);
            this.scrambleButton.TabIndex = 2;
            this.scrambleButton.Text = "Scramble";
            this.scrambleButton.UseVisualStyleBackColor = true;
            this.scrambleButton.Click += new System.EventHandler(this.scrambleButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(3, 35);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(42, 13);
            this.outputLabel.TabIndex = 6;
            this.outputLabel.Text = "Output:";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(46, 32);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(449, 20);
            this.outputTextBox.TabIndex = 1;
            // 
            // inputMethodTabControl
            // 
            this.inputMethodTabControl.Controls.Add(this.simpleInputTabPage);
            this.inputMethodTabControl.Controls.Add(this.fullMethodTabPage);
            this.inputMethodTabControl.Location = new System.Drawing.Point(12, 117);
            this.inputMethodTabControl.Name = "inputMethodTabControl";
            this.inputMethodTabControl.SelectedIndex = 0;
            this.inputMethodTabControl.Size = new System.Drawing.Size(512, 480);
            this.inputMethodTabControl.TabIndex = 0;
            this.inputMethodTabControl.SelectedIndexChanged += new System.EventHandler(this.inputMethodTabControl_SelectedIndexChanged);
            // 
            // simpleInputTabPage
            // 
            this.simpleInputTabPage.Controls.Add(this.settingsLabel);
            this.simpleInputTabPage.Controls.Add(this.plugBoardCheckbox);
            this.simpleInputTabPage.Controls.Add(this.inputTextBox);
            this.simpleInputTabPage.Controls.Add(this.outputTextBox);
            this.simpleInputTabPage.Controls.Add(this.intputLabel);
            this.simpleInputTabPage.Controls.Add(this.outputLabel);
            this.simpleInputTabPage.Controls.Add(this.scrambleButton);
            this.simpleInputTabPage.Location = new System.Drawing.Point(4, 22);
            this.simpleInputTabPage.Name = "simpleInputTabPage";
            this.simpleInputTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.simpleInputTabPage.Size = new System.Drawing.Size(504, 454);
            this.simpleInputTabPage.TabIndex = 0;
            this.simpleInputTabPage.Text = "Simple";
            this.simpleInputTabPage.UseVisualStyleBackColor = true;
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Location = new System.Drawing.Point(6, 132);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(74, 13);
            this.settingsLabel.TabIndex = 8;
            this.settingsLabel.Text = "Settings used:";
            // 
            // fullMethodTabPage
            // 
            this.fullMethodTabPage.Controls.Add(this.plugBoardGroupBox);
            this.fullMethodTabPage.Controls.Add(this.ZKeyButton);
            this.fullMethodTabPage.Controls.Add(this.AKeyButton);
            this.fullMethodTabPage.Controls.Add(this.QKeyButton);
            this.fullMethodTabPage.Controls.Add(this.ZLightLabel);
            this.fullMethodTabPage.Controls.Add(this.ALightLabel);
            this.fullMethodTabPage.Controls.Add(this.QLightLabel);
            this.fullMethodTabPage.Location = new System.Drawing.Point(4, 22);
            this.fullMethodTabPage.Name = "fullMethodTabPage";
            this.fullMethodTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.fullMethodTabPage.Size = new System.Drawing.Size(504, 454);
            this.fullMethodTabPage.TabIndex = 1;
            this.fullMethodTabPage.Text = "Full";
            this.fullMethodTabPage.UseVisualStyleBackColor = true;
            // 
            // plugBoardGroupBox
            // 
            this.plugBoardGroupBox.Controls.Add(this.clearPlugBoardButton);
            this.plugBoardGroupBox.Controls.Add(this.resetPlugBoardButton);
            this.plugBoardGroupBox.Controls.Add(this.shufflePlugBoardButton);
            this.plugBoardGroupBox.Controls.Add(this.APlugBoardLabel);
            this.plugBoardGroupBox.Controls.Add(this.APlugBoardComboBox);
            this.plugBoardGroupBox.Location = new System.Drawing.Point(7, 243);
            this.plugBoardGroupBox.Name = "plugBoardGroupBox";
            this.plugBoardGroupBox.Size = new System.Drawing.Size(491, 206);
            this.plugBoardGroupBox.TabIndex = 53;
            this.plugBoardGroupBox.TabStop = false;
            this.plugBoardGroupBox.Text = "Plug Board";
            // 
            // clearPlugBoardButton
            // 
            this.clearPlugBoardButton.Location = new System.Drawing.Point(394, 173);
            this.clearPlugBoardButton.Name = "clearPlugBoardButton";
            this.clearPlugBoardButton.Size = new System.Drawing.Size(75, 23);
            this.clearPlugBoardButton.TabIndex = 107;
            this.clearPlugBoardButton.Text = "Clear";
            this.clearPlugBoardButton.UseVisualStyleBackColor = true;
            this.clearPlugBoardButton.Click += new System.EventHandler(this.clearPlugBoardButton_Click);
            // 
            // resetPlugBoardButton
            // 
            this.resetPlugBoardButton.Location = new System.Drawing.Point(316, 173);
            this.resetPlugBoardButton.Name = "resetPlugBoardButton";
            this.resetPlugBoardButton.Size = new System.Drawing.Size(75, 23);
            this.resetPlugBoardButton.TabIndex = 106;
            this.resetPlugBoardButton.Text = "Reset";
            this.resetPlugBoardButton.UseVisualStyleBackColor = true;
            this.resetPlugBoardButton.Click += new System.EventHandler(this.resetPlugBoardButton_Click);
            // 
            // shufflePlugBoardButton
            // 
            this.shufflePlugBoardButton.Location = new System.Drawing.Point(235, 173);
            this.shufflePlugBoardButton.Name = "shufflePlugBoardButton";
            this.shufflePlugBoardButton.Size = new System.Drawing.Size(75, 23);
            this.shufflePlugBoardButton.TabIndex = 105;
            this.shufflePlugBoardButton.Text = "Shuffle";
            this.shufflePlugBoardButton.UseVisualStyleBackColor = true;
            this.shufflePlugBoardButton.Click += new System.EventHandler(this.shufflePlugBoardButton_Click);
            // 
            // APlugBoardLabel
            // 
            this.APlugBoardLabel.AutoSize = true;
            this.APlugBoardLabel.BackColor = System.Drawing.SystemColors.Window;
            this.APlugBoardLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APlugBoardLabel.Location = new System.Drawing.Point(6, 19);
            this.APlugBoardLabel.MaximumSize = new System.Drawing.Size(24, 24);
            this.APlugBoardLabel.MinimumSize = new System.Drawing.Size(24, 24);
            this.APlugBoardLabel.Name = "APlugBoardLabel";
            this.APlugBoardLabel.Size = new System.Drawing.Size(24, 24);
            this.APlugBoardLabel.TabIndex = 54;
            this.APlugBoardLabel.Text = "A";
            this.APlugBoardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // APlugBoardComboBox
            // 
            this.APlugBoardComboBox.FormattingEnabled = true;
            this.APlugBoardComboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.APlugBoardComboBox.Location = new System.Drawing.Point(36, 22);
            this.APlugBoardComboBox.Name = "APlugBoardComboBox";
            this.APlugBoardComboBox.Size = new System.Drawing.Size(42, 21);
            this.APlugBoardComboBox.TabIndex = 52;
            // 
            // ZKeyButton
            // 
            this.ZKeyButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZKeyButton.Location = new System.Drawing.Point(83, 207);
            this.ZKeyButton.MaximumSize = new System.Drawing.Size(30, 30);
            this.ZKeyButton.MinimumSize = new System.Drawing.Size(30, 30);
            this.ZKeyButton.Name = "ZKeyButton";
            this.ZKeyButton.Size = new System.Drawing.Size(30, 30);
            this.ZKeyButton.TabIndex = 43;
            this.ZKeyButton.Text = "Z";
            this.ZKeyButton.UseVisualStyleBackColor = true;
            // 
            // AKeyButton
            // 
            this.AKeyButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AKeyButton.Location = new System.Drawing.Point(98, 171);
            this.AKeyButton.MaximumSize = new System.Drawing.Size(30, 30);
            this.AKeyButton.MinimumSize = new System.Drawing.Size(30, 30);
            this.AKeyButton.Name = "AKeyButton";
            this.AKeyButton.Size = new System.Drawing.Size(30, 30);
            this.AKeyButton.TabIndex = 35;
            this.AKeyButton.Text = "A";
            this.AKeyButton.UseVisualStyleBackColor = true;
            // 
            // QKeyButton
            // 
            this.QKeyButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QKeyButton.Location = new System.Drawing.Point(83, 135);
            this.QKeyButton.MaximumSize = new System.Drawing.Size(30, 30);
            this.QKeyButton.MinimumSize = new System.Drawing.Size(30, 30);
            this.QKeyButton.Name = "QKeyButton";
            this.QKeyButton.Size = new System.Drawing.Size(30, 30);
            this.QKeyButton.TabIndex = 26;
            this.QKeyButton.Text = "Q";
            this.QKeyButton.UseVisualStyleBackColor = true;
            // 
            // ZLightLabel
            // 
            this.ZLightLabel.AutoSize = true;
            this.ZLightLabel.BackColor = System.Drawing.Color.Gray;
            this.ZLightLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZLightLabel.Location = new System.Drawing.Point(83, 85);
            this.ZLightLabel.MaximumSize = new System.Drawing.Size(30, 30);
            this.ZLightLabel.MinimumSize = new System.Drawing.Size(30, 30);
            this.ZLightLabel.Name = "ZLightLabel";
            this.ZLightLabel.Size = new System.Drawing.Size(30, 30);
            this.ZLightLabel.TabIndex = 19;
            this.ZLightLabel.Text = "Z";
            this.ZLightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ALightLabel
            // 
            this.ALightLabel.AutoSize = true;
            this.ALightLabel.BackColor = System.Drawing.Color.Gray;
            this.ALightLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ALightLabel.Location = new System.Drawing.Point(98, 50);
            this.ALightLabel.MaximumSize = new System.Drawing.Size(30, 30);
            this.ALightLabel.MinimumSize = new System.Drawing.Size(30, 30);
            this.ALightLabel.Name = "ALightLabel";
            this.ALightLabel.Size = new System.Drawing.Size(30, 30);
            this.ALightLabel.TabIndex = 10;
            this.ALightLabel.Text = "A";
            this.ALightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QLightLabel
            // 
            this.QLightLabel.AutoSize = true;
            this.QLightLabel.BackColor = System.Drawing.Color.Gray;
            this.QLightLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLightLabel.Location = new System.Drawing.Point(83, 14);
            this.QLightLabel.MaximumSize = new System.Drawing.Size(30, 30);
            this.QLightLabel.MinimumSize = new System.Drawing.Size(30, 30);
            this.QLightLabel.Name = "QLightLabel";
            this.QLightLabel.Size = new System.Drawing.Size(30, 30);
            this.QLightLabel.TabIndex = 0;
            this.QLightLabel.Text = "Q";
            this.QLightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 606);
            this.Controls.Add(this.inputMethodTabControl);
            this.Controls.Add(this.rotorSettingsGroupBox);
            this.Name = "Form1";
            this.Text = "Engima Machine";
            ((System.ComponentModel.ISupportInitialize)(this.rotor1PositionUpDown)).EndInit();
            this.rotorSettingsGroupBox.ResumeLayout(false);
            this.rotorSettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rngSeedUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotor4PositionUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotor3PositionUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotor2PositionUpDown)).EndInit();
            this.inputMethodTabControl.ResumeLayout(false);
            this.simpleInputTabPage.ResumeLayout(false);
            this.simpleInputTabPage.PerformLayout();
            this.fullMethodTabPage.ResumeLayout(false);
            this.fullMethodTabPage.PerformLayout();
            this.plugBoardGroupBox.ResumeLayout(false);
            this.plugBoardGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown rotor1PositionUpDown;
        private System.Windows.Forms.GroupBox rotorSettingsGroupBox;
        private System.Windows.Forms.NumericUpDown rotor2PositionUpDown;
        private System.Windows.Forms.NumericUpDown rotor4PositionUpDown;
        private System.Windows.Forms.NumericUpDown rotor3PositionUpDown;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label intputLabel;
        private System.Windows.Forms.Button scrambleButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button setRotorButton;
        private System.Windows.Forms.Label rngSeedLabel;
        private System.Windows.Forms.NumericUpDown rngSeedUpDown;
        private System.Windows.Forms.CheckBox plugBoardCheckbox;
        private System.Windows.Forms.TabControl inputMethodTabControl;
        private System.Windows.Forms.TabPage simpleInputTabPage;
        private System.Windows.Forms.TabPage fullMethodTabPage;
        private System.Windows.Forms.Label ZLightLabel;
        private System.Windows.Forms.Label ALightLabel;
        private System.Windows.Forms.Label QLightLabel;
        private System.Windows.Forms.Button QKeyButton;
        private System.Windows.Forms.Button AKeyButton;
        private System.Windows.Forms.Button ZKeyButton;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Button clearPlugBoardButton;
        private System.Windows.Forms.Button resetPlugBoardButton;
        private System.Windows.Forms.Button shufflePlugBoardButton;
        private System.Windows.Forms.Label APlugBoardLabel;
        private System.Windows.Forms.ComboBox APlugBoardComboBox;
        private System.Windows.Forms.GroupBox plugBoardGroupBox;
    }
}

