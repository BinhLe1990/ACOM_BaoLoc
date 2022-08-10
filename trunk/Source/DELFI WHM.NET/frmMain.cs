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
using System.Linq;
using DELFI_WHM.NET.Models;
using System.Net.Sockets;
using System.Threading;
using System.IO.Ports;
using DELFI_WHM.NET.DELFI_Class;

namespace DELFI_WHM.NET
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_Class.DELFIConnection(Program.sServerName, Program.sUserName, Program.SPassword, Program.sDatabaseName);
        public static string Access_Connection = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Database.mdb";
        clsRun clsRun = new clsRun();
        public frmMain()
        {
            InitializeComponent();
            InitSkinGallery();
            lblNGUOI_DUNG.Caption = " Người dùng: " + Properties.Settings.Default.FULL_NAME + " (" + Properties.Settings.Default.USER_NAME + ")";
            lblDate.Caption = DateTime.Now.ToString("dd/MM/yyyy");
            lblFrmName.Caption = "";
            lblTime.Caption = DateTime.Now.ToString("hh:mm:ss tt");
            //lblSystem.Caption = Program.sServerName + " -> " + Program.sDatabaseName;
                //+ "; RN:" + Properties.Settings.Default.Registry_Name;
            timeTime.Start();

            ribbon.ForceInitialize();
            SetPermit();
            //cnn.History();
            try
            {
                Program.sConnection = cnn.ConnectionString;
                try
                {
                    this.BackgroundImage = clsRun.GetHinhAnh(Program.sPathHinhAnh).Image;
                    this.BackgroundImageLayout = ImageLayout.Zoom;
                }
                catch (Exception) { }
            }
            catch { }
        }
        private void SetPermit()
        {
            if (Properties.Settings.Default.USER_NAME.ToLower() == "supervisor" || Properties.Settings.Default.USER_NAME.ToLower() == "administrator" || Properties.Settings.Default.USER_NAME.ToLower() == "delfi" || Properties.Settings.Default.USER_NAME.ToLower() == "nmphuoc")
            {
                btnPasschange.Caption = "Reset Mật khẩu";
                ribQL_HE_THONG.Visible = true;
                return;
            }
            string sPermit = Properties.Settings.Default.PER_MENU_NGANG;
            string sPTmp = "";
            if (!Properties.Settings.Default.PER_MENU_NGANG.Contains("|btnThamSoSQL|=1|"))
                //btnSQLQuery.Enabled = false;
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
                btnThamSoSQL.Enabled = false;
                btnSystem.Enabled = false;
            }
            if (Properties.Settings.Default.USER_NAME != "Administrator" && Properties.Settings.Default.USER_NAME != "Supervisor")
            {
                btnThamSoSQL.Enabled = false;
            }
            //using (DBACOMEntities db = new DBACOMEntities())
            //{
                //var quyenphanquyen = db.HT_NGUOIDUNG.Where(c => c.TAIKHOAN == Properties.Settings.Default.USER_NAME && c.QUYENPHANQUYEN == true).ToList();
                //if (quyenphanquyen.Count> 0)
                //{
                    //btnCreateUser.Enabled = true;
                    //btnPermit.Enabled = true;
                //}
                //else
                //{
                //    btnCreateUser.Enabled = false;
                //    btnPermit.Enabled = false;
                //}
            //}
            //if (Properties.Settings.Default.QUYENPHANQUYEN == false)
            //{
            //    btnCreateUser.Enabled = false;
            //    btnPermit.Enabled = false;
            //}
            //else
            //{
            //    btnCreateUser.Enabled = true;
            //    btnPermit.Enabled = true;
            //}
            //if (Properties.Settings.Default.USER_ID == "3")
            //{
            //    btnCreateUser.Enabled = true;
            //    btnPermit.Enabled = true;
            //}
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
            (new FrHT.FrND.frmDanhSachNguoiDung(ribbon, pmAppMain)).ShowDialog();
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
            if (Properties.Settings.Default.USER_NAME.ToLower() == "administrator" || Properties.Settings.Default.USER_NAME.ToLower() == "supervisor" || Properties.Settings.Default.USER_NAME.ToLower() == "nmphuoc" || Properties.Settings.Default.USER_NAME.ToLower() == "delfi")
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
                //cnn.ExecuteNonQuery("UPDATE HT_NHATKY SET KETTHUC = GETDATE() WHERE NHATKY = " + cnn.inhatky.ToString());
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
            if (ff.Name == "frmKetnoican")
                ff.Hide();
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

        private void barButtonItem6_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            OpenForm(new frmAbout(), false, true);
        }

        private void btnHinhNen_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new frmThayDoiHinhNem(), false, true);
        }

        private void btnThongTinCoQuan_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new frmThongTinCoQuan(), true, true);
        }

        private void barCauHinhLinkSync_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new CauHinh.frmCauHinhSyncDuLieu(), false, false);
        }

        private void barTaoNguoiDung_ItemClick(object sender, ItemClickEventArgs e)
        {
            (new FrHT.FrND.frmTaoNguoiDung()).ShowDialog();
        }

        #region Menu Cấu Hình

        private void barSanPham_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new CauHinh.frmSanPham(), false, false);
        }

        private void barPackingUnits_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new CauHinh.frmCauHinhPackingUnits(), false, false);
        }

        private void barSoLot_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new CauHinh.frmCauHinhLot(), false, false);
        }

        private void barCropyear_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new CauHinh.frmCropYear(), false, false);
        }

        private void barLocation_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new CauHinh.frmLocations(), false, false);
        }

        private void barNhaVanChuyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new CauHinh.frmNhaVanChuyen(), false, false);
        }

        private void barKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new CauHinh.frmKhachHang(), false, false);
        }
        #endregion


        #region Menu Quản lý
        private void barYeuCauGiaoHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new QuanLy.frmYeuCauGiaoHang(), false, false);
        }

        private void barLenhSanXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new QuanLy.frmLenhSanXuat(), false, false);
        }

        private void barHopDongMuaHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new QuanLy.frmHopDongMuaHang(), false, false);
        }

        private void barPhieuCan_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new QuanLy.fmPhieuCan(), false, false);
        }

        private void barUpDateSP_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new QuanLy.frmThongTinSP(), false, false);
        }
        #endregion


        private void barTachXuatKhoDu_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new XuatKho.frmDS_TachPallet(), false, false);
        }

        private void barXuatKhoNguyenVatLieu_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        #region
        private void barNhapkhoTuBoPhanSanXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
           
                OpenForm(new NhapKho.frmDS_NhapKhoTuSX(), false, false);
        }

        private void barNhapKhoNguyenVatLieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            //OpenForm(new NhapKho.frmNhapKhoThanhPham(), false, false);
        }
       

        private void barNhapKhoThanhPham_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new NhapKho.frmNhapKhoThanhPham(), false, false);
        }


        private void barNhapKhac_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new NhapKho.frmNhapKhoKhac(), false, false);
        }

        #endregion

        private void barCanCau_ItemClick(object sender, ItemClickEventArgs e)
        {
                OpenForm(new CanCau.frmCanCau(), false, false);
        }

        private void barButtonItem13_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            OpenForm(new CauHinh.frmCauHinh_LoaiBao(), false, false);
        }

        private void barButtonItem15_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            OpenForm(new SanXuat.frmDS_SanXuat(), false, false);
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new XuatKho.frmDS_XuatKho(), false, false);
        }

        private void barBaoCaoNhapHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new BaoCao.frmNhapTuNCC(), false, false);
        }

        private void barBaoCaoCanXe_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new BaoCao.fmPhieuCan(), false, false);
        }

        private void barBaoCaoXuatKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new BaoCao.frmXuatKho(), false, false);
        }

        private void barBaoCaoTonKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new BaoCao.frmTonKho(), false, false);
        }

        private void barBaoCaoTongHop_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new BaoCao.frmTongHop(), false, false);
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new CauHinh.frmCauHinhCanTuDong(), false, false);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ribbon.Minimized = !ribbon.Minimized;            
            OpenPort_1();
            OpenPort_3();
            //OpenForm(new QuanLy.frmKetnoican(), false, false);
            
        }

        private void btnKetnoican_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new QuanLy.frmKetnoican(), false, false);
        }

        #region Connect Cân Cầu

        private TcpListener _tcplistener_1;
        private Thread _listenThread_1;
        private static Thread _threadConnect_1;
        private TcpClient _tcpClient_1;
        private TcpClient _myClient_1;
        string _bufferincmessage_1;
        private int _typeConnect_1;
        private SerialPort _serialPort_1;     
        int TrongLuongCan_1 = 0;
        /// <summary>
        /// Mở port cho cổng COM1
        /// </summary>        

        private Parity GetParity_1(string parity_1)
        {
            var parityFullName_1 = Parity.None;
            switch (parity_1)
            {
                case ParityContant.NoneKey:
                    parityFullName_1 = Parity.None;
                    break;
                case ParityContant.EvenKey:
                    parityFullName_1 = Parity.Even;
                    break;
                case ParityContant.OddKey:
                    parityFullName_1 = Parity.Odd;
                    break;
                case ParityContant.MarkKey:
                    parityFullName_1 = Parity.Mark;
                    break;
                case ParityContant.SpaceKey:
                    parityFullName_1 = Parity.Space;
                    break;
            }

            return parityFullName_1;
        }

        private StopBits GetStopBits_1(string stopBits_1)
        {
            var stopBitsFullName_1 = StopBits.One;
            switch (stopBits_1)
            {
                case "1":
                    stopBitsFullName_1 = StopBits.One;
                    break;
                case "1.5":
                    stopBitsFullName_1 = StopBits.OnePointFive;
                    break;
                case "2":
                    stopBitsFullName_1 = StopBits.Two;
                    break;
                default:
                    stopBitsFullName_1 = StopBits.None;
                    break;
            }

            return stopBitsFullName_1;
        }

        void SetStatus_1(int _status_1, TextBox lbl)
        {
            this.Invoke(new EventHandler(delegate
            {
                if (_status_1 == 0)
                {//Stop
                    lbl.Text = "Disconnected";
                    lbl.ForeColor = Color.Red;
                }
                else if (_status_1 == 1)
                { //Waitting...
                    lbl.Text = "Waiting...";
                    lbl.ForeColor = Color.Yellow;
                }
                else if (_status_1 == 2)
                { //Opening...
                    lbl.Text = "Connected";
                    lbl.ForeColor = Color.Lime;
                }
            }));
        }

        private void Receive_1(Socket handler, string msg_1)
        {            
            Invoke(new EventHandler(delegate
            {                 
                ReceiveData_1(msg_1);
            }));
        }
        bool receiving_1 = false;

        private void Receive_1(string msg_1)
        {
                Invoke(new EventHandler(delegate
                {
                    string[] tempArray_1 = txtLogDecrypt.Lines;
                    if (txtLogDecrypt.Text.Length >= 12)
                    {
                        txtLogDecrypt.Clear();
                    }
                    //if (tempArray_1.Length >= 4)
                    //{
                    //    txtLogDecrypt.Clear();
                    //}
                    ReceiveData_1(msg_1);
                }));
                //string[] tempArray_1 = txtLogDecrypt.Lines;
                //if ( tempArray_1.Length >= 4)
                //{
                //    txtLogDecrypt.Clear();
                //}
                //ReceiveData_1(msg_1);         
        }

        private void ReceiveData_1(string msg_1)
        {
            //txtLogDecrypt.AppendText(string.Format("[R]: {0}{1}", msg_1, Environment.NewLine));
            //txtLogDecrypt.SelectionStart = txtLogDecrypt.Text.Length - 1;
            //txtLogDecrypt.ScrollToCaret();
            //receiving_1 = true;
            txtLogDecrypt.AppendText(msg_1.Replace(Environment.NewLine, "").Replace(" ", ""));
            txtLogDecrypt.SelectionStart = txtLogDecrypt.Text.Length - 1;
            txtLogDecrypt.ScrollToCaret();
            receiving_1 = true;
        }

        void serialPort_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            //var serialPort_1 = (SerialPort)sender;
            //if (!serialPort_1.IsOpen || serialPort_1.BytesToRead <= 0) return;
            //var array_1 = new byte[serialPort_1.BytesToRead];
            //serialPort_1.Read(array_1, 0, array_1.Length);
            //_bufferincmessage_1 = Encoding.ASCII.GetString(array_1);
            //Receive_1(_bufferincmessage_1);

            var serialPort_1 = (SerialPort)sender;
            if (!serialPort_1.IsOpen || serialPort_1.BytesToRead <= 0) return;
            var array_1 = new byte[serialPort_1.BytesToRead];
            serialPort_1.Read(array_1, 0, array_1.Length);
            _bufferincmessage_1 = Encoding.ASCII.GetString(array_1);
            Receive_1(_bufferincmessage_1);
        }

        private void OpenPort_1()
        {
                using (DBACOMEntities db = new DBACOMEntities())
                {
                    var list = db.tblConfigScale.Where(c => c.ID == 2).FirstOrDefault();
                    textBox2.Text = list.IPServer + ":" +
                                    list.MaxSpeed + ":" +
                                    list.Parity + ":" +
                                    list.DataBits + ":" +
                                    list.StopBits;
                }           
            try
            {
                if (string.IsNullOrEmpty(textBox2.Text)) return;
                var split_1 = textBox2.Text.Split(':');
                if (split_1.Length <= 0) return;
                _serialPort_1 = new SerialPort
                {
                    RtsEnable = true,
                    DtrEnable = true,
                    PortName = split_1[0],
                    BaudRate = int.Parse(split_1[1]),
                    Parity = GetParity_1(split_1[2]),
                    DataBits = int.Parse(split_1[3]),
                    StopBits = GetStopBits_1(split_1[4]),
                    ReadBufferSize = 10240,
                    WriteBufferSize = 10240,
                    ReadTimeout = 500,
                };
                _typeConnect_1 = 3;
                _serialPort_1.DataReceived += serialPort_DataReceived_1;
                _serialPort_1.Open();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void txtLogDecrypt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtLogDecrypt.Text.Length >= 12)
                {              
                    textBox3.Text = txtLogDecrypt.Text.Substring(txtLogDecrypt.Text.IndexOf("+", 1) + 1, 6);
                    try
                    {
                        TrongLuongCan_1 = Convert.ToInt32(textBox3.Text);
                        numericUpDown2.Value = TrongLuongCan_1;
                    }
                    catch
                    {
                        numericUpDown2.Value = 0;
                    }
                }

            }
            catch
            {
                numericUpDown2.Value = 0;
            }
            //try
            //{
            //    string[] tempArray_1 = txtLogDecrypt.Lines;
            //    if (tempArray_1.Length >= 4)
            //    {
            //        for (int i = tempArray_1.Length - 1; i >= tempArray_1.Length - 4; i--)
            //        {
            //            if (tempArray_1[i].Contains("k"))
            //            {
            //                textBox3.Text = tempArray_1[i].Replace(" ", "").Replace("[R]:", "").Replace("k", "");
            //                try
            //                {
            //                    TrongLuongCan_1 = Convert.ToInt32(textBox3.Text);
            //                    numericUpDown2.Value = TrongLuongCan_1;                                 
            //                }
            //                catch
            //                {                                
            //                    numericUpDown2.Value = 0;
            //                }
            //            }
            //        }
            //    }
            //}
            //catch
            //{               
            //    numericUpDown2.Value = 0;
            //}
        }

        public static int SoCanCau;

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            //using (DBACOMEntities db = new DBACOMEntities())
            //{
            //    tblConfigScale cb = db.tblConfigScale.Where(c => c.ID == 19).FirstOrDefault();
            //    cb.MaxSpeed = Convert.ToInt32(numericUpDown2.Value);
            //    db.SaveChanges();  
            //}
            if (Convert.ToInt32(numericUpDown2.Value) <= 0)
            {
                SoCanCau = 0;
            }
            else
            {
                SoCanCau = Convert.ToInt32(numericUpDown2.Value);
            }

        }

        #endregion Connect Cân cầu


        #region Connect Cân bàn

        private TcpListener _tcplistener_3;
        private Thread _listenThread_3;
        private static Thread _threadConnect_3;
        private TcpClient _tcpClient_3;
        private TcpClient _myClient_3;
        string _bufferincmessage_3;
        private int _typeConnect_3;
        private SerialPort _serialPort_3;
        int TrongLuongCan_3 = 0;
        /// <summary>
        /// Mở port cho cổng COM1
        /// </summary>
        private void OpenPort_3()
        {
                using (DBACOMEntities db = new DBACOMEntities())
                {
                    var list = db.tblConfigScale.Where(c => c.ID == 1).FirstOrDefault();
                    txtcom1.Text = list.IPServer;
                    txtparity.Text = list.Parity;
                    txtstopbits.Text = list.StopBits.ToString();
                    txtmaxspeed.Text = list.MaxSpeed.ToString();
                    txtdatabits.Text = list.DataBits.ToString();
                }
            try
            {
                bool portExists_3 = SerialPort.GetPortNames().Any(x => x == txtcom1.Text);
                if (portExists_3)
                {

                    _serialPort_3 = new SerialPort
                    {
                        RtsEnable = true,
                        DtrEnable = true,
                        PortName = txtcom1.Text,
                        BaudRate = int.Parse(txtmaxspeed.Text),
                        Parity = GetParity_3(txtparity.Text),
                        DataBits = int.Parse(txtdatabits.Text),
                        StopBits = GetStopBits_3(txtstopbits.Text),
                        ReadBufferSize = 10240,
                        WriteBufferSize = 10240,
                        ReadTimeout = 500,
                    };
                    _typeConnect_3 = 3;
                    _serialPort_3.DataReceived += serialPort_DataReceived_3;
                    _serialPort_3.Open();
                    //if (_serialPort_3.IsOpen)
                    //{
                    //    SetStatus(2, lblStatus);
                    //}
                    //else
                    //{
                    //    SetStatus(0, lblStatus);
                    //}
                }
                else
                {
                    lblStatus.Text = "COM note existed.";
                    lblStatus.ForeColor = Color.Red;
                }

            }
            catch (Exception ex)
            {
                //ClosePort();
                //MessageBox.Show(ex.Message);
            }
        }

        private Parity GetParity_3(string parity_3)
        {
            var parityFullName_3 = Parity.None;
            switch (parity_3)
            {
                case ParityContant.NoneKey:
                    parityFullName_3 = Parity.None;
                    break;
                case ParityContant.EvenKey:
                    parityFullName_3 = Parity.Even;
                    break;
                case ParityContant.OddKey:
                    parityFullName_3 = Parity.Odd;
                    break;
                case ParityContant.MarkKey:
                    parityFullName_3 = Parity.Mark;
                    break;
                case ParityContant.SpaceKey:
                    parityFullName_3 = Parity.Space;
                    break;
            }

            return parityFullName_3;
        }

        private StopBits GetStopBits_3(string stopBits_3)
        {
            var stopBitsFullName_3 = StopBits.One;
            switch (stopBits_3)
            {
                case "1":
                    stopBitsFullName_3 = StopBits.One;
                    break;
                case "1.5":
                    stopBitsFullName_3 = StopBits.OnePointFive;
                    break;
                case "2":
                    stopBitsFullName_3 = StopBits.Two;
                    break;
                default:
                    stopBitsFullName_3 = StopBits.None;
                    break;
            }

            return stopBitsFullName_3;
        }

        void SetStatus_3(int _status_3, TextBox lbl)
        {
            this.Invoke(new EventHandler(delegate
            {
                if (_status_3 == 0)
                {//Stop
                    lbl.Text = "Disconnected";
                    lbl.ForeColor = Color.Red;
                }
                else if (_status_3 == 1)
                { //Waitting...
                    lbl.Text = "Waiting...";
                    lbl.ForeColor = Color.Yellow;
                }
                else if (_status_3 == 2)
                { //Opening...
                    lbl.Text = "Connected";
                    lbl.ForeColor = Color.Lime;
                }
            }));
        }

        private void Receive_3(Socket handler, string msg_3)
        {
            Invoke(new EventHandler(delegate
            {
                ReceiveData_3(msg_3);
            }));
        }
        bool receiving_3 = false;
        private void Receive_3(string msg_3)
        {
            Invoke(new EventHandler(delegate
            {
            string[] tempArray_3 = txtResultCom1.Lines;
                if (tempArray_3.Length > 4)
                {
                    txtResultCom1.Clear();
                }
                ReceiveData_3(msg_3);
            }));
        }

        private void ReceiveData_3(string msg_3)
        {
            txtResultCom1.AppendText(msg_3);
            receiving_3 = true;
        }

        void serialPort_DataReceived_3(object sender, SerialDataReceivedEventArgs e)
        {
            var serialPort_3 = (SerialPort)sender;
            if (!serialPort_3.IsOpen || serialPort_3.BytesToRead <= 0) return;
            var array_3 = new byte[serialPort_3.BytesToRead];
            serialPort_3.Read(array_3, 0, array_3.Length);
            _bufferincmessage_3 = Encoding.ASCII.GetString(array_3);

            Receive_3(_bufferincmessage_3);
        }   

        
        private void txtResultCom1_TextChanged(object sender, EventArgs e)
        {
            string[] tempArray_3 = txtResultCom1.Lines;
            if (tempArray_3.Length >= 3)
            {
                for (int i = tempArray_3.Length - 1; i >= tempArray_3.Length - 3; i--)
                {
                    if (tempArray_3[i].Contains("kg"))
                    {
                        textBox1.Text = tempArray_3[i].Replace(" ", "").Replace("kg", "").Replace(".0", "");                        
                        try
                        {
                            TrongLuongCan_3 = Convert.ToInt32(textBox1.Text);
                        }
                        catch { }
                        numericUpDown1.Value = TrongLuongCan_3;
                    }
                    else
                    {
                        numericUpDown1.Value = numericUpDown1.Value;
                    }
                }
            }
        }

        public static int SoCanBan;

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //using (DBACOMEntities db = new DBACOMEntities())
            //{
            //    tblConfigScale cb = db.tblConfigScale.Where(c => c.ID == 18).FirstOrDefault();
            //    cb.MaxSpeed = Convert.ToInt32(numericUpDown1.Value);
            //    db.SaveChanges();
            //}
            if (Convert.ToInt32(numericUpDown1.Value) <= 0)
            {
                SoCanBan = 0;
            }
            else
            {
                SoCanBan = Convert.ToInt32(numericUpDown1.Value);
            }
        }

        #endregion Connect Cân bàn

        private void barButtonItem15_ItemClick_2(object sender, ItemClickEventArgs e)
        {
            OpenForm(new XuatKho.frmSoanHangSX(), false, false);
        }

        private void bar_NhapTuSX_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new BaoCao.frmNhapTuSX(), false, false);
        }

        private void bar_DNXuatHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new BaoCao.frm_DNXuatHang(), false, false);
        }

        private void bar_BC_SuaSoCan_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new BaoCao.frm_BC_SuaPhieuCan(), false, false);
        }

        private void bar_GiaoNhanSX_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new BaoCao.frm_BC_GiaoNhanSX(), false, false);
        }

        private void bar_PhieuXuatHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new BaoCao.frm_SoanHang(), false, false);
        }

        private void bar_KhoaBarCode_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new QuanLy.frm_HuyBarCode(), false, false);
        }

        private void bar_Import_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new QuanLy.frmImport(), false, false);
        }

        private void bar_XuatKhac_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new XuatKho.frmXuatKhoKhac(), false, false);
        }

        private void bar_ListBarCode_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new QuanLy.frmQRCode(), false, false);
        }

        private void bar_UpdateBin_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new QuanLy.frmChuyenCay(), false, false);
        }

        private void bar_CanLai_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new QuanLy.frmCanLai(), false, false);
        }

        private void bar_CapNhatSoBao_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new XuatKho.frmCapNhatSoBao(), false, false);
        }

        private void bar_CapNhatSoBao_PCC_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new NhapKho.frmDS_CapNhatSoBao(), false, false);
        }

        private void bar_KiemKe_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new QuanLy.fmPhieuKiemKe(), false, false);
        }

        private void bar_BCKiemKe_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new BaoCao.frm_BC_KiemKe(), false, false);
        }

        private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new BaoCao.frmBC_LenhSanXuat(), false, false);
        }

        private void barButtonItem26_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new BaoCao.frmBC_HaoHutKho(), false, false);
        }

        private void barButtonItem27_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new BaoCao.frmBC_ChuyenCay(), false, false);
        }

        private void btnEdit_PhieuCanCau_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new CapNhat.fmCapNhat_PhieuCan(), false, false);
        }

        private void barUpdate_LSX_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new SanXuat.FrmSanXuat_Update(), false, false);
        }
    }
}