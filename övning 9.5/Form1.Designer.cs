namespace övning_9._5
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
            this.tbxstart = new System.Windows.Forms.TextBox();
            this.tbxslut = new System.Windows.Forms.TextBox();
            this.tbxsteg = new System.Windows.Forms.TextBox();
            this.tbxvisa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxstart
            // 
            this.tbxstart.Location = new System.Drawing.Point(31, 101);
            this.tbxstart.Name = "tbxstart";
            this.tbxstart.Size = new System.Drawing.Size(100, 20);
            this.tbxstart.TabIndex = 0;
            // 
            // tbxslut
            // 
            this.tbxslut.Location = new System.Drawing.Point(179, 101);
            this.tbxslut.Name = "tbxslut";
            this.tbxslut.Size = new System.Drawing.Size(100, 20);
            this.tbxslut.TabIndex = 1;
            // 
            // tbxsteg
            // 
            this.tbxsteg.Location = new System.Drawing.Point(324, 101);
            this.tbxsteg.Name = "tbxsteg";
            this.tbxsteg.Size = new System.Drawing.Size(100, 20);
            this.tbxsteg.TabIndex = 2;
            // 
            // tbxvisa
            // 
            this.tbxvisa.Location = new System.Drawing.Point(31, 136);
            this.tbxvisa.Multiline = true;
            this.tbxvisa.Name = "tbxvisa";
            this.tbxvisa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxvisa.Size = new System.Drawing.Size(393, 88);
            this.tbxvisa.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "kör";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "slut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "steg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 287);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxvisa);
            this.Controls.Add(this.tbxsteg);
            this.Controls.Add(this.tbxslut);
            this.Controls.Add(this.tbxstart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxstart;
        private System.Windows.Forms.TextBox tbxslut;
        private System.Windows.Forms.TextBox tbxsteg;
        private System.Windows.Forms.TextBox tbxvisa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

