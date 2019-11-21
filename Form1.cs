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
    public partial class StarterForm : Form
    {
        ChooseOptionForm chooseOptionForm;
        public StarterForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            chooseOptionForm = new ChooseOptionForm();
            chooseOptionForm.Show();
            this.Hide();
            //Add a picture to this form later on!!

        }

    }
}
