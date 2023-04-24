using Ejercicio25.model;

namespace Ejercicio25
{
    public partial class Form1 : Form
    {
        Party? party;

        public Form1()
        {
            InitializeComponent();
            CakeTextBox.MaxLength = Birthday.MAXIMUM_NUMBER_LETTERS_LITTLE;
        }

        private void numericUpDownPeople_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownPeople.Value > Birthday.WHEN_IS_BIGGER)
            {
                CakeTextBox.MaxLength = Birthday.MAXIMUM_NUMBER_LETTERS_BIG;
                return;
            }
            
            CakeTextBox.Text = CakeTextBox.Text.Substring(0, Birthday.MAXIMUM_NUMBER_LETTERS_LITTLE);
            CakeTextBox.MaxLength = Birthday.MAXIMUM_NUMBER_LETTERS_LITTLE;
        }
    }
}