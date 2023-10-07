namespace Buoi3_3
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
            this.groupBoxThongTinSach = new System.Windows.Forms.GroupBox();
            this.groupBoxDanhSach = new System.Windows.Forms.GroupBox();
            this.groupBoxChucNang = new System.Windows.Forms.GroupBox();
            this.labelMaSach = new System.Windows.Forms.Label();
            this.textBoxMS = new System.Windows.Forms.TextBox();
            this.textBoxSL = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.labelGia = new System.Windows.Forms.Label();
            this.textBoxTX = new System.Windows.Forms.TextBox();
            this.labelTenSach = new System.Windows.Forms.Label();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxDS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.groupBoxThongTinSach.SuspendLayout();
            this.groupBoxDanhSach.SuspendLayout();
            this.groupBoxChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxThongTinSach
            // 
            this.groupBoxThongTinSach.Controls.Add(this.lblThongBao);
            this.groupBoxThongTinSach.Controls.Add(this.label2);
            this.groupBoxThongTinSach.Controls.Add(this.textBoxTX);
            this.groupBoxThongTinSach.Controls.Add(this.labelTenSach);
            this.groupBoxThongTinSach.Controls.Add(this.textBoxG);
            this.groupBoxThongTinSach.Controls.Add(this.labelGia);
            this.groupBoxThongTinSach.Controls.Add(this.textBoxSL);
            this.groupBoxThongTinSach.Controls.Add(this.lblSoLuong);
            this.groupBoxThongTinSach.Controls.Add(this.textBoxMS);
            this.groupBoxThongTinSach.Controls.Add(this.labelMaSach);
            this.groupBoxThongTinSach.Location = new System.Drawing.Point(13, 50);
            this.groupBoxThongTinSach.Name = "groupBoxThongTinSach";
            this.groupBoxThongTinSach.Size = new System.Drawing.Size(351, 388);
            this.groupBoxThongTinSach.TabIndex = 0;
            this.groupBoxThongTinSach.TabStop = false;
            this.groupBoxThongTinSach.Text = "Thông tin Sách";
            this.groupBoxThongTinSach.Enter += new System.EventHandler(this.groupBoxThongTinSach_Enter);
            // 
            // groupBoxDanhSach
            // 
            this.groupBoxDanhSach.Controls.Add(this.textBoxDS);
            this.groupBoxDanhSach.Location = new System.Drawing.Point(386, 50);
            this.groupBoxDanhSach.Name = "groupBoxDanhSach";
            this.groupBoxDanhSach.Size = new System.Drawing.Size(393, 241);
            this.groupBoxDanhSach.TabIndex = 1;
            this.groupBoxDanhSach.TabStop = false;
            this.groupBoxDanhSach.Text = "Danh Sách";
            // 
            // groupBoxChucNang
            // 
            this.groupBoxChucNang.Controls.Add(this.button3);
            this.groupBoxChucNang.Controls.Add(this.buttonXoa);
            this.groupBoxChucNang.Controls.Add(this.buttonThem);
            this.groupBoxChucNang.Location = new System.Drawing.Point(386, 310);
            this.groupBoxChucNang.Name = "groupBoxChucNang";
            this.groupBoxChucNang.Size = new System.Drawing.Size(393, 128);
            this.groupBoxChucNang.TabIndex = 2;
            this.groupBoxChucNang.TabStop = false;
            this.groupBoxChucNang.Text = "Chức Năng";
            // 
            // labelMaSach
            // 
            this.labelMaSach.AutoSize = true;
            this.labelMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaSach.Location = new System.Drawing.Point(26, 63);
            this.labelMaSach.Name = "labelMaSach";
            this.labelMaSach.Size = new System.Drawing.Size(79, 20);
            this.labelMaSach.TabIndex = 0;
            this.labelMaSach.Text = "Mã Sách";
            // 
            // textBoxMS
            // 
            this.textBoxMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMS.Location = new System.Drawing.Point(158, 63);
            this.textBoxMS.Name = "textBoxMS";
            this.textBoxMS.Size = new System.Drawing.Size(171, 26);
            this.textBoxMS.TabIndex = 1;
            this.textBoxMS.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxSL
            // 
            this.textBoxSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSL.Location = new System.Drawing.Point(158, 217);
            this.textBoxSL.Name = "textBoxSL";
            this.textBoxSL.Size = new System.Drawing.Size(83, 26);
            this.textBoxSL.TabIndex = 3;
            this.textBoxSL.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(26, 217);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(86, 20);
            this.lblSoLuong.TabIndex = 2;
            this.lblSoLuong.Text = "Số Lượng";
            // 
            // textBoxG
            // 
            this.textBoxG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxG.Location = new System.Drawing.Point(159, 157);
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.Size = new System.Drawing.Size(95, 26);
            this.textBoxG.TabIndex = 7;
            this.textBoxG.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // labelGia
            // 
            this.labelGia.AutoSize = true;
            this.labelGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGia.Location = new System.Drawing.Point(27, 157);
            this.labelGia.Name = "labelGia";
            this.labelGia.Size = new System.Drawing.Size(37, 20);
            this.labelGia.TabIndex = 6;
            this.labelGia.Text = "Gía";
            this.labelGia.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxTX
            // 
            this.textBoxTX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTX.Location = new System.Drawing.Point(159, 107);
            this.textBoxTX.Name = "textBoxTX";
            this.textBoxTX.Size = new System.Drawing.Size(171, 26);
            this.textBoxTX.TabIndex = 9;
            this.textBoxTX.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // labelTenSach
            // 
            this.labelTenSach.AutoSize = true;
            this.labelTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenSach.Location = new System.Drawing.Point(27, 107);
            this.labelTenSach.Name = "labelTenSach";
            this.labelTenSach.Size = new System.Drawing.Size(85, 20);
            this.labelTenSach.TabIndex = 8;
            this.labelTenSach.Text = "Tên Sách";
            // 
            // buttonThem
            // 
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Location = new System.Drawing.Point(28, 49);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(75, 23);
            this.buttonThem.TabIndex = 0;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Location = new System.Drawing.Point(157, 49);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(75, 23);
            this.buttonXoa.TabIndex = 1;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(286, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxDS
            // 
            this.textBoxDS.Location = new System.Drawing.Point(18, 19);
            this.textBoxDS.Multiline = true;
            this.textBoxDS.Name = "textBoxDS";
            this.textBoxDS.Size = new System.Drawing.Size(369, 211);
            this.textBoxDS.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Quản LÍ Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "VNĐ";
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.ForeColor = System.Drawing.Color.Red;
            this.lblThongBao.Location = new System.Drawing.Point(16, 318);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(0, 13);
            this.lblThongBao.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxChucNang);
            this.Controls.Add(this.groupBoxDanhSach);
            this.Controls.Add(this.groupBoxThongTinSach);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxThongTinSach.ResumeLayout(false);
            this.groupBoxThongTinSach.PerformLayout();
            this.groupBoxDanhSach.ResumeLayout(false);
            this.groupBoxDanhSach.PerformLayout();
            this.groupBoxChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxThongTinSach;
        private System.Windows.Forms.GroupBox groupBoxDanhSach;
        private System.Windows.Forms.GroupBox groupBoxChucNang;
        private System.Windows.Forms.Label labelMaSach;
        private System.Windows.Forms.TextBox textBoxTX;
        private System.Windows.Forms.Label labelTenSach;
        private System.Windows.Forms.TextBox textBoxG;
        private System.Windows.Forms.Label labelGia;
        private System.Windows.Forms.TextBox textBoxSL;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox textBoxMS;
        private System.Windows.Forms.TextBox textBoxDS;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblThongBao;
    }
}

