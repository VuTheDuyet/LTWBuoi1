namespace Buoi7_1.frm
{
    partial class frmMain
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SinhVienToolStripMenuItem = new System.Windows.Forms.ToolStripLabel();
            this.KhoaToolStripMenuItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Location = new System.Drawing.Point(0, 59);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1032, 616);
            this.tabControlMain.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SinhVienToolStripMenuItem,
            this.KhoaToolStripMenuItem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1032, 38);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SinhVienToolStripMenuItem
            // 
            this.SinhVienToolStripMenuItem.BackColor = System.Drawing.Color.Cyan;
            this.SinhVienToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.SinhVienToolStripMenuItem.Name = "SinhVienToolStripMenuItem";
            this.SinhVienToolStripMenuItem.Size = new System.Drawing.Size(244, 35);
            this.SinhVienToolStripMenuItem.Text = "QUẢN LÝ SINH VIÊN";
            this.SinhVienToolStripMenuItem.Click += new System.EventHandler(this.SinhVienToolStripMenuItem_Click);
            // 
            // KhoaToolStripMenuItem
            // 
            this.KhoaToolStripMenuItem.BackColor = System.Drawing.Color.Cyan;
            this.KhoaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.KhoaToolStripMenuItem.Name = "KhoaToolStripMenuItem";
            this.KhoaToolStripMenuItem.Size = new System.Drawing.Size(192, 35);
            this.KhoaToolStripMenuItem.Text = "QUẢN LÝ KHOA";
            this.KhoaToolStripMenuItem.Click += new System.EventHandler(this.KhoaToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 676);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel SinhVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel KhoaToolStripMenuItem;
    }
}