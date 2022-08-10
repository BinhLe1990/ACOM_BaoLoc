using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BSC_HRM.NET.BSC_Class;
using System.Collections;
using System.Xml;

namespace BSC_HRM.NET.BSC_User_Control
{
    public partial class uLop : DevExpress.XtraEditors.XtraUserControl
    {
        public uLop()
        {
            InitializeComponent();
        }

        public string sWhere = "";
        private string sWhere1 = "";
        private string sWhere2 = "";

        [Category("UserDefine"), DefaultValue("Caption")]
        public string sCaption
        {
            get
            {
                return this.grpMain.Text;
            }
            set
            {
                if (this.grpMain.Text == value)
                    return;
                this.grpMain.Text = value;
            }
        }


        [Category("UserDefine"), DefaultValue(false)]
        public bool bIsReadOnly
        {
            get { return cbxLoaiDaoTao.bIsReadOnly; }
            set
            {
                cbxLoaiDaoTao.bIsReadOnly = value;
                cbxKhoa.bIsReadOnly = value;
                cbxKhoaHoc.bIsReadOnly = value;
                cbxBac.bIsReadOnly = value;
                cbxNganh.bIsReadOnly = value;
                cbxChuyenNganh.bIsReadOnly = value;
                cbxLop.bIsReadOnly = value;
                txtNamHoc.bIsReadOnly = value;
                cbxHocKy.bIsReadOnly = value;
            }
        }
        [Category("UserDefine"), DefaultValue(DevExpress.Utils.HorzAlignment.Default)]
        public DevExpress.Utils.HorzAlignment bLabelAlignment
        {
            get
            {
                return cbxLoaiDaoTao.bLabelAlignment;
            }
            set
            {
                cbxLoaiDaoTao.bLabelAlignment = value;
                cbxKhoa.bLabelAlignment = value;
                cbxKhoaHoc.bLabelAlignment = value;
                cbxBac.bLabelAlignment = value;
                cbxNganh.bLabelAlignment = value;
                cbxChuyenNganh.bLabelAlignment = value;
                cbxLop.bLabelAlignment = value;
                txtNamHoc.bLabelAlignment = value;
                cbxHocKy.bLabelAlignment = value;
            }
        }

        

        [Category("UserDefine"), DefaultValue(DevExpress.Utils.HorzAlignment.Default)]
        public DevExpress.Utils.HorzAlignment bHAlignment
        {
            get
            {
                return cbxLoaiDaoTao.bHAlignment;
            }
            set
            {
                cbxLoaiDaoTao.bHAlignment = value;
                cbxKhoa.bHAlignment = value;
                cbxKhoaHoc.bHAlignment = value;
                cbxBac.bHAlignment = value;
                cbxNganh.bHAlignment = value;
                cbxChuyenNganh.bHAlignment = value;
                cbxLop.bHAlignment = value;
                txtNamHoc.bHAlignment = value;
                cbxHocKy.bHAlignment = value;
            }
        }

        [Category("UserDefine"), DefaultValue(true), Description("Hiển thị tiêu đề")]
        public bool bShowCaption
        {
            get
            {
                return grpMain.ShowCaption;
            }
            set
            {
                this.grpMain.ShowCaption = value;
            }
        }

        [Category("UserDefine"), DefaultValue(true)]
        public bool bLabelTopDock
        {
            get
            {
                return cbxLoaiDaoTao.bLabelTopDock;
            }
            set
            {
                cbxLoaiDaoTao.bLabelTopDock = value;
                cbxKhoa.bLabelTopDock = value;
                cbxKhoaHoc.bLabelTopDock = value;
                cbxBac.bLabelTopDock = value;
                cbxNganh.bLabelTopDock = value;
                cbxChuyenNganh.bLabelTopDock = value;
                cbxLop.bLabelTopDock = value;
                txtNamHoc.bLabelTopDock = value;
                cbxHocKy.bLabelTopDock = value;
            }
        }
        
        [Category("UserDefine"), DefaultValue(true), Description("Hiển thị đối tượng Loại Đào Tạo")]
        public bool bVisibled_LoaiDaoTao
        {
            get { return cbxLoaiDaoTao.Visible; }
            set { cbxLoaiDaoTao.Visible = value; }
        }
        
        [Category("UserDefine"), DefaultValue(true), Description("Hiển thị đối tượng Khoa")]
        public bool bVisibled_Khoa
        {
            get { return cbxKhoa.Visible; }
            set { cbxKhoa.Visible = value; }
        }
        
        [Category("UserDefine"), DefaultValue(true), Description("Hiển thị đối tượng Khóa Học")]
        public bool bVisibled_KhoaHoc
        {
            get { return cbxKhoaHoc.Visible; }
            set { cbxKhoaHoc.Visible = value; }
        }
        
        [Category("UserDefine"), DefaultValue(true), Description("Hiển thị đối tượng Bậc đào tạo")]
        public bool bVisibled_BacDaoTao
        {
            get { return cbxBac.Visible; }
            set { cbxBac.Visible = value; }
        }
        
        [Category("UserDefine"), DefaultValue(true), Description("Hiển thị đối tượng Ngành Đào tạo")]
        public bool bVisibled_NganhDaoTao
        {
            get { return cbxNganh.Visible; }
            set { cbxNganh.Visible = value; }
        }



        [Category("UserDefine"), DefaultValue(false), Description("Hiển thị đối tượng Chuyên Ngành Đào tạo")]
        public bool bVisibled_ChuyenNganh
        {
            get { return cbxChuyenNganh.Visible; }
            set { cbxChuyenNganh.Visible = value; }
        }
        
        [Category("UserDefine"), DefaultValue(true), Description("Hiển thị đối tượng Lớp học")]
        public bool bVisibled_Lop
        {
            get { return cbxLop.Visible; }
            set { cbxLop.Visible = value; }
        }

        [Category("UserDefine"), DefaultValue(false), Description("Hiển thị đối tượng Năm học")]
        public bool bVisibled_NamHoc
        {
            get { return txtNamHoc.Visible; }
            set { txtNamHoc.Visible = value; }
        }

        [Category("UserDefine"), DefaultValue(false), Description("Hiển thị đối tượng Học Kỳ")]
        public bool bVisibled_HocKy
        {
            get { return cbxHocKy.Visible; }
            set { cbxHocKy.Visible = value; }
        }

        [Browsable(false)]

        public void Clear(Control Container)
        {
            foreach (Control ctr in Container.Controls)
            {
                if (ctr is uComboBox)
                {
                    uComboBox cbx = (uComboBox)ctr;
                    cbx.uEditValue = null;
                }
                else if (ctr is BSCEmisNamHoc)
                {
                    BSCEmisNamHoc txt = (BSCEmisNamHoc)ctr;
                    txt.iYear = DateTime.Now.Month < 6 ? DateTime.Now.Year - 1 : DateTime.Now.Year;
                }
                if (ctr.Controls.Count > 0)
                {
                    Clear(ctr);
                }
            }
        }

        private BSCConnection cnn;
        public BSCConnection BSCConn
        {
            set
            {
                if (value != null)
                {
                    cnn = value;
                    cbxLoaiDaoTao.BSCConn = value;
                    cbxLop.BSCConn = value;
                    cbxKhoa.BSCConn = value;
                    cbxKhoaHoc.BSCConn = value;
                    cbxBac.BSCConn = value;
                    cbxNganh.BSCConn = value;
                    cbxChuyenNganh.BSCConn = value;
                    cbxHocKy.BSCConn = value;
                    Khoa_CoQuyen();
                    LoadDefault();
                }
            }
        }

        private void LoadKhoa_TheoQuyen()// Phân quyền phạm vi cho một vài form - Tạm thời chưa sử dụng. hiện tại sử dụng hàm Khoa_CoQuyen() là áp dụng trên tất cả các form
        {
            if (this.FindForm().Name == "frmCT_DaoTao" || this.FindForm().Name == "frmCTDT_LopHocPhan"
                || this.FindForm().Name == "frmDangKyMonHoc" || this.FindForm().Name == "frmDangKyKhoaLuanTotNghiep"
                || this.FindForm().Name == "frmCapNhatDiemThi" || this.FindForm().Name == "frmChamDiemTheoPhongThi"
                || this.FindForm().Name == "frmXetHocTiep" || this.FindForm().Name == "frmXetTotNghiep"
                || this.FindForm().Name == "frmXetTuCachDuThiTotNghiep")
            {
                Khoa_CoQuyen();
            }
            else
                cbxKhoa.uTableName = "DM_Khoa";
        }

        private void Khoa_CoQuyen()
        {
            string[] Quyen = Properties.Settings.Default.PER_PHAMVI.Split(new string[] { "|PV", "|=1|;" }, StringSplitOptions.RemoveEmptyEntries);
            string abc = "";
            for (int i = 0; i < Quyen.Length; i++)
            {
                abc += "N'" + Quyen[i] + "', ";
            }
            if (abc != "")
            {
                abc = abc.Substring(0, abc.Length - 2);
            }
            if (abc == "")
            {
                cbxKhoa.uDataSource = null;
            }
            else
            {
                DataTable dt = cnn.SelectRows("select MaKhoa, TenKhoa, TruongKhoa from DM_Khoa where MaKhoa in (" + abc + ")");
                cbxKhoa.uDataSource = dt;
            }
        }

        private BSC_HRM.NET.BSC_Class.BSCConnection.Lop cLop = new BSCConnection.Lop();

        [Browsable(false)]
        public BSC_HRM.NET.BSC_Class.BSCConnection.Lop Value
        {
            get { return cLop; }
            set
            {
                cLop = value;
                cbxLoaiDaoTao.uEditValue = cLop.sLoaiDaoTao;
                cbxKhoa.uEditValue = cLop.sKhoa;
                cbxKhoaHoc.uEditValue = cLop.sKhoaHoc;
                cbxBac.uEditValue = cLop.sBacDaoTao;
                cbxNganh.uEditValue = cLop.sNganh;
                cbxChuyenNganh.uEditValue = cLop.sChuyenNganh;
                cbxLop.uEditValue = cLop.sLop;
            }
        }
        private string _sLop;
        [Browsable(false)]
        public string sLopHoc
        {
            get { return _sLop; }
            set { _sLop = value; }
        }

        public void InitData(string sl, ref BSC_HRM.NET.BSC_Class.BSCConnection.Lop ul)
        {
            DataTable dt = cnn.SelectRows("select * from DM_LopHoc where MaLopHoc = N'" + sl + "'");
            BSC_HRM.NET.BSC_Class.BSCConnection.Lop _l = new BSC_HRM.NET.BSC_Class.BSCConnection.Lop();
            if (dt.Rows.Count != 0)
            {
                _l.sLoaiDaoTao = dt.Rows[0]["MaLoaiDaoTao"].ToString();
                _l.sKhoa = dt.Rows[0]["MaKhoa"].ToString();
                _l.sKhoaHoc = dt.Rows[0]["MaKhoaHoc"].ToString();
                _l.sBacDaoTao = dt.Rows[0]["MaBacDaoTao"].ToString();
                _l.sNganh = dt.Rows[0]["MaNganh"].ToString();
                _l.sChuyenNganh = dt.Rows[0]["MaChuyenNganh"].ToString();
                _l.sLop = dt.Rows[0]["MaLopHoc"].ToString();

                cbxLoaiDaoTao.uEditValue = dt.Rows[0]["MaLoaiDaoTao"];
                cbxKhoa.uEditValue = dt.Rows[0]["MaKhoa"];
                cbxKhoaHoc.uEditValue = dt.Rows[0]["MaKhoaHoc"];
                cbxBac.uEditValue = dt.Rows[0]["MaBacDaoTao"];
                cbxNganh.uEditValue = dt.Rows[0]["MaNganh"];
                cbxChuyenNganh.uEditValue = dt.Rows[0]["MaChuyenNganh"];
                cbxLop.uEditValue = dt.Rows[0]["MaLopHoc"];
            }
            ul = _l;
        }

        public void InitData(string sl)
        {
            DataTable dt = cnn.SelectRows("select * from DM_LopHoc where MaLopHoc = N'" + sl + "'");
            if (dt.Rows.Count != 0)
            {
                cbxLoaiDaoTao.uEditValue = dt.Rows[0]["MaLoaiDaoTao"];
                cbxKhoa.uEditValue = dt.Rows[0]["MaKhoa"];
                cbxKhoaHoc.uEditValue = dt.Rows[0]["MaKhoaHoc"];
                cbxBac.uEditValue = dt.Rows[0]["MaBacDaoTao"];
                cbxNganh.uEditValue = dt.Rows[0]["MaNganh"];
                cbxChuyenNganh.uEditValue = dt.Rows[0]["MaChuyenNganh"];
                cbxLop.uEditValue = dt.Rows[0]["MaLopHoc"];
            }
        }

        public void InitData(BSC_HRM.NET.BSC_Class.BSCConnection.Lop ul)
        {
            cbxLoaiDaoTao.uEditValue = ul.sLoaiDaoTao;
            cbxKhoa.uEditValue = ul.sKhoa;
            cbxKhoaHoc.uEditValue = ul.sKhoaHoc;
            cbxBac.uEditValue = ul.sBacDaoTao;
            cbxNganh.uEditValue = ul.sNganh;
            cbxChuyenNganh.uEditValue = ul.sChuyenNganh;
            cbxLop.uEditValue = ul.sLop;
        }

        public event System.EventHandler uValueChanged;
        private void cbx_uEditValueChanged(object sender, EventArgs e)
        {
            uComboBox cbx = (uComboBox)sender;
            sWhere1 = "";
            cLop.ResetAll();
            Hashtable Val = new Hashtable();
//--------------------------------
            if (cbx.Name == cbxBac.Name)
            {
                Hashtable Con = new Hashtable();
                if (!cnn.bComboIsNull(cbxBac))
                {
                    //Con.Add("MaBacDaoTao", cbxBac.uEditValue.ToString());
                    DataTable dtCN = cnn.SelectRows(new string[] { "MaNganh", "TenNganh" }, Con, "DM_Nganh");
                    cbxNganh.uDataSource = dtCN;
                    if (dtCN.Rows.Count <= 1)
                        cbxNganh.uEditValue = null;
                }
                else
                    cbxNganh.uEditValue = null;
            }

//------------------------------------
            if (cbx.Name == cbxNganh.Name)
            {
                Hashtable Con = new Hashtable();
                if (!cnn.bComboIsNull(cbxNganh))
                {
                    if (cbxNganh.Visible)
                    {
                        Con.Add("MaNganh", cbxNganh.uEditValue.ToString());
                        DataTable dtCN = cnn.SelectRows(new string[] { "MaChuyenNganh", "TenChuyenNganh" }, Con, "DM_ChuyenNganh");
                        cbxChuyenNganh.uDataSource = dtCN;
                        if (dtCN.Rows.Count <= 1)
                            cbxChuyenNganh.uEditValue = null;
                    }
                    else
                        cbxChuyenNganh.uEditValue = null;
                }
                else
                    cbxChuyenNganh.uEditValue = null;
            }
            if (!cnn.bComboIsNull(cbxLoaiDaoTao))
                if (cbxLoaiDaoTao.Visible)
                {
                    cLop.sLoaiDaoTao = cbxLoaiDaoTao.uEditValue.ToString();
                    Val.Add("MaLoaiDaoTao", cbxLoaiDaoTao.uEditValue);
                    sWhere1 += " MaLoaiDaoTao = N'" + cbxLoaiDaoTao.uEditValue + "' AND";
                }
            if (!cnn.bComboIsNull(cbxKhoa))
                if (cbxKhoa.Visible)
                {
                    cLop.sKhoa = cbxKhoa.uEditValue.ToString();
                    Val.Add("MaKhoa", cbxKhoa.uEditValue);
                    sWhere1 += " MaKhoa = N'" + cbxKhoa.uEditValue + "' AND";
                }
            if (!cnn.bComboIsNull(cbxKhoaHoc))
                if (cbxKhoaHoc.Visible)
                {
                    cLop.sKhoaHoc = cbxKhoaHoc.uEditValue.ToString();
                    Val.Add("MaKhoaHoc", cbxKhoaHoc.uEditValue);
                    sWhere1 += " MaKhoaHoc = N'" + cbxKhoaHoc.uEditValue + "' AND";
                }
            if (!cnn.bComboIsNull(cbxBac))
                if (cbxBac.Visible)
                {
                    cLop.sBacDaoTao = cbxBac.uEditValue.ToString();
                    Val.Add("MaBacDaoTao", cbxBac.uEditValue);
                    sWhere1 += " MaBacDaoTao = N'" + cbxBac.uEditValue + "' AND";
                }
            if (!cnn.bComboIsNull(cbxNganh))
                if (cbxNganh.Visible)
                {
                    cLop.sNganh = cbxNganh.uEditValue.ToString();
                    Val.Add("MaNganh", cbxNganh.uEditValue);
                    sWhere1 += " MaNganh = N'" + cbxNganh.uEditValue + "' AND";
                }
            if (!cnn.bComboIsNull(cbxChuyenNganh))
                if (cbxChuyenNganh.Visible)
                {
                    cLop.sChuyenNganh = cbxChuyenNganh.uEditValue.ToString();
                    Val.Add("MaChuyenNganh", cbxChuyenNganh.uEditValue);
                    sWhere1 += " MaChuyenNganh = N'" + cbxChuyenNganh.uEditValue + "' AND";
                }
            DataTable dt = cnn.SelectRows(new string[] { "MaLopHoc", "TenLopHoc", "MaQuyChe" }, Val, "DM_LopHoc");
            cbxLop.uDataSource = dt;
            cbxLop.uDisplayMember = "TenLopHoc";
            cbxLop.uValueMember = "MaLopHoc";

            if (cnn.bComboIsNull(cbxLop))
            {
                if (sWhere1.Length > 3)
                    sWhere = sWhere1.Substring(0, sWhere1.Length - 3);
                else
                    sWhere = sWhere1;
            }
            else
                sWhere = " MaLopHoc = N'" + cbxLop.uEditValue.ToString() + "'";
            if (this.uValueChanged != null)
                this.uValueChanged(this, e);
        }

        public Hashtable DieuKienLoc(bool LayNamVaHocKy)
        {
            Hashtable Val = new Hashtable();
            if (cbxLop.uEditValue == null || cbxLop.uEditValue.ToString() == "")
            {
                if (cbxLoaiDaoTao.uEditValue != null)
                    if (cbxLoaiDaoTao.Visible && cbxLoaiDaoTao.uEditValue.ToString() != "")
                    {
                        Val.Add("MaLoaiDaoTao", cbxLoaiDaoTao.uEditValue);
                    }
                if (cbxKhoa.uEditValue != null)
                    if (cbxKhoa.Visible && cbxKhoa.uEditValue.ToString() != "")
                    {
                        Val.Add("MaKhoa", cbxKhoa.uEditValue);
                    }
                if (cbxKhoaHoc.uEditValue != null)
                    if (cbxKhoaHoc.Visible && cbxKhoaHoc.uEditValue.ToString() != "")
                    {
                        Val.Add("MaKhoaHoc", cbxKhoaHoc.uEditValue);
                    }
                if (cbxBac.uEditValue != null)
                    if (cbxBac.Visible && cbxBac.uEditValue.ToString() != "")
                    {
                        Val.Add("MaBacDaoTao", cbxBac.uEditValue);
                    }
                if (cbxNganh.uEditValue != null)
                    if (cbxNganh.Visible && cbxNganh.uEditValue.ToString() != "")
                    {
                        Val.Add("MaNganh", cbxNganh.uEditValue);
                    }
                if (cbxChuyenNganh.uEditValue != null)
                    if (cbxChuyenNganh.Visible && cbxChuyenNganh.uEditValue.ToString() != "")
                    {
                        Val.Add("MaChuyenNganh", cbxChuyenNganh.uEditValue);
                    }
            }
            else
            {
                if (cbxLop.uEditValue != null)
                    if (cbxLop.Visible && cbxLop.uEditValue.ToString() != "")
                    {
                        Val.Add("MaLopHoc", cbxLop.uEditValue);
                    }
            }
            if (LayNamVaHocKy)
            {
                if (txtNamHoc.Visible)
                {
                    Val.Add("NamHoc", txtNamHoc.iYear);
                }
                if (cbxHocKy.uEditValue != null)
                    if (cbxHocKy.Visible && cbxHocKy.uEditValue.ToString() != "")
                    {
                        Val.Add("HocKy", cbxHocKy.uEditValue);
                    }
            }
            return Val;
        }

        public void LoadDefault()
        {
            DataRow r = cnn.SelectRows("select * from HT_NGUOIDUNG where NguoiDUng = '" + Properties.Settings.Default.USER_ID + "'").Rows[0];
            cbxLoaiDaoTao.uEditValue = r["MaLoaiDaoTao"];
            cbxBac.uEditValue = r["MaBacDaoTao"];
            cbxKhoa.uEditValue = r["MaKhoa"];
            cbxKhoaHoc.uEditValue = r["MaKhoaHoc"];
            cbxNganh.uEditValue = r["MaNganh"];
            if (!cnn.bComboIsNull(cbxNganh))
            {
                Hashtable Con = new Hashtable();
                Con.Add("MaNganh", cbxNganh.uEditValue.ToString());
                DataTable dtCN = cnn.SelectRows(new string[] { "MaChuyenNganh", "TenChuyenNganh" }, Con, "DM_ChuyenNganh");
                cbxChuyenNganh.uDataSource = dtCN;
                if (dtCN.Rows.Count <= 1)
                    cbxChuyenNganh.uEditValue = null;
            }
            else
                cbxChuyenNganh.uEditValue = null;
            txtNamHoc.iYear = cnn.sNull2Int(r["NamHoc"]);
            cbxHocKy.uEditValue = r["HocKy"];
            cbxChuyenNganh.uEditValue = r["MaChuyenNganh"];



            Hashtable Val = new Hashtable();
            if (!cnn.bComboIsNull(cbxLoaiDaoTao))
            {
                Val.Add("MaLoaiDaoTao", cbxLoaiDaoTao.uEditValue);
            }
            if (!cnn.bComboIsNull(cbxKhoa))
            {
                Val.Add("MaKhoa", cbxKhoa.uEditValue);
            }
            if (!cnn.bComboIsNull(cbxKhoaHoc))
            {
                Val.Add("MaKhoaHoc", cbxKhoaHoc.uEditValue);
            }
            if (!cnn.bComboIsNull(cbxBac))
            {
                Val.Add("MaBacDaoTao", cbxBac.uEditValue);
            }
            if (!cnn.bComboIsNull(cbxNganh))
            {
                Val.Add("MaNganh", cbxNganh.uEditValue);
            }
            if (cbxChuyenNganh.Visible && !cnn.bComboIsNull(cbxChuyenNganh))
            {
                Val.Add("MaChuyenNganh", cbxChuyenNganh.uEditValue);
            }
            DataTable dt = cnn.SelectRows(new string[] { "MaLopHoc", "TenLopHoc", "MaQuyChe" }, Val, "DM_LopHoc");
            cbxLop.uDataSource = dt;
            cbxLop.uDisplayMember = "TenLopHoc";
            cbxLop.uValueMember = "MaLopHoc";




            cbxLop.uEditValue = r["MaLopHoc"];
        }

        public event System.EventHandler NamHoc_ValueChanged;
        private void txtNamHoc_uEditValueChanged(object sender, EventArgs e)
        {
            if (NamHoc_ValueChanged != null) 
                this.NamHoc_ValueChanged(sender, e);
        }

        public event System.EventHandler HocKy_ValueChanged;
        private void cbxHocKy_uEditValueChanged(object sender, EventArgs e)
        {
            if (HocKy_ValueChanged != null)
                this.HocKy_ValueChanged(sender, e);
        }

        private void uLop_Load(object sender, EventArgs e)
        {
            if (cnn != null)
                LoadDefault();
        }

        private void grpMain_Click(object sender, EventArgs e)
        {
            
        }

        public Hashtable DieuKienTimKiem_All(bool NamHoc, bool HocKy)
        {
            Hashtable Val = new Hashtable();
            if (!cnn.bComboIsNull(cbxLoaiDaoTao) && cbxLoaiDaoTao.Visible)
                Val.Add("MaLoaiDaoTao", cbxLoaiDaoTao.uEditValue);
            if (!cnn.bComboIsNull(cbxKhoa) && cbxKhoa.Visible)
                Val.Add("MaKhoa", cbxKhoa.uEditValue);
            if (!cnn.bComboIsNull(cbxBac) && cbxBac.Visible)
                Val.Add("MaBacDaoTao", cbxBac.uEditValue);
            if (!cnn.bComboIsNull(cbxKhoaHoc) && cbxKhoaHoc.Visible)
                Val.Add("MaKhoaHoc", cbxKhoaHoc.uEditValue);
            if (!cnn.bComboIsNull(cbxNganh) && cbxNganh.Visible)
                Val.Add("MaNganh", cbxNganh.uEditValue);
            if (!cnn.bComboIsNull(cbxChuyenNganh) && cbxChuyenNganh.Visible)
                Val.Add("MaChuyenNganh", cbxChuyenNganh.uEditValue);
            if (!cnn.bComboIsNull(cbxLop) && cbxLop.Visible)
                Val.Add("MaLopHoc", cbxLop.uEditValue);
            if (NamHoc)
                if (txtNamHoc.Visible == true && txtNamHoc.Enabled == true)
                    Val.Add("NamHoc", txtNamHoc.iYear);
            if (HocKy)
                if (!cnn.bComboIsNull(cbxHocKy) && cbxHocKy.Visible)
                    Val.Add("HocKy", cbxHocKy.uEditValue);
            if (Val.Count == 0)
                return null;
            return Val;
        }
        public Hashtable DieuKienTimKiem_TheoLop(bool NamHoc, bool HocKy)
        {
            Hashtable Val = new Hashtable();
            if (!cnn.bComboIsNull(cbxLoaiDaoTao) && cbxLoaiDaoTao.Visible)
                Val.Add("MaLoaiDaoTao", cbxLoaiDaoTao.uEditValue);
            if (!cnn.bComboIsNull(cbxKhoa) && cbxKhoa.Visible)
                Val.Add("MaKhoa", cbxKhoa.uEditValue);
            if (!cnn.bComboIsNull(cbxBac) && cbxBac.Visible)
                Val.Add("MaBacDaoTao", cbxBac.uEditValue);
            if (!cnn.bComboIsNull(cbxKhoaHoc) && cbxKhoaHoc.Visible)
                Val.Add("MaKhoaHoc", cbxKhoaHoc.uEditValue);
            if (!cnn.bComboIsNull(cbxNganh) && cbxNganh.Visible)
                Val.Add("MaNganh", cbxNganh.uEditValue);
            if (!cnn.bComboIsNull(cbxChuyenNganh) && cbxChuyenNganh.Visible)
                Val.Add("MaChuyenNganh", cbxChuyenNganh.uEditValue);
            if (!cnn.bComboIsNull(cbxLop) && cbxLop.Visible)
            {
                Val.Clear();
                Val.Add("MaLopHoc", cbxLop.uEditValue);
            }
            if (NamHoc)
                if(txtNamHoc.Visible==true && txtNamHoc.Enabled==true)
                    Val.Add("NamHoc", txtNamHoc.iYear);
            if (HocKy)
                if (!cnn.bComboIsNull(cbxHocKy) && cbxHocKy.Visible)
                    Val.Add("HocKy", cbxHocKy.uEditValue);
            if (Val.Count == 0)
                return null;
            return Val;
        }

        private void cbxLop_uEditValueChanged(object sender, EventArgs e)
        {
            //if (!cbxLop.Visible)
            //    return;
            //if (cnn.bComboIsNull(cbxLop))
            //{
            //    cbx_uEditValueChanged(sender, e);
            //    return;
            //}
            //string sql = "select * from DM_LopHoc where TenLopHoc = N'" + cbxLop.uText + "'";
            
            //DataTable dtVal = cnn.DT_DataTable(sql);
            //if (dtVal.Rows.Count == 0)
            //    return;
            //cbxKhoa.uEditValue = dtVal.Rows[0]["MaKhoa"].ToString();
            //cbxKhoaHoc.uEditValue = dtVal.Rows[0]["MaKhoaHoc"].ToString();
            //cbxLoaiDaoTao.uEditValue = dtVal.Rows[0]["MaLoaiDaoTao"].ToString();
            //cbxBac.uEditValue = dtVal.Rows[0]["MaBacDaoTao"].ToString();
            //cbxNganh.uEditValue = dtVal.Rows[0]["MaNganh"].ToString();
            //cbxChuyenNganh.uEditValue = dtVal.Rows[0]["MaChuyenNganh"].ToString();

            //sWhere2 = "";
            //if (cnn.bComboIsNull(cbxLop))
            //{
            //    cLop.sLoaiDaoTao = "";
            //    cLop.sKhoa = "";
            //    cLop.sKhoaHoc = "";
            //    cLop.sBacDaoTao = "";
            //    cLop.sNganh = "";
            //    cLop.sChuyenNganh = "";
            //    cLop.sLop = "";
            //    cbx_uEditValueChanged(sender, e);
            //}
            //else
            //{
            //    sWhere2 = " MaLopHoc = N'" + cbxLop.uEditValue.ToString() + "' AND";
            //    if (sWhere2.Length > 3)
            //        sWhere = sWhere2.Substring(0, sWhere2.Length - 3);
            //    DataTable dt = cnn.DT_DataTable("select * from DM_LopHoc where MaLopHoc = N'" + cbxLop.uEditValue.ToString() + "'");
            //    cLop.sLoaiDaoTao = dt.Rows[0]["MaLoaiDaoTao"].ToString();
            //    cLop.sKhoa = dt.Rows[0]["MaKhoa"].ToString();
            //    cLop.sKhoaHoc = dt.Rows[0]["MaKhoaHoc"].ToString();
            //    cLop.sBacDaoTao = dt.Rows[0]["MaBacDaoTao"].ToString();
            //    cLop.sNganh = dt.Rows[0]["MaNganh"].ToString();
            //    cLop.sChuyenNganh = dt.Rows[0]["MaChuyenNganh"].ToString();
            //    cLop.sLop = cbxLop.uEditValue.ToString();
            //}
            if (this.uValueChanged != null)
                this.uValueChanged(this, e);
        }

        public event System.EventHandler uValidated;
        private void cbxLop_uValidated(object sender, EventArgs e)
        {
            if (!cbxLop.Visible)
                return;
            if (cnn.bComboIsNull(cbxLop))
            {
                cbx_uEditValueChanged(sender, e);
                return;
            }
            string sql = "select * from DM_LopHoc where MaLopHoc = N'" + cbxLop.uEditValue.ToString() + "'";
            DataTable dtVal = cnn.DT_DataTable(sql);
            cbxKhoa.uEditValue = dtVal.Rows[0]["MaKhoa"].ToString();
            cbxKhoaHoc.uEditValue = dtVal.Rows[0]["MaKhoaHoc"].ToString();
            cbxLoaiDaoTao.uEditValue = dtVal.Rows[0]["MaLoaiDaoTao"].ToString();
            cbxBac.uEditValue = dtVal.Rows[0]["MaBacDaoTao"].ToString();
            cbxNganh.uEditValue = dtVal.Rows[0]["MaNganh"].ToString();
            cbxChuyenNganh.uEditValue = dtVal.Rows[0]["MaChuyenNganh"].ToString();

            sWhere2 = "";
            if (cnn.bComboIsNull(cbxLop))
            {
                cLop.sLoaiDaoTao = "";
                cLop.sKhoa = "";
                cLop.sKhoaHoc = "";
                cLop.sBacDaoTao = "";
                cLop.sNganh = "";
                cLop.sChuyenNganh = "";
                cLop.sLop = "";
                cbx_uEditValueChanged(sender, e);
            }
            else
            {
                sWhere2 = " MaLopHoc = N'" + cbxLop.uEditValue.ToString() + "' AND";
                if (sWhere2.Length > 3)
                    sWhere = sWhere2.Substring(0, sWhere2.Length - 3);
                DataTable dt = cnn.DT_DataTable("select * from DM_LopHoc where MaLopHoc = N'" + cbxLop.uEditValue.ToString() + "'");
                cLop.sLoaiDaoTao = dt.Rows[0]["MaLoaiDaoTao"].ToString();
                cLop.sKhoa = dt.Rows[0]["MaKhoa"].ToString();
                cLop.sKhoaHoc = dt.Rows[0]["MaKhoaHoc"].ToString();
                cLop.sBacDaoTao = dt.Rows[0]["MaBacDaoTao"].ToString();
                cLop.sNganh = dt.Rows[0]["MaNganh"].ToString();
                cLop.sChuyenNganh = dt.Rows[0]["MaChuyenNganh"].ToString();
                cLop.sLop = cbxLop.uEditValue.ToString();
            }
            if (this.uValidated != null)
                this.uValidated(this, e);
        }

        private void cbxLop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void cbxLop_uLeave(object sender, EventArgs e)
        {
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cnn.clearControl(this);
            txtNamHoc.iYear = DateTime.Now.Year;
        }

        private void uLop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(MousePosition);
        }
    }
}