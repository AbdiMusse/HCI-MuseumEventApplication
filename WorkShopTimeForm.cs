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
    public partial class WorkShopTimeForm : Form
    {
        WorkShopListForm workShopList;
        FillingNameForm fillingFirstName;
        StarterForm starterForm;
        public WorkShopTimeForm()
        {
            InitializeComponent();
        }
        private void workshopTimeButton_Click(object sender, EventArgs e)
        {
            workShopList = new WorkShopListForm();
            workShopList.Show();
            this.Close();
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            noChoiceLabel.Text = null;
            warningLabel.Text = "You have chosen to go the workshop on 09/11/2018 which starts at 10:00. Click Next to confirm.";
        }

        private void tenButton_Click(object sender, EventArgs e)
        {
            noChoiceLabel.Text = null;
            warningLabel.Text = "You have chosen to go the workshop on 09/11/2018 which starts at 14:00. Click Next to confirm.";
        }

        private void twelveButton_Click(object sender, EventArgs e)
        {
            noChoiceLabel.Text = null;
            warningLabel.Text = "You have chosen to go the workshop on 11/11/2018 which starts at 10:00. Click Next to confirm.";
        }

        private void fourteenButton_Click(object sender, EventArgs e)
        {
            noChoiceLabel.Text = null;
            warningLabel.Text = "You have chosen to go the workshop on 11/11/2018 which starts at 14:00. Click Next to confirm.";
        }

        private void sixteenButton_Click(object sender, EventArgs e)
        {
            noChoiceLabel.Text = null;
            warningLabel.Text = "You have chosen to go the workshop on 13/11/2018 which starts at 10:00. Click Next to confirm.";
        }

        private void workshopTimeNextButton_Click(object sender, EventArgs e)
        {
            if (warningLabel.Text == "")
            {
                noChoiceLabel.Text = "Please choose a date and time before pressing next.";
            }
            else
            {
                fillingFirstName = new FillingNameForm();
                fillingFirstName.Show();
                this.Close();
            }
        }

        private void WorkShopTimeForm_Load(object sender, EventArgs e)
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
