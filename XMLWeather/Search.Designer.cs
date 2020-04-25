namespace XMLWeather
{
    partial class Search
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.label1 = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.todayLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.toronto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.london = new System.Windows.Forms.Label();
            this.vancouver = new System.Windows.Forms.Label();
            this.kitchener = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 18.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(503, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 66);
            this.label1.TabIndex = 79;
            this.label1.Text = "Search";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.White;
            this.forecastLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.forecastLabel.ForeColor = System.Drawing.Color.Maroon;
            this.forecastLabel.Location = new System.Drawing.Point(270, 28);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(165, 76);
            this.forecastLabel.TabIndex = 77;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // todayLabel
            // 
            this.todayLabel.BackColor = System.Drawing.Color.White;
            this.todayLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.todayLabel.ForeColor = System.Drawing.Color.Maroon;
            this.todayLabel.Location = new System.Drawing.Point(29, 28);
            this.todayLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(165, 76);
            this.todayLabel.TabIndex = 76;
            this.todayLabel.Text = "Today";
            this.todayLabel.Click += new System.EventHandler(this.todayLabel_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(503, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 52);
            this.label5.TabIndex = 78;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.875F);
            this.searchTextBox.Location = new System.Drawing.Point(62, 154);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(512, 60);
            this.searchTextBox.TabIndex = 80;
            this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyDown);
            // 
            // toronto
            // 
            this.toronto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toronto.Font = new System.Drawing.Font("Yu Gothic UI", 14.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.toronto.ForeColor = System.Drawing.Color.Maroon;
            this.toronto.Location = new System.Drawing.Point(59, 262);
            this.toronto.Name = "toronto";
            this.toronto.Size = new System.Drawing.Size(202, 45);
            this.toronto.TabIndex = 85;
            this.toronto.Text = "Toronto";
            this.toronto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toronto.Click += new System.EventHandler(this.toronto_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(750, 121);
            this.label4.TabIndex = 86;
            // 
            // london
            // 
            this.london.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.london.Font = new System.Drawing.Font("Yu Gothic UI", 14.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.london.ForeColor = System.Drawing.Color.Maroon;
            this.london.Location = new System.Drawing.Point(59, 390);
            this.london.Name = "london";
            this.london.Size = new System.Drawing.Size(202, 45);
            this.london.TabIndex = 87;
            this.london.Text = "London ";
            this.london.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.london.Click += new System.EventHandler(this.london_Click);
            // 
            // vancouver
            // 
            this.vancouver.AutoSize = true;
            this.vancouver.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.vancouver.Font = new System.Drawing.Font("Yu Gothic UI", 14.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.vancouver.ForeColor = System.Drawing.Color.Maroon;
            this.vancouver.Location = new System.Drawing.Point(59, 519);
            this.vancouver.Name = "vancouver";
            this.vancouver.Size = new System.Drawing.Size(202, 51);
            this.vancouver.TabIndex = 88;
            this.vancouver.Text = "Vancouver";
            this.vancouver.Click += new System.EventHandler(this.vancouver_Click);
            // 
            // kitchener
            // 
            this.kitchener.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.kitchener.Font = new System.Drawing.Font("Yu Gothic UI", 14.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.kitchener.ForeColor = System.Drawing.Color.Maroon;
            this.kitchener.Location = new System.Drawing.Point(59, 325);
            this.kitchener.Name = "kitchener";
            this.kitchener.Size = new System.Drawing.Size(202, 45);
            this.kitchener.TabIndex = 89;
            this.kitchener.Text = "Kitchener ";
            this.kitchener.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.kitchener.Click += new System.EventHandler(this.kitchener_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 14.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(59, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 51);
            this.label2.TabIndex = 90;
            this.label2.Text = "Calgary";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(601, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 60);
            this.button1.TabIndex = 81;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 14.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(59, 591);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(621, 121);
            this.label3.TabIndex = 91;
            this.label3.Text = "click the above citys to see their weather, or search your own\r\n\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kitchener);
            this.Controls.Add(this.vancouver);
            this.Controls.Add(this.london);
            this.Controls.Add(this.toronto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "Search";
            this.Size = new System.Drawing.Size(750, 810);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label toronto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label london;
        private System.Windows.Forms.Label vancouver;
        private System.Windows.Forms.Label kitchener;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
