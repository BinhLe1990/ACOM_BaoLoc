using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.OleDb;
using System.Collections;
using DELFI_WHM.NET.DELFI_Class;
using System.Management;
using DELFI_WHM.NET.Models;

namespace DELFI_WHM.NET.HeThong
{
    public partial class frmKey : DevExpress.XtraEditors.XtraForm
    {
        string main = "";
        string cpu = "";
        string hardware = "";
        string computername = "";
        string productkey = "";

        public frmKey()
        {
            InitializeComponent();            
        }

        private void frmKey_Load(object sender, EventArgs e)
        {
            main = GetSerial("Win32_BaseBoard", "SerialNumber");
            cpu = GetSerial("Win32_Processor", "processorID");
            hardware = GetSerial("Win32_DiskDrive", "SerialNumber").TrimStart().TrimEnd();
            computername = GetSerial("Win32_ComputerSystem", "DNSHostName");
            productkey = cpu + hardware + main;
            string requestkey = cpu + "!" + hardware + "!" + main + "!" + computername;
            txtRequestKey.uText = DELFIRegistry.Encrypt(requestkey, Properties.Settings.Default.Key_Encrypt);
        }

        public string GetSerial(string serialType, string selectType)
        {
            string result = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from " + serialType);
            foreach (ManagementObject info in searcher.Get())
            {
                result += info.GetPropertyValue(selectType).ToString();
            }
            return result;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            productkey = cpu + hardware + main;
            string result = "";
            result = DELFIRegistry.Decrypt(txtProductKey.uText, Properties.Settings.Default.Key_Encrypt);
            if (result == productkey)
            {
                if (DELFIRegistry.WriteRegistry("SYS", "ProductKey", productkey, Properties.Settings.Default.Key_Encrypt))
                {
                    //Insert to table License in SQL Server
                    using (DBACOMEntities db = new DBACOMEntities())
                    {
                        tblLicenseKey lc = new tblLicenseKey();
                        lc.Hardware = hardware;
                        lc.CPUInfo = cpu;
                        lc.ProductKey = productkey;
                        lc.RequestKey = txtRequestKey.uText;
                        lc.ComputerName = computername;
                        lc.RequestDate = DateTime.Now;
                        lc.ActiveDate = DateTime.Now;
                        db.tblLicenseKey.Add(lc);

                        if (db.SaveChanges() > 0)
                        {
                            XtraMessageBox.Show("Đăng ký thành công. Vui lòng đăng nhập lại phần mềm", "Thông báo");
                        }
                    }
                }
            }
        }
    }
}