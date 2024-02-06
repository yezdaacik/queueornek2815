namespace queue_2_815
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSira1 = new System.Windows.Forms.Button();
            this.btnSira2 = new System.Windows.Forms.Button();
            this.btnSira3 = new System.Windows.Forms.Button();
            this.lblSira1 = new System.Windows.Forms.Label();
            this.lblSira2 = new System.Windows.Forms.Label();
            this.lblSira3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(68, 176);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(237, 40);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSira1
            // 
            this.btnSira1.Location = new System.Drawing.Point(68, 49);
            this.btnSira1.Name = "btnSira1";
            this.btnSira1.Size = new System.Drawing.Size(75, 41);
            this.btnSira1.TabIndex = 1;
            this.btnSira1.Text = "Gişe 1";
            this.btnSira1.UseVisualStyleBackColor = true;
            this.btnSira1.Click += new System.EventHandler(this.btnSira1_Click);
            // 
            // btnSira2
            // 
            this.btnSira2.Location = new System.Drawing.Point(149, 49);
            this.btnSira2.Name = "btnSira2";
            this.btnSira2.Size = new System.Drawing.Size(75, 41);
            this.btnSira2.TabIndex = 2;
            this.btnSira2.Text = "Gişe 2";
            this.btnSira2.UseVisualStyleBackColor = true;
            this.btnSira2.Click += new System.EventHandler(this.btnSira2_Click);
            // 
            // btnSira3
            // 
            this.btnSira3.Location = new System.Drawing.Point(230, 49);
            this.btnSira3.Name = "btnSira3";
            this.btnSira3.Size = new System.Drawing.Size(75, 41);
            this.btnSira3.TabIndex = 3;
            this.btnSira3.Text = "Gişe 3";
            this.btnSira3.UseVisualStyleBackColor = true;
            this.btnSira3.Click += new System.EventHandler(this.btnSira3_Click);
            // 
            // lblSira1
            // 
            this.lblSira1.AutoSize = true;
            this.lblSira1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSira1.Location = new System.Drawing.Point(65, 105);
            this.lblSira1.Name = "lblSira1";
            this.lblSira1.Size = new System.Drawing.Size(44, 16);
            this.lblSira1.TabIndex = 4;
            this.lblSira1.Text = "label1";
            // 
            // lblSira2
            // 
            this.lblSira2.AutoSize = true;
            this.lblSira2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSira2.Location = new System.Drawing.Point(146, 105);
            this.lblSira2.Name = "lblSira2";
            this.lblSira2.Size = new System.Drawing.Size(44, 16);
            this.lblSira2.TabIndex = 5;
            this.lblSira2.Text = "label2";
            // 
            // lblSira3
            // 
            this.lblSira3.AutoSize = true;
            this.lblSira3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSira3.Location = new System.Drawing.Point(227, 105);
            this.lblSira3.Name = "lblSira3";
            this.lblSira3.Size = new System.Drawing.Size(44, 16);
            this.lblSira3.TabIndex = 6;
            this.lblSira3.Text = "label3";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(68, 133);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(237, 20);
            this.txtAd.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 277);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblSira3);
            this.Controls.Add(this.lblSira2);
            this.Controls.Add(this.lblSira1);
            this.Controls.Add(this.btnSira3);
            this.Controls.Add(this.btnSira2);
            this.Controls.Add(this.btnSira1);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSira1;
        private System.Windows.Forms.Button btnSira2;
        private System.Windows.Forms.Button btnSira3;
        private System.Windows.Forms.Label lblSira1;
        private System.Windows.Forms.Label lblSira2;
        private System.Windows.Forms.Label lblSira3;
        private System.Windows.Forms.TextBox txtAd;
    }
}

