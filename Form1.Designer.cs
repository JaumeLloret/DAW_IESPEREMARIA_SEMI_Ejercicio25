namespace Ejercicio25
{
    partial class Form1
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
            tabControlTypeOfParty = new TabControl();
            tabDinner = new TabPage();
            checkBoxHealthyOption = new CheckBox();
            tabBirthday = new TabPage();
            cakeTextBox = new TextBox();
            labelCakeText = new Label();
            labelNumberOfPeople = new Label();
            numericUpDownPeople = new NumericUpDown();
            checkBoxLuxuryDecoration = new CheckBox();
            labelBudget = new Label();
            textBoxPrice = new TextBox();
            tabControlTypeOfParty.SuspendLayout();
            tabDinner.SuspendLayout();
            tabBirthday.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPeople).BeginInit();
            SuspendLayout();
            // 
            // tabControlTypeOfParty
            // 
            tabControlTypeOfParty.Controls.Add(tabDinner);
            tabControlTypeOfParty.Controls.Add(tabBirthday);
            tabControlTypeOfParty.Location = new Point(77, 164);
            tabControlTypeOfParty.Margin = new Padding(2);
            tabControlTypeOfParty.Name = "tabControlTypeOfParty";
            tabControlTypeOfParty.SelectedIndex = 0;
            tabControlTypeOfParty.Size = new Size(395, 179);
            tabControlTypeOfParty.TabIndex = 0;
            tabControlTypeOfParty.SelectedIndexChanged += TabControlTypeOfParty_SelectedIndexChanged;
            // 
            // tabDinner
            // 
            tabDinner.Controls.Add(checkBoxHealthyOption);
            tabDinner.Location = new Point(4, 34);
            tabDinner.Margin = new Padding(2);
            tabDinner.Name = "tabDinner";
            tabDinner.Padding = new Padding(2);
            tabDinner.Size = new Size(387, 141);
            tabDinner.TabIndex = 0;
            tabDinner.Text = "Cenas";
            tabDinner.UseVisualStyleBackColor = true;
            // 
            // checkBoxHealthyOption
            // 
            checkBoxHealthyOption.AutoSize = true;
            checkBoxHealthyOption.Location = new Point(21, 52);
            checkBoxHealthyOption.Margin = new Padding(2);
            checkBoxHealthyOption.Name = "checkBoxHealthyOption";
            checkBoxHealthyOption.Size = new Size(176, 29);
            checkBoxHealthyOption.TabIndex = 0;
            checkBoxHealthyOption.Text = "Opción saludable";
            checkBoxHealthyOption.UseVisualStyleBackColor = true;
            checkBoxHealthyOption.CheckedChanged += CheckBoxHealthyOption_CheckedChanged;
            // 
            // tabBirthday
            // 
            tabBirthday.Controls.Add(cakeTextBox);
            tabBirthday.Controls.Add(labelCakeText);
            tabBirthday.Location = new Point(4, 34);
            tabBirthday.Margin = new Padding(2);
            tabBirthday.Name = "tabBirthday";
            tabBirthday.Padding = new Padding(2);
            tabBirthday.Size = new Size(387, 141);
            tabBirthday.TabIndex = 1;
            tabBirthday.Text = "Cumpleaños";
            tabBirthday.UseVisualStyleBackColor = true;
            // 
            // cakeTextBox
            // 
            cakeTextBox.Location = new Point(21, 57);
            cakeTextBox.Margin = new Padding(2);
            cakeTextBox.MaxLength = 16;
            cakeTextBox.Name = "cakeTextBox";
            cakeTextBox.Size = new Size(347, 31);
            cakeTextBox.TabIndex = 1;
            cakeTextBox.TextChanged += CakeTextBox_TextChanged;
            // 
            // labelCakeText
            // 
            labelCakeText.AutoSize = true;
            labelCakeText.Location = new Point(4, 18);
            labelCakeText.Margin = new Padding(2, 0, 2, 0);
            labelCakeText.Name = "labelCakeText";
            labelCakeText.Size = new Size(140, 25);
            labelCakeText.TabIndex = 0;
            labelCakeText.Text = "Texto en la tarta:";
            // 
            // labelNumberOfPeople
            // 
            labelNumberOfPeople.AutoSize = true;
            labelNumberOfPeople.Location = new Point(77, 36);
            labelNumberOfPeople.Margin = new Padding(2, 0, 2, 0);
            labelNumberOfPeople.Name = "labelNumberOfPeople";
            labelNumberOfPeople.Size = new Size(179, 25);
            labelNumberOfPeople.TabIndex = 0;
            labelNumberOfPeople.Text = "Número de personas";
            // 
            // numericUpDownPeople
            // 
            numericUpDownPeople.Location = new Point(102, 66);
            numericUpDownPeople.Margin = new Padding(2);
            numericUpDownPeople.Name = "numericUpDownPeople";
            numericUpDownPeople.Size = new Size(185, 31);
            numericUpDownPeople.TabIndex = 1;
            numericUpDownPeople.ValueChanged += NumericUpDownPeople_ValueChanged;
            // 
            // checkBoxLuxuryDecoration
            // 
            checkBoxLuxuryDecoration.AutoSize = true;
            checkBoxLuxuryDecoration.Location = new Point(77, 117);
            checkBoxLuxuryDecoration.Margin = new Padding(2);
            checkBoxLuxuryDecoration.Name = "checkBoxLuxuryDecoration";
            checkBoxLuxuryDecoration.Size = new Size(190, 29);
            checkBoxLuxuryDecoration.TabIndex = 0;
            checkBoxLuxuryDecoration.Text = "Decoración de Lujo";
            checkBoxLuxuryDecoration.UseVisualStyleBackColor = true;
            checkBoxLuxuryDecoration.CheckedChanged += CheckBoxLuxuryDecoration_CheckedChanged;
            // 
            // labelBudget
            // 
            labelBudget.AutoSize = true;
            labelBudget.Location = new Point(85, 345);
            labelBudget.Margin = new Padding(2, 0, 2, 0);
            labelBudget.Name = "labelBudget";
            labelBudget.Size = new Size(61, 25);
            labelBudget.TabIndex = 2;
            labelBudget.Text = "Coste:";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(102, 372);
            textBoxPrice.Margin = new Padding(2);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(194, 31);
            textBoxPrice.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 441);
            Controls.Add(textBoxPrice);
            Controls.Add(labelBudget);
            Controls.Add(checkBoxLuxuryDecoration);
            Controls.Add(labelNumberOfPeople);
            Controls.Add(numericUpDownPeople);
            Controls.Add(tabControlTypeOfParty);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            tabControlTypeOfParty.ResumeLayout(false);
            tabDinner.ResumeLayout(false);
            tabDinner.PerformLayout();
            tabBirthday.ResumeLayout(false);
            tabBirthday.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPeople).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControlTypeOfParty;
        private TabPage tabDinner;
        private TabPage tabBirthday;
        private NumericUpDown numericUpDownPeople;
        private Label labelNumberOfPeople;
        private CheckBox checkBoxLuxuryDecoration;
        private CheckBox checkBoxHealthyOption;
        private Label labelCakeText;
        private Label labelBudget;
        private TextBox textBoxPrice;
        private TextBox cakeTextBox;
    }
}