using System;
using System.Collections.Generic;
using System.Text;

namespace BSC_EMIS.NET.BSC_User_Control
{
    class Class1
    {


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
            if(Table.ToLower().Contains("select"))
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
            return CreateDataTable(SQLStr);
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
            return CreateDataTable(SQLStr, LType);
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
            return CreateDataTable(SQLStr);
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
            return CreateDataTable(SQLStr, LType);
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
                BSCException.LogException(ex);
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

    }
}
