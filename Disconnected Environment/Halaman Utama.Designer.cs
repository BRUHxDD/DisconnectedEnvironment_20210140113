﻿namespace Disconnected_Environment
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.dataProdiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMahasiswaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataStatusMahasiswaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataProdiToolStripMenuItem,
            this.dataMahasiswaToolStripMenuItem,
            this.dataStatusMahasiswaToolStripMenuItem});
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(83, 22);
            this.toolStripLabel1.Text = "Data Master";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // dataProdiToolStripMenuItem
            // 
            this.dataProdiToolStripMenuItem.Name = "dataProdiToolStripMenuItem";
            this.dataProdiToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.dataProdiToolStripMenuItem.Text = "Data Prodi";
            // 
            // dataMahasiswaToolStripMenuItem
            // 
            this.dataMahasiswaToolStripMenuItem.Name = "dataMahasiswaToolStripMenuItem";
            this.dataMahasiswaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.dataMahasiswaToolStripMenuItem.Text = "Data Mahasiswa";
            // 
            // dataStatusMahasiswaToolStripMenuItem
            // 
            this.dataStatusMahasiswaToolStripMenuItem.Name = "dataStatusMahasiswaToolStripMenuItem";
            this.dataStatusMahasiswaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.dataStatusMahasiswaToolStripMenuItem.Text = "Data Status Mahasiswa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Data Master";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem dataProdiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataMahasiswaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataStatusMahasiswaToolStripMenuItem;
    }
}

