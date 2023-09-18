namespace uppgift_2._2
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
            this.btnVänster = new System.Windows.Forms.Button();
            this.btnHöger = new System.Windows.Forms.Button();
            this.lblflytta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVänster
            // 
            this.btnVänster.Location = new System.Drawing.Point(88, 259);
            this.btnVänster.Name = "btnVänster";
            this.btnVänster.Size = new System.Drawing.Size(75, 23);
            this.btnVänster.TabIndex = 0;
            this.btnVänster.Text = "vänster";
            this.btnVänster.UseVisualStyleBackColor = true;
            this.btnVänster.Click += new System.EventHandler(this.btnVänster_Click);
            // 
            // btnHöger
            // 
            this.btnHöger.Location = new System.Drawing.Point(647, 258);
            this.btnHöger.Name = "btnHöger";
            this.btnHöger.Size = new System.Drawing.Size(75, 23);
            this.btnHöger.TabIndex = 1;
            this.btnHöger.Text = "höger";
            this.btnHöger.UseVisualStyleBackColor = true;
            this.btnHöger.Click += new System.EventHandler(this.btnHöger_Click);
            // 
            // lblflytta
            // 
            this.lblflytta.AutoSize = true;
            this.lblflytta.Location = new System.Drawing.Point(379, 121);
            this.lblflytta.Name = "lblflytta";
            this.lblflytta.Size = new System.Drawing.Size(118, 16);
            this.lblflytta.TabIndex = 2;
            this.lblflytta.Text = "vänster eller höger";
            this.lblflytta.Click += new System.EventHandler(this.lblflytta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblflytta);
            this.Controls.Add(this.btnHöger);
            this.Controls.Add(this.btnVänster);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVänster;
        private System.Windows.Forms.Button btnHöger;
        private System.Windows.Forms.Label lblflytta;
    }
}

