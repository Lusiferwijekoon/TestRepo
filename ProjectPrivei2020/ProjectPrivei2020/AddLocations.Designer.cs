namespace ProjectPrivei2020
{
    partial class AddLocations
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
            this.mMap = new GMap.NET.WindowsForms.GMapControl();
            this.radioSensor = new System.Windows.Forms.RadioButton();
            this.radioSafeLocations = new System.Windows.Forms.RadioButton();
            this.lbllatitude = new System.Windows.Forms.Label();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.lblLongitute = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClearMap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mMap
            // 
            this.mMap.Bearing = 0F;
            this.mMap.CanDragMap = true;
            this.mMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.mMap.GrayScaleMode = false;
            this.mMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.mMap.LevelsKeepInMemory = 5;
            this.mMap.Location = new System.Drawing.Point(12, 35);
            this.mMap.MarkersEnabled = true;
            this.mMap.MaxZoom = 2;
            this.mMap.MinZoom = 2;
            this.mMap.MouseWheelZoomEnabled = true;
            this.mMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.mMap.Name = "mMap";
            this.mMap.NegativeMode = false;
            this.mMap.PolygonsEnabled = true;
            this.mMap.RetryLoadTile = 0;
            this.mMap.RoutesEnabled = true;
            this.mMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.mMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.mMap.ShowTileGridLines = false;
            this.mMap.Size = new System.Drawing.Size(824, 547);
            this.mMap.TabIndex = 0;
            this.mMap.Zoom = 0D;
            this.mMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mMap_MouseClick);
            // 
            // radioSensor
            // 
            this.radioSensor.AutoSize = true;
            this.radioSensor.Location = new System.Drawing.Point(12, 12);
            this.radioSensor.Name = "radioSensor";
            this.radioSensor.Size = new System.Drawing.Size(102, 17);
            this.radioSensor.TabIndex = 1;
            this.radioSensor.TabStop = true;
            this.radioSensor.Text = "Sensor Location";
            this.radioSensor.UseVisualStyleBackColor = true;
            this.radioSensor.CheckedChanged += new System.EventHandler(this.radioSensor_CheckedChanged);
            // 
            // radioSafeLocations
            // 
            this.radioSafeLocations.AutoSize = true;
            this.radioSafeLocations.Location = new System.Drawing.Point(120, 12);
            this.radioSafeLocations.Name = "radioSafeLocations";
            this.radioSafeLocations.Size = new System.Drawing.Size(96, 17);
            this.radioSafeLocations.TabIndex = 2;
            this.radioSafeLocations.TabStop = true;
            this.radioSafeLocations.Text = "Safe Locations";
            this.radioSafeLocations.UseVisualStyleBackColor = true;
            // 
            // lbllatitude
            // 
            this.lbllatitude.AutoSize = true;
            this.lbllatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllatitude.Location = new System.Drawing.Point(12, 604);
            this.lbllatitude.Name = "lbllatitude";
            this.lbllatitude.Size = new System.Drawing.Size(75, 20);
            this.lbllatitude.TabIndex = 3;
            this.lbllatitude.Text = "Latitude";
            // 
            // txtLatitude
            // 
            this.txtLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLatitude.Location = new System.Drawing.Point(120, 601);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(123, 26);
            this.txtLatitude.TabIndex = 4;
            // 
            // txtLongitude
            // 
            this.txtLongitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLongitude.Location = new System.Drawing.Point(120, 644);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(123, 26);
            this.txtLongitude.TabIndex = 6;
            // 
            // lblLongitute
            // 
            this.lblLongitute.AutoSize = true;
            this.lblLongitute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongitute.Location = new System.Drawing.Point(12, 650);
            this.lblLongitute.Name = "lblLongitute";
            this.lblLongitute.Size = new System.Drawing.Size(89, 20);
            this.lblLongitute.TabIndex = 5;
            this.lblLongitute.Text = "Longitude";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(308, 601);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(412, 69);
            this.richTextBox2.TabIndex = 7;
            this.richTextBox2.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(745, 601);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClearMap
            // 
            this.btnClearMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearMap.Location = new System.Drawing.Point(745, 638);
            this.btnClearMap.Name = "btnClearMap";
            this.btnClearMap.Size = new System.Drawing.Size(91, 32);
            this.btnClearMap.TabIndex = 9;
            this.btnClearMap.Text = "CLEAR";
            this.btnClearMap.UseVisualStyleBackColor = true;
            this.btnClearMap.Click += new System.EventHandler(this.btnClearMap_Click);
            // 
            // AddLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 679);
            this.Controls.Add(this.btnClearMap);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.txtLongitude);
            this.Controls.Add(this.lblLongitute);
            this.Controls.Add(this.txtLatitude);
            this.Controls.Add(this.lbllatitude);
            this.Controls.Add(this.radioSafeLocations);
            this.Controls.Add(this.radioSensor);
            this.Controls.Add(this.mMap);
            this.Name = "AddLocations";
            this.Text = "AddLocations";
            this.Load += new System.EventHandler(this.AddLocations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl mMap;
        private System.Windows.Forms.RadioButton radioSensor;
        private System.Windows.Forms.RadioButton radioSafeLocations;
        private System.Windows.Forms.Label lbllatitude;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.Label lblLongitute;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClearMap;
    }
}