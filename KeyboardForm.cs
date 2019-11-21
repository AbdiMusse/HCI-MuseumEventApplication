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
    public partial class KeyboardForm : Form
    {
        TextBox tt;
        public KeyboardForm()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            tt.Text += ((Button)sender).Text;
        }

        public void setTextBoxForOutput(TextBox t)
        {
            tt = t;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (tt.Text.Length > 0)
            { tt.Text = tt.Text.Substring(0, tt.Text.Length - 1); }
            //SurnameTextBox.Text = SurnameTextBox.Text.Remove(SurnameTextBox.Text.Length - 1, 1);
        }

        private void buttonSpace_Click(object sender, EventArgs e)
        {
            tt.Text += " ";
        }
    }
}
