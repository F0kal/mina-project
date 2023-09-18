namespace övning3._5
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
            this.lblSvar = new System.Windows.Forms.Label();
            this.lblNamn = new System.Windows.Forms.Label();
            this.lblFödelse = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbxfödelse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(301, 345);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(183, 48);
            this.btnKör.TabIndex = 0;
            this.btnKör.Text = "Räkna";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // lblSvar
            // 
            this.lblSvar.AutoSize = true;
            this.lblSvar.Location = new System.Drawing.Point(390, 291);
            this.lblSvar.Name = "lblSvar";
            this.lblSvar.Size = new System.Drawing.Size(0, 16);
            this.lblSvar.TabIndex = 1;
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.Location = new System.Drawing.Point(393, 92);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(40, 16);
            this.lblNamn.TabIndex = 2;
            this.lblNamn.Text = "namn";
            // 
            // lblFödelse
            // 
            this.lblFödelse.AutoSize = true;
            this.lblFödelse.Location = new System.Drawing.Point(396, 138);
            this.lblFödelse.Name = "lblFödelse";
            this.lblFödelse.Size = new System.Drawing.Size(69, 16);
            this.lblFödelse.TabIndex = 3;
            this.lblFödelse.Text = "Födelseår";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(480, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // tbxfödelse
            // 
            this.tbxfödelse.Location = new System.Drawing.Point(480, 132);
            this.tbxfödelse.Name = "tbxfödelse";
            this.tbxfödelse.Size = new System.Drawing.Size(100, 22);
            this.tbxfödelse.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxfödelse);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblFödelse);
            this.Controls.Add(this.lblNamn);
            this.Controls.Add(this.lblSvar);
            this.Controls.Add(this.btnKör);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKör;
        private System.Windows.Forms.Label lblSvar;
        private System.Windows.Forms.Label lblNamn;
        private System.Windows.Forms.Label lblFödelse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbxfödelse;
    }
}

