namespace RandomPasswordGenerator
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            IncludeNumbers = new CheckBox();
            PasswordLength = new NumericUpDown();
            BeginWithLetter = new CheckBox();
            IncludeUpperCase = new CheckBox();
            IncludeLowerCase = new CheckBox();
            IncludeSymbols = new CheckBox();
            NoSimilarCharacters = new CheckBox();
            NoDuplicateCharacters = new CheckBox();
            NoSequentialCharacters = new CheckBox();
            SymbolsToInclude = new TextBox();
            Generate = new Button();
            Result = new TextBox();
            Quantity = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)PasswordLength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Quantity).BeginInit();
            SuspendLayout();
            // 
            // IncludeNumbers
            // 
            IncludeNumbers.AutoSize = true;
            IncludeNumbers.Checked = true;
            IncludeNumbers.CheckState = CheckState.Checked;
            IncludeNumbers.Location = new Point(15, 57);
            IncludeNumbers.Margin = new Padding(4);
            IncludeNumbers.Name = "IncludeNumbers";
            IncludeNumbers.Size = new Size(186, 25);
            IncludeNumbers.TabIndex = 0;
            IncludeNumbers.Text = "Include Numbers (0-9)";
            IncludeNumbers.UseVisualStyleBackColor = true;
            // 
            // PasswordLength
            // 
            PasswordLength.Location = new Point(80, 13);
            PasswordLength.Margin = new Padding(4);
            PasswordLength.Maximum = new decimal(new int[] { 48, 0, 0, 0 });
            PasswordLength.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            PasswordLength.Name = "PasswordLength";
            PasswordLength.Size = new Size(62, 29);
            PasswordLength.TabIndex = 1;
            PasswordLength.Value = new decimal(new int[] { 16, 0, 0, 0 });
            // 
            // BeginWithLetter
            // 
            BeginWithLetter.AutoSize = true;
            BeginWithLetter.Checked = true;
            BeginWithLetter.CheckState = CheckState.Checked;
            BeginWithLetter.Location = new Point(15, 162);
            BeginWithLetter.Margin = new Padding(4);
            BeginWithLetter.Name = "BeginWithLetter";
            BeginWithLetter.Size = new Size(154, 25);
            BeginWithLetter.TabIndex = 2;
            BeginWithLetter.Text = "Begin with a letter";
            BeginWithLetter.UseVisualStyleBackColor = true;
            // 
            // IncludeUpperCase
            // 
            IncludeUpperCase.AutoSize = true;
            IncludeUpperCase.Checked = true;
            IncludeUpperCase.CheckState = CheckState.Checked;
            IncludeUpperCase.Location = new Point(15, 127);
            IncludeUpperCase.Margin = new Padding(4);
            IncludeUpperCase.Name = "IncludeUpperCase";
            IncludeUpperCase.Size = new Size(202, 25);
            IncludeUpperCase.TabIndex = 3;
            IncludeUpperCase.Text = "Include Upper Case (A-Z)";
            IncludeUpperCase.UseVisualStyleBackColor = true;
            // 
            // IncludeLowerCase
            // 
            IncludeLowerCase.AutoSize = true;
            IncludeLowerCase.Checked = true;
            IncludeLowerCase.CheckState = CheckState.Checked;
            IncludeLowerCase.Location = new Point(15, 92);
            IncludeLowerCase.Margin = new Padding(4);
            IncludeLowerCase.Name = "IncludeLowerCase";
            IncludeLowerCase.Size = new Size(198, 25);
            IncludeLowerCase.TabIndex = 4;
            IncludeLowerCase.Text = "Include Lower Case (a-z)";
            IncludeLowerCase.UseVisualStyleBackColor = true;
            // 
            // IncludeSymbols
            // 
            IncludeSymbols.AutoSize = true;
            IncludeSymbols.Location = new Point(15, 197);
            IncludeSymbols.Margin = new Padding(4);
            IncludeSymbols.Name = "IncludeSymbols";
            IncludeSymbols.Size = new Size(143, 25);
            IncludeSymbols.TabIndex = 5;
            IncludeSymbols.Text = "Include Symbols";
            IncludeSymbols.UseVisualStyleBackColor = true;
            // 
            // NoSimilarCharacters
            // 
            NoSimilarCharacters.AutoSize = true;
            NoSimilarCharacters.Checked = true;
            NoSimilarCharacters.CheckState = CheckState.Checked;
            NoSimilarCharacters.Location = new Point(15, 232);
            NoSimilarCharacters.Margin = new Padding(4);
            NoSimilarCharacters.Name = "NoSimilarCharacters";
            NoSimilarCharacters.Size = new Size(292, 25);
            NoSimilarCharacters.TabIndex = 6;
            NoSimilarCharacters.Text = "No Similar Characters (i, l, 1, L, o, 0, O)";
            NoSimilarCharacters.UseVisualStyleBackColor = true;
            // 
            // NoDuplicateCharacters
            // 
            NoDuplicateCharacters.AutoSize = true;
            NoDuplicateCharacters.Checked = true;
            NoDuplicateCharacters.CheckState = CheckState.Checked;
            NoDuplicateCharacters.Location = new Point(15, 267);
            NoDuplicateCharacters.Margin = new Padding(4);
            NoDuplicateCharacters.Name = "NoDuplicateCharacters";
            NoDuplicateCharacters.Size = new Size(197, 25);
            NoDuplicateCharacters.TabIndex = 7;
            NoDuplicateCharacters.Text = "No Duplicate Characters";
            NoDuplicateCharacters.UseVisualStyleBackColor = true;
            // 
            // NoSequentialCharacters
            // 
            NoSequentialCharacters.AutoSize = true;
            NoSequentialCharacters.Checked = true;
            NoSequentialCharacters.CheckState = CheckState.Checked;
            NoSequentialCharacters.Location = new Point(15, 302);
            NoSequentialCharacters.Margin = new Padding(4);
            NoSequentialCharacters.Name = "NoSequentialCharacters";
            NoSequentialCharacters.Size = new Size(299, 25);
            NoSequentialCharacters.TabIndex = 8;
            NoSequentialCharacters.Text = "No Sequential Characters (i.e. 123, abc)";
            NoSequentialCharacters.UseVisualStyleBackColor = true;
            // 
            // SymbolsToInclude
            // 
            SymbolsToInclude.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SymbolsToInclude.Location = new Point(166, 195);
            SymbolsToInclude.Margin = new Padding(4);
            SymbolsToInclude.Name = "SymbolsToInclude";
            SymbolsToInclude.Size = new Size(325, 26);
            SymbolsToInclude.TabIndex = 9;
            SymbolsToInclude.Text = "!\";#$%&'()*+,-./:;<=>?@[]^_`{|}~";
            // 
            // Generate
            // 
            Generate.Location = new Point(601, 302);
            Generate.Margin = new Padding(4);
            Generate.Name = "Generate";
            Generate.Size = new Size(96, 32);
            Generate.TabIndex = 10;
            Generate.Text = "Generate";
            Generate.UseVisualStyleBackColor = true;
            Generate.Click += Generate_Click;
            // 
            // Result
            // 
            Result.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Result.Location = new Point(13, 358);
            Result.Margin = new Padding(4);
            Result.Multiline = true;
            Result.Name = "Result";
            Result.ScrollBars = ScrollBars.Both;
            Result.Size = new Size(684, 158);
            Result.TabIndex = 11;
            // 
            // Quantity
            // 
            Quantity.Location = new Point(272, 13);
            Quantity.Margin = new Padding(4);
            Quantity.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            Quantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(62, 29);
            Quantity.TabIndex = 12;
            Quantity.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 13;
            label1.Text = "Length";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 15);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 14;
            label2.Text = "Quantity";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 535);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Quantity);
            Controls.Add(Result);
            Controls.Add(Generate);
            Controls.Add(SymbolsToInclude);
            Controls.Add(NoSequentialCharacters);
            Controls.Add(NoDuplicateCharacters);
            Controls.Add(NoSimilarCharacters);
            Controls.Add(IncludeSymbols);
            Controls.Add(IncludeLowerCase);
            Controls.Add(IncludeUpperCase);
            Controls.Add(BeginWithLetter);
            Controls.Add(PasswordLength);
            Controls.Add(IncludeNumbers);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Main";
            Text = "Mike's Random Password Generator";
            ((System.ComponentModel.ISupportInitialize)PasswordLength).EndInit();
            ((System.ComponentModel.ISupportInitialize)Quantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox IncludeNumbers;
        private NumericUpDown PasswordLength;
        private CheckBox BeginWithLetter;
        private CheckBox IncludeUpperCase;
        private CheckBox IncludeLowerCase;
        private CheckBox IncludeSymbols;
        private CheckBox NoSimilarCharacters;
        private CheckBox NoDuplicateCharacters;
        private CheckBox NoSequentialCharacters;
        private TextBox SymbolsToInclude;
        private Button Generate;
        private TextBox Result;
        private NumericUpDown Quantity;
        private Label label1;
        private Label label2;
    }
}
