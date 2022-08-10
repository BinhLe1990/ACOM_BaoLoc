using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Reflection;

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

        [STAThread]
        static void Main()
        {
            DevExpress.UserSkins.OfficeSkins.Register();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(Properties.Settings.Default.SKIN_CAPTION);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
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
                Application.Run(new DELFI_WHM.NET.HeThong.frmHeThong(true));
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
            if (DevExpress.XtraEditors.XtraMessageBox.Show("Chương trình phát hiện có một lỗi phát sinh mới.\nBạn hãy liên hệ với nhà quản lý để được hỗ trợ thông tin.\nBạn có muốn xem thông tin lỗi phát sinh đó hay không?", "Lỗi phát sinh", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                DevExpress.XtraEditors.XtraMessageBox.Show(e.Exception.ToString());
        }
    }
}