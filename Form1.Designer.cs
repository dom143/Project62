namespace Project
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
            System.Windows.Forms.Button button2;
            System.Windows.Forms.Button button3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Button button4;
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Transparent;
            button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button2.Cursor = System.Windows.Forms.Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Image = global::Project.Properties.Resources._1login_03;
            button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            button2.Location = new System.Drawing.Point(181, 376);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(154, 68);
            button2.TabIndex = 0;
            button2.UseVisualStyleBackColor = false;
            button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.Transparent;
            button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button3.Cursor = System.Windows.Forms.Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            button3.Location = new System.Drawing.Point(579, 376);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(154, 68);
            button3.TabIndex = 1;
            button3.UseVisualStyleBackColor = false;
            button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.Color.Transparent;
            button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button4.Cursor = System.Windows.Forms.Cursors.Hand;
            button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            button4.Location = new System.Drawing.Point(785, 534);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(112, 65);
            button4.TabIndex = 2;
            button4.UseVisualStyleBackColor = false;
            button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(898, 598);
            this.Controls.Add(button4);
            this.Controls.Add(button3);
            this.Controls.Add(button2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.Button button1;
        //private System.Windows.Forms.Integration.ElementHost elementHost1;
    }
}

