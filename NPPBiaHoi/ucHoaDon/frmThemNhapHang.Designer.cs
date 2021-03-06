﻿namespace NPPBiaHoi.ucHoaDon
{
    partial class frmThemNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemNhapHang));
            this.spinSoLuong = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.spinSoLuongVoThuVe = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.mmoGhiChu = new DevExpress.XtraEditors.MemoEdit();
            this.panNhapHang = new DevExpress.XtraEditors.PanelControl();
            this.luePhuongTien = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lueNhanVien = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.timeThoiGian = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.grdThemHoaDonNhapHang = new DevExpress.XtraGrid.GridControl();
            this.grdThemNhapHangChiTiet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSanPham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueSanPham = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTraVo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spinTraVo = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colSoVoCoTheMuon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChú = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.spinSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSoLuongVoThuVe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panNhapHang)).BeginInit();
            this.panNhapHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luePhuongTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeThoiGian.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeThoiGian.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdThemHoaDonNhapHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdThemNhapHangChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTraVo)).BeginInit();
            this.SuspendLayout();
            // 
            // spinSoLuong
            // 
            this.spinSoLuong.AutoHeight = false;
            this.spinSoLuong.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.spinSoLuong.Name = "spinSoLuong";
            // 
            // spinSoLuongVoThuVe
            // 
            this.spinSoLuongVoThuVe.AutoHeight = false;
            this.spinSoLuongVoThuVe.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.spinSoLuongVoThuVe.Name = "spinSoLuongVoThuVe";
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(789, 701);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 32);
            this.btnHuy.TabIndex = 31;
            this.btnHuy.Text = "Hủy";
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(700, 701);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 32);
            this.btnLuu.TabIndex = 30;
            this.btnLuu.Text = "Lưu";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Location = new System.Drawing.Point(22, 592);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(46, 16);
            this.labelControl9.TabIndex = 24;
            this.labelControl9.Text = "Ghi chú";
            // 
            // mmoGhiChu
            // 
            this.mmoGhiChu.Location = new System.Drawing.Point(77, 590);
            this.mmoGhiChu.Name = "mmoGhiChu";
            this.mmoGhiChu.Size = new System.Drawing.Size(787, 91);
            this.mmoGhiChu.TabIndex = 29;
            // 
            // panNhapHang
            // 
            this.panNhapHang.Controls.Add(this.luePhuongTien);
            this.panNhapHang.Controls.Add(this.labelControl6);
            this.panNhapHang.Controls.Add(this.lueNhanVien);
            this.panNhapHang.Controls.Add(this.labelControl5);
            this.panNhapHang.Controls.Add(this.timeThoiGian);
            this.panNhapHang.Controls.Add(this.labelControl2);
            this.panNhapHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.panNhapHang.Location = new System.Drawing.Point(0, 0);
            this.panNhapHang.Name = "panNhapHang";
            this.panNhapHang.Size = new System.Drawing.Size(882, 192);
            this.panNhapHang.TabIndex = 23;
            // 
            // luePhuongTien
            // 
            this.luePhuongTien.Location = new System.Drawing.Point(618, 85);
            this.luePhuongTien.Name = "luePhuongTien";
            this.luePhuongTien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luePhuongTien.Size = new System.Drawing.Size(246, 22);
            this.luePhuongTien.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Location = new System.Drawing.Point(449, 116);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(147, 17);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Nhân viên nhập hàng";
            // 
            // lueNhanVien
            // 
            this.lueNhanVien.Location = new System.Drawing.Point(618, 113);
            this.lueNhanVien.Name = "lueNhanVien";
            this.lueNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueNhanVien.Size = new System.Drawing.Size(246, 22);
            this.lueNhanVien.TabIndex = 11;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Location = new System.Drawing.Point(449, 90);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(163, 17);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Phương tiện nhập hàng";
            // 
            // timeThoiGian
            // 
            this.timeThoiGian.EditValue = new System.DateTime(2016, 4, 26, 0, 0, 0, 0);
            this.timeThoiGian.Location = new System.Drawing.Point(618, 57);
            this.timeThoiGian.Name = "timeThoiGian";
            this.timeThoiGian.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeThoiGian.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeThoiGian.Properties.DisplayFormat.FormatString = "";
            this.timeThoiGian.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.timeThoiGian.Properties.EditFormat.FormatString = "";
            this.timeThoiGian.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.timeThoiGian.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.timeThoiGian.Properties.Mask.EditMask = "T";
            this.timeThoiGian.Size = new System.Drawing.Size(246, 22);
            this.timeThoiGian.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(449, 60);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 17);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Thời gian";
            // 
            // grdThemHoaDonNhapHang
            // 
            this.grdThemHoaDonNhapHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdThemHoaDonNhapHang.Location = new System.Drawing.Point(0, 189);
            this.grdThemHoaDonNhapHang.MainView = this.grdThemNhapHangChiTiet;
            this.grdThemHoaDonNhapHang.Name = "grdThemHoaDonNhapHang";
            this.grdThemHoaDonNhapHang.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lueSanPham,
            this.spinSoLuongVoThuVe,
            this.spinSoLuong,
            this.spinTraVo});
            this.grdThemHoaDonNhapHang.Size = new System.Drawing.Size(882, 380);
            this.grdThemHoaDonNhapHang.TabIndex = 22;
            this.grdThemHoaDonNhapHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdThemNhapHangChiTiet});
            // 
            // grdThemNhapHangChiTiet
            // 
            this.grdThemNhapHangChiTiet.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.grdThemNhapHangChiTiet.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdThemNhapHangChiTiet.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.grdThemNhapHangChiTiet.Appearance.HeaderPanel.Options.UseFont = true;
            this.grdThemNhapHangChiTiet.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.grdThemNhapHangChiTiet.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdThemNhapHangChiTiet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSanPham,
            this.colSoLuong,
            this.colTraVo,
            this.colSoVoCoTheMuon,
            this.colGhiChú});
            this.grdThemNhapHangChiTiet.GridControl = this.grdThemHoaDonNhapHang;
            this.grdThemNhapHangChiTiet.Name = "grdThemNhapHangChiTiet";
            this.grdThemNhapHangChiTiet.OptionsView.ShowGroupPanel = false;
            // 
            // colSanPham
            // 
            this.colSanPham.Caption = "Sản phẩm";
            this.colSanPham.ColumnEdit = this.lueSanPham;
            this.colSanPham.FieldName = "Ten";
            this.colSanPham.Name = "colSanPham";
            this.colSanPham.OptionsEditForm.Caption = "Sản phẩm";
            this.colSanPham.Visible = true;
            this.colSanPham.VisibleIndex = 0;
            this.colSanPham.Width = 116;
            // 
            // lueSanPham
            // 
            this.lueSanPham.AutoHeight = false;
            this.lueSanPham.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.lueSanPham.Name = "lueSanPham";
            // 
            // colSoLuong
            // 
            this.colSoLuong.Caption = "Số lượng";
            this.colSoLuong.ColumnEdit = this.spinSoLuong;
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.OptionsEditForm.Caption = "Số lượng";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 1;
            this.colSoLuong.Width = 114;
            // 
            // colTraVo
            // 
            this.colTraVo.Caption = "Trả vỏ";
            this.colTraVo.ColumnEdit = this.spinTraVo;
            this.colTraVo.FieldName = "TraVo";
            this.colTraVo.Name = "colTraVo";
            this.colTraVo.OptionsEditForm.Caption = "Trả vỏ";
            this.colTraVo.Visible = true;
            this.colTraVo.VisibleIndex = 2;
            this.colTraVo.Width = 168;
            // 
            // spinTraVo
            // 
            this.spinTraVo.AutoHeight = false;
            this.spinTraVo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinTraVo.Name = "spinTraVo";
            // 
            // colSoVoCoTheMuon
            // 
            this.colSoVoCoTheMuon.Caption = "Số vỏ có thể mượn";
            this.colSoVoCoTheMuon.Name = "colSoVoCoTheMuon";
            this.colSoVoCoTheMuon.OptionsEditForm.Caption = "Số vỏ đang nợ";
            this.colSoVoCoTheMuon.Visible = true;
            this.colSoVoCoTheMuon.VisibleIndex = 3;
            this.colSoVoCoTheMuon.Width = 168;
            // 
            // colGhiChú
            // 
            this.colGhiChú.Caption = "Ghi chú";
            this.colGhiChú.Name = "colGhiChú";
            this.colGhiChú.OptionsEditForm.Caption = "Ghi chú";
            this.colGhiChú.Visible = true;
            this.colGhiChú.VisibleIndex = 4;
            this.colGhiChú.Width = 182;
            // 
            // frmThemNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 743);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.mmoGhiChu);
            this.Controls.Add(this.panNhapHang);
            this.Controls.Add(this.grdThemHoaDonNhapHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThemNhapHang";
            this.Text = "Thêm hóa đơn nhập hàng";
            ((System.ComponentModel.ISupportInitialize)(this.spinSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSoLuongVoThuVe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panNhapHang)).EndInit();
            this.panNhapHang.ResumeLayout(false);
            this.panNhapHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luePhuongTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeThoiGian.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeThoiGian.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdThemHoaDonNhapHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdThemNhapHangChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTraVo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.MemoEdit mmoGhiChu;
        private DevExpress.XtraEditors.PanelControl panNhapHang;
        private DevExpress.XtraEditors.LookUpEdit luePhuongTien;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit lueNhanVien;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit timeThoiGian;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl grdThemHoaDonNhapHang;
        private DevExpress.XtraGrid.Views.Grid.GridView grdThemNhapHangChiTiet;
        private DevExpress.XtraGrid.Columns.GridColumn colSanPham;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueSanPham;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spinSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colTraVo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spinSoLuongVoThuVe;
        private DevExpress.XtraGrid.Columns.GridColumn colSoVoCoTheMuon;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChú;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spinTraVo;
    }
}