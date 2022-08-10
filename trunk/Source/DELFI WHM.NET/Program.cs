using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Reflection;
using DELFI_WHM.NET.Models;
using DELFI_WHM.NET.DELFI_Class;
using System.Management;
using System.Linq;
using System.Globalization;
using System.Threading;
using System.Diagnostics;

namespace DELFI_WHM.NET
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static string sServerName = ".";
        public static string sDatabaseName = "";
        public static string sUserName = "";
        public static string SPassword = "";
        public static string sConnection = "";
        public static string sUserID = "";
        public static string sPathServer = "";
        public static string sPathHinhAnh = "";

        public static string sServerMySql = ".";
        public static string sPortMySql = "";
        public static string sDatabaseMySql = "";
        public static string sUserMySql = "";
        public static string SPasswordMySql = "";

        public static string GetSerial(string serialType, string selectType)
        {
            string result = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from " + serialType);
            foreach (ManagementObject info in searcher.Get())
            {
                result += info.GetPropertyValue(selectType).ToString();
            }
            return result;            
        }

        [STAThread]
        static void Main()
        {
            CultureInfo cultureDefinition = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
            cultureDefinition.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            cultureDefinition.DateTimeFormat.ShortTimePattern = "HH:mm:ss";
            cultureDefinition.DateTimeFormat.LongDatePattern = "dd/MM/yyyy";
            cultureDefinition.DateTimeFormat.LongTimePattern = "HH:mm:ss";
            cultureDefinition.DateTimeFormat.DateSeparator = "/";
            Thread.CurrentThread.CurrentCulture = cultureDefinition;

            DevExpress.UserSkins.OfficeSkins.Register();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(Properties.Settings.Default.SKIN_CAPTION);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
               
                    if (LoadValue())
                    {
                        if (!Properties.Settings.Default.Restore_Mode)
                        {
                            Application.Run(new FrHT.FrND.frmDangNhap());
                        }
                        else
                        {

                            Properties.Settings.Default.Restore_Mode = false;
                            Properties.Settings.Default.Save();
                            Application.Run(new HeThong.FrHT.frmRestore());
                        }
                    }
                    else
                    {
                        try
                        {
                            Application.Run(new FrHT.FrND.frmDangNhap());
                        }
                        catch
                        {

                            Application.Run(new DELFI_WHM.NET.HeThong.frmHeThong(true));
                        }
                    }
                
            }
            catch
            {
                Application.Run(new FrHT.FrND.frmDangNhap());
            }

        }

        static bool LoadValue()
        {
            try
            {               
                DELFI_Class.DELFIRegistry.ReadRegistry("SYS", "ServerName", out sServerName, "Delfi VN");
                DELFI_Class.DELFIRegistry.ReadRegistry("SYS", "UserName", out sUserName, "Delfi VN");
                DELFI_Class.DELFIRegistry.ReadRegistry("SYS", "Password", out SPassword, "Delfi VN");
                DELFI_Class.DELFIRegistry.ReadRegistry("SYS", "Database", out sDatabaseName, "Delfi VN");

                DELFI_Class.DELFIRegistry.ReadRegistry("SYS", "ServerMySql", out sServerMySql, "Delfi VN");
                DELFI_Class.DELFIRegistry.ReadRegistry("SYS", "PortMySql", out sPortMySql, "Delfi VN");
                DELFI_Class.DELFIRegistry.ReadRegistry("SYS", "UserMySql", out sUserMySql, "Delfi VN");
                DELFI_Class.DELFIRegistry.ReadRegistry("SYS", "PasswordMySql", out SPasswordMySql, "Delfi VN");
                DELFI_Class.DELFIRegistry.ReadRegistry("SYS", "DatabaseMySql", out sDatabaseMySql, "Delfi VN");

                if (sServerName.Trim().Length <= 0)
                    return false;
                return true;
            }
            catch { }
            return false;
        }
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            DELFI_Class.DELFIException.LogException(e.Exception);
            if (e.Exception.Message == "File not found.")
                DevExpress.XtraEditors.XtraMessageBox.Show("Không tồn tại tập tin mà bạn chọn.", "Tập tin không tồn tại");
            if (DevExpress.XtraEditors.XtraMessageBox.Show("Không thể tiếp tục.\nBạn có muốn xem thông tin hay không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                DevExpress.XtraEditors.XtraMessageBox.Show(e.Exception.ToString());
        }
    }
}