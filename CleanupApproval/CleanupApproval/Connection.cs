using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CleanupApproval
{
    class Connection
    {
        private static string ConnStr;

        public string GetConnectionStr()
        {
            return ConnStr;
        }

        public void initConnection(string coonString)
        {
            Connection.ConnStr = coonString;
        }

        public string testConnection(string conString)
        {
            if (conString == null)
            {
                MessageBox.Show( "连接字符串为空", "数据库连接串错误", MessageBoxButtons.OK);
                return "连接字符串为空";
            }
            using (SqlConnection conn = new SqlConnection(conString))
            {
                try
                {
                    conn.Open();
                    return "OK";
                }
                catch (System.Exception ex)
                {
                    return ex.Message;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public SqlConnection GetSqlConnection()
        {
            return new SqlConnection(ConnStr);
        }

        public DataSet ExecuteSQLQuery(string sqlStr, string conString = null)
        {
            if (conString == null)
            {
                conString = ConnStr;
            }
            using (var conn = new SqlConnection(conString))
            {
                try
                {
                    conn.Open();
                    try
                    {
                        SqlCommand scCommand = conn.CreateCommand();
                        scCommand.CommandText = sqlStr;
                        //建立Adapter
                        SqlDataAdapter sdaAdapter = new SqlDataAdapter(scCommand);

                        //得到数据
                        DataSet dsSet = new DataSet();
                        sdaAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                        sdaAdapter.Fill(dsSet, "Temp_table");
                        return dsSet;
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(null, ex.Message, "提示", MessageBoxButtons.OK);
                        return null;
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(null, ex.Message, "提示", MessageBoxButtons.OK);
                    return null;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public bool noSQLQuery(string sqlStr, string conString)
        {
            if (conString == null)
            {
                conString = ConnStr;
            }
            using (var conn = new SqlConnection(conString))
            {
                try
                {
                    conn.Open();
                    try
                    {
                        SqlCommand scCommand = new SqlCommand(sqlStr, conn);

                        int res = scCommand.ExecuteNonQuery();

                        return res > 0;
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(null, ex.Message, "提示", MessageBoxButtons.OK);
                        return false;
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(null, ex.Message, "提示", MessageBoxButtons.OK);
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public bool DoConnection()
        {
            return ConnStr != null;
        }
    }
}
