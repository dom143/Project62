namespace Project
{
    partial class studentlogin
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
            System.Windows.Forms.Button button1;
            System.Windows.Forms.Button button4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentlogin));
            this.passstu = new System.Windows.Forms.TextBox();
            this.userstu = new System.Windows.Forms.TextBox();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passstu
            // 
            this.passstu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passstu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.passstu.Location = new System.Drawing.Point(388, 419);
            this.passstu.Name = "passstu";
            this.passstu.PasswordChar = '*';
            this.passstu.Size = new System.Drawing.Size(194, 31);
            this.passstu.TabIndex = 8;
            // 
            // userstu
            // 
            this.userstu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.userstu.Location = new System.Drawing.Point(388, 364);
            this.userstu.Name = "userstu";
            this.userstu.Size = new System.Drawing.Size(194, 31);
            this.userstu.TabIndex = 7;
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
            button2.Location = new System.Drawing.Point(795, 545);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(93, 45);
            button2.TabIndex = 10;
            button2.UseVisualStyleBackColor = false;
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
            button3.Location = new System.Drawing.Point(390, 478);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(112, 45);
            button3.TabIndex = 9;
            button3.UseVisualStyleBackColor = false;
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
            button1.Location = new System.Drawing.Point(393, 479);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(112, 45);
            button1.TabIndex = 9;
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(this.button1_Click);
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
            button4.Location = new System.Drawing.Point(798, 546);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(93, 45);
            button4.TabIndex = 10;
            button4.UseVisualStyleBackColor = false;
            button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // studentlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(900, 602);
            this.Controls.Add(button4);
            this.Controls.Add(button2);
            this.Controls.Add(button1);
            this.Controls.Add(button3);
            this.Controls.Add(this.passstu);
            this.Controls.Add(this.userstu);
            this.Name = "studentlogin";
            this.Text = "studentlogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passstu;
        private System.Windows.Forms.TextBox userstu;
    }
}