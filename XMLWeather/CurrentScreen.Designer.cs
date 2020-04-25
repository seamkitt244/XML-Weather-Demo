namespace XMLWeather
{
    partial class CurrentScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentScreen));
            this.cityOutput = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.todayLabel = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.conditionOutput = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.night = new System.Windows.Forms.PictureBox();
            this.eve = new System.Windows.Forms.PictureBox();
            this.day = new System.Windows.Forms.PictureBox();
            this.nightTemp = new System.Windows.Forms.Label();
            this.eveTemp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.night)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.day)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.AutoSize = true;
            this.cityOutput.BackColor = System.Drawing.Color.White;
            this.cityOutput.Font = new System.Drawing.Font("Yu Gothic UI", 14.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cityOutput.ForeColor = System.Drawing.Color.Maroon;
            this.cityOutput.Location = new System.Drawing.Point(40, 164);
            this.cityOutput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(89, 51);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.BackColor = System.Drawing.Color.White;
            this.minLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.minLabel.ForeColor = System.Drawing.Color.Maroon;
            this.minLabel.Location = new System.Drawing.Point(88, 313);
            this.minLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(170, 45);
            this.minLabel.TabIndex = 29;
            this.minLabel.Text = "Min Temp";
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.BackColor = System.Drawing.Color.White;
            this.tempLabel.Font = new System.Drawing.Font("Yu Gothic UI", 12.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tempLabel.ForeColor = System.Drawing.Color.Maroon;
            this.tempLabel.Location = new System.Drawing.Point(88, 240);
            this.tempLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(224, 45);
            this.tempLabel.TabIndex = 26;
            this.tempLabel.Text = "Current Temp";
            // 
            // todayLabel
            // 
            this.todayLabel.BackColor = System.Drawing.Color.White;
            this.todayLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.todayLabel.ForeColor = System.Drawing.Color.Maroon;
            this.todayLabel.Location = new System.Drawing.Point(29, 28);
            this.todayLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(174, 72);
            this.todayLabel.TabIndex = 40;
            this.todayLabel.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.White;
            this.forecastLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.forecastLabel.ForeColor = System.Drawing.Color.Maroon;
            this.forecastLabel.Location = new System.Drawing.Point(270, 28);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(165, 72);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(29, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 52);
            this.label5.TabIndex = 42;
            this.label5.Text = "_______________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // searchLabel
            // 
            this.searchLabel.BackColor = System.Drawing.Color.White;
            this.searchLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.searchLabel.ForeColor = System.Drawing.Color.Maroon;
            this.searchLabel.Location = new System.Drawing.Point(503, 28);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(190, 72);
            this.searchLabel.TabIndex = 43;
            this.searchLabel.Text = "Search";
            this.searchLabel.Click += new System.EventHandler(this.searchLabel_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.White;
            this.dateLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dateLabel.ForeColor = System.Drawing.Color.Maroon;
            this.dateLabel.Location = new System.Drawing.Point(232, 164);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(89, 51);
            this.dateLabel.TabIndex = 44;
            this.dateLabel.Text = "City";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.White;
            this.timeLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.timeLabel.ForeColor = System.Drawing.Color.Maroon;
            this.timeLabel.Location = new System.Drawing.Point(549, 164);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(108, 51);
            this.timeLabel.TabIndex = 45;
            this.timeLabel.Text = "TIme";
            // 
            // conditionOutput
            // 
            this.conditionOutput.AutoSize = true;
            this.conditionOutput.BackColor = System.Drawing.Color.White;
            this.conditionOutput.Font = new System.Drawing.Font("Yu Gothic UI", 12.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.conditionOutput.ForeColor = System.Drawing.Color.Maroon;
            this.conditionOutput.Location = new System.Drawing.Point(291, 455);
            this.conditionOutput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.conditionOutput.Name = "conditionOutput";
            this.conditionOutput.Size = new System.Drawing.Size(95, 45);
            this.conditionOutput.TabIndex = 46;
            this.conditionOutput.Text = "cond";
            // 
            // maxOutput
            // 
            this.maxOutput.AutoSize = true;
            this.maxOutput.BackColor = System.Drawing.Color.White;
            this.maxOutput.Font = new System.Drawing.Font("Yu Gothic UI", 12.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.maxOutput.ForeColor = System.Drawing.Color.Maroon;
            this.maxOutput.Location = new System.Drawing.Point(506, 383);
            this.maxOutput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(83, 45);
            this.maxOutput.TabIndex = 47;
            this.maxOutput.Text = "max";
            this.maxOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // minOutput
            // 
            this.minOutput.AutoSize = true;
            this.minOutput.BackColor = System.Drawing.Color.White;
            this.minOutput.Font = new System.Drawing.Font("Yu Gothic UI", 12.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.minOutput.ForeColor = System.Drawing.Color.Maroon;
            this.minOutput.Location = new System.Drawing.Point(506, 313);
            this.minOutput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(170, 45);
            this.minOutput.TabIndex = 48;
            this.minOutput.Text = "Min Temp";
            this.minOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(88, 455);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 45);
            this.label4.TabIndex = 49;
            this.label4.Text = "Condition";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 12.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(88, 383);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 45);
            this.label7.TabIndex = 51;
            this.label7.Text = "Max Temp";
            // 
            // currentOutput
            // 
            this.currentOutput.AutoSize = true;
            this.currentOutput.BackColor = System.Drawing.Color.White;
            this.currentOutput.Font = new System.Drawing.Font("Yu Gothic UI", 12.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.currentOutput.ForeColor = System.Drawing.Color.Maroon;
            this.currentOutput.Location = new System.Drawing.Point(506, 240);
            this.currentOutput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(67, 45);
            this.currentOutput.TabIndex = 52;
            this.currentOutput.Text = "cur";
            this.currentOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(750, 121);
            this.label1.TabIndex = 53;
            this.label1.Text = "label1";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(24, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 0);
            this.label6.TabIndex = 56;
            this.label6.Text = "label6";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(73, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(584, 55);
            this.label9.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(73, 448);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(584, 60);
            this.label10.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(73, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(584, 67);
            this.label2.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(73, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(584, 62);
            this.label8.TabIndex = 64;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(3, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(744, 60);
            this.label12.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 11.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(89, 543);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 41);
            this.label3.TabIndex = 66;
            this.label3.Text = "Eve Temperature";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI", 11.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(361, 543);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(277, 41);
            this.label11.TabIndex = 67;
            this.label11.Text = "Night Temperature";
            // 
            // night
            // 
            this.night.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("night.BackgroundImage")));
            this.night.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.night.Location = new System.Drawing.Point(96, 613);
            this.night.Name = "night";
            this.night.Size = new System.Drawing.Size(100, 100);
            this.night.TabIndex = 70;
            this.night.TabStop = false;
            // 
            // eve
            // 
            this.eve.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eve.BackgroundImage")));
            this.eve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eve.Location = new System.Drawing.Point(379, 613);
            this.eve.Name = "eve";
            this.eve.Size = new System.Drawing.Size(100, 100);
            this.eve.TabIndex = 69;
            this.eve.TabStop = false;
            // 
            // day
            // 
            this.day.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.day.Location = new System.Drawing.Point(597, 448);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(60, 60);
            this.day.TabIndex = 68;
            this.day.TabStop = false;
            // 
            // nightTemp
            // 
            this.nightTemp.AutoSize = true;
            this.nightTemp.BackColor = System.Drawing.Color.White;
            this.nightTemp.Font = new System.Drawing.Font("Yu Gothic UI", 11.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.nightTemp.ForeColor = System.Drawing.Color.Maroon;
            this.nightTemp.Location = new System.Drawing.Point(507, 613);
            this.nightTemp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.nightTemp.Name = "nightTemp";
            this.nightTemp.Size = new System.Drawing.Size(111, 41);
            this.nightTemp.TabIndex = 72;
            this.nightTemp.Text = "nittmp";
            // 
            // eveTemp
            // 
            this.eveTemp.AutoSize = true;
            this.eveTemp.BackColor = System.Drawing.Color.White;
            this.eveTemp.Font = new System.Drawing.Font("Yu Gothic UI", 11.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.eveTemp.ForeColor = System.Drawing.Color.Maroon;
            this.eveTemp.Location = new System.Drawing.Point(210, 613);
            this.eveTemp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.eveTemp.Name = "eveTemp";
            this.eveTemp.Size = new System.Drawing.Size(111, 41);
            this.eveTemp.TabIndex = 73;
            this.eveTemp.Text = "nittmp";
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.eveTemp);
            this.Controls.Add(this.nightTemp);
            this.Controls.Add(this.night);
            this.Controls.Add(this.eve);
            this.Controls.Add(this.day);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.conditionOutput);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(750, 810);
            ((System.ComponentModel.ISupportInitialize)(this.night)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.day)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label conditionOutput;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox day;
        private System.Windows.Forms.PictureBox eve;
        private System.Windows.Forms.PictureBox night;
        private System.Windows.Forms.Label nightTemp;
        private System.Windows.Forms.Label eveTemp;
    }
}
