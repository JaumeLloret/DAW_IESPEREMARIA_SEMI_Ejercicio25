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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDinner = new System.Windows.Forms.TabPage();
            this.checkBoxHealthyOption = new System.Windows.Forms.CheckBox();
            this.tabBirthday = new System.Windows.Forms.TabPage();
            this.CakeTextBox = new System.Windows.Forms.TextBox();
            this.labelCakeText = new System.Windows.Forms.Label();
            this.labelNumberOfPeople = new System.Windows.Forms.Label();
            this.numericUpDownPeople = new System.Windows.Forms.NumericUpDown();
            this.checkBoxLuxuryDecoration = new System.Windows.Forms.CheckBox();
            this.labelBudget = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabDinner.SuspendLayout();
            this.tabBirthday.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDinner);
            this.tabControl1.Controls.Add(this.tabBirthday);
            this.tabControl1.Location = new System.Drawing.Point(74, 355);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(946, 401);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDinner
            // 
            this.tabDinner.Controls.Add(this.checkBoxHealthyOption);
            this.tabDinner.Location = new System.Drawing.Point(8, 46);
            this.tabDinner.Name = "tabDinner";
            this.tabDinner.Padding = new System.Windows.Forms.Padding(3);
            this.tabDinner.Size = new System.Drawing.Size(930, 347);
            this.tabDinner.TabIndex = 0;
            this.tabDinner.Text = "Cenas";
            this.tabDinner.UseVisualStyleBackColor = true;
            // 
            // checkBoxHealthyOption
            // 
            this.checkBoxHealthyOption.AutoSize = true;
            this.checkBoxHealthyOption.Location = new System.Drawing.Point(33, 33);
            this.checkBoxHealthyOption.Name = "checkBoxHealthyOption";
            this.checkBoxHealthyOption.Size = new System.Drawing.Size(231, 36);
            this.checkBoxHealthyOption.TabIndex = 0;
            this.checkBoxHealthyOption.Text = "Opción saludable";
            this.checkBoxHealthyOption.UseVisualStyleBackColor = true;
            // 
            // tabBirthday
            // 
            this.tabBirthday.Controls.Add(this.CakeTextBox);
            this.tabBirthday.Controls.Add(this.labelCakeText);
            this.tabBirthday.Location = new System.Drawing.Point(8, 46);
            this.tabBirthday.Name = "tabBirthday";
            this.tabBirthday.Padding = new System.Windows.Forms.Padding(3);
            this.tabBirthday.Size = new System.Drawing.Size(930, 347);
            this.tabBirthday.TabIndex = 1;
            this.tabBirthday.Text = "Cumpleaños";
            this.tabBirthday.UseVisualStyleBackColor = true;
            // 
            // CakeTextBox
            // 
            this.CakeTextBox.Location = new System.Drawing.Point(288, 57);
            this.CakeTextBox.MaxLength = 16;
            this.CakeTextBox.Name = "CakeTextBox";
            this.CakeTextBox.Size = new System.Drawing.Size(450, 39);
            this.CakeTextBox.TabIndex = 1;
            // 
            // labelCakeText
            // 
            this.labelCakeText.AutoSize = true;
            this.labelCakeText.Location = new System.Drawing.Point(73, 57);
            this.labelCakeText.Name = "labelCakeText";
            this.labelCakeText.Size = new System.Drawing.Size(190, 32);
            this.labelCakeText.TabIndex = 0;
            this.labelCakeText.Text = "Texto en la tarta:";
            // 
            // labelNumberOfPeople
            // 
            this.labelNumberOfPeople.AutoSize = true;
            this.labelNumberOfPeople.Location = new System.Drawing.Point(100, 45);
            this.labelNumberOfPeople.Name = "labelNumberOfPeople";
            this.labelNumberOfPeople.Size = new System.Drawing.Size(238, 32);
            this.labelNumberOfPeople.TabIndex = 0;
            this.labelNumberOfPeople.Text = "Número de personas";
            // 
            // numericUpDownPeople
            // 
            this.numericUpDownPeople.Location = new System.Drawing.Point(381, 38);
            this.numericUpDownPeople.Name = "numericUpDownPeople";
            this.numericUpDownPeople.Size = new System.Drawing.Size(240, 39);
            this.numericUpDownPeople.TabIndex = 1;
            this.numericUpDownPeople.ValueChanged += new System.EventHandler(this.numericUpDownPeople_ValueChanged);
            // 
            // checkBoxLuxuryDecoration
            // 
            this.checkBoxLuxuryDecoration.AutoSize = true;
            this.checkBoxLuxuryDecoration.Location = new System.Drawing.Point(115, 116);
            this.checkBoxLuxuryDecoration.Name = "checkBoxLuxuryDecoration";
            this.checkBoxLuxuryDecoration.Size = new System.Drawing.Size(252, 36);
            this.checkBoxLuxuryDecoration.TabIndex = 0;
            this.checkBoxLuxuryDecoration.Text = "Decoración de Lujo";
            this.checkBoxLuxuryDecoration.UseVisualStyleBackColor = true;
            // 
            // labelBudget
            // 
            this.labelBudget.AutoSize = true;
            this.labelBudget.Location = new System.Drawing.Point(100, 800);
            this.labelBudget.Name = "labelBudget";
            this.labelBudget.Size = new System.Drawing.Size(79, 32);
            this.labelBudget.TabIndex = 2;
            this.labelBudget.Text = "Coste:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(209, 793);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 39);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 984);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelBudget);
            this.Controls.Add(this.checkBoxLuxuryDecoration);
            this.Controls.Add(this.labelNumberOfPeople);
            this.Controls.Add(this.numericUpDownPeople);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabDinner.ResumeLayout(false);
            this.tabDinner.PerformLayout();
            this.tabBirthday.ResumeLayout(false);
            this.tabBirthday.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabDinner;
        private TabPage tabBirthday;
        private NumericUpDown numericUpDownPeople;
        private Label labelNumberOfPeople;
        private CheckBox checkBoxLuxuryDecoration;
        private CheckBox checkBoxHealthyOption;
        private Label labelCakeText;
        private Label labelBudget;
        private TextBox textBox1;
        private TextBox CakeTextBox;
    }
}