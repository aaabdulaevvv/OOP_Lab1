﻿
namespace MyExcel
{
    partial class SaveOrNot
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
            this.SaveLabel = new System.Windows.Forms.Label();
            this.YesBtn = new System.Windows.Forms.Button();
            this.NoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveLabel
            // 
            this.SaveLabel.AutoSize = true;
            this.SaveLabel.Location = new System.Drawing.Point(63, 48);
            this.SaveLabel.Name = "SaveLabel";
            this.SaveLabel.Size = new System.Drawing.Size(50, 20);
            this.SaveLabel.TabIndex = 0;
            this.SaveLabel.Text = "label1";
            // 
            // YesBtn
            // 
            this.YesBtn.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.YesBtn.Location = new System.Drawing.Point(73, 124);
            this.YesBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.YesBtn.Name = "YesBtn";
            this.YesBtn.Size = new System.Drawing.Size(86, 31);
            this.YesBtn.TabIndex = 1;
            this.YesBtn.Text = "button1";
            this.YesBtn.UseVisualStyleBackColor = true;
            // 
            // NoBtn
            // 
            this.NoBtn.DialogResult = System.Windows.Forms.DialogResult.No;
            this.NoBtn.Location = new System.Drawing.Point(165, 124);
            this.NoBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NoBtn.Name = "NoBtn";
            this.NoBtn.Size = new System.Drawing.Size(86, 31);
            this.NoBtn.TabIndex = 2;
            this.NoBtn.Text = "button1";
            this.NoBtn.UseVisualStyleBackColor = true;
            // 
            // SaveOrNot
            // 
            this.AcceptButton = this.YesBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 199);
            this.Controls.Add(this.NoBtn);
            this.Controls.Add(this.YesBtn);
            this.Controls.Add(this.SaveLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SaveOrNot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SaveLabel;
        private System.Windows.Forms.Button YesBtn;
        private System.Windows.Forms.Button NoBtn;
    }
}