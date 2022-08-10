using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DELFI_WHM.NET.DELFI_Class;
using DELFI_WHM.NET.Models;
using DevExpress.XtraEditors;

namespace DELFI_WHM.NET.QuanLy
{
    public partial class frmChuyenCay : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);

        public frmChuyenCay()
        {
            InitializeComponent();
        }

        private bool Check_Cond()
        {
            if (cnn.bComboIsNull(cboVitri))
            {
                XtraMessageBox.Show("Vui lòng chọn Cây hàng đến", "Thông báo");
                return false;
            }            
            return true;
        }

        private void History(int ID, string BinCode)
        {       
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var list = db.WH_TonKho.Where(c => c.ID == ID).ToList();
                if (list[0].BinCode != BinCode)
                {
                    db.HIS_Phieucancau.Add(new HIS_Phieucancau
                    {
                        ID_WeightNote = Convert.ToInt32(ID),
                        Dateupdate = cnn.GetDateServer(),
                        UserName = Properties.Settings.Default.USER_NAME,
                        Desc = "Sửa cây hàng " + list[0].BinCode + " thành " + BinCode,
                        Loai = "UpdateSP"
                    });
                    db.SaveChanges();
                }
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!Check_Cond())
                return;
            string BinCode = cboVitri.uEditValue.ToString();
            if (Tab.SelectedTabPage == Tab_Chitiet)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn chuyển Cây theo list đã chọn ?", "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (DBACOMEntities db = new DBACOMEntities())
                    {
                        for (int i = 0; i < gridView_Chitiet.DataRowCount; i++)
                        {
                            if (gridView_Chitiet.GetRowCellValue(i, "Chon").ToString() == "True")
                            {
                                dt.Rows.Add(gridView_Chitiet.GetRowCellValue(i, "ID"));
                            }
                        }
                        
                        if (dt.Rows.Count > 0)
                        {
                            for (int i = 0; i < gridView_Chitiet.DataRowCount; i++)
                            {
                                if (gridView_Chitiet.GetRowCellValue(i, "Chon").ToString() == "True")
                                {
                                    string QRCode = gridView_Chitiet.GetRowCellValue(i, "QRCode").ToString();
                                    var list = db.WH_ChiTietNhapKho.Where(c => c.QRCode == QRCode).ToList();
                                    string Lot = gridView_Chitiet.GetRowCellValue(i, "Lot").ToString();
                                    string Cer = gridView_Chitiet.GetRowCellValue(i, "Certificate").ToString();
                                    string PackageCode = gridView_Chitiet.GetRowCellValue(i, "PackageCode").ToString();
                                    
                                    bool Sample = Convert.ToBoolean(list[0].Sample);
                                    decimal GrossWeight = Convert.ToDecimal(gridView_Chitiet.GetRowCellValue(i, "QRCodeQty"));
                                    decimal TotalPackageQty = 0;
                                    decimal QRCodeQty = Convert.ToDecimal(gridView_Chitiet.GetRowCellValue(i, "QRCodeQty"));

                                    var list2 = db.WH_ChiTietNhapKho.Where(c => c.QRCode == QRCode && c.Del == false).ToList();
                                    var list3 = db.WH_TonKho.Where(c => c.QRCode == QRCode && c.Exported == false).ToList();
                                    if (list2.Count > 0 && list3.Count > 0)
                                    {
                                        History(Convert.ToInt32(gridView_Chitiet.GetRowCellValue(i, "ID")), BinCode);

                                        var ChuyenCay = new Dictionary<String, String>() { { "QRCode", QRCode },
                                                        { "Lot", Lot},
                                                        { "Cer", Cer},
                                                        { "PackageCode", PackageCode},
                                                        { "BinCode", BinCode},
                                                        { "Sample", Sample.ToString()},
                                                        { "GrossWeight", GrossWeight.ToString()},
                                                        { "TotalPackageQty", TotalPackageQty.ToString()},
                                                        { "QRCodeQty", QRCodeQty.ToString() },
                                                        { "UserName", Properties.Settings.Default.USER_NAME}};
                                        cnn.SQL_ExecuteStoredProcedure("SP_UPDATE_ThongTinSP", ChuyenCay);
                                    }
                                }
                            }

                            var Up = new Dictionary<String, String>() { { "Lot", cboLot.uEditValue.ToString() } };
                            grid_Chitiet.DataSource = cnn.SQL_GetStoredProcedure("SP_ChuyenLot", Up);

                            chk_All.Checked = false;
                            XtraMessageBox.Show("Cập nhật thông tin thành công", "Thông báo");
                        }
                        else
                        {
                            XtraMessageBox.Show("Vui lòng chọn QRCode cần chuyển", "Thông báo");
                        }
                    }
                }
            }
            else if (Tab.SelectedTabPage == Tab_TongHop && gridView_TongHop.RowCount > 0)
            {
                try
                {
                    string WeightNote = cnn.dt_Location().Rows[0]["Code"].ToString() + "-" + cnn.GetDateServer().ToString("ddMMyyyyHHmmssfff") + "-" + "2";
                    for (int i = 0; i < gridView_TongHop.DataRowCount; i++)
                    {
                        string QRCode = gridView_TongHop.GetRowCellValue(i, "QRCode").ToString();
                        string PackageCode = gridView_TongHop.GetRowCellValue(i, "PackageCode").ToString();
                        int TruckQty_Ton = Convert.ToInt32(gridView_TongHop.GetRowCellValue(i, "TruckQty_Ton"));
                        int QRCodeQty_Ton = Convert.ToInt32(gridView_TongHop.GetRowCellValue(i, "QRCodeQty_Ton"));                        
                        History(Convert.ToInt32(gridView_TongHop.GetRowCellValue(i, "ID")), BinCode);

                        var ChuyenCay = new Dictionary<String, String>() { { "QRCode", QRCode },
                                                                       { "PackageCode", PackageCode},
                                                                       { "BinCode", BinCode},
                                                                       { "TruckQty_Ton", TruckQty_Ton.ToString()},
                                                                       { "QRCodeQty_Ton", QRCodeQty_Ton.ToString()},
                                                                       { "UserName", Properties.Settings.Default.USER_NAME},
                                                                       { "New_WeightNote2", WeightNote}};
                        cnn.SQL_ExecuteStoredProcedure("SP_UPDATE_ThongTinSP_TheoLot", ChuyenCay);
                    }

                    var Up = new Dictionary<String, String>() { { "Lot", cboLot.uEditValue.ToString() } };
                    grid_Chitiet.DataSource = cnn.SQL_GetStoredProcedure("SP_ChuyenLot", Up);
                    grid_TongHop.DataSource = cnn.SQL_GetStoredProcedure("SP_ChuyenLot_TonKhoTheoLot", Up);

                    XtraMessageBox.Show("Cập nhật thông tin thành công", "Thông báo");
                }
                catch { }
            }
        }

        private void gridView2_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void cboLot_uQueryPopUp(object sender, CancelEventArgs e)
        {
            cboLot.uDataSource = cnn.dt_ChuyenLot();
        }

        private void cboVitri_uQueryPopUp(object sender, CancelEventArgs e)
        {
            cboVitri.uDataSource = cnn.dt_Cayhang();
        }

        private void cboLot_uEditValueChanged(object sender, EventArgs e)
        {
            var Up = new Dictionary<String, String>() { { "Lot", cboLot.uEditValue.ToString() } };
            grid_Chitiet.DataSource = cnn.SQL_GetStoredProcedure("SP_ChuyenLot", Up);
            grid_TongHop.DataSource = cnn.SQL_GetStoredProcedure("SP_ChuyenLot_TonKhoTheoLot", Up);
            chk_All.Checked = false;
        }

        private void chk_All_EditValueChanged(object sender, EventArgs e)
        {
            if (gridView_Chitiet.DataRowCount > 0)
            {
                if (chk_All.Checked == true)
                {
                    for (int i = 0; i < gridView_Chitiet.DataRowCount; i++)
                    {
                        gridView_Chitiet.SetRowCellValue(i, "Chon", true);
                    }
                }
                else
                {
                    for (int i = 0; i < gridView_Chitiet.DataRowCount; i++)
                    {
                        gridView_Chitiet.SetRowCellValue(i, "Chon", false);
                    }
                }
            }
        }

        private void gridView2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                gridView_Chitiet.OptionsSelection.MultiSelect = true;
                gridView_Chitiet.SelectAll();
            }
        }

        private void gridView_TongHop_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void frmChuyenCay_Load(object sender, EventArgs e)
        {

        }
    }
}

