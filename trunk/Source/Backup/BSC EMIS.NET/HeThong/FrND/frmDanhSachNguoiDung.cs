using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BSC_HRM.NET.FrHT.FrND
{
    public partial class frmDanhSachNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        DevExpress.XtraBars.Ribbon.RibbonControl _ribControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
        DevExpress.XtraBars.Ribbon.ApplicationMenu _ApMenu = new DevExpress.XtraBars.Ribbon.ApplicationMenu();
        BSC_Class.BSCConnection cnn = new BSC_Class.BSCConnection(Program.sServerName, Program.sUserName, Program.SPassword, Program.sDatabaseName);
        public frmDanhSachNguoiDung(DevExpress.XtraBars.Ribbon.RibbonControl ribControl, DevExpress.XtraBars.Ribbon.ApplicationMenu ApMenu)
        {
            InitializeComponent();
            _ribControl = ribControl;
            _ApMenu = ApMenu;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTAO_ND_Click(object sender, EventArgs e)
        {
            (new FrHT.FrND.frmTaoNguoiDung(_ribControl)).ShowDialog();
        }

        private void btnPHAN_QUYEN_Click(object sender, EventArgs e)
        {
            (new FrHT.FrND.frmPhanQuyenSuDung(_ribControl, _ApMenu)).ShowDialog();
        }

        private void btnDOI_MK_Click(object sender, EventArgs e)
        {
            (new FrHT.FrND.frmDoiMatKhau()).ShowDialog();
        }
    }
}