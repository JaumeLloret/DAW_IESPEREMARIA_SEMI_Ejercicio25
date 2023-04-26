using Ejercicio25.model;
using System.ComponentModel;
using System.IO;

namespace Ejercicio25
{
    public partial class Form1 : Form
    {
        Party party;

        public Form1()
        {
            InitializeComponent();
            cakeTextBox.MaxLength = Birthday.MAXIMUM_NUMBER_LETTERS_LITTLE;
            party = new Dinner();
        }

        private void NumericUpDownPeople_ValueChanged(object sender, EventArgs e)
        {
            AddNumberOfPeople();

            if (IsDinnerSelected())
                return;

            if (numericUpDownPeople.Value > Birthday.WHEN_IS_BIGGER)
            {
                cakeTextBox.MaxLength = Birthday.MAXIMUM_NUMBER_LETTERS_BIG;
                return;
            }

            if (cakeTextBox.Text.Length > 16)
                cakeTextBox.Text = cakeTextBox.Text.Substring(0, Birthday.MAXIMUM_NUMBER_LETTERS_LITTLE);

            cakeTextBox.MaxLength = Birthday.MAXIMUM_NUMBER_LETTERS_LITTLE;
        }

        private void AddNumberOfPeople()
        {
            party.NumberOfPeople = (int)numericUpDownPeople.Value;
            Refresh();
        }

        private void TabControlTypeOfParty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsDinnerSelected())
            {
                party = new Dinner
                {
                    NumberOfPeople = party.NumberOfPeople,
                    StyleDecorationStdOrLuxe = party.StyleDecorationStdOrLuxe,
                    HealthyOption = checkBoxHealthyOption.Checked
                };
            }
            else
            {
                party = new Birthday
                {
                    NumberOfPeople = party.NumberOfPeople,
                    StyleDecorationStdOrLuxe = party.StyleDecorationStdOrLuxe,
                    CakeText = cakeTextBox.Text
                };
            }

            Refresh();
        }

        private bool IsDinnerSelected() => tabControlTypeOfParty.SelectedIndex == 0;

        private void CheckBoxLuxuryDecoration_CheckedChanged(object sender, EventArgs e)
        {
            party.StyleDecorationStdOrLuxe = checkBoxLuxuryDecoration.Checked;
            Refesh();
        }

        private void CheckBoxHealthyOption_CheckedChanged(object sender, EventArgs e)
        {
            ((Dinner)party).HealthyOption = checkBoxHealthyOption.Checked;
            Refresh();
        }

        private void CakeTextBox_TextChanged(object sender, EventArgs e)
        {
            ((Birthday)party).CakeText = cakeTextBox.Text;
            Refesh();
        }
        private void Refesh()
        {
            textBoxPrice.Text = party.CalculatePrice().ToString();
        }
    }
}