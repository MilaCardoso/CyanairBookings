namespace Assignment
{
    partial class FrmFinalMessage
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
            this.labelSuccessMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSuccessMessage
            // 
            this.labelSuccessMessage.AutoSize = true;
            this.labelSuccessMessage.BackColor = System.Drawing.Color.Transparent;
            this.labelSuccessMessage.Font = new System.Drawing.Font("Lucida Sans", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuccessMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelSuccessMessage.Location = new System.Drawing.Point(144, 162);
            this.labelSuccessMessage.Name = "labelSuccessMessage";
            this.labelSuccessMessage.Size = new System.Drawing.Size(487, 33);
            this.labelSuccessMessage.TabIndex = 1;
            this.labelSuccessMessage.Text = "Thank you! Successful Booking. ";
            // 
            // FrmFinalMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSuccessMessage);
            this.Name = "FrmFinalMessage";
            this.Text = "Cyanair - Thank you";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSuccessMessage;
    }
}