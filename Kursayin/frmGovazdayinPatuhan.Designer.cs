namespace Kursayin
{
    partial class frmGovazd
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblTema = new System.Windows.Forms.Label();
            this.lblAmsativ = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblKursayin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.Color.Maroon;
            this.lblName.Location = new System.Drawing.Point(164, 28);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 22);
            this.lblName.TabIndex = 0;
            // 
            // lblTema
            // 
            this.lblTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTema.Location = new System.Drawing.Point(76, 73);
            this.lblTema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(455, 54);
            this.lblTema.TabIndex = 1;
            this.lblTema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAmsativ
            // 
            this.lblAmsativ.AutoSize = true;
            this.lblAmsativ.Location = new System.Drawing.Point(434, 166);
            this.lblAmsativ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmsativ.Name = "lblAmsativ";
            this.lblAmsativ.Size = new System.Drawing.Size(0, 13);
            this.lblAmsativ.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblKursayin
            // 
            this.lblKursayin.AutoSize = true;
            this.lblKursayin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKursayin.Location = new System.Drawing.Point(163, 188);
            this.lblKursayin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKursayin.Name = "lblKursayin";
            this.lblKursayin.Size = new System.Drawing.Size(243, 29);
            this.lblKursayin.TabIndex = 4;
            this.lblKursayin.Text = "Կուրսային Աշխատանք";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kursayin.Properties.Resources.icons8_cloud_waiting_48;
            this.pictureBox1.Location = new System.Drawing.Point(108, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 48);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmGovazd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(602, 372);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAmsativ);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblKursayin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(618, 411);
            this.MinimumSize = new System.Drawing.Size(618, 411);
            this.Name = "frmGovazd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Գովազդ";
            this.Load += new System.EventHandler(this.frmGovazd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Label lblAmsativ;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblKursayin;
    }
}