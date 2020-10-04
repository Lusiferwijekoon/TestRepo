namespace ProjectPrivei2020
{
    partial class RestFloodEmergency
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
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(211, 87);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(289, 281);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "STOP!";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // RestFloodEmergency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 501);
            this.Controls.Add(this.btnStop);
            this.Name = "RestFloodEmergency";
            this.Text = "RestFloodEmergency";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStop;
    }
}