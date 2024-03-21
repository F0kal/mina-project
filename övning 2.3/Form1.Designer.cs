namespace övning_2._3
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
            this.tbx_PersonNr = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_registrera = new System.Windows.Forms.Button();
            this.tbx_Kredit = new System.Windows.Forms.TextBox();
            this.tbx_Ränta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Uttag = new System.Windows.Forms.Button();
            this.btn_Insättning = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_belopp = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Uppdatera = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_PersonNr
            // 
            this.tbx_PersonNr.Location = new System.Drawing.Point(78, 27);
            this.tbx_PersonNr.Name = "tbx_PersonNr";
            this.tbx_PersonNr.Size = new System.Drawing.Size(100, 20);
            this.tbx_PersonNr.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_registrera);
            this.groupBox2.Controls.Add(this.tbx_Kredit);
            this.groupBox2.Controls.Add(this.tbx_Ränta);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbx_PersonNr);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 189);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öppna Konto";
            // 
            // btn_registrera
            // 
            this.btn_registrera.Location = new System.Drawing.Point(103, 152);
            this.btn_registrera.Name = "btn_registrera";
            this.btn_registrera.Size = new System.Drawing.Size(75, 23);
            this.btn_registrera.TabIndex = 4;
            this.btn_registrera.Text = "Registrera";
            this.btn_registrera.UseVisualStyleBackColor = true;
            this.btn_registrera.Click += new System.EventHandler(this.btn_registrera_Click);
            // 
            // tbx_Kredit
            // 
            this.tbx_Kredit.Location = new System.Drawing.Point(78, 77);
            this.tbx_Kredit.Name = "tbx_Kredit";
            this.tbx_Kredit.Size = new System.Drawing.Size(100, 20);
            this.tbx_Kredit.TabIndex = 6;
            // 
            // tbx_Ränta
            // 
            this.tbx_Ränta.Location = new System.Drawing.Point(78, 53);
            this.tbx_Ränta.Name = "tbx_Ränta";
            this.tbx_Ränta.Size = new System.Drawing.Size(100, 20);
            this.tbx_Ränta.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kredit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ränta %:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PersonNr:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Uttag);
            this.groupBox3.Controls.Add(this.btn_Insättning);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tbx_belopp);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 189);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Insättning/Uttag";
            // 
            // btn_Uttag
            // 
            this.btn_Uttag.Location = new System.Drawing.Point(104, 152);
            this.btn_Uttag.Name = "btn_Uttag";
            this.btn_Uttag.Size = new System.Drawing.Size(75, 23);
            this.btn_Uttag.TabIndex = 3;
            this.btn_Uttag.Text = "Uttag";
            this.btn_Uttag.UseVisualStyleBackColor = true;
            this.btn_Uttag.Click += new System.EventHandler(this.btn_Uttag_Click);
            // 
            // btn_Insättning
            // 
            this.btn_Insättning.Location = new System.Drawing.Point(104, 123);
            this.btn_Insättning.Name = "btn_Insättning";
            this.btn_Insättning.Size = new System.Drawing.Size(75, 23);
            this.btn_Insättning.TabIndex = 2;
            this.btn_Insättning.Text = "Insättning";
            this.btn_Insättning.UseVisualStyleBackColor = true;
            this.btn_Insättning.Click += new System.EventHandler(this.btn_Insättning_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Belopp:";
            // 
            // tbx_belopp
            // 
            this.tbx_belopp.Location = new System.Drawing.Point(79, 24);
            this.tbx_belopp.Name = "tbx_belopp";
            this.tbx_belopp.Size = new System.Drawing.Size(100, 20);
            this.tbx_belopp.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(424, 14);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(202, 134);
            this.listBox1.TabIndex = 0;
            // 
            // btn_Uppdatera
            // 
            this.btn_Uppdatera.Location = new System.Drawing.Point(424, 164);
            this.btn_Uppdatera.Name = "btn_Uppdatera";
            this.btn_Uppdatera.Size = new System.Drawing.Size(202, 23);
            this.btn_Uppdatera.TabIndex = 4;
            this.btn_Uppdatera.Text = "uppdatera med årsränta";
            this.btn_Uppdatera.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 204);
            this.Controls.Add(this.btn_Uppdatera);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_PersonNr;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_belopp;
        private System.Windows.Forms.Button btn_Uttag;
        private System.Windows.Forms.Button btn_Insättning;
        private System.Windows.Forms.TextBox tbx_Kredit;
        private System.Windows.Forms.TextBox tbx_Ränta;
        private System.Windows.Forms.Button btn_registrera;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Uppdatera;
    }
}

