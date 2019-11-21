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
    public partial class WorkShopListForm : Form
    {
        WorkShopTimeForm workShopTime;
        StarterForm starterForm;
        ChooseOptionForm chooseOption;
        public WorkShopListForm()
        {
            InitializeComponent();
        }

        private void museumButton_Click(object sender, EventArgs e)
        {
            noChoiceLabel.Text = null;
            warningLabel.Text = "You have clicked on: Museum Tour. Click Next to confirm.";
        }

        private void chemButton_Click(object sender, EventArgs e)
        {
            noChoiceLabel.Text = null;
            warningLabel.Text = "You have clicked on: Crazy Chemistry Techniques. Click Next to confirm.";
        }

        private void madeOfButton_Click(object sender, EventArgs e)
        {
            noChoiceLabel.Text = null;
            warningLabel.Text = "You have clicked on: What Are You Made Of? Click Next to confirm.";
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            noChoiceLabel.Text = null;
            warningLabel.Text = "You have clicked on: The Starts And Beyond. Click Next to confirm.";
        }

        private void DinosaursButton_Click(object sender, EventArgs e)
        {
            noChoiceLabel.Text = null;
            warningLabel.Text = "You have clicked on: The Truth Behind The Dinosaurs. Click Next to confirm.";
        }

        private void workshopListNextButton_Click(object sender, EventArgs e)
        {
            if (warningLabel.Text == "")
            {
                noChoiceLabel.Text = "Please choose a workshop before pressing next.";
            }
            else
            {
                workShopTime = new WorkShopTimeForm();
                workShopTime.Show();
                this.Close();
            }
        }

        private void WorkShopListForm_Load(object sender, EventArgs e)
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

        private void workshopListBackButton_Click(object sender, EventArgs e)
        {
            chooseOption = new ChooseOptionForm();
            chooseOption.Show();
            this.Close();
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString();
        }
    }
}
