namespace övning_8._1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxspeldata = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxstörstatalet = new System.Windows.Forms.ListBox();
            this.gbxspelet = new System.Windows.Forms.GroupBox();
            this.btngissa = new System.Windows.Forms.Button();
            this.lblresultat = new System.Windows.Forms.Label();
            this.tbxgissa = new System.Windows.Forms.TextBox();
            this.lblgissa = new System.Windows.Forms.Label();
            this.lbldatornstal = new System.Windows.Forms.Label();
            this.lbldator = new System.Windows.Forms.Label();
            this.lblminaresultat = new System.Windows.Forms.Label();
            this.tbxminaresultat = new System.Windows.Forms.TextBox();
            this.btnstartaspelet = new System.Windows.Forms.Button();
            this.btnspelaigen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxspeldata.SuspendLayout();
            this.gbxspelet.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(456, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gbxspeldata
            // 
            this.gbxspeldata.Controls.Add(this.label1);
            this.gbxspeldata.Controls.Add(this.lbxstörstatalet);
            this.gbxspeldata.Location = new System.Drawing.Point(15, 87);
            this.gbxspeldata.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxspeldata.Name = "gbxspeldata";
            this.gbxspeldata.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxspeldata.Size = new System.Drawing.Size(317, 70);
            this.gbxspeldata.TabIndex = 1;
            this.gbxspeldata.TabStop = false;
            this.gbxspeldata.Text = "speldata";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "största talet:";
            // 
            // lbxstörstatalet
            // 
            this.lbxstörstatalet.AllowDrop = true;
            this.lbxstörstatalet.FormattingEnabled = true;
            this.lbxstörstatalet.ItemHeight = 16;
            this.lbxstörstatalet.Location = new System.Drawing.Point(96, 25);
            this.lbxstörstatalet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxstörstatalet.Name = "lbxstörstatalet";
            this.lbxstörstatalet.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxstörstatalet.Size = new System.Drawing.Size(108, 20);
            this.lbxstörstatalet.TabIndex = 3;
            // 
            // gbxspelet
            // 
            this.gbxspelet.Controls.Add(this.btngissa);
            this.gbxspelet.Controls.Add(this.lblresultat);
            this.gbxspelet.Controls.Add(this.tbxgissa);
            this.gbxspelet.Controls.Add(this.lblgissa);
            this.gbxspelet.Controls.Add(this.lbldatornstal);
            this.gbxspelet.Controls.Add(this.lbldator);
            this.gbxspelet.Controls.Add(this.lblminaresultat);
            this.gbxspelet.Controls.Add(this.tbxminaresultat);
            this.gbxspelet.Enabled = false;
            this.gbxspelet.Location = new System.Drawing.Point(12, 185);
            this.gbxspelet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxspelet.Name = "gbxspelet";
            this.gbxspelet.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxspelet.Size = new System.Drawing.Size(459, 123);
            this.gbxspelet.TabIndex = 2;
            this.gbxspelet.TabStop = false;
            this.gbxspelet.Text = "spelet";
            // 
            // btngissa
            // 
            this.btngissa.Location = new System.Drawing.Point(216, 44);
            this.btngissa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btngissa.Name = "btngissa";
            this.btngissa.Size = new System.Drawing.Size(104, 42);
            this.btngissa.TabIndex = 7;
            this.btngissa.Text = "gissa";
            this.btngissa.UseVisualStyleBackColor = true;
            this.btngissa.Click += new System.EventHandler(this.btngissa_Click);
            // 
            // lblresultat
            // 
            this.lblresultat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblresultat.Location = new System.Drawing.Point(5, 92);
            this.lblresultat.Name = "lblresultat";
            this.lblresultat.Size = new System.Drawing.Size(200, 23);
            this.lblresultat.TabIndex = 6;
            this.lblresultat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxgissa
            // 
            this.tbxgissa.Location = new System.Drawing.Point(99, 54);
            this.tbxgissa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxgissa.Name = "tbxgissa";
            this.tbxgissa.Size = new System.Drawing.Size(52, 22);
            this.tbxgissa.TabIndex = 5;
            // 
            // lblgissa
            // 
            this.lblgissa.AutoSize = true;
            this.lblgissa.Location = new System.Drawing.Point(7, 58);
            this.lblgissa.Name = "lblgissa";
            this.lblgissa.Size = new System.Drawing.Size(77, 16);
            this.lblgissa.TabIndex = 4;
            this.lblgissa.Text = "gissa ett tal:";
            // 
            // lbldatornstal
            // 
            this.lbldatornstal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbldatornstal.Location = new System.Drawing.Point(99, 17);
            this.lbldatornstal.Name = "lbldatornstal";
            this.lbldatornstal.Size = new System.Drawing.Size(52, 23);
            this.lbldatornstal.TabIndex = 3;
            this.lbldatornstal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbldator
            // 
            this.lbldator.AutoSize = true;
            this.lbldator.Location = new System.Drawing.Point(9, 21);
            this.lbldator.Name = "lbldator";
            this.lbldator.Size = new System.Drawing.Size(72, 16);
            this.lbldator.TabIndex = 2;
            this.lbldator.Text = "datorns tal:";
            // 
            // lblminaresultat
            // 
            this.lblminaresultat.AutoSize = true;
            this.lblminaresultat.Location = new System.Drawing.Point(345, 23);
            this.lblminaresultat.Name = "lblminaresultat";
            this.lblminaresultat.Size = new System.Drawing.Size(85, 16);
            this.lblminaresultat.TabIndex = 1;
            this.lblminaresultat.Text = "mina resultat:";
            // 
            // tbxminaresultat
            // 
            this.tbxminaresultat.Location = new System.Drawing.Point(333, 42);
            this.tbxminaresultat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxminaresultat.Multiline = true;
            this.tbxminaresultat.Name = "tbxminaresultat";
            this.tbxminaresultat.ReadOnly = true;
            this.tbxminaresultat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxminaresultat.Size = new System.Drawing.Size(119, 73);
            this.tbxminaresultat.TabIndex = 0;
            // 
            // btnstartaspelet
            // 
            this.btnstartaspelet.Location = new System.Drawing.Point(345, 90);
            this.btnstartaspelet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnstartaspelet.Name = "btnstartaspelet";
            this.btnstartaspelet.Size = new System.Drawing.Size(104, 23);
            this.btnstartaspelet.TabIndex = 3;
            this.btnstartaspelet.Text = "starta spelet";
            this.btnstartaspelet.UseVisualStyleBackColor = true;
            this.btnstartaspelet.Click += new System.EventHandler(this.btnstartaspelet_Click);
            // 
            // btnspelaigen
            // 
            this.btnspelaigen.Location = new System.Drawing.Point(345, 134);
            this.btnspelaigen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnspelaigen.Name = "btnspelaigen";
            this.btnspelaigen.Size = new System.Drawing.Size(104, 23);
            this.btnspelaigen.TabIndex = 4;
            this.btnspelaigen.Text = "spela igen";
            this.btnspelaigen.UseVisualStyleBackColor = true;
            this.btnspelaigen.Click += new System.EventHandler(this.btnspelaigen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(483, 311);
            this.Controls.Add(this.btnspelaigen);
            this.Controls.Add(this.btnstartaspelet);
            this.Controls.Add(this.gbxspelet);
            this.Controls.Add(this.gbxspeldata);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(501, 358);
            this.Name = "Form1";
            this.Text = "+";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxspeldata.ResumeLayout(false);
            this.gbxspeldata.PerformLayout();
            this.gbxspelet.ResumeLayout(false);
            this.gbxspelet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbxspeldata;
        private System.Windows.Forms.GroupBox gbxspelet;
        private System.Windows.Forms.ListBox lbxstörstatalet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnstartaspelet;
        private System.Windows.Forms.Button btnspelaigen;
        private System.Windows.Forms.Label lblminaresultat;
        private System.Windows.Forms.TextBox tbxminaresultat;
        private System.Windows.Forms.Label lbldatornstal;
        private System.Windows.Forms.Label lbldator;
        private System.Windows.Forms.Label lblresultat;
        private System.Windows.Forms.TextBox tbxgissa;
        private System.Windows.Forms.Label lblgissa;
        private System.Windows.Forms.Button btngissa;
    }
}

