﻿namespace DataSetTest
{
    partial class Form3
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
            this.dataGridBindXtraUserControl1 = new DataSetTest.DataGridBindXtraUserControl();
            this.SuspendLayout();
            // 
            // dataGridBindXtraUserControl1
            // 
            this.dataGridBindXtraUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridBindXtraUserControl1.Location = new System.Drawing.Point(0, 0);
            this.dataGridBindXtraUserControl1.Name = "dataGridBindXtraUserControl1";
            this.dataGridBindXtraUserControl1.Size = new System.Drawing.Size(850, 523);
            this.dataGridBindXtraUserControl1.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 523);
            this.Controls.Add(this.dataGridBindXtraUserControl1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridBindXtraUserControl dataGridBindXtraUserControl1;
    }
}