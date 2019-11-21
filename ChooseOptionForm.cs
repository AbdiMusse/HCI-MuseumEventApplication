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
    public partial class ChooseOptionForm : Form
    {
        StarterForm StarterForm;
        WorkShopListForm workShopList;
        SearchForm searchForm;
        public ChooseOptionForm()
        {
            InitializeComponent();
        }

        private void chooseOptionBackButton_Click(object sender, EventArgs e)
        {
            StarterForm = new StarterForm();
            StarterForm.Show();
            this.Close();
        }

        private void workshopButton_Click(object sender, EventArgs e)
        {
            workShopList = new WorkShopListForm();
            workShopList.Show();
            this.Close();
        }

        private void confirmationTimer_Tick(object sender, EventArgs e)
        {
            StarterForm = new StarterForm();
            StarterForm.Show();
            this.Hide();
            confirmationTimer.Stop();
        }

        private void ChooseOptionForm_Load(object sender, EventArgs e)
        {
            timeTimer.Enabled = true;
            confirmationTimer.Enabled = true;
            if (this == null)
            {
                confirmationTimer.Stop();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchForm = new SearchForm();
            searchForm.Show();
            this.Close();
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString();
        }
    }
}
