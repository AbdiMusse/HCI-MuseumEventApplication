namespace FinalVersionOfProject
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.searchBackButton = new System.Windows.Forms.Button();
            this.locationLabel = new System.Windows.Forms.Label();
            this.greatWWButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.showMapButton = new System.Windows.Forms.Button();
            this.powerHallButton = new System.Windows.Forms.Button();
            this.airSpaceButton = new System.Windows.Forms.Button();
            this.stationBuildingButton = new System.Windows.Forms.Button();
            this.informationTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmationTimer = new System.Windows.Forms.Timer(this.components);
            this.speechButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // searchBackButton
            // 
            this.searchBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBackButton.Location = new System.Drawing.Point(12, 12);
            this.searchBackButton.Name = "searchBackButton";
            this.searchBackButton.Size = new System.Drawing.Size(160, 87);
            this.searchBackButton.TabIndex = 1;
            this.searchBackButton.Text = "<= Go Back";
            this.searchBackButton.UseVisualStyleBackColor = true;
            this.searchBackButton.Click += new System.EventHandler(this.searchBackButton_Click);
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(54, 172);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(132, 29);
            this.locationLabel.TabIndex = 23;
            this.locationLabel.Text = "Locations:";
            // 
            // greatWWButton
            // 
            this.greatWWButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greatWWButton.Location = new System.Drawing.Point(59, 222);
            this.greatWWButton.Name = "greatWWButton";
            this.greatWWButton.Size = new System.Drawing.Size(600, 87);
            this.greatWWButton.TabIndex = 27;
            this.greatWWButton.Text = "Great Western Warehoue";
            this.greatWWButton.UseVisualStyleBackColor = true;
            this.greatWWButton.Click += new System.EventHandler(this.greatWWButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(307, 112);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(700, 35);
            this.searchTextBox.TabIndex = 28;
            this.searchTextBox.GotFocus += new System.EventHandler(this.textBox_GotFocus);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(1013, 112);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(160, 35);
            this.searchButton.TabIndex = 29;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // showMapButton
            // 
            this.showMapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showMapButton.Location = new System.Drawing.Point(1112, 626);
            this.showMapButton.Name = "showMapButton";
            this.showMapButton.Size = new System.Drawing.Size(200, 76);
            this.showMapButton.TabIndex = 30;
            this.showMapButton.Text = "Show On Map";
            this.showMapButton.UseVisualStyleBackColor = true;
            this.showMapButton.Click += new System.EventHandler(this.showMapButton_Click);
            // 
            // powerHallButton
            // 
            this.powerHallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerHallButton.Location = new System.Drawing.Point(59, 315);
            this.powerHallButton.Name = "powerHallButton";
            this.powerHallButton.Size = new System.Drawing.Size(600, 87);
            this.powerHallButton.TabIndex = 32;
            this.powerHallButton.Text = "Power Hall";
            this.powerHallButton.UseVisualStyleBackColor = true;
            this.powerHallButton.Click += new System.EventHandler(this.powerHallButton_Click);
            // 
            // airSpaceButton
            // 
            this.airSpaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airSpaceButton.Location = new System.Drawing.Point(59, 408);
            this.airSpaceButton.Name = "airSpaceButton";
            this.airSpaceButton.Size = new System.Drawing.Size(600, 87);
            this.airSpaceButton.TabIndex = 33;
            this.airSpaceButton.Text = "Air and Space Hall";
            this.airSpaceButton.UseVisualStyleBackColor = true;
            this.airSpaceButton.Click += new System.EventHandler(this.airSpaceButton_Click);
            // 
            // stationBuildingButton
            // 
            this.stationBuildingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stationBuildingButton.Location = new System.Drawing.Point(59, 501);
            this.stationBuildingButton.Name = "stationBuildingButton";
            this.stationBuildingButton.Size = new System.Drawing.Size(600, 87);
            this.stationBuildingButton.TabIndex = 34;
            this.stationBuildingButton.Text = "Station Building";
            this.stationBuildingButton.UseVisualStyleBackColor = true;
            this.stationBuildingButton.Click += new System.EventHandler(this.stationBuildingButton_Click);
            // 
            // informationTextBox
            // 
            this.informationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informationTextBox.Location = new System.Drawing.Point(680, 222);
            this.informationTextBox.Name = "informationTextBox";
            this.informationTextBox.Size = new System.Drawing.Size(650, 366);
            this.informationTextBox.TabIndex = 36;
            this.informationTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(635, 29);
            this.label1.TabIndex = 37;
            this.label1.Text = "Choose the location you want or search for a location:";
            // 
            // confirmationTimer
            // 
            this.confirmationTimer.Interval = 300000;
            this.confirmationTimer.Tick += new System.EventHandler(this.confirmationTimer_Tick);
            // 
            // speechButton
            // 
            this.speechButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speechButton.Location = new System.Drawing.Point(906, 626);
            this.speechButton.Name = "speechButton";
            this.speechButton.Size = new System.Drawing.Size(200, 76);
            this.speechButton.TabIndex = 38;
            this.speechButton.Text = "Speak direction";
            this.speechButton.UseVisualStyleBackColor = true;
            this.speechButton.Click += new System.EventHandler(this.speechButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(1044, 22);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 29);
            this.timeLabel.TabIndex = 39;
            // 
            // timeTimer
            // 
            this.timeTimer.Tick += new System.EventHandler(this.timeTimer_Tick);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.speechButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.informationTextBox);
            this.Controls.Add(this.stationBuildingButton);
            this.Controls.Add(this.airSpaceButton);
            this.Controls.Add(this.powerHallButton);
            this.Controls.Add(this.showMapButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.greatWWButton);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.searchBackButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchBackButton;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Button greatWWButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button showMapButton;
        private System.Windows.Forms.Button powerHallButton;
        private System.Windows.Forms.Button airSpaceButton;
        private System.Windows.Forms.Button stationBuildingButton;
        private System.Windows.Forms.RichTextBox informationTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer confirmationTimer;
        private System.Windows.Forms.Button speechButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timeTimer;
    }
}