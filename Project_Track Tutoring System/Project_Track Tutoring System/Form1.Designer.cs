namespace Project_Track_Tutoring_System
{
    partial class Home_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Link_Panel = new System.Windows.Forms.Panel();
            this.Image_Panel = new System.Windows.Forms.Panel();
            this.Go_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Image_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 100);
            this.panel1.TabIndex = 0;
            // 
            // Link_Panel
            // 
            this.Link_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Link_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Link_Panel.Location = new System.Drawing.Point(0, 215);
            this.Link_Panel.Name = "Link_Panel";
            this.Link_Panel.Size = new System.Drawing.Size(609, 100);
            this.Link_Panel.TabIndex = 1;
            // 
            // Image_Panel
            // 
            this.Image_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Image_Panel.Controls.Add(this.Go_Button);
            this.Image_Panel.Controls.Add(this.pictureBox1);
            this.Image_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Image_Panel.Location = new System.Drawing.Point(0, 100);
            this.Image_Panel.Name = "Image_Panel";
            this.Image_Panel.Size = new System.Drawing.Size(609, 115);
            this.Image_Panel.TabIndex = 2;
            // 
            // Go_Button
            // 
            this.Go_Button.Location = new System.Drawing.Point(521, 85);
            this.Go_Button.Name = "Go_Button";
            this.Go_Button.Size = new System.Drawing.Size(75, 23);
            this.Go_Button.TabIndex = 0;
            this.Go_Button.Text = "GO!";
            this.Go_Button.UseVisualStyleBackColor = true;
            this.Go_Button.Click += new System.EventHandler(this.Go_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_Track_Tutoring_System.Properties.Resources.Capture;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(607, 113);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Home_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 315);
            this.Controls.Add(this.Image_Panel);
            this.Controls.Add(this.Link_Panel);
            this.Controls.Add(this.panel1);
            this.Name = "Home_Form";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Form_Load);
            this.Resize += new System.EventHandler(this.Home_Form_Resize);
            this.Image_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Link_Panel;
        private System.Windows.Forms.Panel Image_Panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Go_Button;
    }
}

