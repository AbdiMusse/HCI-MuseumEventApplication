namespace FinalVersionOfProject
{
    partial class ChooseOptionForm
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
            this.chooseOptionBackButton = new System.Windows.Forms.Button();
            this.workshopButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.confirmationTimer = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // chooseOptionBackButton
            // 
            this.chooseOptionBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseOptionBackButton.Location = new System.Drawing.Point(12, 12);
            this.chooseOptionBackButton.Name = "chooseOptionBackButton";
            this.chooseOptionBackButton.Size = new System.Drawing.Size(160, 87);
            this.chooseOptionBackButton.TabIndex = 0;
            this.chooseOptionBackButton.Text = "<= Go Back";
            this.chooseOptionBackButton.UseVisualStyleBackColor = true;
            this.chooseOptionBackButton.Click += new System.EventHandler(this.chooseOptionBackButton_Click);
            // 
            // workshopButton
            // 
            this.workshopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workshopButton.Location = new System.Drawing.Point(158, 194);
            this.workshopButton.Name = "workshopButton";
            this.workshopButton.Size = new System.Drawing.Size(500, 300);
            this.workshopButton.TabIndex = 2;
            this.workshopButton.Text = "Sign Up To a Workshop";
            this.workshopButton.UseVisualStyleBackColor = true;
            this.workshopButton.Click += new System.EventHandler(this.workshopButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(759, 194);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(500, 300);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search For Location";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // confirmationTimer
            // 
            this.confirmationTimer.Interval = 300000;
            this.confirmationTimer.Tick += new System.EventHandler(this.confirmationTimer_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(573, 12);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 29);
            this.timeLabel.TabIndex = 3;
            // 
            // timeTimer
            // 
            this.timeTimer.Tick += new System.EventHandler(this.timeTimer_Tick);
            // 
            // ChooseOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.workshopButton);
            this.Controls.Add(this.chooseOptionBackButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseOptionForm";
            this.Text = "ChooseOptionForm";
            this.Load += new System.EventHandler(this.ChooseOptionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseOptionBackButton;
        private System.Windows.Forms.Button workshopButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Timer confirmationTimer;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timeTimer;
    }
}