namespace övning_2._4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_bredd = new System.Windows.Forms.TextBox();
            this.tbx_höjd = new System.Windows.Forms.TextBox();
            this.btn_Trangel = new System.Windows.Forms.Button();
            this.btn_Cirkel = new System.Windows.Forms.Button();
            this.btn_Linje = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbx_area = new System.Windows.Forms.TextBox();
            this.brn_area = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "bredd:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "höjd:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sammanlagd Area:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Linje);
            this.groupBox1.Controls.Add(this.btn_Cirkel);
            this.groupBox1.Controls.Add(this.btn_Trangel);
            this.groupBox1.Controls.Add(this.tbx_höjd);
            this.groupBox1.Controls.Add(this.tbx_bredd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 194);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skapa";
            // 
            // tbx_bredd
            // 
            this.tbx_bredd.Location = new System.Drawing.Point(60, 26);
            this.tbx_bredd.Name = "tbx_bredd";
            this.tbx_bredd.Size = new System.Drawing.Size(100, 20);
            this.tbx_bredd.TabIndex = 2;
            // 
            // tbx_höjd
            // 
            this.tbx_höjd.Location = new System.Drawing.Point(60, 63);
            this.tbx_höjd.Name = "tbx_höjd";
            this.tbx_höjd.Size = new System.Drawing.Size(100, 20);
            this.tbx_höjd.TabIndex = 3;
            // 
            // btn_Trangel
            // 
            this.btn_Trangel.Location = new System.Drawing.Point(60, 99);
            this.btn_Trangel.Name = "btn_Trangel";
            this.btn_Trangel.Size = new System.Drawing.Size(100, 23);
            this.btn_Trangel.TabIndex = 4;
            this.btn_Trangel.Text = "skapa triangel";
            this.btn_Trangel.UseVisualStyleBackColor = true;
            this.btn_Trangel.Click += new System.EventHandler(this.btn_Trangel_Click);
            // 
            // btn_Cirkel
            // 
            this.btn_Cirkel.Location = new System.Drawing.Point(60, 128);
            this.btn_Cirkel.Name = "btn_Cirkel";
            this.btn_Cirkel.Size = new System.Drawing.Size(100, 23);
            this.btn_Cirkel.TabIndex = 5;
            this.btn_Cirkel.Text = "skapa Cirkel";
            this.btn_Cirkel.UseVisualStyleBackColor = true;
            this.btn_Cirkel.Click += new System.EventHandler(this.btn_Cirkel_Click);
            // 
            // btn_Linje
            // 
            this.btn_Linje.Location = new System.Drawing.Point(60, 157);
            this.btn_Linje.Name = "btn_Linje";
            this.btn_Linje.Size = new System.Drawing.Size(100, 23);
            this.btn_Linje.TabIndex = 6;
            this.btn_Linje.Text = "skapa Linje";
            this.btn_Linje.UseVisualStyleBackColor = true;
            this.btn_Linje.Click += new System.EventHandler(this.btn_Linje_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 194);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Figurlista";
            // 
            // tbx_area
            // 
            this.tbx_area.Location = new System.Drawing.Point(110, 252);
            this.tbx_area.Name = "tbx_area";
            this.tbx_area.ReadOnly = true;
            this.tbx_area.Size = new System.Drawing.Size(197, 20);
            this.tbx_area.TabIndex = 5;
            // 
            // brn_area
            // 
            this.brn_area.Location = new System.Drawing.Point(110, 278);
            this.brn_area.Name = "brn_area";
            this.brn_area.Size = new System.Drawing.Size(197, 33);
            this.brn_area.TabIndex = 6;
            this.brn_area.Text = "Sammanlagd Area";
            this.brn_area.UseVisualStyleBackColor = true;
            this.brn_area.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(175, 160);
            this.listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 323);
            this.Controls.Add(this.brn_area);
            this.Controls.Add(this.tbx_area);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Linje;
        private System.Windows.Forms.Button btn_Cirkel;
        private System.Windows.Forms.Button btn_Trangel;
        private System.Windows.Forms.TextBox tbx_höjd;
        private System.Windows.Forms.TextBox tbx_bredd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tbx_area;
        private System.Windows.Forms.Button brn_area;
    }
}

