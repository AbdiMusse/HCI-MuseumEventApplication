using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace FinalVersionOfProject
{
    public partial class SearchForm : Form
    {
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        ChooseOptionForm chooseOption;
        KeyboardForm keyBoardForm;
        GreatWesternWarehouseDirection great;
        PowerHallForm powerHall;
        AirAndSpaceHallForm airAndSpaceHall;
        StationBuildingForm stationBuilding;
        StarterForm starterForm;
        String greatWesternWarhouse, powerHallString, airSpace, station; 
        public SearchForm()
        {
            InitializeComponent();
        }

        private void searchBackButton_Click(object sender, EventArgs e)
        {
            chooseOption = new ChooseOptionForm();
            chooseOption.Show();
            this.Hide();
            confirmationTimer.Stop();
            if (keyBoardForm != null)
                keyBoardForm.Hide();
        }

        private void textBox_GotFocus(Object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (keyBoardForm == null)
            {
                keyBoardForm = new KeyboardForm();
                keyBoardForm.FormClosed += delegate
                {
                    keyBoardForm = null;
                    this.ActiveControl = informationTextBox;
                };
            }
            keyBoardForm.setTextBoxForOutput(tb);
            keyBoardForm.Show();
        }

        private void greatWWButton_Click(object sender, EventArgs e)
        {
            informationTextBox.Text = null;
            informationTextBox.Text = greatWesternWarhouse;
            if (keyBoardForm != null)
                keyBoardForm.Hide();
        }

        private void powerHallButton_Click(object sender, EventArgs e)
        {
            informationTextBox.Text = null;
            informationTextBox.Text = powerHallString;
            if (keyBoardForm != null)
                keyBoardForm.Hide();
        }

        private void airSpaceButton_Click(object sender, EventArgs e)
        {
            informationTextBox.Text = null;
            informationTextBox.Text = airSpace;
            if (keyBoardForm != null)
                keyBoardForm.Hide();
        }

        private void stationBuildingButton_Click(object sender, EventArgs e)
        {
            informationTextBox.Text = null;
            informationTextBox.Text = station;
            if (keyBoardForm != null)
                keyBoardForm.Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "GREAT WESTERN WAREHOUSE")
            {
                informationTextBox.Text = null;
                informationTextBox.Text = greatWesternWarhouse;
            }
            else if (searchTextBox.Text == "POWER HALL")
            {
                informationTextBox.Text = null;
                informationTextBox.Text = powerHallString;
            }
            else if (searchTextBox.Text == "AIR AND SPACE HALL")
            {
                informationTextBox.Text = null;
                informationTextBox.Text = airSpace;
            }
            else if (searchTextBox.Text == "STATION BUILDING")
            {
                informationTextBox.Text = null;
                informationTextBox.Text = station;
            }
            else if (informationTextBox.Text == "" || informationTextBox.Text == "Please click on the search bar and type in a location first." || informationTextBox.Text == "Please choose or search for a location first.")
            {
                informationTextBox.Text = "Please click on the search bar and type in a location first.";
            }
            else
            {
                informationTextBox.Text = null;
                informationTextBox.Text = "search not found.";
            }
            if (keyBoardForm != null)
                keyBoardForm.Hide();
        }

        private void showMapButton_Click(object sender, EventArgs e)
        {
            if (keyBoardForm != null)
                keyBoardForm.Hide();
            if (informationTextBox.Text == greatWesternWarhouse || searchTextBox.Text == "GREAT WESTERN WAREHOUSE")
            {
                great = new GreatWesternWarehouseDirection();
                great.Show();
                this.Close();
            }
            else if (informationTextBox.Text == powerHallString || searchTextBox.Text == "POWER HALL")
            {
                powerHall = new PowerHallForm();
                powerHall.Show();
                this.Close();
            }
            else if (informationTextBox.Text == airSpace || searchTextBox.Text == "AIR AND SPACE HALL")
            {
                airAndSpaceHall = new AirAndSpaceHallForm();
                airAndSpaceHall.Show();
                this.Close();
            }
            else if (informationTextBox.Text == station || searchTextBox.Text == "STATION BUILDING")
            {
                stationBuilding = new StationBuildingForm();
                stationBuilding.Show();
                this.Close();
            }
            else if (informationTextBox.Text == "" || informationTextBox.Text == "Please click on the search bar and type in a location first.")
            {
                informationTextBox.Text = "Please choose or search for a location first.";
            }
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString();
        }

        private void confirmationTimer_Tick(object sender, EventArgs e)
        {
            starterForm = new StarterForm();
            starterForm.Show();
            this.Hide();
            confirmationTimer.Stop();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            greatWesternWarhouse = "To get to Great Western Warehouse, you should walk straight for 5 meters then " +
                "turn right. Walk 5 meters then turn left. Walk 10 meters then turn right. " +
                "You will be at the entrance of the Great War Warehouse.";
            powerHallString = "To get to Power Hall, you should walk straight for 5 meters then " +
                "turn right. Walk 5 meters then turn left. Walk 10 meters then turn left. " +
                "Walk 5 meters then turn left. You will be at the entrance of Power Hall.";
            airSpace = "To get to Air and Space Hall, you should walk straight for 5 meters then " +
            "turn right. Walk 5 meters then turn left. Walk 20 meters and you will be at the entrance of Air and Space Hall.";
            station = "To get to Station Building, you should walk straight for 5 meters then " +
                "turn right. Walk 5 meters then turn left. Walk 10 meters then turn left. " +
                "Walk 8 meters then turn right. Walk 3 meters, and the entrance of Station Building will be to your left.";
            timeTimer.Enabled = true;
            confirmationTimer.Enabled = true;
            if (this == null)
            {
                confirmationTimer.Stop();
            }
        }

        private void speechButton_Click(object sender, EventArgs e)
        {
            if (keyBoardForm != null)
                keyBoardForm.Hide();
            if (informationTextBox.Text == "" || informationTextBox.Text == "Please click on the search bar and type in a location first.")
            {
                informationTextBox.Text = "Please choose or search for a location first.";
            }
            PromptBuilder builder = new PromptBuilder();
            builder.AppendText(informationTextBox.Text);
            synthesizer.Speak(builder);
        }
    }
}
