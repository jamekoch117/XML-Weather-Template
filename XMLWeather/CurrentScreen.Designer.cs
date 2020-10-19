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
            this.cityOutput = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.conditionOutput = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.humidityOutput = new System.Windows.Forms.Label();
            this.sunriseOutput = new System.Windows.Forms.Label();
            this.sun = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sunsetOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.Black;
            this.cityOutput.Location = new System.Drawing.Point(3, 286);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(172, 33);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            // 
            // tempLabel
            // 
            this.tempLabel.BackColor = System.Drawing.Color.Transparent;
            this.tempLabel.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.ForeColor = System.Drawing.Color.Black;
            this.tempLabel.Location = new System.Drawing.Point(159, 151);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(148, 54);
            this.tempLabel.TabIndex = 26;
            this.tempLabel.Text = "currentTemp";
            // 
            // dateLabel
            // 
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.Black;
            this.dateLabel.Location = new System.Drawing.Point(76, 5);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(213, 30);
            this.dateLabel.TabIndex = 40;
            this.dateLabel.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.Black;
            this.forecastLabel.Location = new System.Drawing.Point(294, 289);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(191, 30);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "7 day forecast";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.Black;
            this.timeLabel.Location = new System.Drawing.Point(285, 6);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(117, 22);
            this.timeLabel.TabIndex = 44;
            this.timeLabel.Text = "Time";
            this.timeLabel.Click += new System.EventHandler(this.timeLabel_Click);
            // 
            // minOutput
            // 
            this.minOutput.BackColor = System.Drawing.Color.Transparent;
            this.minOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOutput.ForeColor = System.Drawing.Color.DarkCyan;
            this.minOutput.Location = new System.Drawing.Point(165, 205);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(80, 37);
            this.minOutput.TabIndex = 48;
            this.minOutput.Text = "label3";
            this.minOutput.Click += new System.EventHandler(this.minOutput_Click);
            // 
            // maxOutput
            // 
            this.maxOutput.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput.ForeColor = System.Drawing.Color.Red;
            this.maxOutput.Location = new System.Drawing.Point(222, 205);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(103, 49);
            this.maxOutput.TabIndex = 50;
            this.maxOutput.Text = "label4";
            // 
            // conditionOutput
            // 
            this.conditionOutput.BackColor = System.Drawing.Color.Transparent;
            this.conditionOutput.ForeColor = System.Drawing.SystemColors.Control;
            this.conditionOutput.Location = new System.Drawing.Point(3, 378);
            this.conditionOutput.Name = "conditionOutput";
            this.conditionOutput.Size = new System.Drawing.Size(68, 17);
            this.conditionOutput.TabIndex = 46;
            this.conditionOutput.Text = "condition";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::XMLWeather.Properties.Resources.cloud;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 101);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // humidityOutput
            // 
            this.humidityOutput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityOutput.Location = new System.Drawing.Point(161, 131);
            this.humidityOutput.Name = "humidityOutput";
            this.humidityOutput.Size = new System.Drawing.Size(128, 20);
            this.humidityOutput.TabIndex = 52;
            this.humidityOutput.Text = "humidityOutput";
            // 
            // sunriseOutput
            // 
            this.sunriseOutput.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunriseOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sunriseOutput.Location = new System.Drawing.Point(6, 249);
            this.sunriseOutput.Name = "sunriseOutput";
            this.sunriseOutput.Size = new System.Drawing.Size(75, 19);
            this.sunriseOutput.TabIndex = 53;
            this.sunriseOutput.Text = "label1";
            this.sunriseOutput.Click += new System.EventHandler(this.sunriseOutput_Click);
            // 
            // sun
            // 
            this.sun.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sun.Location = new System.Drawing.Point(379, 215);
            this.sun.Name = "sun";
            this.sun.Size = new System.Drawing.Size(71, 29);
            this.sun.TabIndex = 54;
            this.sun.Text = "sunset";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(6, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 29);
            this.label2.TabIndex = 55;
            this.label2.Text = "sunrise";
            // 
            // sunsetOutput
            // 
            this.sunsetOutput.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunsetOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sunsetOutput.Location = new System.Drawing.Point(365, 249);
            this.sunsetOutput.Name = "sunsetOutput";
            this.sunsetOutput.Size = new System.Drawing.Size(110, 36);
            this.sunsetOutput.TabIndex = 56;
            this.sunsetOutput.Text = "label1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 24);
            this.label1.TabIndex = 57;
            this.label1.Text = "label1";
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.sunsetOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sun);
            this.Controls.Add(this.sunriseOutput);
            this.Controls.Add(this.humidityOutput);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.conditionOutput);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(450, 319);
            this.Load += new System.EventHandler(this.CurrentScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label conditionOutput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label humidityOutput;
        private System.Windows.Forms.Label sunriseOutput;
        private System.Windows.Forms.Label sun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sunsetOutput;
        private System.Windows.Forms.Label label1;
    }
}
