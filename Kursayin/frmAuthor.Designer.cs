namespace Kursayin
{
    partial class frmAuthor
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
            this.lblQolej = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblKurs = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTema = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblQolej
            // 
            this.lblQolej.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQolej.Location = new System.Drawing.Point(161, 101);
            this.lblQolej.Name = "lblQolej";
            this.lblQolej.Size = new System.Drawing.Size(430, 61);
            this.lblQolej.TabIndex = 0;
            this.lblQolej.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOK.Location = new System.Drawing.Point(324, 278);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(133, 43);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblKurs
            // 
            this.lblKurs.AutoSize = true;
            this.lblKurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKurs.Location = new System.Drawing.Point(221, 10);
            this.lblKurs.Name = "lblKurs";
            this.lblKurs.Size = new System.Drawing.Size(0, 29);
            this.lblKurs.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(224, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 22);
            this.lblName.TabIndex = 3;
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTema.Location = new System.Drawing.Point(152, 179);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(0, 17);
            this.lblTema.TabIndex = 0;
            this.lblTema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 333);
            this.ControlBox = false;
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblKurs);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.lblQolej);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "frmAuthor";
            this.Text = "Հեղինակ";
            this.Load += new System.EventHandler(this.frmAuthor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblQolej;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblKurs;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Timer timer2;
    }
}