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
    public partial class PowerHallForm : Form
    {
        SearchForm searchForm;
        public PowerHallForm()
        {
            InitializeComponent();
        }

        private void powerHallBackButton_Click(object sender, EventArgs e)
        {
            searchForm = new SearchForm();
            searchForm.Show();
            this.Hide();
        }

        private void confirmationTimer_Tick(object sender, EventArgs e)
        {
            searchForm = new SearchForm();
            searchForm.Show();
            this.Hide();
            confirmationTimer.Stop();
        }

        private void PowerHallForm_Load(object sender, EventArgs e)
        {
            confirmationTimer.Enabled = true;
        }
    }
}
