namespace lab3
{
    partial class FormTask5
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEPS = new System.Windows.Forms.Label();
            this.txtEps = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lstTerms = new System.Windows.Forms.ListBox();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::lab3.Properties.Resources.PicForLab3;
            this.pictureBox1.Location = new System.Drawing.Point(244, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblEPS
            // 
            this.lblEPS.AutoSize = true;
            this.lblEPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblEPS.Location = new System.Drawing.Point(12, 128);
            this.lblEPS.Name = "lblEPS";
            this.lblEPS.Size = new System.Drawing.Size(261, 24);
            this.lblEPS.TabIndex = 1;
            this.lblEPS.Text = "Введите точность (eps > 0):";
            // 
            // txtEps
            // 
            this.txtEps.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtEps.Location = new System.Drawing.Point(279, 125);
            this.txtEps.Name = "txtEps";
            this.txtEps.Size = new System.Drawing.Size(497, 29);
            this.txtEps.TabIndex = 2;
            // 
            // btnCalc
            // 
            this.btnCalc.AutoSize = true;
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnCalc.Location = new System.Drawing.Point(279, 172);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(289, 58);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Вычислить сумму ряда";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lstTerms
            // 
            this.lstTerms.Font = new System.Drawing.Font("Consolas", 11F);
            this.lstTerms.FormattingEnabled = true;
            this.lstTerms.ItemHeight = 18;
            this.lstTerms.Location = new System.Drawing.Point(16, 250);
            this.lstTerms.Name = "lstTerms";
            this.lstTerms.Size = new System.Drawing.Size(257, 166);
            this.lstTerms.TabIndex = 4;
            // 
            // lblListTitle
            // 
            this.lblListTitle.AutoSize = true;
            this.lblListTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblListTitle.Location = new System.Drawing.Point(12, 223);
            this.lblListTitle.Name = "lblListTitle";
            this.lblListTitle.Size = new System.Drawing.Size(207, 24);
            this.lblListTitle.TabIndex = 5;
            this.lblListTitle.Text = "Члены ряда по шагам:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(510, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Результат:";
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblResult.Location = new System.Drawing.Point(414, 274);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(295, 142);
            this.lblResult.TabIndex = 7;
            // 
            // FormTask5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblListTitle);
            this.Controls.Add(this.lstTerms);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtEps);
            this.Controls.Add(this.lblEPS);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormTask5";
            this.Text = "FormTask5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEPS;
        private System.Windows.Forms.TextBox txtEps;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.ListBox lstTerms;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
    }
}