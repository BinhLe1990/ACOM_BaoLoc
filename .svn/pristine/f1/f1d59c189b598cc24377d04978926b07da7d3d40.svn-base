using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Collections.Specialized;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DevExpress;
using DevExpress.XtraEditors;
using System.Security.Cryptography;

namespace DELFI_WHM.NET.DELFI_Class
{
    class DELFIConnectionMySql
    {
        public enum BSCLoadType
        {
            UseLoadProcess = 0,
            NoUseLoadProcess = 1,
        }

        private string strServerNameMySql = "";
        private string strUserIDMySql = "";
        private string strPortMySql = "";
        private string strPasswordMySql = "";
        private string strDatabaseMySql = "";
        private Exception exceptionLastErr = null;
        private MySqlConnection connectionMySql;
        private MySqlTransaction trans = null;


        public DELFIConnectionMySql()
        {

        }
        public string ServerNameMySql
        {
            get
            {
                return strServerNameMySql;
            }
            set
            {
                //if (value.IndexOfAny("\\()'\",;=".ToCharArray()) > 0)
                //    throw new Exception("Invalid Server Name");
                strServerNameMySql = value;
            }
        }
        public string PortMySql
        {
            get
            {
                return strPortMySql;
            }
            set
            {
                //if (value.IndexOfAny("\\()'\",;=".ToCharArray()) > 0)
                //    throw new Exception("Invalid Server Name");
                strPortMySql = value;
            }
        }
        public string DatabaseMySql
        {
            get
            {
                return strDatabaseMySql;
            }
            set
            {
                //if (value.IndexOfAny("\\()'\",;=".ToCharArray()) > 0)
                //    throw new Exception("Invalid Server Name");
                strDatabaseMySql = value;
            }
        }
        public string UserNameMySql
        {
            get
            {
                return strUserIDMySql;
            }
            set
            {
                //if (value.IndexOfAny("\\()'\",;=".ToCharArray()) > 0)
                //    throw new Exception("Invalid User Name");
                strUserIDMySql = value;
            }
        }
        public string PasswordMySql
        {
            set
            {
                strPasswordMySql = value;
            }
        }
        public string ConnectionStringMySql
        {
            get
            {
                string ConnStr = "";
                if (!strServerNameMySql.Equals(""))
                    ConnStr += "SERVER=" + strServerNameMySql + ";";
                if (!strUserIDMySql.Equals(""))
                    ConnStr += "UID=" + strUserIDMySql + ";";
                if (!strPasswordMySql.Equals(""))
                    ConnStr += "PASSWORD=" + strPasswordMySql + ";";
                if (!strDatabaseMySql.Equals(""))
                    ConnStr += "DATABASE=" + strDatabaseMySql;
                return ConnStr;
            }
            set
            {
                string inp = value;
                string[] arr = inp.Split(new char[] { ';' });
                string us = "", sv = "", ps = "", db = "";
                foreach (string str in arr)
                {
                    if (str.IndexOf('=') < 1) continue;
                    switch (str.Split(new char[] { '=' })[0].Trim().ToLower())
                    {
                        case "user id":
                        case "UID":
                            us = str.Split(new char[] { '=' })[1];
                            break;
                        case "data source":
                        case "SERVER":
                            sv = str.Split(new char[] { '=' })[1];
                            break;
                        case "password":
                        case "PASSWORD":
                            ps = str.Split(new char[] { '=' })[1];
                            break;
                        case "database":
                        case "DATABASE":
                            db = str.Split(new char[] { '=' })[1];
                            break;
                    }
                }

                //if (us.Equals(""))
                //    throw new Exception("User ID is missing");
                //if (sv.Equals(""))
                //    throw new Exception("Server is missing");
                strUserIDMySql = us;
                strServerNameMySql = sv;
                strPasswordMySql = ps;
                strDatabaseMySql = db;
            }
        }
        public DELFIConnectionMySql(string Server, string Port, string UserName, string Password, string Database)
        {
            strServerNameMySql = Server;
            strUserIDMySql = UserName;
            strPasswordMySql = Password;
            //string ConnStr = "SERVER=" + Server + ";PORT=" + Port + ";UID=" + UserName + ";PASSWORD=" + Password + ";DATABASE=" + Database + ";CHARSET=utf8";
            string ConnStr = "SERVER=" + Server + ";UID=" + UserName + ";PASSWORD=" + Password + ";DATABASE=" + Database + ";CHARSET=utf8";
            ConnectionStringMySql = ConnStr;
            connectionMySql = new MySqlConnection(ConnStr);
            try
            {
                connectionMySql.Open();
            }
            catch (Exception ex)
            {
                DELFIException.LogException(ex);
                exceptionLastErr = ex;
            }
        }
        public bool TestConnectMySql(string Server, string Port, string Username, string Password, string Database)
        {
            strServerNameMySql = Server;
            strUserIDMySql = Username;
            strPasswordMySql = Password;
            //string ConnStr = "SERVER=" + Server + ";PORT=" + Port + ";DATABASE=" + Database + ";UID=" + Username + ";PASSWORD=" + Password + ";CHARSET=utf8";
            string ConnStr = "SERVER=" + Server + ";DATABASE=" + Database + ";UID=" + Username + ";PASSWORD=" + Password + ";CHARSET=utf8";
            ConnectionStringMySql = ConnStr;
            bool Flag = false;
            try
            {
                if (connectionMySql.State == ConnectionState.Open)
                    connectionMySql.Close();
            }
            catch { Flag = false; }
            connectionMySql = new MySqlConnection(ConnStr);
            try
            {
                connectionMySql.Open();
                Flag = true;
                connectionMySql.Close();
            }
            catch (Exception ex)
            {
                //DELFIException.LogException(ex);
                XtraMessageBox.Show(ex.ToString(), "error");
                exceptionLastErr = ex;
                Flag = false;
            }
            return Flag;
        }
        public bool InsertNewRowMySql(Hashtable Values, string Table)
        {
            MySqlCommand command = connectionMySql.CreateCommand();
            command.Parameters.Clear();
            string SQLStr = "Insert Into " + Table + "(";
            string columns = "";
            string values = "";
            foreach (DictionaryEntry Ent in Values)
            {
                try
                {
                    if (null == Ent.Value)
                    {
                        columns += Ent.Key.ToString() + ",";
                        values += "NULL,";
                    }
                    else
                    {
                        bool flag = true;
                        if (Ent.Value.GetType().Name != "Object")
                        {
                            switch (Ent.Value.GetType().Name.ToLower())
                            {
                                case "stream":
                                    values += "@" + Ent.Key.ToString() + ",";
                                    Stream inp = (Stream)Ent.Value;
                                    byte[] Buff = new byte[inp.Length];
                                    inp.Read(Buff, 0, (int)inp.Length);
                                    command.Parameters.Add("@" + Ent.Key.ToString(), SqlDbType.Image).Value = Buff;
                                    flag = false;
                                    break;
                                case "byte[]":
                                    values += "@" + Ent.Key.ToString() + ",";
                                    byte[] bBuff = (byte[])Ent.Value;
                                    command.Parameters.Add("@" + Ent.Key.ToString(), SqlDbType.Image).Value = bBuff;
                                    flag = false;
                                    break;
                                case "bitmap":
                                    values += "@" + Ent.Key.ToString() + ",";
                                    Bitmap pBuff = (Bitmap)Ent.Value;
                                    MemoryStream ms = new MemoryStream();
                                    BinaryFormatter bf = new BinaryFormatter();
                                    bf.Serialize(ms, pBuff);
                                    byte[] bmpBytes = ms.GetBuffer();
                                    command.Parameters.Add("@" + Ent.Key.ToString(), SqlDbType.Image).Value = bmpBytes;
                                    flag = false;
                                    break;
                                default:
                                    break;
                            }
                        }
                        columns += Ent.Key.ToString() + ",";
                        if (flag)
                        {
                            values += DELFIConnection.GetString(Ent.Value) + ",";
                        }
                    }
                }
                catch { }
            }
            SQLStr += columns.Substring(0, columns.Length - 1) + ") Values (" + values.Substring(0, values.Length - 1) + ")";
            command.CommandText = SQLStr;
            if (connectionMySql.State == ConnectionState.Closed)
            {
                connectionMySql.Open();
            }
            command.Connection = this.connectionMySql;
            if (trans != null)
                command.Transaction = trans;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //catch (Exception ex)
            //{
            //    DELFIException.LogException(ex);
            //    exceptionLastErr = ex;
            //    return false;
            //}
            finally
            {
                if (trans == null)
                {
                    if (connectionMySql.State == ConnectionState.Open)
                    {
                        connectionMySql.Close();
                    }
                }
            }
            return true;
        }
        public void BeginTransaction()
        {
            if (trans != null)
            {
                if (trans.Connection == null)
                {
                    trans = null;
                }
                else
                {
                    try
                    {
                        trans.Commit();

                        trans.Dispose();
                    }
                    catch (Exception ex)
                    {
                        DELFIException.LogException(ex);
                        exceptionLastErr = ex;
                    }
                }
            }
            try
            {
                if (connectionMySql.State == ConnectionState.Closed)
                {
                    connectionMySql.Open();
                }
                trans = connectionMySql.BeginTransaction();
            }
            catch (Exception ex)
            {
                DELFIException.LogException(ex);
                exceptionLastErr = ex;
            }
        }
        /// <summary>
        /// Commit current Transaction.
        /// </summary>
        public void EndTransaction()
        {
            try
            {
                trans.Commit();
                trans = null;
                connectionMySql.Close();
            }
            catch (Exception ex)
            {
                DELFIException.LogException(ex);
                exceptionLastErr = ex;
            }
        }
        /// <summary>
        /// Rollback current Transaction.
        /// </summary>
        public void RollbackTransaction()
        {
            try
            {
                trans.Rollback();
                connectionMySql.Close();
            }
            catch (Exception ex)
            {
                DELFIException.LogException(ex);
                exceptionLastErr = ex;
            }
        }
    }
}
