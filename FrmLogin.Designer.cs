namespace Assignment
{
    partial class FrmLogin
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
            this.labelCyanairBookingSystem = new System.Windows.Forms.Label();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.colorDialogDelete = new System.Windows.Forms.ColorDialog();
            this.toolTipFrmCars = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelCyanairBookingSystem
            // 
            this.labelCyanairBookingSystem.AutoSize = true;
            this.labelCyanairBookingSystem.BackColor = System.Drawing.Color.Transparent;
            this.labelCyanairBookingSystem.Font = new System.Drawing.Font("Lucida Sans", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCyanairBookingSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelCyanairBookingSystem.Location = new System.Drawing.Point(213, 59);
            this.labelCyanairBookingSystem.Name = "labelCyanairBookingSystem";
            this.labelCyanairBookingSystem.Size = new System.Drawing.Size(378, 33);
            this.labelCyanairBookingSystem.TabIndex = 0;
            this.labelCyanairBookingSystem.Text = "Cyanair Booking System";
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.BackColor = System.Drawing.Color.Black;
            this.buttonLogIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLogIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonLogIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogIn.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLogIn.Location = new System.Drawing.Point(357, 314);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(85, 46);
            this.buttonLogIn.TabIndex = 3;
            this.buttonLogIn.Text = "LogIn";
            this.toolTipFrmCars.SetToolTip(this.buttonLogIn, "Do you want to Add a new record?");
            this.buttonLogIn.UseVisualStyleBackColor = false;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelUsername.Location = new System.Drawing.Point(354, 134);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(79, 16);
            this.labelUsername.TabIndex = 14;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelPassword.Location = new System.Drawing.Point(354, 207);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(76, 16);
            this.labelPassword.TabIndex = 15;
            this.labelPassword.Text = "Password";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(340, 163);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(114, 20);
            this.textBoxUsername.TabIndex = 1;
            this.toolTipFrmCars.SetToolTip(this.textBoxUsername, "Size of the Engine");
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(340, 239);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(114, 20);
            this.textBoxPassword.TabIndex = 2;
            this.toolTipFrmCars.SetToolTip(this.textBoxPassword, "Size of the Engine");
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.labelCyanairBookingSystem);
            this.Name = "FrmLogin";
            this.Text = "Cyanair - LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCyanairBookingSystem;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.ColorDialog colorDialogDelete;
        private System.Windows.Forms.ToolTip toolTipFrmCars;
        private System.Windows.Forms.TextBox textBoxPassword;
    }
}

