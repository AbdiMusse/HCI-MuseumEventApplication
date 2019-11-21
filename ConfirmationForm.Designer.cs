namespace FinalVersionOfProject
{
    partial class ConfirmationForm
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
            this.confirmButton = new System.Windows.Forms.Button();
            this.confirmationTextBox = new System.Windows.Forms.RichTextBox();
            this.confirmationTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(440, 123);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(139, 48);
            this.confirmButton.TabIndex = 1;
            this.confirmButton.Text = "OK";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // confirmationTextBox
            // 
            this.confirmationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmationTextBox.Location = new System.Drawing.Point(0, 0);
            this.confirmationTextBox.Name = "confirmationTextBox";
            this.confirmationTextBox.Size = new System.Drawing.Size(591, 183);
            this.confirmationTextBox.TabIndex = 2;
            this.confirmationTextBox.Text = "Thank you for registering to a workshop.\nA text message has been sent to you with" +
    " the details of the workshop and a ticket.";
            // 
            // confirmationTimer
            // 
            this.confirmationTimer.Interval = 300000;
            this.confirmationTimer.Tick += new System.EventHandler(this.confirmationTimer_Tick);
            // 
            // ConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 183);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.confirmationTextBox);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfirmationForm";
            this.Text = "ConfirmationForm";
            this.Load += new System.EventHandler(this.ConfirmationForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.RichTextBox confirmationTextBox;
        private System.Windows.Forms.Timer confirmationTimer;
    }
}