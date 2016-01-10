namespace Project_Track_Tutoring_System
{
    partial class BasicForm
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
            this.OutputPanel = new System.Windows.Forms.Panel();
            this.CodePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.RunButton = new System.Windows.Forms.Button();
            this.CodePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputPanel
            // 
            this.OutputPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.OutputPanel.Location = new System.Drawing.Point(210, 0);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Size = new System.Drawing.Size(200, 489);
            this.OutputPanel.TabIndex = 3;
            // 
            // CodePanel
            // 
            this.CodePanel.Controls.Add(this.label1);
            this.CodePanel.Controls.Add(this.RunButton);
            this.CodePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.CodePanel.Location = new System.Drawing.Point(0, 0);
            this.CodePanel.Name = "CodePanel";
            this.CodePanel.Size = new System.Drawing.Size(200, 489);
            this.CodePanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(98, 331);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 23);
            this.RunButton.TabIndex = 2;
            this.RunButton.Text = "button1";
            this.RunButton.UseVisualStyleBackColor = true;
            // 
            // BasicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 489);
            this.Controls.Add(this.OutputPanel);
            this.Controls.Add(this.CodePanel);
            this.Name = "BasicForm";
            this.Text = "BasicForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BasicForm_Load);
            this.CodePanel.ResumeLayout(false);
            this.CodePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel OutputPanel;
        private System.Windows.Forms.Panel CodePanel;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Label label1;
    }
}