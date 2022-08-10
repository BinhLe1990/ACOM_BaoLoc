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
    public partial class frmCanLai : DevExpress.XtraEditors.XtraForm
    {
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        string _QRCode = "";
        decimal TLTruBi = 0;
        decimal TLCan = 0;

        public frmCanLai()
        {
            InitializeComponent();
        }

        private void Search()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                var list = db.WH_TonKho.Where(c => c.Exported == false).ToList();
                if (list.Count > 0)
                {
                    griDanhSach.DataSource = list;
                }
            }
            for (int i = 0; i < gridView2.Columns.Count; i++)
            {
                gridView2.Columns[i].OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            }
        }

        private bool Check()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                string QR = txtMaPallet.uText;
                var list = db.WH_TonKho.Where(c => c.QRCode == QR && c.Exported == false).ToList();
                if (list.Count ==0 || list == null)
                {
                    XtraMessageBox.Show("Mã QRCode không hợp lệ", "Thông báo");
                    return false;
                }
            }
                return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!Check())
                return;
            var Up = new Dictionary<String, String>() { { "QRCode", txtMaPallet.uText },
                                                        { "TLCan", spnTLCan.uValue.ToString()},
                                                        { "TLTruBi", spnTLTrubi.uValue.ToString()},
                                                        { "SoBao", spnSoBao.uValue.ToString()},
                                                        { "UserName", Properties.Settings.Default.USER_NAME}};
            cnn.SQL_ExecuteStoredProcedure("SP_UPDATE_TLCan", Up);
            Search();
            cnn.clearControl(group);
            XtraMessageBox.Show("Cập nhật thông tin thành công", "Thông báo");
        }

        private void gridView2_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = Convert.ToString(e.RowHandle + 1);
            }
        }

        private void frmCanLai_Load(object sender, EventArgs e)
        {
            Search();            
        }

        private void QRCode_Detail()
        {
            using (DBACOMEntities db = new DBACOMEntities())
            {
                _QRCode = txtMaPallet.uText;
                var list = db.WH_TonKho.Where(c => c.QRCode == _QRCode).ToList();
                if (list.Count > 0)
                {
                    txtItem.uText = list[0].ItemNo;
                    txtLot.uText = list[0].Lot;
                    txtLoaiBaoBi.uText = list[0].PackageCode;
                    txtCayHang.uText = list[0].BinCode;
                    spnID.uValue = Convert.ToInt32(list[0].ID);
                    spnTLCan.uValue = Convert.ToInt32(list[0].QRCodeQty);
                    spnTLTrubi.uValue = 0;
                    spnSoBao.uValue = Convert.ToInt32(list[0].TruckQty);
                }
                else
                {
                    XtraMessageBox.Show("Mã QRCode không hợp lệ", "Thông báo");
                }
            }
        }

        private void txtMaPallet_uKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                QRCode_Detail();
            }
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            txtMaPallet.uText   = gridView2.GetFocusedRowCellValue("QRCode").ToString();
            QRCode_Detail();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            spnTLCan.uValue = frmMain.SoCanBan;
        }

        private void spnTLTrubi_uValueChanged(object sender, EventArgs e)
        {
            if (spnTLTrubi.uValue < 0)
            {
                spnTLTrubi.uValue = 0;
                XtraMessageBox.Show("Tổng trọng lượng trừ bì không được âm", "Thông báo");
            }
        }

        private void chkNhanDuLieu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNhanDuLieu.Checked == true)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
                QRCode_Detail();
            }
        }

        private void gridView2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                gridView2.OptionsSelection.MultiSelect = true;
                gridView2.SelectAll();
            }
        }
    }
}

