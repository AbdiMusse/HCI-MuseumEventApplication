using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalVersionOfProject
{
    public partial class NumberOfAtendeesForm : Form
    {
        FillingNumberForm fillingNumber;
        ConfirmationForm confirmation;
        StarterForm starterForm;
        int a = 10;
        int i = 0;
        public NumberOfAtendeesForm()
        {
            InitializeComponent();
        }

        private void attendeeBackButton_Click(object sender, EventArgs e)
        {
            fillingNumber = new FillingNumberForm();
            fillingNumber.Show();
            this.Hide();
            confirmationTimer.Stop();
        }

        private void increaseButton_Click(object sender, EventArgs e)
        {
            if (a > 0)
            {
                i += 1;
                numberBox.Text = i.ToString();
                a = a - 1;
                maxTextBox.Text = a.ToString();
            }
        }

        private void decreaseButton_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i -= 1;
                numberBox.Text = i.ToString();
                a = a + 1;
                maxTextBox.Text = a.ToString();
            }
        }

        private void NumberOfAtendeesForm_Load(object sender, EventArgs e)
        {
            numberBox.Text = i.ToString();
            timeTimer.Enabled = true;
            confirmationTimer.Enabled = true;
        }

        private void attendeeSignUpButton_Click(object sender, EventArgs e)
        {
            confirmationTimer.Stop();
            confirmation = new ConfirmationForm();
            confirmation.ShowDialog();
            this.Hide();
            
        }

        private void confirmationTimer_Tick(object sender, EventArgs e)
        {
                starterForm = new StarterForm();
                starterForm.Show();
                this.Hide();
                confirmationTimer.Stop();
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString();
        }
    }
}
