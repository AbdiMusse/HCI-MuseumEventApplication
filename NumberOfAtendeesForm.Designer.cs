namespace FinalVersionOfProject
{
    partial class NumberOfAtendeesForm
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
            this.attendeeSignUpButton = new System.Windows.Forms.Button();
            this.attendeeBackButton = new System.Windows.Forms.Button();
            this.increaseButton = new System.Windows.Forms.Button();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.numberOfAttendeeLabel = new System.Windows.Forms.Label();
            this.decreaseButton = new System.Windows.Forms.Button();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.AttendeeLabel = new System.Windows.Forms.Label();
            this.spaceLabel = new System.Windows.Forms.Label();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.confirmationTimer = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // attendeeSignUpButton
            // 
            this.attendeeSignUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendeeSignUpButton.Location = new System.Drawing.Point(1151, 612);
            this.attendeeSignUpButton.Name = "attendeeSignUpButton";
            this.attendeeSignUpButton.Size = new System.Drawing.Size(160, 87);
            this.attendeeSignUpButton.TabIndex = 94;
            this.attendeeSignUpButton.Text = "Sign Up";
            this.attendeeSignUpButton.UseVisualStyleBackColor = true;
            this.attendeeSignUpButton.Click += new System.EventHandler(this.attendeeSignUpButton_Click);
            // 
            // attendeeBackButton
            // 
            this.attendeeBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendeeBackButton.Location = new System.Drawing.Point(12, 12);
            this.attendeeBackButton.Name = "attendeeBackButton";
            this.attendeeBackButton.Size = new System.Drawing.Size(160, 87);
            this.attendeeBackButton.TabIndex = 95;
            this.attendeeBackButton.Text = "<= Go Back";
            this.attendeeBackButton.UseVisualStyleBackColor = true;
            this.attendeeBackButton.Click += new System.EventHandler(this.attendeeBackButton_Click);
            // 
            // increaseButton
            // 
            this.increaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.increaseButton.Location = new System.Drawing.Point(819, 331);
            this.increaseButton.Name = "increaseButton";
            this.increaseButton.Size = new System.Drawing.Size(147, 35);
            this.increaseButton.TabIndex = 98;
            this.increaseButton.Text = "+";
            this.increaseButton.UseVisualStyleBackColor = true;
            this.increaseButton.Click += new System.EventHandler(this.increaseButton_Click);
            // 
            // numberBox
            // 
            this.numberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBox.Location = new System.Drawing.Point(465, 331);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(348, 35);
            this.numberBox.TabIndex = 97;
            this.numberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numberOfAttendeeLabel
            // 
            this.numberOfAttendeeLabel.AutoSize = true;
            this.numberOfAttendeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfAttendeeLabel.Location = new System.Drawing.Point(418, 281);
            this.numberOfAttendeeLabel.Name = "numberOfAttendeeLabel";
            this.numberOfAttendeeLabel.Size = new System.Drawing.Size(453, 29);
            this.numberOfAttendeeLabel.TabIndex = 96;
            this.numberOfAttendeeLabel.Text = "How many people will be joining you?";
            // 
            // decreaseButton
            // 
            this.decreaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decreaseButton.Location = new System.Drawing.Point(312, 331);
            this.decreaseButton.Name = "decreaseButton";
            this.decreaseButton.Size = new System.Drawing.Size(147, 35);
            this.decreaseButton.TabIndex = 99;
            this.decreaseButton.Text = "-";
            this.decreaseButton.UseVisualStyleBackColor = true;
            this.decreaseButton.Click += new System.EventHandler(this.decreaseButton_Click);
            // 
            // totalTextBox
            // 
            this.totalTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.totalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTextBox.Location = new System.Drawing.Point(1238, 38);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(48, 35);
            this.totalTextBox.TabIndex = 103;
            this.totalTextBox.Text = "25";
            this.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AttendeeLabel
            // 
            this.AttendeeLabel.AutoSize = true;
            this.AttendeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendeeLabel.Location = new System.Drawing.Point(1028, 41);
            this.AttendeeLabel.Name = "AttendeeLabel";
            this.AttendeeLabel.Size = new System.Drawing.Size(204, 29);
            this.AttendeeLabel.TabIndex = 102;
            this.AttendeeLabel.Text = "Total Attendees:";
            // 
            // spaceLabel
            // 
            this.spaceLabel.AutoSize = true;
            this.spaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spaceLabel.Location = new System.Drawing.Point(1028, 79);
            this.spaceLabel.Name = "spaceLabel";
            this.spaceLabel.Size = new System.Drawing.Size(204, 29);
            this.spaceLabel.TabIndex = 101;
            this.spaceLabel.Text = "Available space:";
            // 
            // maxTextBox
            // 
            this.maxTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.maxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTextBox.Location = new System.Drawing.Point(1238, 79);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(48, 35);
            this.maxTextBox.TabIndex = 100;
            this.maxTextBox.Text = "10";
            this.maxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.timeLabel.TabIndex = 104;
            // 
            // timeTimer
            // 
            this.timeTimer.Tick += new System.EventHandler(this.timeTimer_Tick);
            // 
            // NumberOfAtendeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.AttendeeLabel);
            this.Controls.Add(this.spaceLabel);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.decreaseButton);
            this.Controls.Add(this.increaseButton);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.numberOfAttendeeLabel);
            this.Controls.Add(this.attendeeBackButton);
            this.Controls.Add(this.attendeeSignUpButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NumberOfAtendeesForm";
            this.Text = "NumberOfAtendeesForm";
            this.Load += new System.EventHandler(this.NumberOfAtendeesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button attendeeSignUpButton;
        private System.Windows.Forms.Button attendeeBackButton;
        private System.Windows.Forms.Button increaseButton;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.Label numberOfAttendeeLabel;
        private System.Windows.Forms.Button decreaseButton;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label AttendeeLabel;
        private System.Windows.Forms.Label spaceLabel;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.Timer confirmationTimer;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timeTimer;
    }
}