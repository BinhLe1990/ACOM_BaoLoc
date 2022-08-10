using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPrinting.BarCode;
using DevExpress.XtraReports.UI;
using System.Drawing.Printing;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;

namespace DELFI_WHM.NET.BaoCaoTK
{
    public partial class frmViewReport : DevExpress.XtraEditors.XtraForm
    {
        string _sReportPath = "";
        DataTable _dtValue = new DataTable();
        DELFI_Class.DELFIConnection cnn;
        clsRun clRun = new clsRun();
        private string Par_NienHoc = "";
        public string Parameter1 = "";
        public bool bXoayDiem = false;
        public int iMon_Start = 1;
        public int iMon_End = 30;
        public int SoMonHoc = 0;
        public string[] MonHoc = new string[30];
        public string[] CachViet = new string[30];
        public string[] SoTC = new string[30];
        public bool bDiemLN = false;
        public string[] DiemLN = new string[30];
        public string[] Diem4 = new string[30];
        public int iNamHoc = DateTime.Now.Year;
        public string sHocKy = "";
        public string sTime_FromTo = "";
        public int iNamThu = 0;
        public string sKhoaHoc = "";
        public string sBacDaoTao = "";
        public string sNganh = "";
        public string sKhoa = "";
        public DateTime dTuNgay = DateTime.Now.Date;
        public DateTime dDenNgay = DateTime.Now.Date;
        public int iThang = 0;
        public int iNam = 0;
        public string sPhongBan = "";
        public string sCoSo = "";
        public string sPhanHe = "";
        public string sTuThangNam = "";
        public string sDenThangNam = "";
        public string sNganHang = "";
        public string sPhuCap = "";
        public string sThuNhapKhac = "";
        public int iQuy = 0;
        public string sDot = "";
        public string sNoiDungChuyenKhoan = "";
        public string sSoTienBangChu = "";
        public string[] NamXet = new string[6];


        public frmViewReport(string sReportPath, DataTable dtValue)
        {
            if (Properties.Settings.Default.Offline == false)
            {
                cnn = new DELFI_Class.DELFIConnection(Program.sServerName, Program.sUserName, Program.SPassword, Program.sDatabaseName);
            }
            else
            {
                cnn = new DELFI_Class.DELFIConnection(".", "sa", Program.SPassword, "DBACOM_Offline");
            }

            InitializeComponent();
            _sReportPath = sReportPath;
            _dtValue = dtValue;          
            
        }

        bool bDirect = false;

        public frmViewReport(string sReportPath, DataTable dtValue, bool bPrintDirect)
        {
            if (Properties.Settings.Default.Offline == false)
            {
                cnn = new DELFI_Class.DELFIConnection(Program.sServerName, Program.sUserName, Program.SPassword, Program.sDatabaseName);
            }
            else
            {
                cnn = new DELFI_Class.DELFIConnection(".", "sa", Program.SPassword, "DBACOM_Offline");
            }
            InitializeComponent();
            _sReportPath = sReportPath;
            _dtValue = dtValue;
            bDirect = bPrintDirect;
            LoadReport();
            if (bDirect)
                printControl1.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.PrintDirect);
        }

        private void LoadReport()
        {
            this.Text = _sReportPath;

            string[] sSplit = _sReportPath.Split(new string[] { @"\" }, StringSplitOptions.None);
            string sServerPath = Program.sPathServer + @"Report\" + sSplit[sSplit.Length - 1];
            clRun.CheckVersionReports(sServerPath, _sReportPath);
            if (_dtValue == null)
            {
                XtraMessageBox.Show("Không có dữ liệu để in!");
                return;
            }
            if (_dtValue.Rows.Count <= 0)
            {
                XtraMessageBox.Show("Không có dữ liệu để in!");
                return;
            }
            try
            {
                                
                DevExpress.XtraReports.UI.XtraReport xNew = new DevExpress.XtraReports.UI.XtraReport();
                xNew.LoadLayout(_sReportPath);
                xNew.DataSource = _dtValue;
                xNew.RequestParameters = false;
                DataTable dtInf = cnn.SelectRows("select * from ht_hethong");
                if (dtInf.Rows.Count != 0)
                {
                    try
                    {
                        xNew.Parameters["par_COQUANCHUQUAN"].Value = dtInf.Rows[0]["COQUANCHUQUAN"].ToString().ToUpper();
                    }
                    catch { }
                    try
                    {
                        xNew.Parameters["par_TENCOQUAN"].Value = dtInf.Rows[0]["TENCOQUAN"].ToString().ToUpper();
                    }
                    catch { }
                    try
                    {
                        xNew.Parameters["par_TENCOQUAN2"].Value = dtInf.Rows[0]["TENCOQUAN2"].ToString().ToUpper();
                    }
                    catch { }
                    try
                    {
                        xNew.Parameters["par_DIENTHOAI"].Value = dtInf.Rows[0]["DIENTHOAI"];
                    }
                    catch { }
                    try
                    {
                        xNew.Parameters["par_DIACHI"].Value = dtInf.Rows[0]["DIACHI"];
                    }
                    catch { }
                    try
                    {
                        xNew.Parameters["par_DIADIEM"].Value = dtInf.Rows[0]["DIADIEM"];
                    }
                    catch { }
                    try
                    {
                        xNew.Parameters["par_DOT"].Value = sDot;
                    }
                    catch { }
                    try
                    {
                        xNew.Parameters["par_NGAYKY"].Value = dtInf.Rows[0]["DIADIEM"] + ", ngày ... tháng ... năm 20...";
                    }
                    catch { }
                    try
                    {
                        xNew.Parameters["par_NOW"].Value = dtInf.Rows[0]["DIADIEM"] + ", ngày " + DateTime.Now.Day.ToString("00") + " tháng " + DateTime.Now.Month.ToString("00") + " năm " + DateTime.Now.Year;
                    }
                    catch { }
                    try
                    {
                        xNew.Parameters["par_HIEUTRUONG"].Value = dtInf.Rows[0]["HIEUTRUONG"];
                    }
                    catch { }
                    try
                    {
                        xNew.Parameters["par_TPTAIVU"].Value = dtInf.Rows[0]["TPTAIVU"];
                    }
                    catch { }
                    try
                    {
                        xNew.Parameters["par_TPDAOTAO"].Value = dtInf.Rows[0]["TPDAOTAO"];
                    }
                    catch { }
                    try
                    {
                        xNew.Parameters["par_THANG"].Value = iThang.ToString();
                    }
                    catch { }
                    try
                    {
                        xNew.Parameters["par_NAM"].Value = iNam.ToString();
                    }
                    catch { }
                    try
                    {
                        xNew.Parameters["par_TUTHANG"].Value = sTuThangNam;
                    }
                    catch { }
                    try
                    {
                        xNew.Parameters["par_DENTHANG"].Value = sDenThangNam;
                    }
                    catch { }
                    try
                    {
                        xNew.Parameters["par_NGANHANG"].Value = sNganHang;
                    }
                    catch { }
                    try
                    {
                        xNew.Parameters["par_PHONGBAN"].Value = sPhongBan;
                    }
                    catch { }
                    try
                    {
                        xNew.Parameters["par_COSO"].Value = sCoSo;
                    }
                    catch { }
                    try
                    {
                        xNew.Parameters["par_PHANHE"].Value = sPhanHe;
                    }
                    catch { }
                    try
                    {
                        xNew.Parameters["par_PHUCAP"].Value = sPhuCap;
                    }
                    catch { }
                    try
                    {
                        xNew.Parameters["par_THUNHAPKHAC"].Value = sThuNhapKhac;
                    }
                    catch { }
                    try
                    {
                        xNew.Parameters["par_TPQLSV"].Value = dtInf.Rows[0]["TPQLSV"];
                    }
                    catch { }
                }
                try
                {
                    xNew.Parameters["par_TuNgay"].Value = dTuNgay.ToString("dd/MM/yyyy");
                }
                catch { }
                try
                {
                    xNew.Parameters["par_DenNgay"].Value = dDenNgay.ToString("dd/MM/yyyy");
                }
                catch { }
                try
                {
                    xNew.Parameters["par_QUY"].Value = iQuy.ToString();
                }
                catch { }
                try
                {
                    Par_NienHoc = iNamHoc.ToString() + " - " + Convert.ToString(iNamHoc + 1);
                    xNew.Parameters["par_NIENHOC"].Value = Par_NienHoc;
                }
                catch { }
                try
                {
                    xNew.Parameters["par_HOCKY"].Value = sHocKy;
                }
                catch { }
                try
                {
                    xNew.Parameters["par_DATE"].Value = sTime_FromTo;
                }
                catch { }
                try
                {
                    xNew.Parameters["par_NAMTHU"].Value = iNamThu.ToString();
                }
                catch { }
                try
                {
                    xNew.Parameters["parameter1"].Value = Parameter1;
                }
                catch { }
                try
                {
                    xNew.Parameters["par_BangChu"].Value = sSoTienBangChu;
                }
                catch { }
                if (bXoayDiem)
                {
                    for (int i = iMon_Start; i <= iMon_End; i++)
                    {
                        try
                        {
                            xNew.Parameters["pMH" + i.ToString()].Value = MonHoc[i - 1];
                        }
                        catch { }
                        try
                        {
                            xNew.Parameters["pCV" + i.ToString()].Value = CachViet[i - 1];
                        }
                        catch { }
                        try
                        {
                            xNew.Parameters["pTC" + i.ToString()].Value = SoTC[i - 1];
                        }
                        catch { }
                    }
                }
                if (NamXet.Length > 0)
                {
                    for (int i = 1; i <= 6; i++)
                    {
                        try
                        {
                            xNew.Parameters["par_NAMXET" + i.ToString()].Value = NamXet[i - 1];
                        }
                        catch { }
                    }
                }
                if (bDiemLN)
                {
                    for (int i = iMon_Start; i <= iMon_End; i++)
                    {
                        try
                        {
                            xNew.Parameters["pDLN" + i.ToString()].Value = DiemLN[i - 1];
                        }
                        catch { }
                    }

                    for (int i = iMon_Start; i <= iMon_End; i++)
                    {
                        try
                        {
                            xNew.Parameters["pDiem4" + i.ToString()].Value = Diem4[i - 1];
                        }
                        catch { }
                    }
                }
                try
                {
                    xNew.Parameters["par_KHOAHOC"].Value = sKhoaHoc;
                }
                catch { }
                try
                {
                    xNew.Parameters["par_KHOA"].Value = sKhoa;
                }
                catch { }
                try
                {
                    xNew.Parameters["par_BACDAOTAO"].Value = sBacDaoTao;
                }
                catch { }
                try
                {
                    xNew.Parameters["par_NGANH"].Value = sNganh;
                }
                catch { }
                try
                {
                    xNew.Parameters["par_NOIDUNGCHUYENKHOAN"].Value = sNoiDungChuyenKhoan;
                }
                catch { } DevExpress.XtraReports.UI.CalculatedField Nam_Hoc = new DevExpress.XtraReports.UI.CalculatedField();
                Nam_Hoc.DisplayName = "Nam_Hoc";
                Nam_Hoc.FieldType = DevExpress.XtraReports.UI.FieldType.String;
                Nam_Hoc.Name = "Nam_Hoc";
                Nam_Hoc.Expression = "Trim([NamHoc]) + ' - ' + Trim([NamHoc]+1)";
                
                xNew.CalculatedFields.Add(Nam_Hoc);
                xNew.RequestParameters = false;  
                //printControl1.PrintingSystem = xNew.PrintingSystem;
                xNew.CreateDocument();
                DevExpress.XtraReports.UI.ReportPrintTool ReportPrintTool = new DevExpress.XtraReports.UI.ReportPrintTool(xNew);
                ReportPrintTool.AutoShowParametersPanel = false;
                printControl1.PrintingSystem = ReportPrintTool.PrintingSystem;
                //printControl1.PrintingSystem.Document.AutoFitToPagesWidth = 1;
            }
            catch (Exception ex)
            {
                if (ex.Message == "File not found.")
                    XtraMessageBox.Show("Không tồn tại tập tin \n'" + _sReportPath + "'", "File not found.");
                else
                    XtraMessageBox.Show(ex.Message);
            }
        }

        public frmViewReport(string sReportPath, DataView dtView_Value)
        {
            DataTable dtValue = new DataTable();
            dtValue = ConvertDataView_2_DataTable(dtView_Value);
            InitializeComponent();
            _sReportPath = sReportPath;
            _dtValue = dtValue;
        }

        public frmViewReport(string sReportPath, string sSQLSelect)
        {
            InitializeComponent();
            DevExpress.XtraReports.UI.XtraReport xNew = new DevExpress.XtraReports.UI.XtraReport();
            xNew.LoadLayout(sReportPath);
            _sReportPath = sReportPath;
            this.Text = sReportPath;
            DataTable dtValue = cnn.SelectRows(sSQLSelect);
            _dtValue = dtValue;
        }

        private System.Data.DataTable ConvertDataView_2_DataTable(DataView dv)
        {
            System.Data.DataTable DTT = new System.Data.DataTable();
            try
            {
                if (dv != null)
                {
                    DTT = dv.Table.Clone();
                    for (int ii = 0; ii < dv.Count; ii++)
                    {
                        DTT.ImportRow(dv[ii].Row);
                    }
                    DTT.DefaultView.AllowNew = false;
                }
                else
                {
                    DTT = null;
                }
            }
            catch
            {
            }
            return (DTT);
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrReport.frmReportDesign frm = new DELFI_WHM.NET.FrReport.frmReportDesign(_sReportPath,_dtValue);
            frm.Show();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadReport();
        }

        public void frmViewReport_Load(object sender, EventArgs e)
        {
            if (bDirect)
                return;//Vì đã Load rồi, không cần Load lần 2
                LoadReport();
            }
        public void InNhanh(bool bDirect)
        {
            if (bDirect)
            {
                //DevExpress.XtraReports.UI.ReportPrintTool ReportPrintTool = new DevExpress.XtraReports.UI.ReportPrintTool(xNew);
                //ReportPrintTool.AutoShowParametersPanel = false;
                LoadReport();
                printControl1.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.PrintDirect);
            }
        }

        private void printPreviewBarItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        /*
public XRBarCode TaoQRCode()
{
  // Tạo 1 barcode mới
  XRBarCode barCode = new XRBarCode();

  // Đặt cho nó là kiểu QRCode.
  barCode.Symbology = new DevExpress.XtraPrinting.BarCode.QRCodeGenerator();

  //Đưa dữ liệu vào mã QRcode
  const string input = "Lap trinh la niem vui!" + "\n" + "https://blogthangbom.wordpress.com/";

  //Chuyển dữ liệu qua dạng mãng byte
  byte[] array = System.Text.Encoding.ASCII.GetBytes(input);

  //Gán mãng byte vào barcode
  barCode.BinaryData = array;

  //Đặt thêm một số thuộc tính cho barcode
  barCode.Width = 400;
  barCode.Height = 150;
  barCode.AutoModule = true;
  ((QRCodeGenerator)barCode.Symbology).CompactionMode = QRCodeCompactionMode.Byte;
  ((QRCodeGenerator)barCode.Symbology).ErrorCorrectionLevel = QRCodeErrorCorrectionLevel.H;
  ((QRCodeGenerator)barCode.Symbology).Version = QRCodeVersion.AutoVersion;

  return barCode;
}
*/
    }
}
