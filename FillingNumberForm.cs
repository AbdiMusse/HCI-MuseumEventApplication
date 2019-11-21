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
    public partial class FillingNumberForm : Form
    {
        FillingNameForm fillingName;
        NumberOfAtendeesForm numberOfAtendees;
        StarterForm starterForm;
        public FillingNumberForm()
        {
            InitializeComponent();
        }
        private void fillingNumberBackButton_Click(object sender, EventArgs e)
        {
            fillingName = new FillingNameForm();
            fillingName.Show();
            this.Hide();
            confirmationTimer.Stop();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1 = (Button)sender;
            numberTextBox.Text += button1.Text;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (numberTextBox.Text.Length > 0)
            { numberTextBox.Text = numberTextBox.Text.Substring(0, numberTextBox.Text.Length - 1); }
            // NumberTextBox.Text = NumberTextBox.Text.Remove(NumberTextBox.Text.Length - 1, 1);
        }

        private void numberNextButton_Click(object sender, EventArgs e)
        {
            if (numberTextBox.Text == "")
            {
                labelNumber.Text = "Please enter your number before clicking next:";
            }
            else
            {
                numberOfAtendees = new NumberOfAtendeesForm();
                numberOfAtendees.Show();
                this.Close();
            }
        }

        private void FillingNumberForm_Load(object sender, EventArgs e)
        {
            timeTimer.Enabled = true;
            confirmationTimer.Enabled = true;
            if (this == null)
            {
                confirmationTimer.Stop();
            }
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
