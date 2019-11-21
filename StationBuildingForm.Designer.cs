namespace FinalVersionOfProject
{
    partial class StationBuildingForm
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
            this.gWWLabel = new System.Windows.Forms.Label();
            this.meLocationLabel = new System.Windows.Forms.Label();
            this.powerHallLabel = new System.Windows.Forms.Label();
            this.gWWBackButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stationBuildingLabel = new System.Windows.Forms.Label();
            this.airSpaceLabel = new System.Windows.Forms.Label();
            this.confirmationTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gWWLabel
            // 
            this.gWWLabel.AutoSize = true;
            this.gWWLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gWWLabel.Location = new System.Drawing.Point(30, 472);
            this.gWWLabel.Name = "gWWLabel";
            this.gWWLabel.Size = new System.Drawing.Size(319, 29);
            this.gWWLabel.TabIndex = 38;
            this.gWWLabel.Text = "Great Western Warehouse";
            // 
            // meLocationLabel
            // 
            this.meLocationLabel.AutoSize = true;
            this.meLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meLocationLabel.Location = new System.Drawing.Point(888, 29);
            this.meLocationLabel.Name = "meLocationLabel";
            this.meLocationLabel.Size = new System.Drawing.Size(170, 29);
            this.meLocationLabel.TabIndex = 37;
            this.meLocationLabel.Text = "You Are Here";
            // 
            // powerHallLabel
            // 
            this.powerHallLabel.AutoSize = true;
            this.powerHallLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerHallLabel.Location = new System.Drawing.Point(917, 400);
            this.powerHallLabel.Name = "powerHallLabel";
            this.powerHallLabel.Size = new System.Drawing.Size(141, 29);
            this.powerHallLabel.TabIndex = 36;
            this.powerHallLabel.Text = "Power Hall";
            // 
            // gWWBackButton
            // 
            this.gWWBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gWWBackButton.Location = new System.Drawing.Point(35, 12);
            this.gWWBackButton.Name = "gWWBackButton";
            this.gWWBackButton.Size = new System.Drawing.Size(160, 87);
            this.gWWBackButton.TabIndex = 35;
            this.gWWBackButton.Text = "<= Go Back";
            this.gWWBackButton.UseVisualStyleBackColor = true;
            this.gWWBackButton.Click += new System.EventHandler(this.gWWBackButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::FinalVersionOfProject.Properties.Resources.Station_Building;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1370, 749);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // stationBuildingLabel
            // 
            this.stationBuildingLabel.AutoSize = true;
            this.stationBuildingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stationBuildingLabel.Location = new System.Drawing.Point(1138, 647);
            this.stationBuildingLabel.Name = "stationBuildingLabel";
            this.stationBuildingLabel.Size = new System.Drawing.Size(197, 29);
            this.stationBuildingLabel.TabIndex = 39;
            this.stationBuildingLabel.Text = "Station Building";
            // 
            // airSpaceLabel
            // 
            this.airSpaceLabel.AutoSize = true;
            this.airSpaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airSpaceLabel.Location = new System.Drawing.Point(677, 647);
            this.airSpaceLabel.Name = "airSpaceLabel";
            this.airSpaceLabel.Size = new System.Drawing.Size(229, 29);
            this.airSpaceLabel.TabIndex = 40;
            this.airSpaceLabel.Text = "Air and Space Hall";
            // 
            // confirmationTimer
            // 
            this.confirmationTimer.Interval = 300000;
            this.confirmationTimer.Tick += new System.EventHandler(this.confirmationTimer_Tick);
            // 
            // StationBuildingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.airSpaceLabel);
            this.Controls.Add(this.stationBuildingLabel);
            this.Controls.Add(this.gWWLabel);
            this.Controls.Add(this.meLocationLabel);
            this.Controls.Add(this.powerHallLabel);
            this.Controls.Add(this.gWWBackButton);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StationBuildingForm";
            this.Text = "StationBuildingForm";
            this.Load += new System.EventHandler(this.StationBuildingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gWWLabel;
        private System.Windows.Forms.Label meLocationLabel;
        private System.Windows.Forms.Label powerHallLabel;
        private System.Windows.Forms.Button gWWBackButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label stationBuildingLabel;
        private System.Windows.Forms.Label airSpaceLabel;
        private System.Windows.Forms.Timer confirmationTimer;
    }
}