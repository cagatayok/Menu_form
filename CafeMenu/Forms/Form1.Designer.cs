namespace CafeMenu
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
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_1.Location = new System.Drawing.Point(62, 31);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(117, 115);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "MASA-1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.Coral;
            this.btn_2.Location = new System.Drawing.Point(260, 31);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(117, 115);
            this.btn_2.TabIndex = 0;
            this.btn_2.Text = "MASA-2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_3.Location = new System.Drawing.Point(475, 31);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(117, 115);
            this.btn_3.TabIndex = 0;
            this.btn_3.Text = "MASA-3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_4.Location = new System.Drawing.Point(62, 296);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(117, 115);
            this.btn_4.TabIndex = 0;
            this.btn_4.Text = "MASA-4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.Yellow;
            this.btn_6.Location = new System.Drawing.Point(475, 296);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(117, 115);
            this.btn_6.TabIndex = 0;
            this.btn_6.Text = "MASA-6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.Bisque;
            this.btn_5.Location = new System.Drawing.Point(264, 296);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(113, 115);
            this.btn_5.TabIndex = 1;
            this.btn_5.Text = "MASA-5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 470);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Masalar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
    }
}

