namespace Project
{
    partial class teacherlogin
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
            System.Windows.Forms.Button button3;
            System.Windows.Forms.Button button1;
            System.Windows.Forms.Button button2;
            System.Windows.Forms.Button button4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teacherlogin));
            this.usertea = new System.Windows.Forms.TextBox();
            this.passtea = new System.Windows.Forms.TextBox();
            button3 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            button3.Location = new System.Drawing.Point(394, 479);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(112, 45);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Transparent;
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            button1.Location = new System.Drawing.Point(394, 278);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(112, 45);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
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
            button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            button2.Location = new System.Drawing.Point(799, 546);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(93, 45);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = false;
            button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // usertea
            // 
            this.usertea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.usertea.Location = new System.Drawing.Point(394, 363);
            this.usertea.Name = "usertea";
            this.usertea.Size = new System.Drawing.Size(194, 31);
            this.usertea.TabIndex = 5;
            // 
            // passtea
            // 
            this.passtea.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passtea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.passtea.Location = new System.Drawing.Point(394, 418);
            this.passtea.Name = "passtea";
            this.passtea.PasswordChar = '*';
            this.passtea.Size = new System.Drawing.Size(194, 31);
            this.passtea.TabIndex = 6;
            this.passtea.TextChanged += new System.EventHandler(this.passtea_TextChanged);
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.Color.Transparent;
            button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            button4.Cursor = System.Windows.Forms.Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            button4.Location = new System.Drawing.Point(8, 545);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(114, 45);
            button4.TabIndex = 7;
            button4.UseVisualStyleBackColor = false;
            button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // teacherlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(901, 600);
            this.Controls.Add(button4);
            this.Controls.Add(this.passtea);
            this.Controls.Add(this.usertea);
            this.Controls.Add(button2);
            this.Controls.Add(button1);
            this.Controls.Add(button3);
            this.DoubleBuffered = true;
            this.Name = "teacherlogin";
            this.Text = "teacherlogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox usertea;
        private System.Windows.Forms.TextBox passtea;
    }
}