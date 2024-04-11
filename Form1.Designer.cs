namespace WeatherApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.searchBtn = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.locationTextBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.siticoneAnimateWindow1 = new Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow(this.components);
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.localTimeLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.tempFeelsLikeLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.pressureLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.uvLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.humidityLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.windLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.tempLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.weatherLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.locationLabel = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.imageBox = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.siticonePanel1.SuspendLayout();
            this.siticonePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.Transparent;
            this.siticonePanel1.BorderRadius = 15;
            this.siticonePanel1.Controls.Add(this.searchBtn);
            this.siticonePanel1.Controls.Add(this.locationTextBox);
            this.siticonePanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.siticonePanel1.Location = new System.Drawing.Point(10, 10);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(1);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(678, 68);
            this.siticonePanel1.TabIndex = 0;
            // 
            // searchBtn
            // 
            this.searchBtn.Animated = true;
            this.searchBtn.AutoRoundedCorners = true;
            this.searchBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchBtn.BorderRadius = 19;
            this.searchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.searchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.searchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.searchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.searchBtn.Font = new System.Drawing.Font("Tw Cen MT", 13F, System.Drawing.FontStyle.Bold);
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(461, 14);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(213, 41);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // locationTextBox
            // 
            this.locationTextBox.AutoRoundedCorners = true;
            this.locationTextBox.BackColor = System.Drawing.Color.Transparent;
            this.locationTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.locationTextBox.BorderRadius = 19;
            this.locationTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.locationTextBox.DefaultText = "";
            this.locationTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.locationTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.locationTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.locationTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.locationTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.locationTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.locationTextBox.Font = new System.Drawing.Font("Tw Cen MT", 13F, System.Drawing.FontStyle.Bold);
            this.locationTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.locationTextBox.Location = new System.Drawing.Point(9, 14);
            this.locationTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.PasswordChar = '\0';
            this.locationTextBox.PlaceholderText = "Location";
            this.locationTextBox.SelectedText = "";
            this.locationTextBox.Size = new System.Drawing.Size(445, 41);
            this.locationTextBox.TabIndex = 1;
            this.locationTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.locationTextBox_KeyDown);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Black;
            this.imageList1.Images.SetKeyName(0, "cloudy.png");
            this.imageList1.Images.SetKeyName(1, "rainy.png");
            this.imageList1.Images.SetKeyName(2, "snowflake.png");
            this.imageList1.Images.SetKeyName(3, "sunny-day.png");
            this.imageList1.Images.SetKeyName(4, "wind.png");
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.BackColor = System.Drawing.Color.Transparent;
            this.siticonePanel2.BorderRadius = 15;
            this.siticonePanel2.Controls.Add(this.imageBox);
            this.siticonePanel2.Controls.Add(this.localTimeLabel);
            this.siticonePanel2.Controls.Add(this.tempFeelsLikeLabel);
            this.siticonePanel2.Controls.Add(this.pressureLabel);
            this.siticonePanel2.Controls.Add(this.uvLabel);
            this.siticonePanel2.Controls.Add(this.humidityLabel);
            this.siticonePanel2.Controls.Add(this.windLabel);
            this.siticonePanel2.Controls.Add(this.tempLabel);
            this.siticonePanel2.Controls.Add(this.weatherLabel);
            this.siticonePanel2.Controls.Add(this.locationLabel);
            this.siticonePanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.siticonePanel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.siticonePanel2.Location = new System.Drawing.Point(10, 89);
            this.siticonePanel2.Margin = new System.Windows.Forms.Padding(1);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(678, 382);
            this.siticonePanel2.TabIndex = 1;
            // 
            // localTimeLabel
            // 
            this.localTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.localTimeLabel.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.localTimeLabel.Location = new System.Drawing.Point(70, 275);
            this.localTimeLabel.Name = "localTimeLabel";
            this.localTimeLabel.Size = new System.Drawing.Size(137, 24);
            this.localTimeLabel.TabIndex = 8;
            this.localTimeLabel.Text = "Local Time Zone:";
            // 
            // tempFeelsLikeLabel
            // 
            this.tempFeelsLikeLabel.BackColor = System.Drawing.Color.Transparent;
            this.tempFeelsLikeLabel.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempFeelsLikeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tempFeelsLikeLabel.Location = new System.Drawing.Point(70, 245);
            this.tempFeelsLikeLabel.Name = "tempFeelsLikeLabel";
            this.tempFeelsLikeLabel.Size = new System.Drawing.Size(138, 24);
            this.tempFeelsLikeLabel.TabIndex = 7;
            this.tempFeelsLikeLabel.Text = "Temp (feels like):";
            // 
            // pressureLabel
            // 
            this.pressureLabel.BackColor = System.Drawing.Color.Transparent;
            this.pressureLabel.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressureLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.pressureLabel.Location = new System.Drawing.Point(70, 215);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.Size = new System.Drawing.Size(74, 24);
            this.pressureLabel.TabIndex = 6;
            this.pressureLabel.Text = "Pressure:";
            // 
            // uvLabel
            // 
            this.uvLabel.BackColor = System.Drawing.Color.Transparent;
            this.uvLabel.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uvLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.uvLabel.Location = new System.Drawing.Point(71, 185);
            this.uvLabel.Name = "uvLabel";
            this.uvLabel.Size = new System.Drawing.Size(81, 24);
            this.uvLabel.TabIndex = 5;
            this.uvLabel.Text = "UV Index:";
            // 
            // humidityLabel
            // 
            this.humidityLabel.BackColor = System.Drawing.Color.Transparent;
            this.humidityLabel.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.humidityLabel.Location = new System.Drawing.Point(71, 155);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(80, 24);
            this.humidityLabel.TabIndex = 4;
            this.humidityLabel.Text = "Humidity:";
            // 
            // windLabel
            // 
            this.windLabel.BackColor = System.Drawing.Color.Transparent;
            this.windLabel.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.windLabel.Location = new System.Drawing.Point(72, 125);
            this.windLabel.Name = "windLabel";
            this.windLabel.Size = new System.Drawing.Size(48, 24);
            this.windLabel.TabIndex = 3;
            this.windLabel.Text = "Wind:";
            // 
            // tempLabel
            // 
            this.tempLabel.BackColor = System.Drawing.Color.Transparent;
            this.tempLabel.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.tempLabel.Location = new System.Drawing.Point(72, 95);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(106, 24);
            this.tempLabel.TabIndex = 2;
            this.tempLabel.Text = "Temperature:";
            // 
            // weatherLabel
            // 
            this.weatherLabel.BackColor = System.Drawing.Color.Transparent;
            this.weatherLabel.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weatherLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.weatherLabel.Location = new System.Drawing.Point(72, 65);
            this.weatherLabel.Name = "weatherLabel";
            this.weatherLabel.Size = new System.Drawing.Size(72, 24);
            this.weatherLabel.TabIndex = 1;
            this.weatherLabel.Text = "Weather:";
            // 
            // locationLabel
            // 
            this.locationLabel.BackColor = System.Drawing.Color.Transparent;
            this.locationLabel.Font = new System.Drawing.Font("Tw Cen MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.locationLabel.Location = new System.Drawing.Point(236, 15);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(74, 24);
            this.locationLabel.TabIndex = 0;
            this.locationLabel.Text = "Location: ";
            // 
            // imageBox
            // 
            this.imageBox.FillColor = System.Drawing.Color.Transparent;
            this.imageBox.Image = global::WeatherApp.Properties.Resources.windG;
            this.imageBox.ImageRotate = 0F;
            this.imageBox.Location = new System.Drawing.Point(448, 94);
            this.imageBox.Margin = new System.Windows.Forms.Padding(1);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(175, 175);
            this.imageBox.TabIndex = 9;
            this.imageBox.TabStop = false;
            this.imageBox.UseTransparentBackground = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(698, 481);
            this.Controls.Add(this.siticonePanel2);
            this.Controls.Add(this.siticonePanel1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel2.ResumeLayout(false);
            this.siticonePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox locationTextBox;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton searchBtn;
        private System.Windows.Forms.ImageList imageList1;
        private Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow siticoneAnimateWindow1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel localTimeLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel tempFeelsLikeLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel pressureLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel uvLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel humidityLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel windLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel tempLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel weatherLabel;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel locationLabel;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox imageBox;
    }
}

