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
//using DevExpress;
using DevExpress.XtraEditors;
using System.Security.Cryptography;

namespace DELFI_WHM.NET.DELFI_Class
{
    public class DELFIConnection
    {
        public enum BSCLoadType
        {
            UseLoadProcess = 0,
            NoUseLoadProcess = 1,
        }
        private string strServerName = "";
        private string strUserID = "";
        private string strPassword = "";
        private string strDatabase = "";
        private Exception exceptionLastErr = null;
        /// <summary>
        /// Get the curent Server.
        /// </summary>
        /// 
     
        public string ServerName
        {
            get
            {
                return strServerName;
            }
            set
            {
                //if (value.IndexOfAny("\\()'\",;=".ToCharArray()) > 0)
                //    throw new Exception("Invalid Server Name");
                strServerName = value;
            }
        }
        public string Database
        {
            get
            {
                return strDatabase;
            }
            set
            {
                //if (value.IndexOfAny("\\()'\",;=".ToCharArray()) > 0)
                //    throw new Exception("Invalid Server Name");
                strDatabase = value;
            }
        }
     
        public string UserName
        {
            get
            {
                return strUserID;
            }
            set
            {
                //if (value.IndexOfAny("\\()'\",;=".ToCharArray()) > 0)
                //    throw new Exception("Invalid User Name");
                strUserID = value;
            }
        }
     
        public string Password
        {
            set
            {
                strPassword = value;
            }
        }
      
        public string ConnectionString
        {
            get
            {
                string ConnStr = "";
                if (!strServerName.Equals(""))
                    ConnStr += "Data Source=" + strServerName + ";";
                if (!strUserID.Equals(""))
                    ConnStr += "User ID=" + strUserID + ";";
                if (!strPassword.Equals(""))
                    ConnStr += "Password=" + strPassword + ";";
                if (!strDatabase.Equals(""))
                    ConnStr += "Initial Catalog=" + strDatabase;
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
                        case "uid":
                            us = str.Split(new char[] { '=' })[1];
                            break;
                        case "data source":
                        case "server":
                            sv = str.Split(new char[] { '=' })[1];
                            break;
                        case "password":
                        case "pwd":
                            ps = str.Split(new char[] { '=' })[1];
                            break;
                        case "database":
                        case "initial catalog":
                            db = str.Split(new char[] { '=' })[1];
                            break;
                    }
                }

                if (us.Equals(""))
                    throw new Exception("User ID is missing");
                if (sv.Equals(""))
                    throw new Exception("Server is missing");
                strUserID = us;
                strServerName = sv;
                strPassword = ps;
                strDatabase = db;
            }
        }
     
        public Exception LastError
        {
            get
            {
                return exceptionLastErr;
            }
        }
        public SqlConnection Connection
        {
            get
            {
                return connection;
            }
        }
        public int iNguoiDung;
        private SqlConnection connection;
        public SqlCommand command = new SqlCommand();
        private SqlTransaction trans = null;

        #region BSC Connection
        public void Dispose()
        {
            try
            {
                connection.Dispose();
                command.Dispose();
                trans.Dispose();
            }
            catch (Exception ex)
            { DELFIException.LogException(ex); }
        }
        public DELFIConnection()
        {

        }
      
        /// <summary>
        /// Initial a new SqlConnect Class.
        /// </summary>
        /// <param name="Connectionstring">String used to open an Sql database </param>
        public DELFIConnection(string Connectionstring)
        {

            ConnectionString = Connectionstring;
            string ConnStr = "Data Source=" + ServerName + ";User ID=" + UserName + ";password=" + strPassword + ";Database=" + strDatabase ;

            connection = new SqlConnection(ConnStr);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                DELFIException.LogException(ex);
                exceptionLastErr = ex;
            }
        }
        /// <summary>
        /// Initial a new SqlConnect Class.
        /// </summary>
        /// <param name="Server">The name of database server, "." for the local.</param>
        /// <param name="Username">The username used to connect to database server.</param>
        /// <param name="Password">The password used for the user</param>
        public DELFIConnection(string Server, string Username, string Password, string Database)
        {
            strServerName = Server;
            strUserID = Username;
            strPassword = Password;
            string ConnStr = "Data Source=" + Server + ";User ID=" + UserName + ";Password=" + Password + ";Database=" + Database;
            ConnectionString = ConnStr;
            connection = new SqlConnection(ConnStr);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                DELFIException.LogException(ex);
                exceptionLastErr = ex;
            }
        }
      
        /// <summary>
        /// Open a Connection to Database Server.
        /// </summary>
        public bool TestConnect(string Server, string Username, string Password, string Database)
        {
            strServerName = Server;
            strUserID = Username;
            strPassword = Password;
            string ConnStr = "Data Source = " + Server + "; User ID = " + UserName + "; Password = " + Password + "; Database = " + Database;
            ConnectionString = ConnStr;
            bool Flag = false;
            try
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            catch { Flag = false; }
            connection = new SqlConnection();
            connection.ConnectionString = ConnStr;
            try
            {
                connection.Open();
                Flag = true;
            }
            catch (Exception ex)
            {
                DELFIException.LogException(ex);
                exceptionLastErr = ex;
                Flag = false;
            }
            return Flag;
        }
        /// <summary>
        /// Open a Connection to Database Server.
        /// </summary>
        public bool TestConnect(string ConnStr)
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
            connection.ConnectionString = ConnStr;
            bool Flag = false;
            try
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
            catch { Flag = false; }
            connection = new SqlConnection();
            connection.ConnectionString = ConnStr;
            try
            {
                connection.Open();
                Flag = true;
            }
            catch (Exception ex)
            {
                DELFIException.LogException(ex);
                exceptionLastErr = ex;
                Flag = false;
            }
            return Flag;
        }
        /// <summary>
        /// Close the current Connection.
        /// </summary>
        public void Disconnect()
        {
            connection.Close();
        }

        #endregion


        #region Transaction
        /// <summary>
        /// Begin a new Transation.
        /// </summary>

        public void BeginTransaction(IsolationLevel Level)
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
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                trans = connection.BeginTransaction(Level);
            }
            catch (Exception ex)
            {
                DELFIException.LogException(ex);
                exceptionLastErr = ex;
            }
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
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                trans = connection.BeginTransaction();
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
                connection.Close();
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
                connection.Close();
            }
            catch (Exception ex)
            {
                DELFIException.LogException(ex);
                exceptionLastErr = ex;
            }
        }
        #endregion


        #region Data Container
        /// <summary>
        /// Create an Instance of System.Data.Dataset Class
        /// </summary>
        /// <param name="SelectQuerryString">Querry String verifying Data to fill in the Dataset</param>
        /// <returns></returns>
        public DataSet CreateDataset(string SelectQueryString)
        {
            if (command == null)
                command = new SqlCommand();
            command.CommandText = SelectQueryString;
            command.Connection = this.connection;
            command.CommandType = CommandType.Text;
            SqlDataAdapter Adpt = new SqlDataAdapter(command);
            DataSet Rslt = new DataSet();
            try
            {
                Adpt.Fill(Rslt);
            }
            catch (Exception ex)
            {
                DELFIException.LogException(ex);
                exceptionLastErr = ex;
                return null;
            }
            return Rslt;
        }
        /// <summary>
        /// Create an Instance of System.Data.DataTable Class
        /// </summary>
        /// <param name="SelectQuerryString">Querry String verifying Data to fill in the DataTable</param>
        /// <returns></returns>



        public DataTable CreateDataTable(string sSQL)
        {
            //if (command == null)
            //    command = new SqlCommand();
            //command.CommandText = SelectQueryString;
            //command.Connection = this.connection;
            //command.CommandType = CommandType.Text;
            //SqlDataAdapter Adpt = new SqlDataAdapter(command);
            //DataTable Rslt = new DataTable();
            //try
            //{
            //    Adpt.Fill(Rslt);
            //}
            //catch (Exception ex)
            //{
            //    DELFIException.LogException(ex);
            //    exceptionLastErr = ex;
            //    return null;
            //}
            //return Rslt;

            if (sSQL == "" || sSQL == null)
                return null;
            System.Data.SqlClient.SqlDataAdapter sqlDA;
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            if (trans != null)
                command.Transaction = trans;
            System.Data.DataTable DTT = new System.Data.DataTable();
            try
            {
                command.CommandText = sSQL;
                command.Connection = connection;
                sqlDA = new SqlDataAdapter(command);
                sqlDA.Fill(DTT);
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.ToString(), e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (trans == null)
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            return DTT;
        }
        /// <summary>
        /// Create an Instance of System.Data.DataTable Class
        /// </summary>
        /// <param name="SelectQuerryString">Querry String verifying Data to fill in the DataTable</param>
        /// <returns></returns>
        public DataTable CreateDataTable(string SelectQueryString, BSCLoadType LType)
        {
            if (LType == BSCLoadType.NoUseLoadProcess)
                return CreateDataTable(SelectQueryString);
            frmSQLProcess frm = new frmSQLProcess(this.ConnectionString, SelectQueryString);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DataTable reDt = frm.reValue;
                frm.Dispose();
                return reDt;
            }
            return null;
        }
        public DataTable CreateDataTable(string SelectQueryString, string TableName)
        {
            if (command == null)
                command = new SqlCommand();
            command.CommandText = SelectQueryString;
            command.Connection = this.connection;
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            command.CommandType = CommandType.Text;
            if (trans != null)
                command.Transaction = trans;

            SqlDataAdapter Adpt = new SqlDataAdapter(command);
            DataTable Rslt = new DataTable(TableName);
            try
            {
                Adpt.Fill(Rslt);
            }
            catch (Exception ex)
            {
                DELFIException.LogException(ex);
                exceptionLastErr = ex;
                return null;
            }
            finally
            {
                if (trans == null)
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            return Rslt;
        }
        public DataTable CreateDataTable(string SelectQueryString, BSCLoadType LType, string TableName)
        {
            if (LType == BSCLoadType.NoUseLoadProcess)
                return CreateDataTable(SelectQueryString);
            frmSQLProcess frm = new frmSQLProcess(this.ConnectionString, SelectQueryString);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DataTable reDt = frm.reValue;
                reDt.TableName = TableName;
                frm.Dispose();
                return reDt;
            }
            return null;
        }
        #endregion

        #region Data Execution
        /// <summary>
        /// Execute a non-querry with current Connection
        /// </summary>
        /// <param name="QuerryString">Querry String used for executing</param>
        /// <returns>Number of affected rows</returns>
        public int ExecuteNonQuery(string QueryString)
        {
            command.Parameters.Clear();
            command.CommandText = QueryString;
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            command.Connection = this.connection;
            if (trans != null)
                command.Transaction = trans;
            int Rs = -1;
            try
            {
                Rs = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (trans == null)
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            return Rs;
        }

        /// <summary>
        /// Insert a new data Row into the specified Table with the current Connection.
        /// </summary>
        /// <param name="Values">HashTable contains the column names with specified values.</param>
        /// <param name="Table">Name of the Table to insert into.</param>
        /// <returns>True for successful inserted. Otherwise, false.</returns>
        public bool InsertNewRow(Hashtable Values, string Table)
        {
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
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            command.Connection = this.connection;
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
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// Insert a new data Row into the specified Table.
        /// </summary>
        /// <param name="Columns">Names of the inserted Columns.</param>
        /// <param name="Values">Values to insert into the Table.</param>
        /// <param name="Table">Name of the inserted table.</param>
        /// <param name="Connection">Connection to the Database.</param>
        /// <returns></returns>
        public bool InsertNewRow(string[] Columns, string[] Values, string Table)
        {
            if (Columns.Length != Values.Length || Columns.Length <= 0)
                throw new Exception("Invalid Arguments, Columns number and Values Number do not macth");
            string SQLStr = "insert into " + Table + "( ";
            foreach (string Str in Columns)
            {
                SQLStr += Str + ",";
            }
            SQLStr = SQLStr.Substring(0, SQLStr.Length - 1) + ") values(";

            foreach (string Str in Values)
            {
                SQLStr += "'" + Str + "',";
            }
            SQLStr = SQLStr.Substring(0, SQLStr.Length - 1) + ")";
            command.CommandText = SQLStr;
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            command.Connection = connection;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                DELFIException.LogException(ex);
                exceptionLastErr = ex;
                return false;
            }
            finally
            {
                if (trans == null)
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            return true;
        }
        public bool UpdateRows(string QueryString)
        {
            if (command == null)
                command = new SqlCommand();
            if (trans != null)
                command.Transaction = trans;
            command.CommandText = QueryString;
            command.Connection = this.connection;
            command.CommandType = CommandType.Text;
            int Rs = -1;
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            command.Connection = this.connection;
            try
            {
                Rs = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                DELFIException.LogException(ex);
                exceptionLastErr = ex;
                return false;
            }
            finally
            {
                if (trans == null)
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// Update a data Row in a specified Table with the current Connection.
        /// </summary>
        /// <param name="Values">HashTable contains the column names with specified values.</param>
        /// <param name="Condition">HashTable contains the condition to update.</param>
        /// <param name="Table">Name of the Table to update.</param>
        /// <returns>True for successful inserted. Otherwise, false.</returns>
        public bool UpdateRows(Hashtable Values, Hashtable Condition, string Table)
        {
            string SQLStr = "Update " + Table + " Set ";
            string str = "";
            foreach (DictionaryEntry Ent in Values)
            {
                bool flag = true;
                try
                {
                    if (Ent.Value.GetType().Name != "Object")
                    {
                        if (Ent.Value.GetType().Name == "Stream" || Ent.Value.GetType().BaseType.Name == "Stream")
                        {
                            str += Ent.Key.ToString() + "=@" + Ent.Key.ToString() + ", ";
                            Stream inp = (Stream)Ent.Value;
                            byte[] Buff = new byte[inp.Length];
                            inp.Read(Buff, 0, (int)inp.Length);
                            command.Parameters.Add("@" + Ent.Key.ToString(), SqlDbType.Image).Value = Buff;
                            flag = false;
                        }
                        if (Ent.Value.GetType().Name.ToLower() == "byte[]")
                        {
                            str += Ent.Key.ToString() + "=@" + Ent.Key.ToString() + ", ";
                            byte[] Buff = (byte[])Ent.Value;
                            command.Parameters.Add("@" + Ent.Key.ToString(), SqlDbType.Image).Value = Buff;
                            flag = false;
                        }
                        if (Ent.Value.GetType().Name.ToLower() == "bitmap")
                        {
                            Bitmap pBuff = (Bitmap)Ent.Value;
                            MemoryStream ms = new MemoryStream();
                            BinaryFormatter bf = new BinaryFormatter();
                            bf.Serialize(ms, pBuff);
                            byte[] bmpBytes = ms.GetBuffer();
                            command.Parameters.Add("@" + Ent.Key.ToString(), SqlDbType.Image).Value = bmpBytes;
                            flag = false;
                        }
                    }
                }
                catch
                {
                    str += Ent.Key.ToString() + "=NULL, ";
                    flag = false;
                }
                if (flag)
                    str += Ent.Key.ToString() + "=" + DELFIConnection.GetString(Ent.Value) + ", ";
            }
            SQLStr += str.Substring(0, str.Length - 2) + " Where ";
            str = GetCondition(Condition);
            if (str != "")
                SQLStr += "(" + str + ")";
            command.CommandText = SQLStr;
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            command.Connection = this.connection;
            if (trans != null)
                command.Transaction = trans;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                DELFIException.LogException(ex);
                exceptionLastErr = ex;
                return false;
            }
            finally
            {
                command.Parameters.Clear();
                if (trans == null)
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// Update a data Row in a specified Table with the current Connection.
        /// </summary>
        /// <param name="Values">HashTable contains the column names with specified values.</param>
        /// <param name="Condition">HashTable contains the condition to update.</param>
        /// <param name="Table">Name of the Table to update.</param>
        /// <param name="ExtCond">Extended condition string.</param>
        /// <returns>True for successful inserted. Otherwise, false.</returns>
        public bool UpdateRows(Hashtable Values, Hashtable Condition, string ExtCondition, string Table)
        {
            string SQLStr = "Update " + Table + " Set ";
            string str = "";
            foreach (DictionaryEntry Ent in Values)
            {
                str += Ent.Key.ToString() + "=" + DELFIConnection.GetString(Ent.Value) + ", ";
            }

            SQLStr += str.Substring(0, str.Length - 2) + " Where ";
            str = GetCondition(Condition);
            if (str != "")
                SQLStr += "(" + str + ") and ";
            SQLStr += "(" + ExtCondition + ")";

            command.CommandText = SQLStr;
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            command.Connection = this.connection;
            if (trans != null)
                command.Transaction = trans;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                DELFIException.LogException(ex);
                exceptionLastErr = ex;
                return false;
            }
            finally
            {
                if (trans == null)
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// Delete data Rows in a specified Table with the current Connection.
        /// </summary>
        /// <param name="Condition">HashTable contains the condition to delete.</param>
        /// <param name="Table">Name of the Table to delete.</param>
        /// <returns>Boolean</returns>
        public bool DeleteRows(string QueryString)
        {
            if (command == null)
                command = new SqlCommand();
            if (trans != null)
                command.Transaction = trans;
            command.CommandText = QueryString;
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            command.Connection = this.connection;
            command.CommandType = CommandType.Text;
            if (trans != null)
                command.Transaction = trans;
            int Rs = -1;
            try
            {
                Rs = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                DELFIException.LogException(ex);
                exceptionLastErr = ex;
                return false;
            }
            finally
            {
                if (trans == null)
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            return true;
        }
        public bool DeleteRows(Hashtable Condition, string Table)
        {
            string SQLStr = "Delete From " + Table + " Where ";
            string str = "";
            str = GetCondition(Condition);
            SQLStr += "(" + str + ")";
            command.CommandText = SQLStr;
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            command.Connection = this.connection;
            if (trans != null)
                command.Transaction = trans;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                DELFIException.LogException(ex);
                exceptionLastErr = ex;
                return false;
            }
            finally
            {
                if (trans == null)
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            return true;
        }

        #endregion

        #region SelectQuery
        /// <summary>
        /// Create an Instance of System.Data.DataTable Class
        /// </summary>
        /// <param name="SelectQuerryString">Querry String verifying Data to fill in the DataTable</param>
        /// <returns></returns>
        public DataTable SelectRows(string SelectQueryString)
        {
            if (ExistField(CreateDataTable(SelectQueryString), "SortOrder"))
                return CreateDataTable("select top 100 percent * from (" + SelectQueryString + ")Tb order by SortOrder");
            return CreateDataTable(SelectQueryString);
        }
        /// <summary>
        /// Create an Instance of System.Data.DataTable Class
        /// </summary>
        /// <param name="SelectQuerryString">Querry String verifying Data to fill in the DataTable</param>
        /// <returns></returns>
        public DataTable SelectRows(string SelectQueryString, BSCLoadType LType)
        {
            if (ExistField(CreateDataTable(SelectQueryString), "SortOrder"))
                return CreateDataTable("select top 100 percent * from (" + SelectQueryString + ")Tb order by SortOrder", LType);
            return CreateDataTable(SelectQueryString, LType);
        }
        public DataTable SelectRows(string SelectQueryString, string TableName)
        {
            if (ExistField(CreateDataTable(SelectQueryString), "SortOrder"))
                return CreateDataTable("select top 100 percent * from (" + SelectQueryString + ")Tb order by SortOrder", TableName);
            return CreateDataTable(SelectQueryString, TableName);
        }
        public DataTable SelectRows(string SelectQueryString, BSCLoadType LType, string TableName)
        {
            if (ExistField(CreateDataTable(SelectQueryString), "SortOrder"))
                return CreateDataTable("select top 100 percent * from (" + SelectQueryString + ")Tb order by SortOrder", LType, TableName);
            return CreateDataTable(SelectQueryString, LType, TableName);
        }
        /// <summary>
        /// Get data from Sql database server.
        /// </summary>
        /// <param name="Condition">Condition to get.</param>
        /// <param name="Table">Name of table to get data.</param>
        /// <returns>DataTable</returns>
        public DataTable SelectRows(Hashtable Condition, string Table)
        {
            return SelectRows(new string[] { "*" }, Condition, Table, "");
        }
        /// <summary>
        /// Get data from Sql database server.
        /// </summary>
        /// <param name="Condition">Condition to get.</param>
        /// <param name="ExtCond">Extended condition string </param>
        /// <param name="Table">Name of table to get data.</param>
        /// <returns>DataTable</returns>
        public DataTable SelectRows(Hashtable Condition, string ExtCond, string Table)
        {
            string SQLStr = "";
            if (Table.ToLower().Contains("select"))
                SQLStr = "select * from (" + Table + ")A ";
            else
                SQLStr = "select * from " + Table;
            string str = "";
            if (Condition.Count > 0)
            {
                str = GetCondition(Condition);
                SQLStr += " where (" + str + ") and ";
                SQLStr += ExtCond;
            }
            else
            {
                SQLStr += " where (" + ExtCond + ")";
            }
            DataTable dt = CreateDataTable(SQLStr);
            if (ExistField(dt, "SortOrder"))
                return CreateDataTable("select top 100 percent * from (" + SQLStr + ")Tb order by SortOrder");
            return dt;
        }
        /// <summary>
        /// Get data from Sql database server.
        /// </summary>
        /// <param name="Condition">Condition to get.</param>
        /// <param name="Table">Name of table to get data.</param>
        /// <returns>DataTable</returns>
        public DataTable SelectRows(Hashtable Condition, string Table, BSCLoadType LType)
        {
            return SelectRows(new string[] { "*" }, Condition, Table, "", LType);
        }
        /// <summary>
        /// Get data from Sql database server.
        /// </summary>
        /// <param name="Condition">Condition to get.</param>
        /// <param name="ExtCond">Extended condition string </param>
        /// <param name="Table">Name of table to get data.</param>
        /// <returns>DataTable</returns>
        public DataTable SelectRows(Hashtable Condition, string ExtCond, string Table, BSCLoadType LType)
        {
            string SQLStr = "";
            if(Table.ToLower().Contains("select"))
                SQLStr = "select * from (" + Table + ")A ";
            else
                SQLStr = "select * from " + Table;
            string str = "";
            if (Condition.Count > 0)
            {
                str = GetCondition(Condition);
                SQLStr += " where (" + str + ") and ";
                SQLStr += ExtCond;
            }
            else
            {
                SQLStr += " where (" + ExtCond + ")";
            }
            DataTable dt = CreateDataTable(SQLStr, LType);
            if (ExistField(dt, "SortOrder"))
                return CreateDataTable("select top 100 percent * from (" + SQLStr + ")Tb order by SortOrder", LType);
            return dt;
        }
        /// <summary>
        /// Get data from Sql database server.
        /// </summary>
        /// <param name="Condition">Condition to get.</param>
        /// <param name="Table">Name of table to get data.</param>
        /// <returns>DataTable</returns>
        public DataTable SelectRows(string[] Columns, Hashtable Condition, string Table)
        {
            return SelectRows(Columns, Condition, Table, "");
        }
        /// <summary>
        /// Get data from Sql database server.
        /// </summary>
        /// <param name="Condition">Condition to get.</param>
        /// <param name="Table">Name of table to get data.</param>
        /// <returns>DataTable</returns>
        public DataTable SelectRows(string[] Columns, Hashtable Condition, string Table, string OrderByString)
        {
            string SQLStr = "select ";
            foreach (string str in Columns)
            {
                SQLStr += str + ",";
            }
            SQLStr = SQLStr.Substring(0, SQLStr.Length - 1);
            if(Table.ToLower().Contains("select"))
                SQLStr += " from (" + Table + ")A ";
            else
                SQLStr += " from " + Table;
            string str1 = GetCondition(Condition);
            if (str1 != "")
                SQLStr += " where ( " + str1 + " )";
            if (OrderByString.Trim() != "")
                SQLStr += " order by " + OrderByString;
            DataTable dt = CreateDataTable(SQLStr);
            if (ExistField(dt, "SortOrder"))
                return CreateDataTable("select top 100 percent * from (" + SQLStr + ")Tb order by SortOrder");
            return dt;
        }
        public DataTable SelectRows(string[] Columns, Hashtable Condition, string Table, BSCLoadType LType)
        {
            return SelectRows(Columns, Condition, Table, "", LType);
        }
        /// <summary>
        /// Get data from Sql database server.
        /// </summary>
        /// <param name="Condition">Condition to get.</param>
        /// <param name="Table">Name of table to get data.</param>
        /// <returns>DataTable</returns>
        public DataTable SelectRows(string[] Columns, Hashtable Condition, string Table, string OrderByString, BSCLoadType LType)
        {
            string SQLStr = "select ";
            foreach (string str in Columns)
            {
                SQLStr += str + ",";
            }
            SQLStr = SQLStr.Substring(0, SQLStr.Length - 1);
            if(Table.ToLower().Contains("select"))
                SQLStr += " from (" + Table + ")A";
            else
                SQLStr += " from " + Table;
            string str1 = GetCondition(Condition);
            if (str1 != "")
                SQLStr += " where ( " + str1 + " )";
            if (OrderByString.Trim() != "")
                SQLStr += " order by " + OrderByString;
            DataTable dt = CreateDataTable(SQLStr, LType);
            if (ExistField(dt, "SortOrder"))
                return CreateDataTable("select top 100 percent * from (" + SQLStr + ")Tb order by SortOrder", LType);
            return dt;
        }
        public StringCollection SelectRows(string Column, Hashtable Condition, string Table)
        {
            return SelectRows(Column, Condition, Table, "");
        }
        public StringCollection SelectRows(string Column, Hashtable Condition, string Table, string OrderByString)
        {
            string SQLStr = "select " + Column;
            SQLStr += " from " + Table;
            string str = GetCondition(Condition);
            if (str != "")
                SQLStr += " where ( " + str + " )";
            if (OrderByString.Trim() != "")
                SQLStr += " order by " + OrderByString;
            command.CommandText = SQLStr;
            command.Connection = this.connection;
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            DataTable Tb = new DataTable();
            if (trans != null)
                command.Transaction = trans;
            try
            {
                SqlDataAdapter Adt = new SqlDataAdapter(command);
                Adt.Fill(Tb);
            }
            catch (Exception ex)
            {
                DELFIException.LogException(ex);
                exceptionLastErr = ex;
                return null;
            }

            if (Tb.Columns.Count < 1) return null;
            StringCollection Rs = new StringCollection();
            for (int i = 0; i < Tb.Rows.Count; i++)
            {
                Rs.Add(Tb.Rows[i][0].ToString());
            }
            return Rs;
        }
        
        #region SelectRows_NonSortOrder
        /// <summary>
        /// Create an Instance of System.Data.DataTable Class
        /// </summary>
        /// <param name="SelectQuerryString">Querry String verifying Data to fill in the DataTable</param>
        /// <returns></returns>
        /// 
        public DataTable SelectRows_NonSortOrder(string SelectQueryString)
        {
            return CreateDataTable(SelectQueryString);
        }

        public DataTable SelectRows_NonSortOrder(string SelectQueryString, BSCLoadType LType)
        {
            return CreateDataTable(SelectQueryString, LType);
        }
        public DataTable SelectRows_NonSortOrder(string SelectQueryString, string TableName)
        {
            return CreateDataTable(SelectQueryString, TableName);
        }
        public DataTable SelectRows_NonSortOrder(string SelectQueryString, BSCLoadType LType, string TableName)
        {
            return CreateDataTable(SelectQueryString, LType, TableName);
        }
        /// <summary>
        /// Get data from Sql database server.
        /// </summary>
        /// <param name="Condition">Condition to get.</param>
        /// <param name="Table">Name of table to get data.</param>
        /// <returns>DataTable</returns>
        public DataTable SelectRows_NonSortOrder(Hashtable Condition, string Table)
        {
            return SelectRows_NonSortOrder(new string[] { "*" }, Condition, Table, "");
        }
        /// <summary>
        /// Get data from Sql database server.
        /// </summary>
        /// <param name="Condition">Condition to get.</param>
        /// <param name="ExtCond">Extended condition string </param>
        /// <param name="Table">Name of table to get data.</param>
        /// <returns>DataTable</returns>
        public DataTable SelectRows_NonSortOrder(Hashtable Condition, string ExtCond, string Table)
        {
            string SQLStr = "";
            if (Table.ToLower().Contains("select"))
                SQLStr = "select * from (" + Table + ")A ";
            else
                SQLStr = "select * from " + Table;
            string str = "";
            if (Condition.Count > 0)
            {
                str = GetCondition(Condition);
                SQLStr += " where (" + str + ") and ";
                SQLStr += ExtCond;
            }
            else
            {
                SQLStr += " where (" + ExtCond + ")";
            }
            DataTable dt = CreateDataTable(SQLStr);
            return dt;
        }
        /// <summary>
        /// Get data from Sql database server.
        /// </summary>
        /// <param name="Condition">Condition to get.</param>
        /// <param name="Table">Name of table to get data.</param>
        /// <returns>DataTable</returns>
        public DataTable SelectRows_NonSortOrder(Hashtable Condition, string Table, BSCLoadType LType)
        {
            return SelectRows_NonSortOrder(new string[] { "*" }, Condition, Table, "", LType);
        }
        /// <summary>
        /// Get data from Sql database server.
        /// </summary>
        /// <param name="Condition">Condition to get.</param>
        /// <param name="ExtCond">Extended condition string </param>
        /// <param name="Table">Name of table to get data.</param>
        /// <returns>DataTable</returns>
        public DataTable SelectRows_NonSortOrder(Hashtable Condition, string ExtCond, string Table, BSCLoadType LType)
        {
            string SQLStr = "";
            if (Table.ToLower().Contains("select"))
                SQLStr = "select * from (" + Table + ")A ";
            else
                SQLStr = "select * from " + Table;
            string str = "";
            if (Condition.Count > 0)
            {
                str = GetCondition(Condition);
                SQLStr += " where (" + str + ") and ";
                SQLStr += ExtCond;
            }
            else
            {
                SQLStr += " where (" + ExtCond + ")";
            }
            DataTable dt = CreateDataTable(SQLStr, LType);
            return dt;
        }
        /// <summary>
        /// Get data from Sql database server.
        /// </summary>
        /// <param name="Condition">Condition to get.</param>
        /// <param name="Table">Name of table to get data.</param>
        /// <returns>DataTable</returns>
        public DataTable SelectRows_NonSortOrder(string[] Columns, Hashtable Condition, string Table)
        {
            return SelectRows_NonSortOrder(Columns, Condition, Table, "");
        }
        /// <summary>
        /// Get data from Sql database server.
        /// </summary>
        /// <param name="Condition">Condition to get.</param>
        /// <param name="Table">Name of table to get data.</param>
        /// <returns>DataTable</returns>
        public DataTable SelectRows_NonSortOrder(string[] Columns, Hashtable Condition, string Table, string OrderByString)
        {
            string SQLStr = "select ";
            foreach (string str in Columns)
            {
                SQLStr += str + ",";
            }
            SQLStr = SQLStr.Substring(0, SQLStr.Length - 1);
            if (Table.ToLower().Contains("select"))
                SQLStr += " from (" + Table + ")A ";
            else
                SQLStr += " from " + Table;
            string str1 = GetCondition(Condition);
            if (str1 != "")
                SQLStr += " where ( " + str1 + " )";
            if (OrderByString.Trim() != "")
                SQLStr += " order by " + OrderByString;
            DataTable dt = CreateDataTable(SQLStr);
            return dt;
        }
        public DataTable SelectRows_NonSortOrder(string[] Columns, Hashtable Condition, string Table, BSCLoadType LType)
        {
            return SelectRows_NonSortOrder(Columns, Condition, Table, "", LType);
        }
        /// <summary>
        /// Get data from Sql database server.
        /// </summary>
        /// <param name="Condition">Condition to get.</param>
        /// <param name="Table">Name of table to get data.</param>
        /// <returns>DataTable</returns>
        public DataTable SelectRows_NonSortOrder(string[] Columns, Hashtable Condition, string Table, string OrderByString, BSCLoadType LType)
        {
            string SQLStr = "select ";
            foreach (string str in Columns)
            {
                SQLStr += str + ",";
            }
            SQLStr = SQLStr.Substring(0, SQLStr.Length - 1);
            if (Table.ToLower().Contains("select"))
                SQLStr += " from (" + Table + ")A";
            else
                SQLStr += " from " + Table;
            string str1 = GetCondition(Condition);
            if (str1 != "")
                SQLStr += " where ( " + str1 + " )";
            if (OrderByString.Trim() != "")
                SQLStr += " order by " + OrderByString;
            DataTable dt = CreateDataTable(SQLStr, LType);
            return dt;
        }
        #endregion


        #endregion

        #region Search_Condition

        /// <summary>
        /// Get data from Sql database server.
        /// </summary>
        /// <param name="Condition">Condition to get.</param>
        /// <param name="Table">Name of table to get data.</param>
        /// <returns>DataTable</returns>
        public DataTable SearchRows(Hashtable Condition, string Table)
        {
            return SearchRows(new string[] { "*" }, Condition, Table, "");
        }
        /// <summary>
        /// Get data from Sql database server.
        /// </summary>
        /// <param name="Condition">Condition to get.</param>
        /// <param name="ExtCond">Extended condition string </param>
        /// <param name="Table">Name of table to get data.</param>
        /// <returns>DataTable</returns>
        public DataTable SearchRows(Hashtable Condition, string ExtCond, string Table)
        {
            string SQLStr = "";
            if (Table.ToLower().Contains("select"))
                SQLStr = "select * from (" + Table + ")A";
            else
                SQLStr = "select * from " + Table;
            string str = "";
            if (Condition.Count > 0)
            {
                str = Get_SearchCondition(Condition);
                SQLStr += " where (" + str + ") and ";
                SQLStr += ExtCond;
            }
            else
            {
                SQLStr += " where (" + ExtCond + ")";
            }
            DataTable dt = CreateDataTable(SQLStr);
            if (ExistField(dt, "SortOrder"))
                return CreateDataTable("select top 100 percent * from (" + SQLStr + ")Tb order by SortOrder");
            return dt;
        }
        /// <summary>
        /// Get data from Sql database server.
        /// </summary>
        /// <param name="Condition">Condition to get.</param>
        /// <param name="Table">Name of table to get data.</param>
        /// <returns>DataTable</returns>
        public DataTable SearchRows(Hashtable Condition, string Table, BSCLoadType LType)
        {
            return SearchRows(new string[] { "*" }, Condition, Table, "", LType);
        }
        /// <summary>
        /// Get data from Sql database server.
        /// </summary>
        /// <param name="Condition">Condition to get.</param>
        /// <param name="ExtCond">Extended condition string </param>
        /// <param name="Table">Name of table to get data.</param>
        /// <returns>DataTable</returns>
        public DataTable SearchRows(Hashtable Condition, string ExtCond, string Table, BSCLoadType LType)
        {
            string SQLStr = "";
            if (Table.ToLower().Contains("select"))
                SQLStr = "select * from (" + Table + ")A";
            else
                SQLStr = "select * from " + Table;
            string str = "";
            if (Condition.Count > 0)
            {
                str = Get_SearchCondition(Condition);
                SQLStr += " where (" + str + ") and ";
                SQLStr += ExtCond;
            }
            else
            {
                SQLStr += " where (" + ExtCond + ")";
            }
            DataTable dt = CreateDataTable(SQLStr, LType);
            if (ExistField(dt, "SortOrder"))
                return CreateDataTable("select top 100 percent * from (" + SQLStr + ")Tb order by SortOrder", LType);
            return dt;
        }
        /// <summary>
        /// Get data from Sql database server.
        /// </summary>
        /// <param name="Condition">Condition to get.</param>
        /// <param name="Table">Name of table to get data.</param>
        /// <returns>DataTable</returns>
        public DataTable SearchRows(string[] Columns, Hashtable Condition, string Table)
        {
            return SearchRows(Columns, Condition, Table, "");
        }
        /// <summary>
        /// Get data from Sql database server.
        /// </summary>
        /// <param name="Condition">Condition to get.</param>
        /// <param name="Table">Name of table to get data.</param>
        /// <returns>DataTable</returns>
        public DataTable SearchRows(string[] Columns, Hashtable Condition, string Table, string OrderByString)
        {
            string SQLStr = "select ";
            foreach (string str in Columns)
            {
                SQLStr += str + ",";
            }
            SQLStr = SQLStr.Substring(0, SQLStr.Length - 1);
            if (Table.ToLower().Contains("select"))
                SQLStr += " from (" + Table + ")A ";
            else
                SQLStr += " from " + Table;
            string str1 = Get_SearchCondition(Condition);
            if (str1 != "")
                SQLStr += " where ( " + str1 + " )";
            if (OrderByString.Trim() != "")
                SQLStr += " order by " + OrderByString;
            DataTable dt = CreateDataTable(SQLStr);
            if (ExistField(dt, "SortOrder"))
                return CreateDataTable("select top 100 percent * from (" + SQLStr + ")Tb order by SortOrder");
            return dt;
        }
        public DataTable SearchRows(string[] Columns, Hashtable Condition, string Table, BSCLoadType LType)
        {
            return SearchRows(Columns, Condition, Table, "", LType);
        }
        /// <summary>
        /// Get data from Sql database server.
        /// </summary>
        /// <param name="Condition">Condition to get.</param>
        /// <param name="Table">Name of table to get data.</param>
        /// <returns>DataTable</returns>
        public DataTable SearchRows(string[] Columns, Hashtable Condition, string Table, string OrderByString, BSCLoadType LType)
        {
            string SQLStr = "select ";
            foreach (string str in Columns)
            {
                SQLStr += str + ",";
            }
            SQLStr = SQLStr.Substring(0, SQLStr.Length - 1);
            if (Table.ToLower().Contains("select"))
                SQLStr += " from (" + Table + ")A ";
            else
                SQLStr += " from " + Table;
            string str1 = Get_SearchCondition(Condition);
            if (str1 != "")
                SQLStr += " where ( " + str1 + " )";
            if (OrderByString.Trim() != "")
                SQLStr += " order by " + OrderByString;
            DataTable dt = CreateDataTable(SQLStr, LType);
            if (ExistField(dt, "SortOrder"))
                return CreateDataTable("select top 100 percent * from (" + SQLStr + ")Tb order by SortOrder", LType);
            return dt;
        }
        public StringCollection SearchRows(string Column, Hashtable Condition, string Table)
        {
            return SearchRows(Column, Condition, Table, "");
        }
        public StringCollection SearchRows(string Column, Hashtable Condition, string Table, string OrderByString)
        {
            string SQLStr = "select " + Column;
            if (Table.ToLower().Contains("select"))
                SQLStr += " from (" + Table + ")A ";
            else
                SQLStr += " from " + Table;
            string str = Get_SearchCondition(Condition);
            if (str != "")
                SQLStr += " where ( " + str + " )";
            if (OrderByString.Trim() != "")
                SQLStr += " order by " + OrderByString;
            command.CommandText = SQLStr;
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            command.Connection = this.connection;
            DataTable Tb = new DataTable();
            if (trans != null)
                command.Transaction = trans;
            try
            {
                SqlDataAdapter Adt = new SqlDataAdapter(command);
                Adt.Fill(Tb);
            }
            catch (Exception ex)
            {
                DELFIException.LogException(ex);
                exceptionLastErr = ex;
                return null;
            }

            if (Tb.Columns.Count < 1) return null;
            StringCollection Rs = new StringCollection();
            for (int i = 0; i < Tb.Rows.Count; i++)
            {
                Rs.Add(Tb.Rows[i][0].ToString());
            }
            return Rs;
        }

        #endregion

        #region Support
        /// <summary>
        /// Get a valid formated string for Sql
        /// </summary>
        /// <param name="Inp">Input object</param>
        /// <returns></returns>
        public static string GetString(object Inp)
        {
            if (Inp == null) return "NULL";
            if (Inp.ToString() == "") return "NULL";
            string abcd = Inp.GetType().Name;
            //XtraMessageBox.Show(abcd);
            switch (Inp.GetType().Name)
            {
                case "Decimal":
                    return Convert.ToDecimal(Inp).ToString();
                case "Int":
                    return Inp.ToString();
                case "String":
                    {
                        if (!IsUnicode((String)Inp))
                            return "'" + (((String)Inp).Replace("'", "''")).Trim() + "'";
                        else
                            return "N'" + (((String)Inp).Replace("'", "''")).Trim() + "'";
                    }
                case "Boolean":
                    return ((Boolean)Inp) ? "1" : "0";
                case "DateTime":
                    return "CONVERT(datetime,'" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", ((DateTime)Inp)) + "', 120)";
                default:
                    return Inp.ToString();
            }
        }
        private static bool IsUnicode(string Inp)
        {
            System.Text.Encoding Ascii = System.Text.UnicodeEncoding.ASCII;
            string EncodeString = Ascii.GetString(Ascii.GetBytes(Inp));
            return !Inp.Equals(EncodeString);
        }
        private string GetCondition(Hashtable Cond)
        {
            if (Cond == null) return "";
            string Rs = "";
            foreach (DictionaryEntry Ent in Cond)
            {
                Rs += Ent.Key.ToString();
                if (Ent.Value == null)
                {
                    Rs += " is NULL and ";
                    continue;
                }
                if (Ent.Value.GetType().Name == "StringCollection" || Ent.Value.GetType().Name == "String[]")
                {
                    StringCollection Coll;
                    if (Ent.Value.GetType().Name == "StringCollection")
                        Coll = (StringCollection)Ent.Value;
                    else
                    {
                        Coll = new StringCollection();
                        Coll.AddRange((string[])Ent.Value);
                    }
                    Rs += " in ( ";
                    foreach (string str in Coll)
                    {
                        if (!IsUnicode(str))
                            Rs += "'" + str.Replace("'", "''") + "',";
                        else
                            Rs += "N'" + str.Replace("'", "''") + "',";
                    }
                    Rs = Rs.Substring(0, Rs.Length - 1) + ") and ";
                }
                else
                {
                    Rs += "=" + DELFIConnection.GetString(Ent.Value) + " and ";
                }
            }
            if (Rs != "")
                Rs = Rs.Substring(0, Rs.Length - 5);
            return Rs;
        }


        private string Get_SearchCondition(Hashtable Cond)
        {
            if (Cond == null) return "";
            string Rs = "";
            foreach (DictionaryEntry Ent in Cond)
            {
                if (Ent.Value == null)
                {
                    continue;
                }
                Rs += Ent.Key.ToString();
                if (Ent.Value.GetType().Name == "StringCollection" || Ent.Value.GetType().Name == "String[]")
                {
                    StringCollection Coll;
                    if (Ent.Value.GetType().Name == "StringCollection")
                        Coll = (StringCollection)Ent.Value;
                    else
                    {
                        Coll = new StringCollection();
                        Coll.AddRange((string[])Ent.Value);
                    }
                    Rs += " in ( ";
                    foreach (string str in Coll)
                    {
                        if (!IsUnicode(str))
                            Rs += "'" + str.Replace("'", "''") + "',";
                        else
                            Rs += "N'" + str.Replace("'", "''") + "',";
                    }
                    Rs = Rs.Substring(0, Rs.Length - 1) + ") and ";
                }
                else if (Ent.Value.GetType().Name == "StringCollection")
                {

                }
                else if (Ent.Value.GetType().Name == "Boolean")
                {
                    Rs += " = " + ((Ent.Value.ToString() == "True") ? "1" : "0") + " and ";
                }
                else
                {
                    if(Ent.Key.ToString().Substring(0,2).ToLower() != "ma")
                        Rs += " like N'%" + Ent.Value + "%' and ";
                    else
                        Rs += " = N'" + Ent.Value + "' and ";
                }
            }
            if (Rs != "")
                Rs = Rs.Substring(0, Rs.Length - 5);
            return Rs;
        }
        #endregion
        
        // //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Lấy từ BSC CRM.NET 2003


        /// <summary>
        /// GetSQLString: Lấy câu truy vấn SQL từ tham số SQL
        /// </summary>
        /// <param name="sKey">Tham số SQL</param>
        /// <returns>string</returns>

        public string GetSQLString(string sKey)
        {
            string sSQLRun = "";
            try
            {
                sSQLRun = (string)SQL_ExecuteScalar("SELECT SQLRUN FROM HT_SQL_CAU_LENH WHERE MACAULENH =" + sUnicode(sKey, true));
                if (bLength(sSQLRun))
                {
                    //WriteFile(sSQLRun, sKey);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return (sSQLRun);
        }

        public void WriteFile(string sText)
        {
            string sFileSystem = Application.StartupPath + @"\Parameter\ThamSo.txt";
            try
            {
                if (!Directory.Exists(Application.StartupPath + @"\Parameter\"))
                {
                    Directory.CreateDirectory(Application.StartupPath + @"\Parameter\");
                }
                if (File.Exists(sFileSystem))
                {
                    File.Delete(sFileSystem);
                }
                else
                {
                    File.CreateText(sFileSystem);
                }
                FileStream fs = new FileStream(sFileSystem, FileMode.CreateNew, FileAccess.Write, FileShare.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(sText);
                fs.Close();
                bw.Close();
            }
            catch
            {
                throw;
            }
        }

        public void WriteFile(string sText, string sFileSystem)
        {
            sFileSystem = Application.StartupPath + @"\Parameter\" + sFileSystem + ".txt";
            try
            {
                if (!Directory.Exists(Application.StartupPath + @"\Parameter\"))
                {
                    Directory.CreateDirectory(Application.StartupPath + @"\Parameter\");
                }
                if (File.Exists(sFileSystem))
                {
                    File.Delete(sFileSystem);
                }
                else
                {
                    //					File.CreateText(sFileSystem); 
                }
                //				FileStream fs = new FileStream( sFileSystem, FileMode.CreateNew, FileAccess.Write, FileShare.Write );
                //				BinaryWriter bw = new BinaryWriter(fs); 
                //				bw.Write(sText); 
                //				fs.Close();
                //				bw.Close();

                StreamWriter sw = new StreamWriter(sFileSystem, false, System.Text.Encoding.Unicode);
                sw.Write(sText);
                sw.Close();
            }
            catch
            {
                throw;
            }
        }


        public string sUnicode(string sChuoi)
        {
            sChuoi = sChuoi.Replace("'", "''");
            return "'" + sChuoi + "'";
        }
        /// <summary>
        /// sUnicode
        /// </summary>
        /// <param name="str">string</param>
        /// <param name="bUnicode">bool</param>
        /// <returns>string</returns>
        public string sUnicode(string str, bool bUnicode)
        {
            str = str.Replace("'", "''");
            if (bUnicode)
                return "N'" + str + "'";
            else
                return "'" + str + "'";
        }
        /// <summary>
        /// Convert to Number Type
        /// </summary>
        /// <param name="obj">đối tượng cần Convert</param>
        /// <returns></returns>
        public string sNull2String(object obj)
        {
            if (obj == null)
            {
                return ("");
            }
            else if (obj == System.DBNull.Value)
            {
                return ("");
            }
            else
            {
                return Convert.ToString(obj);
            }
        }
        public string sNull2String(Control ctrl)
        {
            string sResult = "";
            if (ctrl is System.Windows.Forms.ComboBox)
            {
                System.Windows.Forms.ComboBox cbo = (System.Windows.Forms.ComboBox)ctrl;
                sResult = cbo.Text;
            }
            else if (ctrl is DevExpress.XtraEditors.ComboBox)
            {
                DevExpress.XtraEditors.ComboBox cbo = (DevExpress.XtraEditors.ComboBox)ctrl;
                sResult = cbo.Text;
            }
            else if (ctrl is DevExpress.XtraEditors.LookUpEdit)
            {
                DevExpress.XtraEditors.LookUpEdit cbo = (DevExpress.XtraEditors.LookUpEdit)ctrl;
                sResult = cbo.Text;
            }
            else if (ctrl is Label)
            {
                Label lbl = (Label)ctrl;
                sResult = lbl.Text;
            }
            else if (ctrl is Button)
            {
                Button btn = (Button)ctrl;
                sResult = btn.Text;
            }
            return (sResult);
        }
        /// <summary>
        /// Convert to Number Type
        /// </summary>
        /// <param name="obj">object</param>
        /// <returns>decimal</returns>
        public decimal sNull2Number(object obj)
        {
            if (obj == null)
            {
                return (0);
            }
            else if (obj.ToString() == "")
            {
                return (0);
            }
            else if (obj == System.DBNull.Value)
            {
                return (0);
            }
            else
            {
                return Convert.ToDecimal(obj);
            }
        }
        public int sNull2Int(object obj)
        {
            if (obj == null)
            {
                return (0);
            }
            else if (obj.ToString() == string.Empty)
            {
                return (0);
            }
            else if (obj == System.DBNull.Value)
            {
                return (0);
            }
            else if (obj.ToString() == "False")
            {
                return (0);
            }
            else if (obj.ToString() == "True")
            {
                return (1);
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        public object sNull2Object(object obj)
        {
            if (obj == null)
            {
                return (0);
            }
            else if (obj.ToString() == string.Empty)
            {
                return (0);
            }
            else if (obj == System.DBNull.Value)
            {
                return (0);
            }
            else
            {
                return (obj);
            }
        }

        public string fGiaTri(string type, object obj)
        {
            switch (type)
            {
                case "System.String":
                    return (sUnicode(sNull2String(obj), true));
                case "System.Boolean":
                case "System.Int32":
                case "System.Int16":
                case "System.Byte":
                    return (sNull2Int(obj).ToString());
                case "System.Decimal":
                    return (sNull2Number(obj).ToString());
                case "System.DateTime":
                    if (obj.ToString() == "NULL")
                    {
                        return obj.ToString();
                    }
                    return sUnicode(obj.ToString());
                case "System.Byte[]":
                    return "NULL";
                case "System.DBNull":
                    return "";
                default:
                    return "";
            }
        }

        /// <summary>
        /// Insert/Update to Database
        /// </summary>
        /// <param name="MyFrm"> Control chứa đựng các fild cần lưu</param>
        /// <param name="sTable">Tên Table</param>
        /// <param name="sCondition">Điều kiện sd cho câu lệnh Update</param>
        /// <param name="bExist">Field đã tồn tại</param>
        /// <param name="bUserDate"></param>
        /// <returns></returns>
        public string UpdateDataSQLComm(Control MyFrm, string sTable, string sCondition, ref bool bExist, bool bUserDate)
        {
            string sSQL = "";
            string sField = "";
            string sValues = "";
            string[] sGiaTri = new string[0];
            string sVal = "";
            try
            {
                if (!sCondition.Length.Equals(0))
                {
                    bExist = SQL_ExistValue(sTable, sCondition);
                }
                else
                {
                    bExist = false;
                }
                CreateValuesFromControl(MyFrm, ref sField, ref sValues);
                sGiaTri = sValues.Split('|');
                sValues = "";
                DataTable DTT_Schema = GetSchemaTable("select top 0 " + sField.Substring(0, sField.Length - 1) + " from " + sTable);
                int i = 0;
                int iRow = DTT_Schema.Rows.Count;
                foreach (DataRow dr in DTT_Schema.Rows)
                {
                    string sColumn = (string)(dr["ColumnName"]);
                    string type = Convert.ToString(dr["DataType"]);
                    sVal = fGiaTri(type, sGiaTri[i]);
                    if (bExist)
                    {
                        sValues += sColumn + "=" + sVal;
                        if (i < (iRow - 1))
                        {
                            sValues += ",";
                        }
                    }
                    else
                    {
                        sValues += sVal;
                        if (i < (iRow - 1))
                        {
                            sValues += ",";
                        }
                    }
                    i++;
                }
                if (bExist)
                {
                    sField = sValues;
                    if (bUserDate)
                    {
                        if (!ExistField(sTable, "NGUOIDUNG2"))
                        {
                            SQL_ExecuteNonQuery("Alter Table " + sTable + " ADD [NGUOIDUNG2] [int] NOT NULL DEFAULT (0)");
                        }
                        if (!ExistField(sTable, "NGAY2"))
                        {
                            SQL_ExecuteNonQuery("Alter Table " + sTable + " ADD [NGAY2] [smalldatetime] NULL");
                        }
                        if (!ExistField(sTable, "MAY2"))
                        {
                            SQL_ExecuteNonQuery("Alter Table " + sTable + " ADD [MAY2] [nvarchar] (100) NOT NULL DEFAULT ('')");

                        }
                        sSQL = "UPDATE " + sTable + " SET " + sField + ",NGUOIDUNG2=" + 
                            Properties.Settings.Default.USER_ID + ",NGAY2='" + GetDateServer().ToString("MM/dd/yyyy") + "',MAY2=N'" + 
                            System.Net.Dns.GetHostName() + "' where " + sCondition;
                    }
                    else
                    {
                        sSQL = "UPDATE " + sTable + " SET " + sField + " where " + sCondition;
                    }

                }
                else
                {
                    if (bUserDate)
                    {
                        if (!ExistField(sTable, "NGUOIDUNG1"))
                        {
                            SQL_ExecuteNonQuery("Alter Table " + sTable + " ADD [NGUOIDUNG1] [int] NOT NULL DEFAULT (0)");
                        }
                        if (!ExistField(sTable, "NGAY1"))
                        {
                            SQL_ExecuteNonQuery("Alter Table " + sTable + " ADD [NGAY1] [smalldatetime] NULL");
                        }
                        if (!ExistField(sTable, "MAY1"))
                        {
                            SQL_ExecuteNonQuery("Alter Table " + sTable + " ADD [MAY1] [nvarchar] (100) NOT NULL DEFAULT ('')");
                        }
                        //sSQL = "INSERT INTO " + sTable + " (" + sField + "NGUOIDUNG1, NGAY1, MAY1) values (" + sValues + k.iTaiKhoan + "," + sUnicode(GetDateServer(k.sKetNoi).ToString("MM/d/yyyy")) + ",N'"+k.sTenMay +"')";
                        //						sSQL = "INSERT INTO "+sTable+"(" + sField+"NGUOIDUNG1,NGAY1,MAY1)VALUES("+sValues+","+k.iTaiKhoan + "," + sUnicode(GetDateServer(k.sKetNoi).ToString(MMddyyyy)) + ",N'"+k.sTenMay +"')";
                        sSQL = string.Format("INSERT INTO {0}({1} NGUOIDUNG1, NGAY1, MAY1)VALUES({2}, '{3}', '{4}', N'{5}')", sTable, sField, sValues, Properties.Settings.Default.USER_ID, GetDateServer().ToString("MM/dd/yyyy"), System.Net.Dns.GetHostName());
                    }
                    else
                    {
                        //						sSQL = "INSERT INTO " + sTable + " (" + sField.Substring(0, sField.Length - 1) + ") values (" + sValues.Substring(0, sValues.Length - 1) + ")";

                        sSQL = "INSERT INTO " + sTable + "(" + sField.Substring(0, sField.Length - 1) + ")VALUES(" + sValues + ")";
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "CreateValuesFromControl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return (sSQL);
        }
        /// <summary>
        /// Insert/Update to Database
        /// </summary>
        /// <param name="MyFrm">Control chứa đựng các fild cần lưu</param>
        /// <param name="sTable">Tên Table</param>
        /// <param name="sCondition">Điều kiện sd cho câu lệnh Update</param>
        /// <returns></returns>
        public string UpdateDataSQLComm(Control MyFrm, string sTable, string sCondition)
        {
            string sSQL = "";
            string sField = "";
            string sValues = "";
            string[] sGiaTri = { };
            string sVal = "";
            bool bExist = false;
            try
            {
                if (sCondition.Trim().Length > 0)
                {
                    bExist = SQL_ExistValue(sTable, sCondition);
                }
                CreateValuesFromControl(MyFrm, ref sField, ref sValues);
                sGiaTri = sValues.Split('|');
                sValues = "";
                DataTable DTT_Schema = GetSchemaTable("select " + sField.Substring(0, sField.Length - 1) + " from " + sTable);
                for (int i = 0; i < DTT_Schema.Rows.Count; i++)
                {
                    DataRow dr = DTT_Schema.Rows[i];
                    string sColumn = (string)(dr["ColumnName"]);
                    string type = Convert.ToString(dr["DataType"]);
                    sVal = fGiaTri(type, sGiaTri[i]);
                    if (bExist)
                    {
                        sValues += sColumn + "=" + sVal;
                        if (i < DTT_Schema.Rows.Count - 1)
                        {
                            sValues += ",";
                        }
                    }
                    else
                    {
                        sValues += sVal;
                        if (i < DTT_Schema.Rows.Count - 1)
                        {
                            sValues += ",";
                        }
                    }
                }
                if (bExist)
                {
                    sField = sValues;
                    sSQL = "UPDATE " + sTable + " SET " + sField + " WHERE " + sCondition;
                }
                else
                {
                    sSQL = "INSERT INTO " + sTable + "(" + sField.Substring(0, sField.Length - 1) + ")VALUES(" + sValues + ")";
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "CreateValuesFromControl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
            return (sSQL);
        }

        private const string PW_KEY = "PWD";

        public DateTime GetDateServer()
        {
            return (System.DateTime.Parse(SQL_ExecuteScalar("select getdate()").ToString()));
        }
        public int inhatky;
        /// <summary>
        /// Ghi lại nhật ký sử dụng
        /// </summary>
        /// <param name="sConnect"></param>
        public void History()
        {
            string sTenMay = Environment.MachineName + @"\" + Environment.UserName;
            string sSQL = "INSERT INTO HT_NHATKY(TENMAY,TAIKHOAN,BATDAU,KETTHUC)VALUES(@TENMAY,@TAIKHOAN,@BATDAU,@KETTHUC)";
            SqlConnection sqlConn = SQL_Connect(ConnectionString);
            if (sqlConn.State == ConnectionState.Closed)
            {
                sqlConn.Open();
            }
            try
            {
                SqlCommand sqlCmm = new SqlCommand(sSQL);
                sqlCmm.Connection = sqlConn;
                DateTime date = GetDateServer();
                sqlCmm.Parameters.Add(new SqlParameter("@TENMAY", SqlDbType.NVarChar, 255, "TENMAY")).Value = sTenMay;
                sqlCmm.Parameters.Add(new SqlParameter("@TAIKHOAN", SqlDbType.NVarChar, 50, "TAIKHOAN")).Value = Properties.Settings.Default.USER_NAME;
                sqlCmm.Parameters.Add(new SqlParameter("@BATDAU", SqlDbType.SmallDateTime, 4, "BATDAU")).Value = date;
                sqlCmm.Parameters.Add(new SqlParameter("@KETTHUC", SqlDbType.SmallDateTime, 4, "KETTHUC")).Value = date;

                sqlCmm.ExecuteNonQuery();

                sqlCmm.CommandText = "SELECT @@IDENTITY";
                object obj = sqlCmm.ExecuteScalar();
                inhatky = System.Int32.Parse(obj.ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
            }
        }

        public bool bChuoi(DataRow r, string sCol)
        {
            if (r[sCol] == System.DBNull.Value)
            {
                return false;
            }
            else
            {
                return ((bool)r[sCol]);
            }
        }
        public bool bChuoi(DataRow r, int IDX)
        {
            if (r[IDX] == System.DBNull.Value)
            {
                return false;
            }
            else
            {
                return ((bool)r[IDX]);
            }
        }
        public int iChuoi(DataRow r, string sCol)
        {
            if (r[sCol] == System.DBNull.Value)
            {
                return 0;
            }
            else
            {
                return (Convert.ToInt32(r[sCol]));
            }
        }
        public int iChuoi(DataRow r, int IDX)
        {
            if (r[IDX] == System.DBNull.Value)
            {
                return 0;
            }
            else
            {
                return (Convert.ToInt32(r[IDX]));
            }
        }
        public string sChuoi(DataRow r, string sCol)
        {
            if (r[sCol] == System.DBNull.Value)
            {
                return "";
            }
            else
            {
                return (r[sCol].ToString().Trim());
            }
        }
        public string sChuoi(DataRow r, int IDX)
        {
            if (r[IDX] == System.DBNull.Value)
            {
                return "";
            }
            else
            {
                return (r[IDX].ToString().Trim());
            }
        }

        /// <summary>
        /// DR_DataReader: Load dữ liệu lên Control
        /// </summary>
        /// <param name="control">Control chứa các Control chứa dữ liệu</param>
        /// <param name="dtrow">DataRow chứa dữ liệu</param>
        public void DR_DataReader(Control control, DataRow row)
        {
            string sFieldName;
            try
            {
                foreach (Control ctrl in control.Controls)
                {
                    string sTag = sNull2String(ctrl.Tag);
                    if (bLength(sTag))
                    {
                        if (sTag.Substring(0, 2).Equals(".."))
                        {
                            sFieldName = sTag.Substring(2);
                            if (ctrl is TextBox)
                            {
                                TextBox txt = (TextBox)ctrl;
                                txt.Text = sChuoi(row, sFieldName);
                                if (sFieldName.Equals("MATKHAU"))
                                {
                                    txt.Text = Decrypt(sChuoi(row, sFieldName), PW_KEY);
                                }
                            }
                            else if (ctrl is RichTextBox)
                            {
                                RichTextBox rtb = (RichTextBox)ctrl;
                                rtb.Text = sChuoi(row, sFieldName);
                            }
                            else if (ctrl is DevExpress.XtraEditors.TextEdit)
                            {
                                DevExpress.XtraEditors.TextEdit txt = (DevExpress.XtraEditors.TextEdit)ctrl;
                                txt.Text = sChuoi(row, sFieldName);
                                if (sFieldName.ToUpper().Equals("MATKHAU"))
                                {
                                    txt.Text = Decrypt(sChuoi(row, sFieldName), PW_KEY);
                                }
                            }
                            else if (ctrl is DELFI_User_Control.uTextBox)
                            {
                                DELFI_User_Control.uTextBox txt = (DELFI_User_Control.uTextBox)ctrl;
                                txt.uText = sChuoi(row, sFieldName);
                                if (sFieldName.ToUpper().Equals("MATKHAU"))
                                {
                                    txt.uText = Decrypt(sChuoi(row, sFieldName), PW_KEY);
                                }
                            }
                            else if (ctrl is MemoEdit)
                            {
                                MemoEdit txt = (MemoEdit)ctrl;
                                txt.Text = sChuoi(row, sFieldName);
                            }
                            else if (ctrl is DELFI_User_Control.uMemoEdit)
                            {
                                DELFI_User_Control.uMemoEdit txt = (DELFI_User_Control.uMemoEdit)ctrl;
                                txt.uText = sChuoi(row, sFieldName);
                            }
                            else if (ctrl is MemoExEdit)
                            {
                                MemoExEdit txt = (MemoExEdit)ctrl;
                                txt.Text = sChuoi(row, sFieldName);
                            }
                            else if (ctrl is DELFI_User_Control.uMemoExEdit)
                            {
                                DELFI_User_Control.uMemoExEdit txt = (DELFI_User_Control.uMemoExEdit)ctrl;
                                txt.uText = sChuoi(row, sFieldName);
                            }
                            else if (ctrl is SpinEdit)
                            {
                                SpinEdit txt = (SpinEdit)ctrl;
                                txt.Value = iChuoi(row, sFieldName);
                            }
                            else if (ctrl is DELFI_User_Control.uSpinEdit)
                            {
                                DELFI_User_Control.uSpinEdit txt = (DELFI_User_Control.uSpinEdit)ctrl;
                                txt.uText = sChuoi(row, sFieldName);
                            }
                            else if (ctrl is CheckBox)
                            {
                                CheckBox chk = (CheckBox)ctrl;
                                chk.Checked = bChuoi(row, sFieldName);
                            }
                            else if (ctrl is DevExpress.XtraEditors.CheckEdit)
                            {
                                CheckEdit chk = (CheckEdit)ctrl;
                                chk.Checked = bChuoi(row, sFieldName);
                            }
                            else if (ctrl is RadioButton)
                            {
                                RadioButton rdb = (RadioButton)ctrl;
                                rdb.Checked = bChuoi(row, sFieldName);
                            }
                            else if (ctrl is RadioGroup)
                            {
                                RadioGroup rdg = (RadioGroup)ctrl;
                                rdg.EditValue = bChuoi(row, sFieldName);
                            }
                            else if (ctrl is System.Windows.Forms.ComboBox)
                            {
                                System.Windows.Forms.ComboBox cbo = (System.Windows.Forms.ComboBox)ctrl;
                                if (row[sFieldName] != System.DBNull.Value)
                                {
                                    cbo.SelectedIndex = cbo.FindString(sChuoi(row, sFieldName));
                                }
                                else
                                {
                                    cbo.SelectedIndex = -1;
                                }
                            }
                            else if (ctrl is LookUpEdit)
                            {
                                LookUpEdit cbo = (LookUpEdit)ctrl;
                                if (row[sFieldName] != System.DBNull.Value)
                                {
                                    cbo.EditValue = sChuoi(row, sFieldName);
                                }
                                else
                                {
                                    cbo.EditValue = null;
                                }
                            }
                            else if (ctrl is DELFI_User_Control.uComboBox)
                            {
                                DELFI_User_Control.uComboBox cbo = (DELFI_User_Control.uComboBox)ctrl;
                                if (sNull2String(row[sFieldName]) != "")
                                {
                                    cbo.uEditValue = sChuoi(row, sFieldName);
                                }
                                else
                                {
                                    cbo.uEditValue = null;
                                }
                            }
                            else if (ctrl is Label)
                            {
                                Label lbl = (Label)ctrl;
                                lbl.Text = sChuoi(row, sFieldName);
                                if (sFieldName.Equals("MATKHAU"))
                                {
                                    lbl.Text = Decrypt(sChuoi(row, sFieldName), PW_KEY);
                                }
                            }
                            else if (ctrl is DELFI_User_Control.BSCEmisNamHoc)
                            {
                                DELFI_User_Control.BSCEmisNamHoc txt = (DELFI_User_Control.BSCEmisNamHoc)ctrl;
                                try
                                {
                                    txt.iYear = sNull2Int(row[sFieldName]);
                                }catch{}
                            }
                            else if (ctrl is DateTimePicker)
                            {
                                DateTimePicker dtp = (DateTimePicker)ctrl;
                                if (row[sFieldName] == System.DBNull.Value)
                                {
                                    if (dtp.ShowCheckBox)
                                    {
                                        dtp.Checked = false;
                                    }
                                }
                                else
                                {
                                    if (dtp.ShowCheckBox)
                                    {
                                        dtp.Checked = true;
                                    }
                                    dtp.Value = (DateTime)row[sFieldName];
                                }
                            }
                            else if (ctrl is DevExpress.XtraEditors.DateEdit)
                            {
                                DateEdit dtp = (DateEdit)ctrl;
                                if (row[sFieldName] == System.DBNull.Value)
                                {
                                    dtp.EditValue = null;
                                }
                                else
                                {
                                    dtp.DateTime = (DateTime)row[sFieldName];
                                }
                            }
                            else if (ctrl is DELFI_User_Control.uDateTimePicker)
                            {
                                DELFI_User_Control.uDateTimePicker dtp = (DELFI_User_Control.uDateTimePicker)ctrl;
                                if (sNull2String(row[sFieldName]) == "")
                                {
                                    dtp.uValue = null;
                                }
                                else
                                {
                                   // dtp.uValue = new DateTime(sNull2Int(row[sFieldName].ToString().Substring(6, 4)), sNull2Int(row[sFieldName].ToString().Substring(0, 2)), sNull2Int(row[sFieldName].ToString().Substring(3, 2)));
                                    try { dtp.uValue = (DateTime)row[sFieldName]; }
                                    catch { dtp.uValue = null; }
                                }
                            }
                            else if (ctrl is PictureBox)
                            {
                                PictureBox pic = (PictureBox)ctrl;
                                if (row[sFieldName] != System.DBNull.Value)
                                {
                                    byte[] arrPicture = (byte[])(row[sFieldName]);
                                    if (arrPicture.Length != 0)
                                    {
                                        MemoryStream ms = new MemoryStream(arrPicture);
                                        pic.Image = new System.Drawing.Bitmap(ms);
                                    }
                                    else
                                    {
                                        pic.Image = null;
                                    }
                                }
                                else
                                {
                                    pic.Image = null;
                                }
                                pic.Refresh();
                            }
                            else if (ctrl is PictureEdit)
                            {
                                PictureEdit pic = (PictureEdit)ctrl;
                                if (row[sFieldName] != System.DBNull.Value)
                                {
                                    byte[] arrPicture = (byte[])(row[sFieldName]);
                                    if (arrPicture.Length != 0)
                                    {
                                        MemoryStream ms = new MemoryStream(arrPicture);
                                        pic.Image = new System.Drawing.Bitmap(ms);
                                    }
                                    else
                                    {
                                        pic.Image = null;
                                    }
                                }
                                else
                                {
                                    pic.Image = null;
                                }
                                pic.Refresh();
                            }
                        }
                    }//end if sTag
                    if (ctrl.Controls.Count > 0)
                    {
                        if (bUserControl(ctrl))
                        {
                            continue;
                        }
                        DR_DataReader(ctrl, row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "DR_DataReader", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Kiểm tra Field đã tồn tại trong Table
        /// </summary>
        /// <param name="sTable">Table chứa đựng</param>
        /// <param name="sColumn">Column cần kiểm tra</param>
        /// <returns></returns>
        public bool ExistField(string sTable, string sColumn)
        {
            bool bExist = false;
            try
            {
                string sSQL = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA='dbo' AND TABLE_NAME='" + sTable + "' AND COLUMN_NAME='" + sColumn + "'";
                if (SQL_ExecuteScalar(sSQL) != null)
                {
                    bExist = true;
                }
                else
                {
                    bExist = false;
                }
            }
            catch
            {
                throw;
            }
            return (bExist);
        }

        /// <summary>
        /// Kiểm tra Field đã tồn tại trong DataTable
        /// </summary>
        /// <param name="sTable">DataTable chứa đựng</param>
        /// <param name="sColumn">Column cần kiểm tra</param>
        /// <returns></returns>
        public bool ExistField(DataTable dTable, string sColumn)
        {
            if (dTable == null)
                return false;
            foreach (DataColumn c in dTable.Columns)
            {
                if (c.ColumnName == sColumn)
                    return true;
            }
            return false;
        }

        public bool bLength(object obj)
        {
            bool _bLength = false;
            if (sNull2String(obj).Trim().Length > 0)
            {
                _bLength = true;
            }
            return (_bLength);
        }

        /// <summary>
        /// SQL_ExistValue
        /// </summary>
        /// <param name="sSQL">string</param>
        /// <param name="sConnect">string</param>
        /// <returns>bool</returns>
        public bool SQL_ExistValue(string sSQL)
        {
            bool bExist = false;
            try
            {
                if (SQL_ExecuteScalar(sSQL) != null)
                {
                    bExist = true;
                }
                else
                {
                    bExist = false;
                }
            }
            catch
            {
                throw;
            }
            return (bExist);
        }

        public bool SQL_ExistValue(string sTable, string sCondition)
        {
            bool bExist = false;
            if (!bLength(sCondition))
                return false;
            try
            {
                if (SQL_ExecuteScalar("select * from " + sTable + " where " + sCondition) != null)
                {
                    bExist = true;
                }
                else
                {
                    bExist = false;
                }
            }
            catch
            {
                throw;
            }
            return bExist;
        }

        /// <summary>
        /// SQL_ExecuteScalar
        /// </summary>
        /// <param name="sSQL">string</param>
        /// <returns>Object</returns>
        public object SQL_ExecuteScalar(object QueryString)
        {

            if (command == null)
                command = new SqlCommand();
            if (trans != null)
                command.Transaction = trans;
            object obj = new object();
            command.CommandText = QueryString.ToString();
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            command.Connection = this.connection;
            command.CommandType = CommandType.Text;
            if (trans != null)
                command.Transaction = trans;
            try
            {
                obj = command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                obj = null;
                //throw ex;
            }
            finally
            {
                if (trans == null)
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            return obj;
        }

        public SqlConnection SQL_Connect(string sConnect)
        {
            //			GregorianCalendar reg = new GregorianCalendar(GregorianCalendarTypes.Localized);
            SqlConnection sqlConnect = new SqlConnection();
            try
            {
                sqlConnect.ConnectionString = sConnect;
                sqlConnect.Open();
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.ToString(), e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return (sqlConnect);
        }

        public int SQL_ExecuteNonQuery(string QueryString)
        {
            if (command == null)
                command = new SqlCommand();
            if (trans != null)
                command.Transaction = trans;
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            command.Connection = this.connection;
            command.CommandType = CommandType.Text;
            command.CommandText = QueryString;
            int Rs = -1;
            try
            {
                Rs = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (trans == null)
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            return Rs;
        }

        public void SQL_ExecuteNonQuery(string storedProcedure, string parameterName, object valueparameterName)
        {
            SqlConnection sqlConn = new SqlConnection(ConnectionString);
            if (sqlConn.State == ConnectionState.Closed)
            {
                sqlConn.Open();
            }
            SqlCommand sqlCmd = new SqlCommand();
            if (trans != null)
                sqlCmd.Transaction = trans;
            sqlCmd.Connection = sqlConn;
            try
            {
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = storedProcedure;
                sqlCmd.Parameters.Add(parameterName, valueparameterName);

                sqlCmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                if (trans == null)
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

        public System.Data.DataTable GetSchemaTable(string sSQL)
        {
            System.Data.SqlClient.SqlDataReader DataReader;
            SqlCommand sqlCmm = new SqlCommand();
            DataTable DTT = new DataTable();
            SqlConnection sqlConnect = SQL_Connect(ConnectionString);
            if (sqlConnect.State == ConnectionState.Closed)
            {
                sqlConnect.Open();
            }
            if (trans != null)
                sqlCmm.Transaction = trans;
            try
            {
                sqlCmm = new SqlCommand(sSQL, sqlConnect);
                DataReader = sqlCmm.ExecuteReader();
                DTT = DataReader.GetSchemaTable();
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.ToString(), e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (trans == null)
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            return (DTT);
        }

        public void SQL_ExecuteStoredProcedure(string storedProcedure)
        {
            SqlConnection sqlConn = new SqlConnection(ConnectionString);
            if (sqlConn.State == ConnectionState.Closed)
            {
                sqlConn.Open();
            }
            SqlCommand sqlCmd = new SqlCommand();
            if (trans != null)
                sqlCmd.Transaction = trans;
            sqlCmd.Connection = sqlConn;
            try
            {
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = storedProcedure;

                sqlCmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                if (trans == null)
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

        public int iLength(object obj)
        {
            int Length = 0;
            if (sNull2String(obj).Length > 0)
            {
                Length = sNull2String(obj).Length;
            }
            return (Length);
        }


        /// <summary>
        /// Get DataTable từ câu truy vấn
        /// </summary>
        /// <param name="sSQL">câu truy vấn SQL</param>
        /// <returns></returns>
        public System.Data.DataTable DT_DataTable(string sSQL)
        {
            if (sSQL == "" || sSQL == null)
                return null;
            System.Data.SqlClient.SqlDataAdapter sqlDA;

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            if (trans != null)
                command.Transaction = trans;
            System.Data.DataTable DTT = new System.Data.DataTable();
            try
            {
                command.CommandText = sSQL;
                command.Connection = connection;
                sqlDA = new SqlDataAdapter(command);
                sqlDA.Fill(DTT);
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.ToString(), e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (trans == null)
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            return DTT;
        }

        public System.Data.DataTable DT_DataTable(DELFI_User_Control.uComboBox cbo)
        {
            if (cbo.uDataSource is DataTable)
                return cbo.uDataSource as DataTable;
            else if (cbo.uDataSource is DataView)
                return (cbo.uDataSource as DataView).Table;

            return null;
        }

        /// <summary>
        /// Đưa dữ liệu vào các control chứa dữ liệu
        /// </summary>
        /// <param name="control">Control chứa các control chứa dữ liệu</param>
        /// <param name="sField">các field</param>
        /// <param name="sValues">Giá trị của field</param>
        public void CreateValuesFromControl(Control control, ref string sField, ref string sValues)
        {
            try
            {
                object sText;
                foreach (Control ctrl in control.Controls)
                {
                    string sTag = sNull2String(ctrl.Tag);
                    if (sTag != "" && sTag.Length > 2)
                    {
                        if (sTag.Substring(0, 2).Equals(".."))
                        {
                            sText = null;
                            if (ctrl is TextBox)
                            {
                                TextBox txt = (TextBox)ctrl;
                                sText = txt.Text;
                            }
                            else if (ctrl is DevExpress.XtraEditors.TextEdit)
                            {
                                DevExpress.XtraEditors.TextEdit txt = (DevExpress.XtraEditors.TextEdit)ctrl;
                                sText = txt.Text;
                            }
                            else if (ctrl is DELFI_User_Control.uTextBox)
                            {
                                DELFI_User_Control.uTextBox txt = (DELFI_User_Control.uTextBox)ctrl;
                                sText = txt.uText;
                            }
                            else if (ctrl is DevExpress.XtraEditors.MemoEdit)
                            {
                                DevExpress.XtraEditors.MemoEdit txt = (DevExpress.XtraEditors.MemoEdit)ctrl;
                                sText = txt.Text;
                            }
                            else if (ctrl is DELFI_User_Control.uMemoEdit)
                            {
                                DELFI_User_Control.uMemoEdit txt = (DELFI_User_Control.uMemoEdit)ctrl;
                                sText = txt.uText;
                            }

                            else if (ctrl is DevExpress.XtraEditors.MemoExEdit)
                            {
                                DevExpress.XtraEditors.MemoExEdit txt = (DevExpress.XtraEditors.MemoExEdit)ctrl;
                                sText = txt.Text;
                            }
                            else if (ctrl is DELFI_User_Control.uMemoExEdit)
                            {
                                DELFI_User_Control.uMemoExEdit txt = (DELFI_User_Control.uMemoExEdit)ctrl;
                                sText = txt.uText;
                            }
                            else if (ctrl is DevExpress.XtraEditors.SpinEdit)
                            {
                                DevExpress.XtraEditors.SpinEdit txt = (DevExpress.XtraEditors.SpinEdit)ctrl;
                                sText = txt.Value.ToString();
                            }
                            else if (ctrl is DELFI_User_Control.uSpinEdit)
                            {
                                DELFI_User_Control.uSpinEdit txt = (DELFI_User_Control.uSpinEdit)ctrl;
                                sText = txt.uText;
                            }
                            else if (ctrl is CheckBox)
                            {
                                CheckBox chk = (CheckBox)ctrl;
                                sText = chk.Checked ? "1" : "0";
                            }
                            else if (ctrl is DevExpress.XtraEditors.CheckEdit)
                            {
                                DevExpress.XtraEditors.CheckEdit chk = (DevExpress.XtraEditors.CheckEdit)ctrl;
                                sText = chk.Checked ? "1" : "0";
                            }
                            else if (ctrl is RadioButton)
                            {
                                RadioButton rdb = (RadioButton)ctrl;
                                sText = rdb.Checked ? "1" : "0";
                            }
                            else if (ctrl is DevExpress.XtraEditors.RadioGroup)
                            {
                                DevExpress.XtraEditors.RadioGroup rdgr = (DevExpress.XtraEditors.RadioGroup)ctrl;
                                sText = rdgr.EditValue.ToString();
                            }
                            else if (ctrl is RichTextBox)
                            {
                                sText = ctrl.Text;
                            }
                            else if (ctrl is DELFI_User_Control.BSCEmisNamHoc)
                            {
                                DELFI_User_Control.BSCEmisNamHoc NamHoc = (DELFI_User_Control.BSCEmisNamHoc)ctrl;
                                sText = NamHoc.iYear;
                            }
                            else if (ctrl is System.Windows.Forms.ComboBox)
                            {
                                System.Windows.Forms.ComboBox cbo = (System.Windows.Forms.ComboBox)ctrl;
                                if (bLength(cbo))
                                {
                                    sText = sNull2String(cbo.SelectedValue);
                                }
                                else
                                {
                                    sText = sNull2Int(sText);
                                }
                            }
                            else if (ctrl is DevExpress.XtraEditors.LookUpEdit)
                            {
                                DevExpress.XtraEditors.LookUpEdit cbo = (DevExpress.XtraEditors.LookUpEdit)ctrl;
                                if (bLength(cbo.Text))
                                {
                                    sText = sNull2String(cbo.EditValue.ToString());
                                }
                                else
                                {
                                    sText = DBNull.Value;
                                }
                            }
                            else if (ctrl is DELFI_User_Control.uComboBox)
                            {
                                DELFI_User_Control.uComboBox cbo = (DELFI_User_Control.uComboBox)ctrl;
                                if (bLength(cbo.uEditValue))
                                {
                                    sText = sNull2String(cbo.uEditValue.ToString());
                                }
                                else
                                {
                                    sText = DBNull.Value;
                                }
                            }
                            else if (ctrl is Label)
                            {
                                Label lbl = (Label)ctrl;
                                sText = lbl.Text;
                            }
                            else if (ctrl is DateTimePicker)
                            {
                                DateTimePicker dtp = (DateTimePicker)ctrl;
                                if (dtp.ShowCheckBox)
                                {
                                    if (dtp.Checked)
                                    {
                                        sText = dtp.Value.ToString("MM/dd/yyyy");
                                    }
                                    else
                                    {
                                        sText = "";
                                    }
                                }
                                else
                                {
                                    sText = dtp.Value.ToString("MM/dd/yyyy");
                                }
                            }
                            else if (ctrl is DevExpress.XtraEditors.DateEdit)
                            {
                                DevExpress.XtraEditors.DateEdit txt = (DevExpress.XtraEditors.DateEdit)ctrl;
                                if (txt.EditValue != DBNull.Value)
                                {
                                    sText = txt.DateTime.ToString("MM/dd/yyyy");
                                }
                                else
                                {
                                    sText = "";
                                }
                            }
                            else if (ctrl is DELFI_User_Control.uDateTimePicker)
                            {
                                DELFI_User_Control.uDateTimePicker txt = (DELFI_User_Control.uDateTimePicker)ctrl;
                                if (txt.uValue != DBNull.Value)
                                {
                                    sText = ((DateTime)txt.uValue).ToString("MM/dd/yyyy");
                                }
                                else
                                {
                                    sText = "NULL";
                                }
                            }
                            else if (ctrl is RichTextBox)
                            {
                                RichTextBox rtf = ctrl as RichTextBox;
                                sText = rtf.Rtf;
                            }
                            else if (ctrl is DevExpress.XtraEditors.PictureEdit)
                            {
                                DevExpress.XtraEditors.PictureEdit pic = (DevExpress.XtraEditors.PictureEdit)ctrl;
                                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                                byte[] arrPic;
                                if (pic.Image != null)
                                {
                                    System.Drawing.Imaging.ImageFormat imgft = pic.Image.RawFormat;
                                    pic.Image.Save(ms, imgft);
                                    arrPic = ms.GetBuffer();
                                }
                                else
                                {
                                    arrPic = new byte[0];
                                }
                            }
                            sField += sTag.Substring(2) + ",";
                            sValues += sText + "|";
                        }
                    } // end if Tag
                    if (ctrl.Controls.Count > 0) //Nếu ctr chứa đựng các control khác
                    {
                        if (bUserControl(ctrl))
                        {
                            continue;
                        }
                        CreateValuesFromControl(ctrl, ref sField, ref sValues);
                    }
                }// end foreach
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "CreateValuesFromControl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Đưa dữ liệu vào các control chứa dữ liệu
        /// </summary>
        /// <param name="control">Control chứa các control chứa dữ liệu</param>
        /// <param name="sField">các field</param>
        /// <param name="sValues">Giá trị của field</param>
        /// <param name="sWhere">Điều kiện lọc</param>
        public void CreateValuesFromControl(Control control, ref string sField, ref string sValues, ref string sWhere)
        {
            try
            {
                object sText;
                bool bDate = false;
                string sNgay = "FROM";
                foreach (Control ctrl in control.Controls)
                {
                    string sTag = sNull2String(ctrl.Tag);
                    if (sTag != "" && sTag.Length > 0)
                    {
                        sText = null;
                        if (ctrl is TextBox)
                        {
                            TextBox txt = (TextBox)ctrl;
                            sText = txt.Text;
                        }
                        else if (ctrl is DevExpress.XtraEditors.TextEdit)
                        {
                            DevExpress.XtraEditors.TextEdit txt = (DevExpress.XtraEditors.TextEdit)ctrl;
                            sText = txt.Text;
                        }
                        else if (ctrl is DELFI_User_Control.uTextBox)
                        {
                            DELFI_User_Control.uTextBox txt = (DELFI_User_Control.uTextBox)ctrl;
                            sText = txt.uText;
                        }
                        else if (ctrl is DevExpress.XtraEditors.MemoEdit)
                        {
                            DevExpress.XtraEditors.MemoEdit txt = (DevExpress.XtraEditors.MemoEdit)ctrl;
                            sText = txt.Text;
                        }
                        else if (ctrl is DELFI_User_Control.uMemoEdit)
                        {
                            DELFI_User_Control.uMemoEdit txt = (DELFI_User_Control.uMemoEdit)ctrl;
                            sText = txt.uText;
                        }

                        else if (ctrl is DevExpress.XtraEditors.MemoExEdit)
                        {
                            DevExpress.XtraEditors.MemoExEdit txt = (DevExpress.XtraEditors.MemoExEdit)ctrl;
                            sText = txt.Text;
                        }
                        else if (ctrl is DELFI_User_Control.uMemoExEdit)
                        {
                            DELFI_User_Control.uMemoExEdit txt = (DELFI_User_Control.uMemoExEdit)ctrl;
                            sText = txt.uText;
                        }
                        else if (ctrl is DevExpress.XtraEditors.SpinEdit)
                        {
                            DevExpress.XtraEditors.SpinEdit txt = (DevExpress.XtraEditors.SpinEdit)ctrl;
                            sText = txt.Value.ToString();
                        }
                        else if (ctrl is DELFI_User_Control.uSpinEdit)
                        {
                            DELFI_User_Control.uSpinEdit txt = (DELFI_User_Control.uSpinEdit)ctrl;
                            sText = txt.uText;
                        }
                        else if (ctrl is CheckBox)
                        {
                            CheckBox chk = (CheckBox)ctrl;
                            sText = chk.Checked ? "1" : "0";
                        }
                        else if (ctrl is DevExpress.XtraEditors.CheckEdit)
                        {
                            DevExpress.XtraEditors.CheckEdit chk = (DevExpress.XtraEditors.CheckEdit)ctrl;
                            sText = chk.Checked ? "1" : "0";
                        }
                        else if (ctrl is RadioButton)
                        {
                            RadioButton rdb = (RadioButton)ctrl;
                            sText = rdb.Checked ? "1" : "0";
                        }
                        else if (ctrl is DevExpress.XtraEditors.RadioGroup)
                        {
                            DevExpress.XtraEditors.RadioGroup rdgr = (DevExpress.XtraEditors.RadioGroup)ctrl;
                            sText = rdgr.EditValue.ToString();
                        }
                        else if (ctrl is RichTextBox)
                        {
                            sText = ctrl.Text;
                        }
                        else if (ctrl is DELFI_User_Control.BSCEmisNamHoc)
                        {
                            DELFI_User_Control.BSCEmisNamHoc NamHoc = (DELFI_User_Control.BSCEmisNamHoc)ctrl;
                            sText = NamHoc.iYear;
                        }
                        else if (ctrl is System.Windows.Forms.ComboBox)
                        {
                            System.Windows.Forms.ComboBox cbo = (System.Windows.Forms.ComboBox)ctrl;
                            if (bLength(cbo))
                            {
                                sText = cbo.Text;
                            }
                            else
                            {
                                sText = sNull2String(sText);
                            }
                        }
                        else if (ctrl is DevExpress.XtraEditors.LookUpEdit)
                        {
                            DevExpress.XtraEditors.LookUpEdit cbo = (DevExpress.XtraEditors.LookUpEdit)ctrl;
                            if (bLength(cbo.Text))
                            {
                                sText = cbo.Text;
                            }
                            else
                            {
                                sText = DBNull.Value;
                            }
                        }
                        else if (ctrl is DELFI_User_Control.uComboBox)
                        {
                            DELFI_User_Control.uComboBox cbo = (DELFI_WHM.NET.DELFI_User_Control.uComboBox)ctrl;
                            if (bLength(cbo.Text))
                            {
                                sText = cbo.uEditValue;
                            }
                            else
                            {
                                sText = DBNull.Value;
                            }
                        }
                        else if (ctrl is Label)
                        {
                            Label lbl = (Label)ctrl;
                            sText = lbl.Text;
                        }
                        else if (ctrl is DateTimePicker)
                        {
                            DateTimePicker dtp = (DateTimePicker)ctrl;
                            if (dtp.ShowCheckBox)
                            {
                                if (dtp.Checked)
                                {
                                    sText = dtp.Value.ToString("MM/dd/yyyy");
                                }
                                else
                                {
                                    sText = "NULL";
                                }
                            }
                            else
                            {
                                sText = dtp.Value.ToString("MM/dd/yyyy");
                            }
                        }
                        else if (ctrl is DevExpress.XtraEditors.DateEdit)
                        {
                            DevExpress.XtraEditors.DateEdit txt = (DevExpress.XtraEditors.DateEdit)ctrl;
                            if (txt.EditValue != DBNull.Value)
                            {
                                sText = txt.DateTime.ToString("MM/dd/yyyy");
                            }
                            else
                            {
                                sText = "NULL";
                            }
                        }
                        else if (ctrl is DELFI_User_Control.uDateTimePicker)
                        {
                            DELFI_User_Control.uDateTimePicker txt = (DELFI_User_Control.uDateTimePicker)ctrl;
                            if (txt.uValue != DBNull.Value)
                            {
                                sText = ((DateTime)txt.uValue).ToString("MM/dd/yyyy");
                            }
                            else
                            {
                                sText = "NULL";
                            }
                        }
                        if (bLength(sText))
                        {
                            if (bDate)
                            {
                                if (sNgay.Equals("FROM"))
                                {
                                    sWhere += sTag + ">=" + sText + " AND ";
                                }
                                else
                                {
                                    sWhere += sTag + "<=" + sText + " AND ";
                                }
                            }
                            else
                            {
                                sWhere += sTag + " LIKE N'%" + sText + "%' AND ";
                            }
                            sField += sTag + ",";
                            sValues += sText + "|";
                        }
                    } // end if Tag
                    if (ctrl.Controls.Count > 0 && ctrl.Enabled)
                    {
                        if (bUserControl(ctrl))
                        {
                            continue;
                        }
                        CreateValuesFromControl(ctrl, ref sField, ref sValues, ref sWhere);
                    }
                }// end foreach
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "CreateValuesFromControl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string sLike(string s)
        {
            s = s.Replace("'", "''");
            s = s.Replace("*", "%");
            s = s.Replace("?", "_");
            return ("LIKE " + sUnicode(s));
        }

        public string sLike(string s, bool bUnicode)
        {
            s = s.Replace("'", "''");
            s = s.Replace("*", "%");
            s = s.Replace("?", "_");
            s = "LIKE " + sUnicode(s, bUnicode);
            return (s);
        }

        /// <summary>
        /// Kiểm tra Control có phải là UserControl không?
        /// </summary>
        /// <param name="ctrl">Control cần kiểm tra</param>
        /// <returns></returns>
        public bool bUserControl(Control ctrl)
        {
            if (ctrl is DELFI_User_Control.uTextBox || ctrl is DELFI_User_Control.uComboBox || ctrl is DELFI_User_Control.uDateTimePicker ||
                ctrl is DELFI_User_Control.uMemoEdit || ctrl is DELFI_User_Control.uMemoExEdit || ctrl is DELFI_User_Control.uSpinEdit || ctrl is DELFI_User_Control.uLop || ctrl is DELFI_User_Control.uNhanSu || ctrl is DELFI_User_Control.uFind)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Xóa dữ liệu các control chứa đựng dữ liệu
        /// </summary>
        /// <param name="control">Control chứa dữ liệu</param>
        public void clearControl(Control control)
        {
            try
            {
                foreach (Control ctrl in control.Controls)
                {
                    if (ctrl is DELFI_User_Control.uComboBox)
                    {
                        DELFI_User_Control.uComboBox ucbo = (DELFI_User_Control.uComboBox)ctrl;
                        ucbo.uEditValue = null;
                    }
                    else if (ctrl is DELFI_User_Control.uTextBox)
                    {
                        DELFI_User_Control.uTextBox utxt = (DELFI_User_Control.uTextBox)ctrl;
                        utxt.uText = "";
                    }
                    else if (ctrl is DELFI_User_Control.uDateTimePicker)
                    {
                        DELFI_User_Control.uDateTimePicker dtp = (DELFI_User_Control.uDateTimePicker)ctrl;
                        dtp.uValue = null;
                    }
                    else if (ctrl is DELFI_User_Control.uMemoEdit)
                    {
                        DELFI_User_Control.uMemoEdit txt = (DELFI_User_Control.uMemoEdit)ctrl;
                        txt.uText = "";
                    }
                    else if (ctrl is DELFI_User_Control.uMemoExEdit)
                    {
                        DELFI_User_Control.uMemoExEdit txt = (DELFI_User_Control.uMemoExEdit)ctrl;
                        txt.uText = "";
                    }
                    else if (ctrl is DELFI_User_Control.uSpinEdit)
                    {
                        DELFI_User_Control.uSpinEdit txt = (DELFI_User_Control.uSpinEdit)ctrl;
                        txt.uText = "";
                    }
                    else if (ctrl is System.Windows.Forms.ComboBox)
                    {
                        System.Windows.Forms.ComboBox cbo = (System.Windows.Forms.ComboBox)ctrl;
                        cbo.SelectedIndex = -1;
                    }
                    else if (ctrl is DELFI_User_Control.uLop)
                    {
                        DELFI_User_Control.uLop _uLop = (DELFI_User_Control.uLop)ctrl;
                        _uLop.Clear(_uLop);
                        _uLop.sWhere = "";
                    }
                    else if (ctrl is TextBox)
                    {
                        TextBox txt = (TextBox)ctrl;
                        txt.Text = string.Empty;
                    }
                    else if (ctrl is CheckBox)
                    {
                        CheckBox chk = (CheckBox)ctrl;
                        chk.Checked = false;
                    }
                    else if (ctrl is PictureBox)
                    {
                        PictureBox pic = (PictureBox)ctrl;
                        pic.Image = null;
                    }
                    else if (ctrl is DevExpress.XtraEditors.ComboBox)
                    {
                        DevExpress.XtraEditors.ComboBox cbx = (DevExpress.XtraEditors.ComboBox)ctrl;
                        cbx.SelectedIndex = -1;
                    }
                    else if (ctrl is DevExpress.XtraEditors.DateEdit)
                    {
                        DevExpress.XtraEditors.DateEdit txt = (DevExpress.XtraEditors.DateEdit)ctrl;
                        txt.EditValue = null;
                    }
                    else if (ctrl is DevExpress.XtraEditors.TextEdit)
                    {
                        DevExpress.XtraEditors.TextEdit txt = (DevExpress.XtraEditors.TextEdit)ctrl;
                        txt.Text = "";
                    }
                    else if (ctrl is DevExpress.XtraEditors.MemoEdit)
                    {
                        DevExpress.XtraEditors.MemoEdit txt = (DevExpress.XtraEditors.MemoEdit)ctrl;
                        txt.Text = "";
                    }
                    else if (ctrl is DevExpress.XtraEditors.MemoExEdit)
                    {
                        DevExpress.XtraEditors.MemoExEdit txt = (DevExpress.XtraEditors.MemoExEdit)ctrl;
                        txt.Text = "";
                    }
                    else if (ctrl is DevExpress.XtraEditors.SpinEdit)
                    {
                        DevExpress.XtraEditors.SpinEdit txt = (DevExpress.XtraEditors.SpinEdit)ctrl;
                        txt.Text = "";
                    }
                    else if (ctrl is DevExpress.XtraEditors.CheckEdit)
                    {
                        DevExpress.XtraEditors.CheckEdit chk = (DevExpress.XtraEditors.CheckEdit)ctrl;
                        if (chk.Properties.AllowGrayed)
                            chk.CheckState = CheckState.Indeterminate;
                        else
                            chk.Checked = false;
                    }
                    else if (ctrl is PictureEdit)
                    {
                        PictureEdit pic = (PictureEdit)ctrl;
                        pic.Image = null;
                    }
                    if (ctrl.Controls.Count > 0)
                    {
                        if (bUserControl(ctrl))
                        {
                            continue;
                        }
                        clearControl(ctrl);
                    }
                }
            }
            catch (ArgumentException ag)
            {
                //MessageBox.Show(ag.ToString(), "clearControl", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool bComboIsNull(DELFI_User_Control.uComboBox cbx)
        {
            if (sNull2String(cbx.uEditValue) == "" || sNull2String(cbx.uText) == "")
                return true;
            return false;
        }


        #region Encrypt/Decrypt

        public byte[] Encrypt(byte[] clearData, byte[] Key, byte[] IV)
        {
            MemoryStream ms = new MemoryStream();
            Rijndael alg = Rijndael.Create();
            alg.Key = Key;
            alg.IV = IV;

            CryptoStream cs = new CryptoStream(ms, alg.CreateEncryptor(), CryptoStreamMode.Write);

            cs.Write(clearData, 0, clearData.Length);

            cs.Close();

            byte[] encryptedData = ms.ToArray();

            return encryptedData;
        }

        // Encrypt a string into a string using a password 
        //    Uses Encrypt(byte[], byte[], byte[]) 

        public string Encrypt(string clearText, string Password)
        {
            byte[] clearBytes = System.Text.Encoding.Unicode.GetBytes(clearText);
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password,
                new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 
							   0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});

            byte[] encryptedData = Encrypt(clearBytes,
                pdb.GetBytes(32), pdb.GetBytes(16));

            return Convert.ToBase64String(encryptedData);
        }

        // Encrypt bytes into bytes using a password 
        //    Uses Encrypt(byte[], byte[], byte[]) 

        public byte[] Encrypt(byte[] clearData, string Password)
        {
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password,
                new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 
							   0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});
            return Encrypt(clearData, pdb.GetBytes(32), pdb.GetBytes(16));
        }

        // Encrypt a file into another file using a password 
        public void Encrypt(string fileIn, string fileOut, string Password)
        {
            // First we are going to open the file streams 
            FileStream fsIn = new FileStream(fileIn, FileMode.Open, FileAccess.Read);
            FileStream fsOut = new FileStream(fileOut, FileMode.OpenOrCreate, FileAccess.Write);

            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password,
                new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });

            Rijndael alg = Rijndael.Create();
            alg.Key = pdb.GetBytes(32);
            alg.IV = pdb.GetBytes(16);

            CryptoStream cs = new CryptoStream(fsOut,
                alg.CreateEncryptor(), CryptoStreamMode.Write);

            int bufferLen = 4096;
            byte[] buffer = new byte[bufferLen];
            int bytesRead;

            do
            {
                // read a chunk of data from the input file 
                bytesRead = fsIn.Read(buffer, 0, bufferLen);
                // encrypt it 
                cs.Write(buffer, 0, bytesRead);
            } while (bytesRead != 0);

            cs.Close();
            fsIn.Close();
        }

        // Decrypt a byte array into a byte array using a key and an IV 
        public byte[] Decrypt(byte[] cipherData, byte[] Key, byte[] IV)
        {
            MemoryStream ms = new MemoryStream();

            Rijndael alg = Rijndael.Create();

            alg.Key = Key;
            alg.IV = IV;

            CryptoStream cs = new CryptoStream(ms, alg.CreateDecryptor(), CryptoStreamMode.Write);

            // Write the data and make it do the decryption 
            cs.Write(cipherData, 0, cipherData.Length);

            cs.Close();

            byte[] decryptedData = ms.ToArray();

            return decryptedData;
        }

        // Decrypt a string into a string using a password 
        //    Uses Decrypt(byte[], byte[], byte[]) 

        public string Decrypt(string cipherText, string Password)
        {
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password,
                new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 
							   0x64, 0x76, 0x65, 0x64, 0x65, 0x76});
            byte[] decryptedData = Decrypt(cipherBytes, pdb.GetBytes(32), pdb.GetBytes(16));
            return System.Text.Encoding.Unicode.GetString(decryptedData);
        }

        // Decrypt bytes into bytes using a password 
        //    Uses Decrypt(byte[], byte[], byte[]) 

        public byte[] Decrypt(byte[] cipherData, string Password)
        {
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password,
                new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 
							   0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});
            return Decrypt(cipherData, pdb.GetBytes(32), pdb.GetBytes(16));
        }

        // Decrypt a file into another file using a password 
        public void Decrypt(string fileIn, string fileOut, string Password)
        {
            FileStream fsIn = new FileStream(fileIn, FileMode.Open, FileAccess.Read);
            FileStream fsOut = new FileStream(fileOut, FileMode.OpenOrCreate, FileAccess.Write);
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password,
                new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 
							   0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});
            Rijndael alg = Rijndael.Create();

            alg.Key = pdb.GetBytes(32);
            alg.IV = pdb.GetBytes(16);

            CryptoStream cs = new CryptoStream(fsOut, alg.CreateDecryptor(), CryptoStreamMode.Write);

            int bufferLen = 4096;
            byte[] buffer = new byte[bufferLen];
            int bytesRead;

            do
            {
                // read a chunk of data from the input file 
                bytesRead = fsIn.Read(buffer, 0, bufferLen);
                // Decrypt it 
                cs.Write(buffer, 0, bytesRead);
            } while (bytesRead != 0);
            // close everything 
            cs.Close(); // this will also close the unrelying fsOut stream 
            fsIn.Close();
        }


        #endregion

    public string EncodeString(string originalPassword)
        {
            //Declarations
            Byte[] originalBytes;
            Byte[] encodedBytes;
            MD5 md5;

            //Instantiate MD5CryptoServiceProvider, get bytes for original password and compute hash (encoded password)
            md5 = new MD5CryptoServiceProvider();
            originalBytes = ASCIIEncoding.Default.GetBytes(originalPassword);
            encodedBytes = md5.ComputeHash(originalBytes);

            //Convert encoded bytes back to a 'readable' string
            return BitConverter.ToString(encodedBytes);
        }
        public struct Lop
        {
            public void ResetAll()
            {
                sLoaiDaoTao = "";
                sKhoa = "";
                sKhoaHoc = "";
                sBacDaoTao = "";
                sNganh = "";
                sChuyenNganh = "";
                sLop = "";
            }
            public string sLoaiDaoTao;
            public string sKhoa;
            public string sKhoaHoc;
            public string sBacDaoTao;
            public string sNganh;
            public string sChuyenNganh;
            public string sLop;
        }

        public void GetHSSV(string MaSinhVien, ref Lop cLop)
        {
            string sSQL = "select DM_LopHoc.MaLoaiDaoTao, DM_LopHoc.MaKhoa, DM_LopHoc.MaKhoaHoc, DM_LopHoc.MaBacDaoTao, DM_LopHoc.MaNganh, DM_LopHoc.MaChuyenNganh, DM_LopHoc.MaLopHoc from EM_HS_SINHVIEN INNER JOIN DM_LOPHOC ON EM_HS_SINHVIEN.MaLopHoc = DM_LopHoc.MaLopHoc where EM_HS_SINHVIEN.MaSinhVien = N'" + MaSinhVien + "'";
            DataTable dt = DT_DataTable(sSQL);
            if (dt == null)
            {
                cLop.sLoaiDaoTao = "";
                cLop.sKhoa = "";
                cLop.sKhoaHoc = "";
                cLop.sBacDaoTao = "";
                cLop.sNganh = "";
                cLop.sChuyenNganh = "";
                cLop.sLop = "";
            }
            else
            {
                cLop.sLoaiDaoTao = dt.Rows[0]["MaLoaiDaoTao"].ToString();
                cLop.sKhoa = dt.Rows[0]["MaKhoa"].ToString();
                cLop.sKhoaHoc = dt.Rows[0]["MaKhoaHoc"].ToString();
                cLop.sBacDaoTao = dt.Rows[0]["MaBacDaoTao"].ToString();
                cLop.sNganh = dt.Rows[0]["MaNganh"].ToString();
                //if (dt.Rows[0]["MaChuyenNganh"] != DBNull.Value)
                    cLop.sChuyenNganh = dt.Rows[0]["MaChuyenNganh"].ToString();
                //lse
                    //cLop.sChuyenNganh = null;
                cLop.sLop = dt.Rows[0]["MaLopHoc"].ToString();
            }
        }
        public void GetValue(Control fr, ref Hashtable Val)
        {
            foreach (Control ctrl in fr.Controls)
            {
                string sTag = sNull2String(ctrl.Tag);
                if (sTag != "" && sTag.Length > 0)
                {
                    if (!sTag.Contains(".."))
                        continue;
                    sTag = sTag.Replace("..", "");
                    if (ctrl is TextBox)
                    {
                        TextBox txt = (TextBox)ctrl;
                        if (bLength(txt.Text))
                            Val.Add(sTag, txt.Text);
                    }
                    else if (ctrl is DevExpress.XtraEditors.TextEdit)
                    {
                        DevExpress.XtraEditors.TextEdit txt = (DevExpress.XtraEditors.TextEdit)ctrl;
                        if (bLength(txt.EditValue))
                            Val.Add(sTag, txt.Text);
                    }
                    else if (ctrl is DELFI_User_Control.uTextBox)
                    {
                        DELFI_User_Control.uTextBox txt = (DELFI_User_Control.uTextBox)ctrl;
                        if (bLength(txt.uText))
                            if (txt.bUseMask && txt.uMaskType == DevExpress.XtraEditors.Mask.MaskType.Numeric && Convert.ToDecimal(txt.uText) == 0)
                            { }
                            else
                            {
                                Val.Add(sTag, txt.uText);
                            }
                    }
                    else if (ctrl is DevExpress.XtraEditors.MemoEdit)
                    {
                        DevExpress.XtraEditors.MemoEdit txt = (DevExpress.XtraEditors.MemoEdit)ctrl;
                        if (bLength(txt.EditValue))
                            Val.Add(sTag, txt.Text);
                    }
                    else if (ctrl is DELFI_User_Control.uMemoEdit)
                    {
                        DELFI_User_Control.uMemoEdit txt = (DELFI_User_Control.uMemoEdit)ctrl;
                        if (bLength(txt.uText))
                            Val.Add(sTag, txt.Text);
                    }
                    else if (ctrl is DevExpress.XtraEditors.MemoExEdit)
                    {
                        DevExpress.XtraEditors.MemoExEdit txt = (DevExpress.XtraEditors.MemoExEdit)ctrl;
                        if (bLength(txt.EditValue))
                            Val.Add(sTag, txt.Text);
                    }
                    else if (ctrl is DELFI_User_Control.uMemoExEdit)
                    {
                        DELFI_User_Control.uMemoExEdit txt = (DELFI_User_Control.uMemoExEdit)ctrl;
                        if (bLength(txt.uText))
                            Val.Add(sTag, txt.Text);
                    }
                    else if (ctrl is DevExpress.XtraEditors.SpinEdit)
                    {
                        DevExpress.XtraEditors.SpinEdit txt = (DevExpress.XtraEditors.SpinEdit)ctrl;
                        if (bLength(txt.EditValue) && txt.Text != "0")
                            Val.Add(sTag, txt.Text);
                    }
                    else if (ctrl is DELFI_User_Control.uSpinEdit)
                    {
                        DELFI_User_Control.uSpinEdit txt = (DELFI_User_Control.uSpinEdit)ctrl;
                        if (bLength(txt.uText) && txt.uText != "0")
                            Val.Add(sTag, txt.uText);
                    }
                    else if (ctrl is RichTextBox)
                    {
                        RichTextBox txt = (RichTextBox)ctrl;
                        if (bLength(txt.Text))
                            Val.Add(sTag, txt.Text);
                    }
                    else if (ctrl is System.Windows.Forms.ComboBox)
                    {
                        System.Windows.Forms.ComboBox cbo = (System.Windows.Forms.ComboBox)ctrl;
                        if (bLength(cbo.SelectedValue))
                        {
                            Val.Add(sTag, cbo.SelectedValue.ToString());
                        }
                    }
                    else if (ctrl is DevExpress.XtraEditors.LookUpEdit)
                    {
                        DevExpress.XtraEditors.LookUpEdit cbo = (DevExpress.XtraEditors.LookUpEdit)ctrl;
                        if (cbo.EditValue != null)
                            if (cbo.EditValue.ToString() != "")
                            {
                                Val.Add(sTag, cbo.EditValue.ToString());
                            }
                    }
                    else if (ctrl is DELFI_User_Control.uComboBox)
                    {
                        DELFI_User_Control.uComboBox cbo = (DELFI_User_Control.uComboBox)ctrl;
                        if (cbo.uEditValue != null)
                            if (cbo.uEditValue.ToString() != "")
                            {
                                Val.Add(sTag, cbo.uEditValue.ToString());
                            }
                    }
                    else if (ctrl is DateTimePicker)
                    {
                        DateTimePicker dtp = (DateTimePicker)ctrl;
                        if (dtp.ShowCheckBox)
                        {
                            if (dtp.Checked)
                            {
                                Val.Add(sTag, dtp.Value.ToString("MM/dd/yyyy"));
                            }
                        }
                        else
                        {
                            Val.Add(sTag, dtp.Value.ToString("MM/dd/yyyy"));
                        }
                    }
                    else if (ctrl is DevExpress.XtraEditors.DateEdit)
                    {
                        DevExpress.XtraEditors.DateEdit txt = (DevExpress.XtraEditors.DateEdit)ctrl;
                        if (txt.EditValue != DBNull.Value)
                        {
                            Val.Add(sTag, txt.DateTime.ToString("MM/dd/yyyy"));
                        }
                    }
                    else if (ctrl is DELFI_User_Control.uDateTimePicker)
                    {
                        DELFI_User_Control.uDateTimePicker txt = (DELFI_User_Control.uDateTimePicker)ctrl;
                        if (txt.uValue != DBNull.Value)
                            if (txt.uValue != null && txt.uValue != "")
                            {
                                Val.Add(sTag, txt.uDateTime.ToString("MM/dd/yyyy"));
                            }
                    }
                    else if (ctrl is DELFI_User_Control.BSCEmisNamHoc)
                    {
                        DELFI_User_Control.BSCEmisNamHoc txt = (DELFI_User_Control.BSCEmisNamHoc)ctrl;
                        Val.Add(sTag, txt.iYear.ToString());
                    }
                    else if (ctrl is DevExpress.XtraEditors.CheckEdit)
                    {
                        DevExpress.XtraEditors.CheckEdit txt = (DevExpress.XtraEditors.CheckEdit)ctrl;
                        if (txt.CheckState != CheckState.Indeterminate)
                            Val.Add(sTag, txt.Checked);
                    }
                }
                if (ctrl.Controls.Count > 0 && ctrl.Enabled)
                {
                    if (bUserControl(ctrl))
                    {
                        continue;
                    }
                    GetValue(ctrl, ref Val);
                }
            }
        }
    }
    public class Doctien
    {
        public string Convert_NumtoText(string Sonhap)
        {
            string result = "";
            Sonhap = Sonhap.Split('.')[0].Replace(",", "");
            switch (Sonhap.Length)
            {
                case 0: result = "";
                    break;
                case 1: result = Sodonvi(Sonhap);
                    break;
                case 2:
                    {

                        result = Sohangchuc(Sonhap);

                    }
                    break;
                case 3:
                    {
                        result = Sohangtram(Sonhap);
                    }
                    break;
                case 4:
                    {
                        result = Sohangngan(Sonhap);

                    }
                    break;
                case 5:
                    {
                        if (Sonhap.Substring(2, 3).Equals("000"))
                        {
                            result = Sohangchuc(Sonhap.Substring(0, 2)) + " ngàn ";
                        }
                        else
                            result = Sohangchuc(Sonhap.Substring(0, 2)) + " ngàn " + Sohangtram(Sonhap.Substring(2, 3)).ToLower();
                    }
                    break;
                case 6:
                    {
                        if (Sonhap.Substring(3, 3).Equals("000"))
                        {
                            result = Sohangtram(Sonhap.Substring(0, 3)) + " ngàn ";
                        }
                        else
                            result = Sohangtram(Sonhap.Substring(0, 3)) + " ngàn " + Sohangtram(Sonhap.Substring(3, 3)).ToLower();

                    }
                    break;
                case 7:
                    {
                        if (Sonhap.Substring(4, 3).Equals("000"))
                        {
                            result = Sodonvi(Sonhap.Substring(0, 1)) + " triệu " + Sohangtram(Sonhap.Substring(1, 3)).ToLower() + " ngàn";
                        }
                        else
                        result = Sodonvi(Sonhap.Substring(0, 1)) + " triệu " + Sohangtram(Sonhap.Substring(1, 3)).ToLower() + " ngàn " + Sohangtram(Sonhap.Substring(4, 3)).ToLower();
                    }
                    break;
                case 8:
                    {
                        if (Sonhap.Substring(2, 6).Equals("000000"))
                        {
                            result = Sohangchuc(Sonhap.Substring(0, 2)) + " triệu ";
                        }
                        else
                            result = Sohangchuc(Sonhap.Substring(0, 2)) + " triệu " + Sohangtram(Sonhap.Substring(2, 3)).ToLower() +
                                " ngàn " + Sohangtram(Sonhap.Substring(5, 3)).ToLower();
                    }
                    break;
                case 9:
                    {
                        if (Sonhap.Substring(3, 6).Equals("000000"))
                        {
                            result = Sohangtram(Sonhap.Substring(0, 3)) + " triệu ";
                        }
                        else
                            result = Sohangtram(Sonhap.Substring(0, 3)) + " triệu " + Sohangtram(Sonhap.Substring(3, 3)).ToLower() +
                                " ngàn " + Sohangtram(Sonhap.Substring(6, 3)).ToLower();
                    }
                    break;
                case 10:
                    {
                        if (Sonhap.Substring(1, 9).Equals("000000000"))
                        {
                            result = Sodonvi(Sonhap.Substring(0, 1)) + " tỷ ";
                        }
                        else
                            result = Sodonvi(Sonhap.Substring(0, 1)) + " tỷ " + Sohangtram(Sonhap.Substring(1, 3)).ToLower() + " triệu " + Sohangtram(Sonhap.Substring(4, 3)).ToLower() +
                                " ngàn " + Sohangtram(Sonhap.Substring(7, 3)).ToLower();
                    }
                    break;
                case 11:
                    {
                        if (Sonhap.Substring(2, 9).Equals("000000000"))
                        {
                            result = Sohangchuc(Sonhap.Substring(0, 2)) + " tỷ ";
                        }
                        else
                            result = Sohangchuc(Sonhap.Substring(0, 2)) + " tỷ " + Sohangtram(Sonhap.Substring(2, 3)).ToLower() + " triệu " + Sohangtram(Sonhap.Substring(5, 3)).ToLower() +
                                " ngàn " + Sohangtram(Sonhap.Substring(6, 3)).ToLower();
                    }
                    break;
                case 12:
                    {
                        if (Sonhap.Substring(3, 9).Equals("000000000"))
                        {
                            result = Sohangtram(Sonhap.Substring(0, 3)) + " tỷ ";
                        }
                        else
                            result = Sohangtram(Sonhap.Substring(0, 3)) + " tỷ " + Sohangtram(Sonhap.Substring(3, 3)).ToLower() + " triệu " + Sohangtram(Sonhap.Substring(6, 3)).ToLower() +
                                " ngàn " + Sohangtram(Sonhap.Substring(9, 3)).ToLower();
                    }
                    break;
            }
            return result.Replace("  ", " ").Replace("mươi một", "mươi mốt").Replace("mươi năm", "mươi lăm").Replace("Mười năm", "Mười lăm").Replace("mười năm", "mười lăm").Replace("không trăm triệu ", "").Replace("không trăm ngàn ", "").Trim() + " đồng";
        }
        private string ChuanHoa(string st)
        {
            string st1 = "";
            return st1.Trim();
        }
        string Sohangngan(string So)
        {
            string result = "";
            if (So.Equals("1000"))
                result = " Một ngàn ";
            else
            {
                result = Sodonvi(So.Substring(0, 1)) + " ngàn ";
                if (So.Substring(1, 1).Equals("0"))
                {
                    if (So.Substring(2, 1).Equals("0"))
                    {
                        if (!So.Substring(3, 1).Equals("0"))
                        {
                            result += Sodonvi(So.Substring(1, 1)).ToLower() + " trăm ";
                            result += " lẻ " + Sodonvi(So.Substring(So.Length - 1)).ToLower();
                        }
                    }
                    else
                    {
                        result += Sodonvi(So.Substring(1, 1).ToLower()) + " trăm ";
                        result += Sohangchuc(So.Substring(2, 2)).ToLower();
                    }
                }
                else
                    result += Sohangtram(So.Substring(1, 3)).ToLower();
            }
            return result;
        }

        string Sohangtram(string So)
        {
            string result = "";
            if (So.Equals("100"))
                result = " Một trăm ";
            else
            {
                result += Sodonvi(So.Substring(0, 1)) + " trăm ";
                if (So.Substring(1, 1).Equals("0"))
                {
                    if (!So.Substring(2, 1).Equals("0"))
                        result += " lẻ " + Sodonvi(So.Substring(2, 1)).ToLower();
                }
                else
                    result += Sohangchuc(So.Substring(1, 2)).ToLower();
            }
            return result;

        }
        string Sohangchuc(string So)
        {
            string result = "";
            if (So.Equals("10"))
                result = " Mười ";
            else
            {
                if (So.Substring(0, 1).Equals("1"))
                    result += " Mười " + Sodonvi(So.Substring(1, 1)).ToLower();
                else
                {
                    result += Sodonvi(So.Substring(0, 1)) + " mươi ";
                    if (!So.Substring(1, 1).Equals("0"))
                        result += Sodonvi(So.Substring(1, 1)).ToLower();
                }
            }
            return result;
        }
        string Sodonvi(string So)
        {
            string result = "";
            switch (So)
            {
                case "0": result += " Không ";
                    break;
                case "1": result += " Một ";
                    break;
                case "2": result += " Hai ";
                    break;
                case "3": result += " Ba  ";
                    break;
                case "4": result += " Bốn ";
                    break;
                case "5": result += " Năm ";
                    break;
                case "6": result += " Sáu ";
                    break;
                case "7": result += " Bảy ";
                    break;
                case "8": result += " Tám ";
                    break;
                case "9": result += " Chín ";
                    break;

            }
            return result;
        }
    }


}