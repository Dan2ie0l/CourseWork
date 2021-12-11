namespace Kursayin
{
    partial class frmKursayinTema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKursayinTema));
            this.lbVektor1 = new System.Windows.Forms.ListBox();
            this.lbVektor2 = new System.Windows.Forms.ListBox();
            this.btnGtnel = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbVektor1
            // 
            this.lbVektor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbVektor1.FormattingEnabled = true;
            this.lbVektor1.ItemHeight = 20;
            this.lbVektor1.Location = new System.Drawing.Point(40, 111);
            this.lbVektor1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbVektor1.Name = "lbVektor1";
            this.lbVektor1.Size = new System.Drawing.Size(167, 244);
            this.lbVektor1.TabIndex = 0;
            // 
            // lbVektor2
            // 
            this.lbVektor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbVektor2.FormattingEnabled = true;
            this.lbVektor2.ItemHeight = 20;
            this.lbVektor2.Location = new System.Drawing.Point(278, 111);
            this.lbVektor2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbVektor2.Name = "lbVektor2";
            this.lbVektor2.Size = new System.Drawing.Size(167, 244);
            this.lbVektor2.TabIndex = 0;
            // 
            // btnGtnel
            // 
            this.btnGtnel.BackColor = System.Drawing.Color.Maroon;
            this.btnGtnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGtnel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGtnel.Location = new System.Drawing.Point(526, 194);
            this.btnGtnel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGtnel.Name = "btnGtnel";
            this.btnGtnel.Size = new System.Drawing.Size(86, 37);
            this.btnGtnel.TabIndex = 1;
            this.btnGtnel.Text = "Լուծել";
            this.btnGtnel.UseVisualStyleBackColor = false;
            this.btnGtnel.Click += new System.EventHandler(this.btnGtnel_Click);
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtN.Location = new System.Drawing.Point(92, 10);
            this.txtN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(55, 27);
            this.txtN.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(55, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "n =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(227, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(412, 60);
            this.label2.TabIndex = 4;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // frmKursayinTema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(716, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.btnGtnel);
            this.Controls.Add(this.lbVektor2);
            this.Controls.Add(this.lbVektor1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKursayinTema";
            this.Text = "Կուրսային Աշխատանք";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbVektor1;
        private System.Windows.Forms.ListBox lbVektor2;
        private System.Windows.Forms.Button btnGtnel;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}