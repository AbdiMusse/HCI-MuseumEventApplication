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
    public partial class ConfirmationForm : Form
    {
        StarterForm starterForm;
        public ConfirmationForm()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            starterForm = new StarterForm();
            starterForm.Show();
            this.Hide();
            confirmationTimer.Stop();
        }

        private void confirmationTimer_Tick(object sender, EventArgs e)
        {
            starterForm = new StarterForm();
            starterForm.Show();
            this.Hide();
            confirmationTimer.Stop();
        }

        private void ConfirmationForm_Load(object sender, EventArgs e)
        {
            confirmationTimer.Enabled = true;
        }
    }
}
