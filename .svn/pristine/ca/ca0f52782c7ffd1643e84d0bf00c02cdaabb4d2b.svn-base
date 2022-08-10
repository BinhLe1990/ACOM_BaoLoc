using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using DevExpress.XtraBars.Ribbon;
using DevExpress.Utils.Drawing;
using System.Collections;
using DELFI_WHM.NET.FrHT;
using System.Diagnostics;

namespace DELFI_WHM.NET
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_Class.DELFIConnection(Program.sServerName, Program.sUserName, Program.SPassword, Program.sDatabaseName);
        clsRun clsRun = new clsRun();
        public frmMain()
        {
            InitializeComponent();
            InitSkinGallery();
            lblNGUOI_DUNG.Caption = " Người dùng: " + Properties.Settings.Default.FULL_NAME + " (" + Properties.Settings.Default.USER_NAME + ")";
            lblDate.Caption = DateTime.Now.ToString("dd/MM/yyyy");
            lblFrmName.Caption = "";
            lblTime.Caption = DateTime.Now.ToString("hh:mm:ss tt");
            lblSystem.Caption = Program.sServerName + " -> " + Program.sDatabaseName + "; RN:" + Properties.Settings.Default.Registry_Name;
            timeTime.Start();

            ribbon.ForceInitialize();
            SetPermit();
            cnn.History();
            Program.sConnection = cnn.ConnectionString;
            try
            {
                this.BackgroundImage = clsRun.GetHinhAnh(Program.sPathHinhAnh).Image;
                this.BackgroundImageLayout = ImageLayout.Zoom;
            }
            catch (Exception) { }
        }
        private void SetPermit()
        {
            if (Properties.Settings.Default.USER_NAME.ToLower() == "supervisor" || Properties.Settings.Default.USER_NAME.ToLower() == "administrator")
            {
                btnPasschange.Caption = "Reset Mật khẩu";
                return;
            }
            string sPermit = Properties.Settings.Default.PER_MENU_NGANG;
            string sPTmp = "";
            if (!Properties.Settings.Default.PER_MENU_NGANG.Contains("|btnThamSoSQL|=1|"))
                btnSQLQuery.Enabled = false;
            foreach (DevExpress.XtraBars.Ribbon.RibbonPage ribPage in ribbon.Pages)
            {
                sPTmp = "|" + ribPage.Name + "|";
                if (sPermit.IndexOf(sPTmp) >= 0)
                    ribPage.Visible = true;
                else
                    ribPage.Visible = false;
                foreach (DevExpress.XtraBars.Ribbon.RibbonPageGroup ribGroup in ribPage.Groups)
                {
                    sPTmp = "|" + ribGroup.Name + "|";
                    if (sPermit.IndexOf(sPTmp) >= 0)
                        ribGroup.Visible = true;
                    else
                        ribGroup.Visible = false;
                    foreach (object objItem in ribGroup.ItemLinks)
                    {
                        if (objItem.GetType().FullName.Equals("DevExpress.XtraBars.BarButtonItemLink"))
                        {
                            DevExpress.XtraBars.BarButtonItemLink btnItem = (DevExpress.XtraBars.BarButtonItemLink)objItem;
                            sPTmp = "|" + btnItem.Item.Name + "|";
                            if (sPermit.IndexOf(sPTmp) >= 0)
                                btnItem.Item.Visibility = BarItemVisibility.Always;
                            else
                                btnItem.Item.Visibility = BarItemVisibility.Never;
                        }
                        else
                        {
                            if (objItem.GetType().FullName.Equals("DevExpress.XtraBars.BarSubItemLink"))
                            {
                                DevExpress.XtraBars.BarSubItemLink btnItemLink = (DevExpress.XtraBars.BarSubItemLink)objItem;
                                sPTmp = "|" + btnItemLink.Item.Name + "|";
                                if (sPermit.IndexOf(sPTmp) >= 0)
                                    btnItemLink.Item.Visibility = BarItemVisibility.Always;
                                else
                                    btnItemLink.Item.Visibility = BarItemVisibility.Never;
                                foreach (DevExpress.XtraBars.BarButtonItemLink btnItemAdd in btnItemLink.Item.ItemLinks)
                                {
                                    sPTmp = "|" + btnItemAdd.Item.Name + "|";
                                    if (sPermit.IndexOf(sPTmp) >= 0)
                                        btnItemAdd.Item.Visibility = BarItemVisibility.Always;
                                    else
                                        btnItemAdd.Item.Visibility = BarItemVisibility.Never;
                                }
                            }
                        }
                    }
                }
            }
            //Menu Doc
            sPermit = Properties.Settings.Default.PER_MENU_DOC;
            sPTmp = "";
            foreach (object objItem in pmAppMain.ItemLinks)
            {
                if (objItem.GetType().FullName.Equals("DevExpress.XtraBars.BarButtonItemLink"))
                {
                    DevExpress.XtraBars.BarButtonItemLink btnItem = (DevExpress.XtraBars.BarButtonItemLink)objItem;
                    sPTmp = "|" + btnItem.Item.Name + "|";
                    if (sPermit.IndexOf(sPTmp) >= 0)
                        btnItem.Item.Visibility = BarItemVisibility.Always;
                    else
                        btnItem.Item.Visibility = BarItemVisibility.Never;
                }
                else
                {
                    if (objItem.GetType().FullName.Equals("DevExpress.XtraBars.BarSubItemLink"))
                    {
                        DevExpress.XtraBars.BarSubItemLink btnItemLink = (DevExpress.XtraBars.BarSubItemLink)objItem;
                        sPTmp = "|" + btnItemLink.Item.Name + "|";
                        if (sPermit.IndexOf(sPTmp) >= 0)
                            btnItemLink.Item.Visibility = BarItemVisibility.Always;
                        else
                            btnItemLink.Item.Visibility = BarItemVisibility.Never;
                        foreach (DevExpress.XtraBars.BarButtonItemLink btnItemAdd in btnItemLink.Item.ItemLinks)
                        {
                            sPTmp = "|" + btnItemAdd.Item.Name + "|";
                            if (sPermit.IndexOf(sPTmp) >= 0)
                                btnItemAdd.Item.Visibility = BarItemVisibility.Always;
                            else
                                btnItemAdd.Item.Visibility = BarItemVisibility.Never;
                        }
                    }
                }
            }
            sPermit = Properties.Settings.Default.PER_SYSTEM;
            if (!sPermit.Contains("|HT|=1"))
            {
                btnSQLQuery.Enabled = false;
                btnThamSoSQL.Enabled = false;
                btnSQLQueryAna.Enabled = false;
                btnImport.Enabled = false;
                btnSystem.Enabled = false;
                btnRestore.Enabled = false;
            }
            if (Properties.Settings.Default.USER_NAME != "Administrator" && Properties.Settings.Default.USER_NAME != "Supervisor")
            {
                btnSQLQuery.Enabled = false;
                btnThamSoSQL.Enabled = false;
                btnSQLQueryAna.Enabled = false;
            }
            if (Properties.Settings.Default.QUYENPHANQUYEN == false)
            {
                btnCreateUser.Enabled = false;
                btnPermit.Enabled = false;
            }
            if (Properties.Settings.Default.USER_ID == "3")
            {
                btnCreateUser.Enabled = true;
                btnPermit.Enabled = true;
            }
        }
        #region SkinGallery
        void InitSkinGallery()
        {
            SimpleButton imageButton = new SimpleButton();
            foreach (SkinContainer cnt in SkinManager.Default.Skins)
            {
                imageButton.LookAndFeel.SetSkinStyle(cnt.SkinName);
                GalleryItem gItem = new GalleryItem();
                rgbiSkins.Gallery.Groups[0].Items.Add(gItem);
                gItem.Caption = cnt.SkinName;

                gItem.Image = GetSkinImage(imageButton, 32, 17, 2);
                gItem.HoverImage = GetSkinImage(imageButton, 70, 36, 5);
                gItem.Caption = cnt.SkinName;
                gItem.Hint = cnt.SkinName;
                //rgbiSkins.Gallery.Groups[1].Visible = false;
            }
        }
        Bitmap GetSkinImage(SimpleButton button, int width, int height, int indent)
        {
            Bitmap image = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(image))
            {
                StyleObjectInfoArgs info = new StyleObjectInfoArgs(new GraphicsCache(g));
                info.Bounds = new Rectangle(0, 0, width, height);
                button.LookAndFeel.Painter.GroupPanel.DrawObject(info);
                button.LookAndFeel.Painter.Border.DrawObject(info);
                info.Bounds = new Rectangle(indent, indent, width - indent * 2, height - indent * 2);
                button.LookAndFeel.Painter.Button.DrawObject(info);
            }
            return image;
        }
        private void rgbiSkins_Gallery_ItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            Properties.Settings.Default.SKIN_CAPTION = e.Item.Caption;
            Properties.Settings.Default.Save();
            Hashtable Val = new Hashtable();
            Val.Add("KIEUGIAODIEN", e.Item.Caption);
            Hashtable Con = new Hashtable();
            Con.Add("NGUOIDUNG", Properties.Settings.Default.USER_ID);
            cnn.UpdateRows(Val, Con, "HT_NGUOIDUNG");
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(e.Item.Caption);
        }

        private void rgbiSkins_Gallery_InitDropDownGallery(object sender, DevExpress.XtraBars.Ribbon.InplaceGalleryEventArgs e)
        {
            e.PopupGallery.CreateFrom(rgbiSkins.Gallery);
            e.PopupGallery.AllowFilter = false;
            e.PopupGallery.ShowItemText = true;
            e.PopupGallery.ShowGroupCaption = true;
            e.PopupGallery.AllowHoverImages = false;
            foreach (GalleryItemGroup galleryGroup in e.PopupGallery.Groups)
                foreach (GalleryItem item in galleryGroup.Items)
                    item.Image = item.HoverImage;
            e.PopupGallery.ColumnCount = 2;
            e.PopupGallery.ImageSize = new Size(70, 36);
        }
        #endregion
        private bool IsActiveForm(string sFormName)
        {
            foreach (Form fTmp in this.MdiChildren)
            {
                if (fTmp.Name.ToUpper().Equals(sFormName.ToUpper()))
                {
                    fTmp.Activate();
                    return true;
                }
            }
            return false;
        }
        private void timeTime_Tick(object sender, EventArgs e)
        {
            lblTime.Caption = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void btnPermit_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new FrHT.FrND.frmPhanQuyenSuDung(ribbon, pmAppMain)).ShowDialog();
        }

        private void btnCreateUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new FrHT.FrND.frmTaoNguoiDung(ribbon)).ShowDialog();
        }

        private void btnDANH_MUC_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IsActiveForm("frmDM_DanhMucHeThong"))
                return;
            FrDM.frmDM_DanhMucHeThong frm = new DELFI_WHM.NET.FrDM.frmDM_DanhMucHeThong();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnPasschange_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Properties.Settings.Default.USER_NAME.ToLower() == "administrator" || Properties.Settings.Default.USER_NAME.ToLower() == "supervisor")
                (new FrHT.FrND.frmDoiMatKhau()).ShowDialog();
            else
                (new FrHT.FrND.frmNDDoiMatKhau()).ShowDialog();    
        }

        private void btnLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(XtraMessageBox.Show(this, "Bạn có chắc là đăng nhập lại chương trình hay không?","Đăng nhập lại", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                Dispose();
                Application.Restart();
            }
        }

        private void btnPass_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new FrHT.FrND.frmNDDoiMatKhau()).ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show(this, "Bạn có chắc là thoát khỏi chương trình hay không?", "Thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cnn.ExecuteNonQuery("UPDATE HT_NHATKY SET KETTHUC = GETDATE() WHERE NHATKY = " + cnn.inhatky.ToString());
                Dispose();
                Application.Exit();
            }
            else
                e.Cancel = true;
        }
        
        /// <summary>
        /// Hàm mở Form
        /// </summary>
        /// <param name="ff">Form cần mở</param>
        /// <param name="ShowProcess">Hiển thị process</param>
        /// <param name="ShowDialog">Hiển thị kiểu Hộp thoại hay không?</param>
        private void OpenForm(Form ff, bool ShowProcess, bool ShowDialog)
        {
            if(IsActiveForm(ff.Name))
                return;
            if (ShowProcess)
            {
                frmProcess frm = new frmProcess(ff, ShowDialog, this);
                if (!ShowDialog)
                    ff.MdiParent = this;
                frm.ShowDialog();
            }
            else
            {
                if (!ShowDialog)
                {
                    ff.MdiParent = this;
                    ff.Show();
                }
                else
                    ff.ShowDialog();
            }
        }

        private void btnThamSoSQL_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IsActiveForm("frmThamSoSQL"))
                return;
            FrSYS.frmThamSoSQL frm = new DELFI_WHM.NET.FrSYS.frmThamSoSQL();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnImport_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IsActiveForm("frmImportData"))
                return;
            FrHT.frmImportData frm = new frmImportData();
            frm.MdiParent = this;
            frm.Show();
        }
        
        private void ribbon_ShowCustomizationMenu(object sender, RibbonCustomizationMenuEventArgs e)
        {
            e.ShowCustomizationMenu = false;
        }

        private void btnBTClose_Click(object sender, EventArgs e)
        {
            Close();
        }   

        private void btnAnHien_ItemClick(object sender, ItemClickEventArgs e)
        {
            ribbon.Minimized = !ribbon.Minimized;
        }

        private void btnBackup_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new HeThong.FrHT.frmBackup()).ShowDialog();
        }

        private void btnRestore_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Để phục hồi dữ liệu, chương trình phải khởi động lại để ngắt các kết nối vào Cơ sở dữ liệu. Bạn có chắc không?", "Phục hồi dữ liệu", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            Properties.Settings.Default.Restore_Mode = true;
            Properties.Settings.Default.Save();
            Dispose();
            Application.Restart();
        }

        private void btnSystem_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new HeThong.frmHeThong()).ShowDialog();
        }

        private void frmMain_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
                if (xtraTabbedMdiManager1.MdiParent != this)
                    xtraTabbedMdiManager1.MdiParent = this;
        }

        private void xtraTabbedMdiManager1_PageRemoved(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {
            if (this.MdiChildren.Length == 0)
                xtraTabbedMdiManager1.MdiParent = null;
        }

        private void btnONH_BaoCao_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrReport.frmMainViewReport frm = new DELFI_WHM.NET.FrReport.frmMainViewReport();
            frm.Show();
        }

        private void btnEditReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrReport.frmReportDesign frm = new DELFI_WHM.NET.FrReport.frmReportDesign();
            frm.Show();
        }

        private void btnSQLQueryAna_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IsActiveForm("frmSQLAnalyzer"))
                return;
            FrSYS.frmSQLAnalyzer frm = new DELFI_WHM.NET.FrSYS.frmSQLAnalyzer();
            frm.MdiParent = this;
            frm.Show();
        }

        private void xtraTabbedMdiManager1_SelectedPageChanged(object sender, EventArgs e)
        {
            try
            {
                lblFrmName.Caption = xtraTabbedMdiManager1.SelectedPage.Text + " - " + xtraTabbedMdiManager1.SelectedPage.MdiChild.Name;
            }
            catch
            {
                lblFrmName.Caption = "";
            }
        }

        private void btnSQLQuery_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IsActiveForm("frmThamSoSQL"))
                return;
            FrSYS.frmThamSoSQL frm = new DELFI_WHM.NET.FrSYS.frmThamSoSQL();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new frmThongTinCoQuan(), true, true);
        }

        private void btnHelp_ItemClick(object sender, ItemClickEventArgs e)
        {
            //if (this.ActiveMdiChild == null)
            //{
            //    Help.ShowHelp(this, Application.StartupPath+@"/Help/Help.chm");
            //    return;
            //}
            //if (cnn.sNull2String(this.ActiveMdiChild.AccessibleDescription) == "")
            //    return;
            //Help.ShowHelp(this.ActiveMdiChild, Application.StartupPath + @"/Help/Help.chm", HelpNavigator.Index, this.ActiveMdiChild.AccessibleDescription);
            //Help.ShowHelp(this.ActiveMdiChild, Application.StartupPath + @"/Help/Help.chm", HelpNavigator.KeywordIndex, this.ActiveMdiChild.AccessibleDescription);
            //OpenForm(new frmAbout(), false, true);
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new frmWebBrowser(), false, false);
        }

        private void btnLogUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new HeThong.FrND.frmNhatKyNguoiDung(), false, false);
        }

        private void lblTime_ItemDoubleClick(object sender, ItemClickEventArgs e)
        {
            Process pr = new Process();
            pr.StartInfo = new ProcessStartInfo("timedate.cpl");
            pr.Start();
        }
        
        private void btnHoSoGiaoVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new NhanSu.frmHoSoNhanSu(), false, false);
        }   

        private void barButtonItem6_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            OpenForm(new frmAbout(), false, true);
        }

        private void btnChamCongNgay_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new Luong.frmChamCongNgay(), false, false);
        }

        private void btnChamCongThang_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new Luong.frmChamCongThang(), false, false);
        }

        private void btnThongKeNghiPhep_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new Luong.frmThongKeNghiPhep(), false, false);
        }

        private void btnHopDongLaoDong_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new NhanSu.frmHopDongLaoDong(), false,true);
        }

        private void btnThongKeLoaiHD_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new NhanSu.frmThongKeTheoLoaiHD(), false, false);
        }

        private void btnNhanSuSapHetHan_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new NhanSu.frmNhanSuSapHetHanHD(), false, false);
        }

        private void btnNhanSuChuaTangLuong_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new NhanSu.frmNhanSuChuaTangLuong(), false, false);
        }

        private void btnQuanHeGiaDinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new NhanSu.frmQuanHeGiaDinh(), false, true);
        }

        private void btnChuyenPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new NhanSu.frmChuyenPhong(), false, false);
        }

        private void btnDanhMaNhanSu_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new NhanSu.frmDanhMaNhanSu(), false, false);
        }

        private void btnTongHopQuaTrinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new NhanSu.frmTongHopQuaTrinh(), false, false);
        }

        private void btnKhauTruTrongThang_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new Luong.frmKhauTruTrongThang(), false, false);
        }

        private void btnSoLuong_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new Luong.frmSoLuong(), false, false);
        }

        private void btnThuong_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new Luong.frmThuong(), false, false);
        }       

        private void btnBangPhuCap_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new Luong.frmBangPhuCap(), false, false);
        }

        private void btnBangLuongKy2_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new Luong.frmBangLuong(), false, false);
        }

        private void btnTongHopTienLuongThuong_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new Luong.frmTongHopTienLuong_Thuong(), false, false);
        }

        private void btnTongHopTienLuongTheoChucDanh_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new Luong.frmTongHopTienLuongTheoChucDanh(), false, false);
        }

        private void btnXetTangLuong_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new Luong.frmXetTangLuong(), false, false);
        }

        private void btnHinhNen_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new frmThayDoiHinhNem(), false, true);
        }

        private void btnThuLaoGiangDay_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new Luong.frmThuLaoGiangDay(), false, false);
        }

        private void btnThuNhapKhac_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new Luong.frmThuNhapKhac(), false, false);
        }

        private void btnBaoCaoThongKe_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new NhanSu.frmBC_TKToChucCanBo(), false, false);
        }

        private void btnBaoCaoThuNhapTheoNhanSu_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new Luong.frmTongHopThuNhap(), false, false);
        }

        private void btnThanhToanLuongNganHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new Luong.frmThanhToanLuongQuaNganHang(), false, false);
        }

        private void btnXuatHoaDon_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new Luong.frmXuatHoaDonDo(), false, true);
        }

        private void btnThongKeHoaDonXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new Luong.frmThongKeHoaDonXuat(), false, false);
        }

        private void btnInTemLuong_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new Luong.frmInTemLuong(), false, false);
        }

        private void btnXetGiamTruGiaCanh_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new Luong.frmXetGiamTruGiaCanh(), false, false);
        }

        private void btnLapQuyetToanTheoQuy_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new Luong.frmQuyetToanQuy(), false, false);
        }

        private void btnLapQuyetToanNam_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new Luong.frmQuyetToanNam(), false, false);
        }

        private void btnTongHopLuongTheoPhongBan_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new Luong.frmTongHopLuongTheoPhongBan(), false, false);
        }

        private void btnImportThuLaoGiangDay_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new Luong.frmThuLaoGiangDay_ChiTiet(), false, false);
        }

        private void btnNhanSu_BaoHiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new Luong.frmNhanSu_BaoHiem(), false, false);
        }

        private void btnQuyetToanThueNam_ThinhGiang_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new Luong.frmQuyetToanNam_ThinhGiang(), false, false);
        }

        private void btnThongKeThayDoiLuong_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new Luong.frmThongKeThayDoiLuong(), false, false);
        }

        private void btnDenHanNghiHuu_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new NhanSu.frmDanhSachDenHanNghiHuu(), false, false);
        }

        private void btnTruyThu_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new Luong.frmTruyThu(), false, false);
        }

        private void btnDuLieuChuyenKhoanATM_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new Luong.frmThanhToanLuongQuaATM(), false, false);
        }

        private void btnPhuCapGioPhuTroi_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new Luong.frmPhuCapGioPhuTroi(), false, false);
        }

        private void btnPhuCapABC_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new Luong.frmPhuCapABC(), false, false);
        }

        private void btnXetTangThamNienGD_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new Luong.frmXetTangThamNienGD(), false, false);
        }

        private void btnThongKeNhanVienTheoTuoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new NhanSu.frmThongKeNhanVienTheoDoTuoi(), false, false);
        }

        private void btnXetThiDua_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new NhanSu.frmXetThiDua(), false, false);
        }

        private void btnThongKeThiDua_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new NhanSu.frmThongKeThiDua(), false, false);
        }

        private void btnNhaCungCap_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new KhoHang.frmNhaCungCap(), false, false);
        }

        private void btnHangHoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new KhoHang.frmHangHoa(), false, false);
        }

        private void btnNhapHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new KhoHang.frmNhapHangHoa(), false, false);
        }

        private void btnNhapKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new KhoHang.frmImportDanhSachKhachHang(), false, false);
        }

        private void btnCheck_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new KhoHang.frmCheckCustommer(), false, false);
        }

        private void btnSuKien_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new SuKien.frmNhapDSSuKien(), false, false);
        }

        private void btnThongTinCoQuan_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new frmThongTinCoQuan(), true, true);
        }
    }
}