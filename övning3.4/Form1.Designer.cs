namespace övning3._4
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
            this.btnKör = new System.Windows.Forms.Button();
            this.tbxEngelska = new System.Windows.Forms.TextBox();
            this.tbxSvenska = new System.Windows.Forms.TextBox();
            this.lblEngelska = new System.Windows.Forms.Label();
            this.lblSvenska = new System.Windows.Forms.Label();
            this.lblSvar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(264, 352);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(237, 66);
            this.btnKör.TabIndex = 0;
            this.btnKör.Text = "kör";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // tbxEngelska
            // 
            this.tbxEngelska.Location = new System.Drawing.Point(548, 111);
            this.tbxEngelska.Name = "tbxEngelska";
            this.tbxEngelska.Size = new System.Drawing.Size(100, 22);
            this.tbxEngelska.TabIndex = 1;
            // 
            // tbxSvenska
            // 
            this.tbxSvenska.Location = new System.Drawing.Point(548, 172);
            this.tbxSvenska.Name = "tbxSvenska";
            this.tbxSvenska.Size = new System.Drawing.Size(100, 22);
            this.tbxSvenska.TabIndex = 2;
            // 
            // lblEngelska
            // 
            this.lblEngelska.AutoSize = true;
            this.lblEngelska.Location = new System.Drawing.Point(490, 116);
            this.lblEngelska.Name = "lblEngelska";
            this.lblEngelska.Size = new System.Drawing.Size(51, 16);
            this.lblEngelska.TabIndex = 3;
            this.lblEngelska.Text = "English";
            // 
            // lblSvenska
            // 
            this.lblSvenska.AutoSize = true;
            this.lblSvenska.Location = new System.Drawing.Point(483, 178);
            this.lblSvenska.Name = "lblSvenska";
            this.lblSvenska.Size = new System.Drawing.Size(58, 16);
            this.lblSvenska.TabIndex = 4;
            this.lblSvenska.Text = "svenska";
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Location = new System.Drawing.Point(376, 274);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(0, 16);
            this.lblSvar.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.lblSvenska);
            this.Controls.Add(this.lblEngelska);
            this.Controls.Add(this.tbxSvenska);
            this.Controls.Add(this.tbxEngelska);
            this.Controls.Add(this.btnKör);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKör;
        private System.Windows.Forms.TextBox tbxEngelska;
        private System.Windows.Forms.TextBox tbxSvenska;
        private System.Windows.Forms.Label lblEngelska;
        private System.Windows.Forms.Label lblSvenska;
        private System.Windows.Forms.Label lblSvar;
    }
}

