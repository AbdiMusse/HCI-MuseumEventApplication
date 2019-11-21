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
    public partial class StationBuildingForm : Form
    {
        SearchForm searchForm;
        public StationBuildingForm()
        {
            InitializeComponent();
        }

        private void gWWBackButton_Click(object sender, EventArgs e)
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

        private void StationBuildingForm_Load(object sender, EventArgs e)
        {
            confirmationTimer.Enabled = true;
        }
    }
}
