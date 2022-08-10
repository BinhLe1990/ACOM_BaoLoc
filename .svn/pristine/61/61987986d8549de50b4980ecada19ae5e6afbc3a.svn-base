using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Media;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Xml;
using System.Data.OleDb;

namespace DELFI_WHM.NET.KhoHang
{
    public partial class frmCheckCustommer : DevExpress.XtraEditors.XtraForm
    {
        public frmCheckCustommer()
        {
            InitializeComponent();
            clRun.SetValueToControl(this);
            dtg.sKEY = sKey;
        }
        DELFI_Class.DELFIConnection cnn = new DELFI_WHM.NET.DELFI_Class.DELFIConnection(Program.sConnection);
        clsRun clRun = new clsRun();
        string sKey = "LocDuLieu";

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtg_uDataSourceChanged(object sender, EventArgs e)
        {
            foreach (DevExpress.XtraGrid.Columns.GridColumn gc in dtg.Columns)
            {
                if (gc.FieldName != "Chon")
                    gc.OptionsColumn.AllowEdit = false;
            }
        }     


        private void btnInDS_Click(object sender, EventArgs e)
        {
            DataTable dt = dtg.GetDataSource();
            BaoCaoTK.frmViewReport frm = new DELFI_WHM.NET.BaoCaoTK.frmViewReport(Application.StartupPath + @"\Report\KH_DanhSachKhachHang.repx", dt);
            frm.Show();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            string MaSuKien = cnn.sNull2String(cboSuKien.uEditValue);
            if (MaSuKien == "")
            {
                XtraMessageBox.Show("Vui lòng chọn sự kiện.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string str = cnn.GetSQLString("LocDuLieu") + " Where Customer.MaSuKien = N'" + MaSuKien + "'";
            DataTable dt = cnn.SelectRows(str);
            dtg.uDataSource = dt;
        }

        private void txtIDCus_uKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtIDCus.bIsReadOnly == false)
            {
                string ID = cnn.sNull2String(txtIDCus.uText);
                string MaSuKien = cnn.sNull2String(cboSuKien.uEditValue);
                if (ID == "")
                {
                    return;
                }
                string str = "select * from Customer where IDCustomer = N'" + ID + "' AND MaSuKien = N'" + MaSuKien + "'";
                DataTable dt = cnn.SelectRows(str);
                if (dt.Rows.Count == 0)
                {
                    if (chkSound.Checked == true)
                    {
                        string path = Application.StartupPath + @"\Sound\Wrong_Beep.wav";
                        SoundPlayer sp = new SoundPlayer(path);
                        sp.Play();
                    }
                    else
                    {
                        XtraMessageBox.Show("Không tìm thấy mã khách hàng! Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    txtHoDem.uText = "";
                    txtTen.uText = "";
                    txtDiaChi.uText = "";
                    txtDienThoai.uText = "";
                    txtEmail.uText = "";
                    txtChucVu.uText = "";
                    txtLoaiSuKien.uText = "";
                    txtNamKinhNghiem.uText = "";
                    txtNganhNghe.uText = "";
                    txtLoaiNganhNghe.uText = "";
                    txtDiaDiem.uText = "";
                    txtSoLanQuet.uText = "";
                    txtIDCus.Focus();
                    txtIDCus.SelectAll();
                    return;
                }
                //if (dt.Rows[0]["Checked"].ToString() == "True")
                //{
                //    if (chkSound.Checked == true)
                //    {
                //            string path = Application.StartupPath + @"\Sound\Loop_beep.wav";
                //            SoundPlayer sp = new SoundPlayer(path);
                //            sp.Play();
                //    }
                //    else
                //    {
                //        XtraMessageBox.Show("Khách hàng này đã kiểm tra rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //    txtHoDem.uText = "";
                //    txtTen.uText = "";
                //    txtDiaChi.uText = "";
                //    txtDienThoai.uText = "";
                //    txtEmail.uText = "";
                //    txtChucVu.uText = "";
                //    txtLoaiSuKien.uText = "";
                //    txtNamKinhNghiem.uText = "";
                //    txtNganhNghe.uText = "";
                //    txtLoaiNganhNghe.uText = "";
                //    txtDiaDiem.uText = "";
                //    txtIDCus.Focus();
                //    txtIDCus.SelectAll();
                //    return;
                //}
                txtHoDem.uText = dt.Rows[0]["HoDem"].ToString();
                txtTen.uText = dt.Rows[0]["Ten"].ToString();
                txtDiaChi.uText = dt.Rows[0]["DiaChi"].ToString();
                txtDienThoai.uText = dt.Rows[0]["DienThoai"].ToString();
                txtEmail.uText = dt.Rows[0]["Email"].ToString();
                txtChucVu.uText = dt.Rows[0]["ChucVu"].ToString();
                txtLoaiSuKien.uText = dt.Rows[0]["LoaiSuKien"].ToString();
                txtNamKinhNghiem.uText = dt.Rows[0]["NamKinhNghiem"].ToString();
                txtNganhNghe.uText = dt.Rows[0]["NganhNghe"].ToString();
                txtLoaiNganhNghe.uText = dt.Rows[0]["LoaiNganhNghe"].ToString();
                txtDiaDiem.uText = dt.Rows[0]["DiaDiem"].ToString();
                txtSoLanQuet.uText = (cnn.sNull2Int(dt.Rows[0]["SoLanQuet"].ToString()) + 1).ToString();
                try
                {
                    Hashtable Val = new Hashtable();
                    Hashtable Con = new Hashtable();
                    Val.Clear();
                    Con.Clear();
                    Val.Add("IDCustomer", dt.Rows[0]["IDCustomer"]);
                    Con.Add("Checked", 1);
                    Con.Add("SoLanQuet", cnn.sNull2Int(dt.Rows[0]["SoLanQuet"].ToString()) + 1);
                    cnn.UpdateRows(Con, Val, "Customer");
                    if (chkSound.Checked == true)
                    { 
                        string path = Application.StartupPath + @"\Sound\Right_Beep.wav";
                        SoundPlayer sp = new SoundPlayer(path);
                        sp.Play();
                    }
                    txtIDCus.SelectAll();
                }
                catch
                {
                    if (chkSound.Checked == true)
                    {
                        string path = Application.StartupPath + @"\Sound\Wrong_Beep.wav";
                        SoundPlayer sp = new SoundPlayer(path);
                        sp.Play();
                    }
                    else
                        XtraMessageBox.Show("Cập nhật không thành công! Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHoDem.uText = "";
                    txtTen.uText = "";
                    txtDiaChi.uText = "";
                    txtDienThoai.uText = "";
                    txtEmail.uText = "";
                    txtChucVu.uText = "";
                    txtLoaiSuKien.uText = "";
                    txtNamKinhNghiem.uText = "";
                    txtNganhNghe.uText = "";
                    txtLoaiNganhNghe.uText = "";
                    txtDiaDiem.uText = "";
                    txtSoLanQuet.uText = "";
                    txtIDCus.Focus();
                    txtIDCus.SelectAll();
                }
            }
        }

        private void radChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radChon.EditValue.ToString() == "1")
            {
                txtIDCus.bIsReadOnly = false;
                txtDienThoai.bIsReadOnly = true;
                txtEmail.bIsReadOnly = true;

                txtHoDem.uText = "";
                txtTen.uText = "";
                txtDiaChi.uText = "";
                txtDienThoai.uText = "";
                txtEmail.uText = "";
                txtChucVu.uText = "";
                txtLoaiSuKien.uText = "";
                txtNamKinhNghiem.uText = "";
                txtNganhNghe.uText = "";
                txtLoaiNganhNghe.uText = "";
                txtDiaDiem.uText = "";
                txtIDCus.uText = "";
                txtSoLanQuet.uText = "";
                txtIDCus.Focus();
                txtIDCus.SelectAll();
            }
            else if (radChon.EditValue.ToString() == "2")
            {
                txtIDCus.bIsReadOnly = true;
                txtDienThoai.bIsReadOnly = false;
                txtEmail.bIsReadOnly = true;

                txtHoDem.uText = "";
                txtTen.uText = "";
                txtDiaChi.uText = "";
                txtDienThoai.uText = "";
                txtEmail.uText = "";
                txtChucVu.uText = "";
                txtLoaiSuKien.uText = "";
                txtNamKinhNghiem.uText = "";
                txtNganhNghe.uText = "";
                txtLoaiNganhNghe.uText = "";
                txtDiaDiem.uText = "";
                txtIDCus.uText = "";
                txtSoLanQuet.uText = "";
                txtDienThoai.Focus();
                txtDienThoai.SelectAll();
            }
            else if (radChon.EditValue.ToString() == "3")
            {
                txtIDCus.bIsReadOnly = true;
                txtDienThoai.bIsReadOnly = true;
                txtEmail.bIsReadOnly = false;

                txtHoDem.uText = "";
                txtTen.uText = "";
                txtDiaChi.uText = "";
                txtDienThoai.uText = "";
                txtEmail.uText = "";
                txtChucVu.uText = "";
                txtLoaiSuKien.uText = "";
                txtNamKinhNghiem.uText = "";
                txtNganhNghe.uText = "";
                txtLoaiNganhNghe.uText = "";
                txtDiaDiem.uText = "";
                txtIDCus.uText = "";
                txtSoLanQuet.uText = "";
                txtEmail.Focus();
                txtEmail.SelectAll();
            }

        }

        private void txtDienThoai_uKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtDienThoai.bIsReadOnly == false)
            {
                string DienThoai = cnn.sNull2String(txtDienThoai.uText);
                string MaSuKien = cnn.sNull2String(cboSuKien.uEditValue);
                if (DienThoai == "")
                {
                    return;
                }
                string str = "select Top 1 * from Customer where DienThoai = N'" + DienThoai + "' AND MaSuKien = N'" + MaSuKien + "' Order by Checked";
                DataTable dt = cnn.SelectRows(str);
                if (dt.Rows.Count == 0)
                {
                    if (chkSound.Checked == true)
                    {
                        string path = Application.StartupPath + @"\Sound\Wrong_Beep.wav";
                        SoundPlayer sp = new SoundPlayer(path);
                        sp.Play();
                    }
                    else
                        XtraMessageBox.Show("Không tìm thấy số điện thoại này! Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHoDem.uText = "";
                    txtTen.uText = "";
                    txtDiaChi.uText = "";
                    txtIDCus.uText = "";
                    txtEmail.uText = "";
                    txtChucVu.uText = "";
                    txtLoaiSuKien.uText = "";
                    txtNamKinhNghiem.uText = "";
                    txtNganhNghe.uText = "";
                    txtLoaiNganhNghe.uText = "";
                    txtDiaDiem.uText = "";
                    txtDienThoai.Focus();
                    txtDienThoai.SelectAll();
                    return;
                }
                //if (dt.Rows[0]["Checked"].ToString() == "True")
                //{
                //    if (chkSound.Checked == true)
                //    {
                //        string path = Application.StartupPath + @"\Sound\Loop_beep.wav";
                //        SoundPlayer sp = new SoundPlayer(path);
                //        sp.Play();
                //    }
                //    else
                //    {
                //        XtraMessageBox.Show("Khách hàng này đã kiểm tra rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //    txtHoDem.uText = "";
                //    txtTen.uText = "";
                //    txtDiaChi.uText = "";
                //    txtIDCus.uText = "";
                //    txtEmail.uText = "";
                //    txtChucVu.uText = "";
                //    txtLoaiSuKien.uText = "";
                //    txtNamKinhNghiem.uText = "";
                //    txtNganhNghe.uText = "";
                //    txtLoaiNganhNghe.uText = "";
                //    txtDiaDiem.uText = "";
                //    txtSoLanQuet.uText = "";
                //    txtDienThoai.Focus();
                //    txtDienThoai.SelectAll();
                //    return;
                //}
                txtHoDem.uText = dt.Rows[0]["HoDem"].ToString();
                txtTen.uText = dt.Rows[0]["Ten"].ToString();
                txtDiaChi.uText = dt.Rows[0]["DiaChi"].ToString();
                txtIDCus.uText = dt.Rows[0]["IDCustomer"].ToString();
                txtEmail.uText = dt.Rows[0]["Email"].ToString();
                txtChucVu.uText = dt.Rows[0]["ChucVu"].ToString();
                txtLoaiSuKien.uText = dt.Rows[0]["LoaiSuKien"].ToString();
                txtNamKinhNghiem.uText = dt.Rows[0]["NamKinhNghiem"].ToString();
                txtNganhNghe.uText = dt.Rows[0]["NganhNghe"].ToString();
                txtLoaiNganhNghe.uText = dt.Rows[0]["LoaiNganhNghe"].ToString();
                txtDiaDiem.uText = dt.Rows[0]["DiaDiem"].ToString();
                txtSoLanQuet.uText = (cnn.sNull2Int(dt.Rows[0]["SoLanQuet"].ToString()) + 1).ToString();
                try
                {
                    Hashtable Val = new Hashtable();
                    Hashtable Con = new Hashtable();
                    Val.Clear();
                    Con.Clear();
                    Val.Add("IDCustomer", dt.Rows[0]["IDCustomer"]);
                    Con.Add("Checked", 1);
                    Con.Add("SoLanQuet", cnn.sNull2Int(dt.Rows[0]["SoLanQuet"].ToString()) + 1);
                    cnn.UpdateRows(Con, Val, "Customer");
                    if (chkSound.Checked == true)
                    {
                        string path = Application.StartupPath + @"\Sound\Right_Beep.wav";
                        SoundPlayer sp = new SoundPlayer(path);
                        sp.Play();
                    }
                    txtDienThoai.SelectAll();
                }
                catch
                {
                    if (chkSound.Checked == true)
                    {
                        string path = Application.StartupPath + @"\Sound\Wrong_Beep.wav";
                        SoundPlayer sp = new SoundPlayer(path);
                        sp.Play();
                    }
                    else
                        XtraMessageBox.Show("Cập nhật không thành công! Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHoDem.uText = "";
                    txtTen.uText = "";
                    txtDiaChi.uText = "";
                    txtIDCus.uText = "";
                    txtEmail.uText = "";
                    txtChucVu.uText = "";
                    txtLoaiSuKien.uText = "";
                    txtNamKinhNghiem.uText = "";
                    txtNganhNghe.uText = "";
                    txtLoaiNganhNghe.uText = "";
                    txtDiaDiem.uText = "";
                    txtSoLanQuet.uText = "";
                    txtDienThoai.Focus();
                    txtDienThoai.SelectAll();
                }
            }
        }

        private void txtEmail_uKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtEmail.bIsReadOnly == false)
            {
                string Email = cnn.sNull2String(txtEmail.uText);
                string MaSuKien = cnn.sNull2String(cboSuKien.uEditValue);
                if (Email == "")
                {
                    return;
                }
                string str = "select Top 1 * from Customer where Email = N'" + Email + "' AND MaSuKien = N'" + MaSuKien + "' order by Checked";
                DataTable dt = cnn.SelectRows(str);
                if (dt.Rows.Count == 0)
                {
                    if (chkSound.Checked == true)
                    {
                        string path = Application.StartupPath + @"\Sound\Wrong_Beep.wav";
                        SoundPlayer sp = new SoundPlayer(path);
                        sp.Play();
                    }
                    else
                        XtraMessageBox.Show("Không tìm thấy số điện thoại này! Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHoDem.uText = "";
                    txtTen.uText = "";
                    txtDiaChi.uText = "";
                    txtIDCus.uText = "";
                    txtDienThoai.uText = "";
                    txtChucVu.uText = "";
                    txtLoaiSuKien.uText = "";
                    txtNamKinhNghiem.uText = "";
                    txtNganhNghe.uText = "";
                    txtLoaiNganhNghe.uText = "";
                    txtDiaDiem.uText = "";
                    txtSoLanQuet.uText = "";
                    txtEmail.Focus();
                    txtEmail.SelectAll();
                    return;
                }
                //if (dt.Rows[0]["Checked"].ToString() == "True")
                //{
                //    if (chkSound.Checked == true)
                //    {
                //        string path = Application.StartupPath + @"\Sound\Loop_beep.wav";
                //        SoundPlayer sp = new SoundPlayer(path);
                //        sp.Play();
                //    }
                //    else
                //    {
                //        XtraMessageBox.Show("Khách hàng này đã kiểm tra rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //    txtHoDem.uText = "";
                //    txtTen.uText = "";
                //    txtDiaChi.uText = "";
                //    txtIDCus.uText = "";
                //    txtDienThoai.uText = "";
                //    txtChucVu.uText = "";
                //    txtLoaiSuKien.uText = "";
                //    txtNamKinhNghiem.uText = "";
                //    txtNganhNghe.uText = "";
                //    txtLoaiNganhNghe.uText = "";
                //    txtDiaDiem.uText = "";
                //    txtSoLanQuet.uText = "";
                //    txtEmail.Focus();
                //    txtEmail.SelectAll();
                //    return;
                //}

                txtHoDem.uText = dt.Rows[0]["HoDem"].ToString();
                txtTen.uText = dt.Rows[0]["Ten"].ToString();
                txtDiaChi.uText = dt.Rows[0]["DiaChi"].ToString();
                txtIDCus.uText = dt.Rows[0]["IDCustomer"].ToString();
                txtDienThoai.uText = dt.Rows[0]["DienThoai"].ToString();
                txtChucVu.uText = dt.Rows[0]["ChucVu"].ToString();
                txtLoaiSuKien.uText = dt.Rows[0]["LoaiSuKien"].ToString();
                txtNamKinhNghiem.uText = dt.Rows[0]["NamKinhNghiem"].ToString();
                txtNganhNghe.uText = dt.Rows[0]["NganhNghe"].ToString();
                txtLoaiNganhNghe.uText = dt.Rows[0]["LoaiNganhNghe"].ToString();
                txtDiaDiem.uText = dt.Rows[0]["DiaDiem"].ToString();
                txtSoLanQuet.uText = (cnn.sNull2Int(dt.Rows[0]["SoLanQuet"].ToString()) + 1).ToString();
                try
                {
                    Hashtable Val = new Hashtable();
                    Hashtable Con = new Hashtable();
                    Val.Clear();
                    Con.Clear();
                    Val.Add("IDCustomer", dt.Rows[0]["IDCustomer"]);
                    Con.Add("Checked", 1);
                    Con.Add("SoLanQuet", cnn.sNull2Int(dt.Rows[0]["SoLanQuet"].ToString()) + 1);
                    cnn.UpdateRows(Con, Val, "Customer");
                    if (chkSound.Checked == true)
                    {
                        string path = Application.StartupPath + @"\Sound\Right_Beep.wav";
                        SoundPlayer sp = new SoundPlayer(path);
                        sp.Play();
                    }
                    txtEmail.SelectAll();
                }
                catch
                {
                    if (chkSound.Checked == true)
                    {
                        string path = Application.StartupPath + @"\Sound\Wrong_Beep.wav";
                        SoundPlayer sp = new SoundPlayer(path);
                        sp.Play();
                    }
                    else
                        XtraMessageBox.Show("Cập nhật không thành công! Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHoDem.uText = "";
                    txtTen.uText = "";
                    txtDiaChi.uText = "";
                    txtIDCus.uText = "";
                    txtDienThoai.uText = "";
                    txtChucVu.uText = "";
                    txtLoaiSuKien.uText = "";
                    txtNamKinhNghiem.uText = "";
                    txtNganhNghe.uText = "";
                    txtLoaiNganhNghe.uText = "";
                    txtDiaDiem.uText = "";
                    txtSoLanQuet.uText = "";
                    txtEmail.Focus();
                    txtEmail.SelectAll();
                }
            }
        }

        private void frmCheckCustommer_Load(object sender, EventArgs e)
        {
            string str = cnn.GetSQLString("SuKien");
            DataTable dt = new DataTable();
            dt = cnn.SelectRows(str);
            cboSuKien.uDataSource = dt;
        }
    }
}