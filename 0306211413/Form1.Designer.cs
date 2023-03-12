
namespace _0306211413
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grbViewStyle = new System.Windows.Forms.GroupBox();
            this.rdbTile = new System.Windows.Forms.RadioButton();
            this.rdbList = new System.Windows.Forms.RadioButton();
            this.rdbSmallIcon = new System.Windows.Forms.RadioButton();
            this.rdbDetail = new System.Windows.Forms.RadioButton();
            this.rdbLargeIcon = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbHinh = new System.Windows.Forms.PictureBox();
            this.lvDSTraSua = new System.Windows.Forms.ListView();
            this.colMaTra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenTra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListTraSuaLarge = new System.Windows.Forms.ImageList(this.components);
            this.imageListTraSuaSmall = new System.Windows.Forms.ImageList(this.components);
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtMaTra = new System.Windows.Forms.TextBox();
            this.txtTenTra = new System.Windows.Forms.TextBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.btnHuy = new System.Windows.Forms.Button();
            this.grbViewStyle.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(380, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH TRÀ SỮA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(681, 327);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã trà";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(681, 372);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên trà";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(681, 422);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số tiền";
            // 
            // grbViewStyle
            // 
            this.grbViewStyle.Controls.Add(this.rdbTile);
            this.grbViewStyle.Controls.Add(this.rdbList);
            this.grbViewStyle.Controls.Add(this.rdbSmallIcon);
            this.grbViewStyle.Controls.Add(this.rdbDetail);
            this.grbViewStyle.Controls.Add(this.rdbLargeIcon);
            this.grbViewStyle.Location = new System.Drawing.Point(52, 108);
            this.grbViewStyle.Margin = new System.Windows.Forms.Padding(4);
            this.grbViewStyle.Name = "grbViewStyle";
            this.grbViewStyle.Padding = new System.Windows.Forms.Padding(4);
            this.grbViewStyle.Size = new System.Drawing.Size(435, 58);
            this.grbViewStyle.TabIndex = 1;
            this.grbViewStyle.TabStop = false;
            this.grbViewStyle.Text = "View style";
            // 
            // rdbTile
            // 
            this.rdbTile.AutoSize = true;
            this.rdbTile.Location = new System.Drawing.Point(364, 23);
            this.rdbTile.Margin = new System.Windows.Forms.Padding(4);
            this.rdbTile.Name = "rdbTile";
            this.rdbTile.Size = new System.Drawing.Size(51, 20);
            this.rdbTile.TabIndex = 0;
            this.rdbTile.TabStop = true;
            this.rdbTile.Text = "Tile";
            this.rdbTile.UseVisualStyleBackColor = true;
            this.rdbTile.CheckedChanged += new System.EventHandler(this.rdbTile_CheckedChanged);
            // 
            // rdbList
            // 
            this.rdbList.AutoSize = true;
            this.rdbList.Location = new System.Drawing.Point(301, 23);
            this.rdbList.Margin = new System.Windows.Forms.Padding(4);
            this.rdbList.Name = "rdbList";
            this.rdbList.Size = new System.Drawing.Size(48, 20);
            this.rdbList.TabIndex = 0;
            this.rdbList.TabStop = true;
            this.rdbList.Text = "List";
            this.rdbList.UseVisualStyleBackColor = true;
            this.rdbList.CheckedChanged += new System.EventHandler(this.rdbList_CheckedChanged);
            // 
            // rdbSmallIcon
            // 
            this.rdbSmallIcon.AutoSize = true;
            this.rdbSmallIcon.Location = new System.Drawing.Point(195, 23);
            this.rdbSmallIcon.Margin = new System.Windows.Forms.Padding(4);
            this.rdbSmallIcon.Name = "rdbSmallIcon";
            this.rdbSmallIcon.Size = new System.Drawing.Size(90, 20);
            this.rdbSmallIcon.TabIndex = 0;
            this.rdbSmallIcon.TabStop = true;
            this.rdbSmallIcon.Text = "Small Icon";
            this.rdbSmallIcon.UseVisualStyleBackColor = true;
            this.rdbSmallIcon.CheckedChanged += new System.EventHandler(this.rdbSmallIcon_CheckedChanged);
            // 
            // rdbDetail
            // 
            this.rdbDetail.AutoSize = true;
            this.rdbDetail.Location = new System.Drawing.Point(117, 23);
            this.rdbDetail.Margin = new System.Windows.Forms.Padding(4);
            this.rdbDetail.Name = "rdbDetail";
            this.rdbDetail.Size = new System.Drawing.Size(63, 20);
            this.rdbDetail.TabIndex = 0;
            this.rdbDetail.TabStop = true;
            this.rdbDetail.Text = "Detail";
            this.rdbDetail.UseVisualStyleBackColor = true;
            this.rdbDetail.CheckedChanged += new System.EventHandler(this.rdbDetail_CheckedChanged);
            // 
            // rdbLargeIcon
            // 
            this.rdbLargeIcon.AutoSize = true;
            this.rdbLargeIcon.Location = new System.Drawing.Point(8, 23);
            this.rdbLargeIcon.Margin = new System.Windows.Forms.Padding(4);
            this.rdbLargeIcon.Name = "rdbLargeIcon";
            this.rdbLargeIcon.Size = new System.Drawing.Size(91, 20);
            this.rdbLargeIcon.TabIndex = 0;
            this.rdbLargeIcon.TabStop = true;
            this.rdbLargeIcon.Text = "Large Icon";
            this.rdbLargeIcon.UseVisualStyleBackColor = true;
            this.rdbLargeIcon.CheckedChanged += new System.EventHandler(this.rdbLargeIcon_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbHinh);
            this.groupBox2.Location = new System.Drawing.Point(649, 108);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(355, 196);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết trà sữa";
            // 
            // pbHinh
            // 
            this.pbHinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHinh.Location = new System.Drawing.Point(76, 46);
            this.pbHinh.Margin = new System.Windows.Forms.Padding(4);
            this.pbHinh.Name = "pbHinh";
            this.pbHinh.Size = new System.Drawing.Size(188, 121);
            this.pbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHinh.TabIndex = 0;
            this.pbHinh.TabStop = false;
            this.pbHinh.Click += new System.EventHandler(this.pbHinh_Click);
            // 
            // lvDSTraSua
            // 
            this.lvDSTraSua.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaTra,
            this.colTenTra,
            this.colDonGia});
            this.lvDSTraSua.HideSelection = false;
            this.lvDSTraSua.LargeImageList = this.imageListTraSuaLarge;
            this.lvDSTraSua.Location = new System.Drawing.Point(60, 192);
            this.lvDSTraSua.Margin = new System.Windows.Forms.Padding(4);
            this.lvDSTraSua.Name = "lvDSTraSua";
            this.lvDSTraSua.Size = new System.Drawing.Size(588, 329);
            this.lvDSTraSua.SmallImageList = this.imageListTraSuaSmall;
            this.lvDSTraSua.TabIndex = 2;
            this.lvDSTraSua.UseCompatibleStateImageBehavior = false;
            this.lvDSTraSua.View = System.Windows.Forms.View.Details;
            this.lvDSTraSua.SelectedIndexChanged += new System.EventHandler(this.lvDSTraSua_SelectedIndexChanged);
            // 
            // colMaTra
            // 
            this.colMaTra.Text = "Mã Trà";
            this.colMaTra.Width = 105;
            // 
            // colTenTra
            // 
            this.colTenTra.Text = "Tên Trà";
            this.colTenTra.Width = 122;
            // 
            // colDonGia
            // 
            this.colDonGia.Text = "Đơn giá";
            this.colDonGia.Width = 159;
            // 
            // imageListTraSuaLarge
            // 
            this.imageListTraSuaLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTraSuaLarge.ImageStream")));
            this.imageListTraSuaLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTraSuaLarge.Images.SetKeyName(0, "TS001.jpg");
            this.imageListTraSuaLarge.Images.SetKeyName(1, "TS002.jpg");
            this.imageListTraSuaLarge.Images.SetKeyName(2, "TS003.jpg");
            this.imageListTraSuaLarge.Images.SetKeyName(3, "TS004.jpg");
            this.imageListTraSuaLarge.Images.SetKeyName(4, "TS005.jpg");
            this.imageListTraSuaLarge.Images.SetKeyName(5, "TS006.jpg");
            this.imageListTraSuaLarge.Images.SetKeyName(6, "TS007.jpg");
            this.imageListTraSuaLarge.Images.SetKeyName(7, "TS008.jpg");
            this.imageListTraSuaLarge.Images.SetKeyName(8, "TS009.jpg");
            this.imageListTraSuaLarge.Images.SetKeyName(9, "TS010.jpg");
            this.imageListTraSuaLarge.Images.SetKeyName(10, "TS011.jpg");
            this.imageListTraSuaLarge.Images.SetKeyName(11, "TS012.jpg");
            this.imageListTraSuaLarge.Images.SetKeyName(12, "TS013.jpg");
            this.imageListTraSuaLarge.Images.SetKeyName(13, "TS014.jpg");
            this.imageListTraSuaLarge.Images.SetKeyName(14, "TS015.jpg");
            this.imageListTraSuaLarge.Images.SetKeyName(15, "TS016.jpg");
            this.imageListTraSuaLarge.Images.SetKeyName(16, "TS017.jpg");
            this.imageListTraSuaLarge.Images.SetKeyName(17, "TS018.jpg");
            // 
            // imageListTraSuaSmall
            // 
            this.imageListTraSuaSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTraSuaSmall.ImageStream")));
            this.imageListTraSuaSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTraSuaSmall.Images.SetKeyName(0, "TS001.jpg");
            this.imageListTraSuaSmall.Images.SetKeyName(1, "TS002.jpg");
            this.imageListTraSuaSmall.Images.SetKeyName(2, "TS003.jpg");
            this.imageListTraSuaSmall.Images.SetKeyName(3, "TS004.jpg");
            this.imageListTraSuaSmall.Images.SetKeyName(4, "TS005.jpg");
            this.imageListTraSuaSmall.Images.SetKeyName(5, "TS006.jpg");
            this.imageListTraSuaSmall.Images.SetKeyName(6, "TS007.jpg");
            this.imageListTraSuaSmall.Images.SetKeyName(7, "TS008.jpg");
            this.imageListTraSuaSmall.Images.SetKeyName(8, "TS009.jpg");
            this.imageListTraSuaSmall.Images.SetKeyName(9, "TS010.jpg");
            this.imageListTraSuaSmall.Images.SetKeyName(10, "TS011.jpg");
            this.imageListTraSuaSmall.Images.SetKeyName(11, "TS012.jpg");
            this.imageListTraSuaSmall.Images.SetKeyName(12, "TS013.jpg");
            this.imageListTraSuaSmall.Images.SetKeyName(13, "TS014.jpg");
            this.imageListTraSuaSmall.Images.SetKeyName(14, "TS015.jpg");
            this.imageListTraSuaSmall.Images.SetKeyName(15, "TS016.jpg");
            this.imageListTraSuaSmall.Images.SetKeyName(16, "TS017.jpg");
            this.imageListTraSuaSmall.Images.SetKeyName(17, "TS018.jpg");
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(684, 457);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 28);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(684, 509);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 28);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(820, 509);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 28);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(820, 457);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 28);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtMaTra
            // 
            this.txtMaTra.Location = new System.Drawing.Point(767, 319);
            this.txtMaTra.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaTra.Name = "txtMaTra";
            this.txtMaTra.ReadOnly = true;
            this.txtMaTra.Size = new System.Drawing.Size(193, 22);
            this.txtMaTra.TabIndex = 4;
            // 
            // txtTenTra
            // 
            this.txtTenTra.Location = new System.Drawing.Point(767, 363);
            this.txtTenTra.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenTra.Name = "txtTenTra";
            this.txtTenTra.ReadOnly = true;
            this.txtTenTra.Size = new System.Drawing.Size(193, 22);
            this.txtTenTra.TabIndex = 2;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(767, 414);
            this.txtSoTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.ReadOnly = true;
            this.txtSoTien.Size = new System.Drawing.Size(193, 22);
            this.txtSoTien.TabIndex = 3;
            this.txtSoTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTien_KeyPress);
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "ofdFile";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(942, 457);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 28);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.txtTenTra);
            this.Controls.Add(this.txtMaTra);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lvDSTraSua);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbViewStyle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách trà sữa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbViewStyle.ResumeLayout(false);
            this.grbViewStyle.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbViewStyle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbSmallIcon;
        private System.Windows.Forms.RadioButton rdbDetail;
        private System.Windows.Forms.RadioButton rdbLargeIcon;
        private System.Windows.Forms.RadioButton rdbTile;
        private System.Windows.Forms.RadioButton rdbList;
        private System.Windows.Forms.ListView lvDSTraSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtMaTra;
        private System.Windows.Forms.TextBox txtTenTra;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.PictureBox pbHinh;
        private System.Windows.Forms.ImageList imageListTraSuaLarge;
        private System.Windows.Forms.ImageList imageListTraSuaSmall;
        private System.Windows.Forms.ColumnHeader colMaTra;
        private System.Windows.Forms.ColumnHeader colTenTra;
        private System.Windows.Forms.ColumnHeader colDonGia;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.Button btnHuy;
    }
}

