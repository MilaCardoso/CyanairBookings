namespace Assignment
{
    partial class FrmAirports
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
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelAirportName = new System.Windows.Forms.Label();
            this.textBoxAirport_Name = new System.Windows.Forms.TextBox();
            this.buttonAddAirport = new System.Windows.Forms.Button();
            this.dataGridViewAirports = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAirports)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(110, 184);
            this.textBoxCountry.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(297, 38);
            this.textBoxCountry.TabIndex = 4;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelDate.Location = new System.Drawing.Point(100, 63);
            this.labelDate.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(193, 55);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "Country";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelCity.Location = new System.Drawing.Point(726, 63);
            this.labelCity.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(106, 55);
            this.labelCity.TabIndex = 7;
            this.labelCity.Text = "City";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(737, 184);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(297, 38);
            this.textBoxCity.TabIndex = 6;
            // 
            // labelAirportName
            // 
            this.labelAirportName.AutoSize = true;
            this.labelAirportName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAirportName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelAirportName.Location = new System.Drawing.Point(1340, 63);
            this.labelAirportName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelAirportName.Name = "labelAirportName";
            this.labelAirportName.Size = new System.Drawing.Size(307, 55);
            this.labelAirportName.TabIndex = 9;
            this.labelAirportName.Text = "Airport Name";
            // 
            // textBoxAirport_Name
            // 
            this.textBoxAirport_Name.Location = new System.Drawing.Point(1350, 184);
            this.textBoxAirport_Name.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxAirport_Name.Name = "textBoxAirport_Name";
            this.textBoxAirport_Name.Size = new System.Drawing.Size(297, 38);
            this.textBoxAirport_Name.TabIndex = 8;
            // 
            // buttonAddAirport
            // 
            this.buttonAddAirport.BackColor = System.Drawing.Color.Black;
            this.buttonAddAirport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAddAirport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonAddAirport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAddAirport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddAirport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddAirport.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAddAirport.Location = new System.Drawing.Point(1814, 112);
            this.buttonAddAirport.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonAddAirport.Name = "buttonAddAirport";
            this.buttonAddAirport.Size = new System.Drawing.Size(227, 110);
            this.buttonAddAirport.TabIndex = 12;
            this.buttonAddAirport.Text = "Add";
            this.buttonAddAirport.UseVisualStyleBackColor = false;
            this.buttonAddAirport.Click += new System.EventHandler(this.buttonAddAirport_Click);
            // 
            // dataGridViewAirports
            // 
            this.dataGridViewAirports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAirports.Location = new System.Drawing.Point(-22, 325);
            this.dataGridViewAirports.Name = "dataGridViewAirports";
            this.dataGridViewAirports.RowHeadersWidth = 102;
            this.dataGridViewAirports.RowTemplate.Height = 40;
            this.dataGridViewAirports.Size = new System.Drawing.Size(2156, 769);
            this.dataGridViewAirports.TabIndex = 13;
            // 
            // FrmAirports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(2133, 1073);
            this.Controls.Add(this.dataGridViewAirports);
            this.Controls.Add(this.buttonAddAirport);
            this.Controls.Add(this.labelAirportName);
            this.Controls.Add(this.textBoxAirport_Name);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textBoxCountry);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "FrmAirports";
            this.Text = "Cyanair - Airports";
            this.Load += new System.EventHandler(this.FrmAirports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAirports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelAirportName;
        private System.Windows.Forms.TextBox textBoxAirport_Name;
        private System.Windows.Forms.Button buttonAddAirport;
        private System.Windows.Forms.DataGridView dataGridViewAirports;
    }
}