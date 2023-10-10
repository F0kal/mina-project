namespace övning_8._2
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
            this.btnRektangel = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRektangel
            // 
            this.btnRektangel.Location = new System.Drawing.Point(207, 104);
            this.btnRektangel.Name = "btnRektangel";
            this.btnRektangel.Size = new System.Drawing.Size(134, 33);
            this.btnRektangel.TabIndex = 0;
            this.btnRektangel.Text = "Rektangel";
            this.btnRektangel.UseVisualStyleBackColor = true;
            this.btnRektangel.Click += new System.EventHandler(this.btnRektangel_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.Location = new System.Drawing.Point(489, 104);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(134, 33);
            this.btnEllipse.TabIndex = 1;
            this.btnEllipse.Text = "Ellipse";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEllipse);
            this.Controls.Add(this.btnRektangel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRektangel;
        private System.Windows.Forms.Button btnEllipse;
    }
}

