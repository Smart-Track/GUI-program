
namespace WindowsFormsApplication3
{
    partial class initialsWindow
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
            this.Initials = new System.Windows.Forms.Label();
            this.enteredInitials = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // Initials
            // 
            this.Initials.AutoSize = true;
            this.Initials.Font = new System.Drawing.Font("Gill Sans MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Initials.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(25)))));
            this.Initials.Location = new System.Drawing.Point(337, 129);
            this.Initials.Name = "Initials";
            this.Initials.Size = new System.Drawing.Size(138, 52);
            this.Initials.TabIndex = 0;
            this.Initials.Text = "Initials";
            // 
            // enteredInitials
            // 
            this.enteredInitials.Font = new System.Drawing.Font("Gill Sans MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enteredInitials.Location = new System.Drawing.Point(346, 184);
            this.enteredInitials.Name = "enteredInitials";
            this.enteredInitials.Size = new System.Drawing.Size(115, 50);
            this.enteredInitials.TabIndex = 1;
            this.enteredInitials.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // okButton
            // 
            this.okButton.Font = new System.Drawing.Font("Gill Sans MT", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(346, 271);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(115, 58);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // initialsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(34)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.enteredInitials);
            this.Controls.Add(this.Initials);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "initialsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Leaderboard Signup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Initials;
        private System.Windows.Forms.TextBox enteredInitials;
        private System.Windows.Forms.Button okButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}