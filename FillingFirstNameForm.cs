using System;
using System;
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
    public partial class FillingNameForm : Form
    {
        WorkShopTimeForm workShopTime;
        FillingNumberForm fillingNumber;
        StarterForm starterForm;
        //TextBox textBox = null;
        public FillingNameForm()
        {
            InitializeComponent();
            //this.FRTB.GotFocus += new EventHandler(GetF);
            //this.SRTB.GotFocus += new EventHandler(GetF);
            //this.PNTB.GotFocus += new EventHandler(GetF);
        }

        private void GetF(object sender, EventArgs e)
        {
            //textBox = sender as TextBox;
        }
        private void fillingNameBackButton_Click(object sender, EventArgs e)
        {
            workShopTime = new WorkShopTimeForm();
            workShopTime.Show();
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text.Length > 0)
            { firstNameTextBox.Text = firstNameTextBox.Text.Substring(0, firstNameTextBox.Text.Length - 1); }
            //firstNameTextBox.Text = firstNameTextBox.Text.Remove(firstNameTextBox.Text.Length - 1, 1);
        }

        private void buttonSpace_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text += " ";
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            buttonA = (Button)sender;

            if (buttonCaps.BackColor == Color.CadetBlue)
            {
                firstNameTextBox.Text += buttonA.Text;
            }
            else
            {
                buttonA.Text = buttonA.Text.ToLower();
                firstNameTextBox.Text += buttonA.Text;
            }
            //Allows you to pick between caps at all time or only 1 letter:
            buttonCaps.BackColor = Color.LightGray;
            buttonA.Text = buttonA.Text.ToUpper();
        }

        private void buttonCaps_Click(object sender, EventArgs e)
        {
            if (buttonCaps.BackColor == Color.LightGray)
            {
                buttonCaps.BackColor = Color.CadetBlue;
            }
            else
            {
                buttonCaps.BackColor = Color.LightGray;
            }
            
        }

        private void nameNextButton_Click(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text == "")
            {
                labelFirstName.Text = "Please fill in your name before clicking next:";
            }
            else
            {
                fillingNumber = new FillingNumberForm();
                fillingNumber.Show();
                this.Close();
            }
        }

        private void FillingNameForm_Load(object sender, EventArgs e)
        {
            timeTimer.Enabled = true;
            confirmationTimer.Enabled = true;
            if (this == null)
            {
                confirmationTimer.Stop();
            }
            buttonCaps.BackColor = Color.LightGray;
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
