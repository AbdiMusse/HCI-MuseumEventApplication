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
    public partial class GreatWesternWarehouseDirection : Form
    {
        SearchForm SearchForm;
        public GreatWesternWarehouseDirection()
        {
            InitializeComponent();
        }

        private void gWWBackButton_Click(object sender, EventArgs e)
        {
            SearchForm = new SearchForm();
            SearchForm.Show();
            this.Hide();
        }

        private void GreatWesternWarehouseDirection_Load(object sender, EventArgs e)
        {
            confirmationTimer.Enabled = true;
        }

        private void confirmationTimer_Tick(object sender, EventArgs e)
        {
            SearchForm = new SearchForm();
            SearchForm.Show();
            this.Hide();
            confirmationTimer.Stop();
        }
    }
}
