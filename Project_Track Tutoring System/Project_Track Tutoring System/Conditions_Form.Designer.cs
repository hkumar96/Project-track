namespace Project_Track_Tutoring_System
{
    partial class Conditions_Form
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
            this.CodePanel = new System.Windows.Forms.Panel();
            this.OutputPanel = new System.Windows.Forms.Panel();
            this.RunButton = new System.Windows.Forms.Button();
            this.CodePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CodePanel
            // 
            this.CodePanel.Controls.Add(this.RunButton);
            this.CodePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.CodePanel.Location = new System.Drawing.Point(0, 0);
            this.CodePanel.Name = "CodePanel";
            this.CodePanel.Size = new System.Drawing.Size(200, 366);
            this.CodePanel.TabIndex = 0;
            // 
            // OutputPanel
            // 
            this.OutputPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.OutputPanel.Location = new System.Drawing.Point(213, 0);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Size = new System.Drawing.Size(200, 366);
            this.OutputPanel.TabIndex = 1;
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
            // Conditions_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 366);
            this.Controls.Add(this.OutputPanel);
            this.Controls.Add(this.CodePanel);
            this.Name = "Conditions_Form";
            this.Text = "Conditions_Form";
            this.Load += new System.EventHandler(this.Conditions_Form_Load);
            this.CodePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CodePanel;
        private System.Windows.Forms.Panel OutputPanel;
        private System.Windows.Forms.Button RunButton;

    }
}