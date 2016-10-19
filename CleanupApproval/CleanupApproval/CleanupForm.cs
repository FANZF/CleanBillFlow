using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace CleanupApproval
{
    public partial class CleanupForm : Form
    {

        public CleanupForm()
        {
            InitializeComponent();
            initButtons();
        }

        private void initButtons()
        {
            btnSearch.Enabled = false;
            btnExecute.Enabled = false;
            btnSQL.Enabled = false;
            btnSQLSet.Text = "连接设置\r\n(未设置)";

            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.ForeColor = Color.Red;
            foreach (DataGridViewColumn col in this.dgvDJList.Columns)
            {
                col.HeaderCell.Style = style;
            }
            this.dgvDJList.EnableHeadersVisualStyles = false;

            SQLSetForm sqlSet = new SQLSetForm();
            sqlSet.ShowDialog();

            initComboBox();
        }

        private void MyinitComboBox()
        {
            ISynchronizeInvoke synchronizer = this;

            if (synchronizer.InvokeRequired)
            {
                MethodInvoker minvoker = new MethodInvoker(this.initComboBox);
                synchronizer.Invoke(minvoker, null);
            }
            else
            {
                this.initComboBox();
            }
        }

        private void initComboBox()
        {

            ISynchronizeInvoke synchronizer = this;

            Connection con = new Connection();

            if (con.DoConnection())
            {
                btnSQLSet.Text = "连接设置\r\n(已连接)";
                btnSearch.Enabled = true;
                btnExecute.Enabled = false;
                btnSQL.Enabled = false;

                DataSet ds = con.ExecuteSQLQuery(ConstSQLs.queryOrgs);

                cbOrg.DataSource = ds.Tables[0];
                cbOrg.DisplayMember = "Name";
                cbOrg.ValueMember = "OrgID";

                cbOrg.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbOrg.AutoCompleteSource = AutoCompleteSource.ListItems;
                cbOrg.SelectedIndex = -1;

                ds = con.ExecuteSQLQuery(ConstSQLs.queryMKs);
                cbMK.DataSource = ds.Tables[0];

                cbMK.DisplayMember = "Name";
                cbMK.ValueMember = "BizTypeID";

                cbMK.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbMK.AutoCompleteSource = AutoCompleteSource.ListItems;
                cbMK.SelectedIndex = -1;
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            bool iRes = false;

            List<string> tableList = getMasterTableList();

            string updateCommonsql = string.Format(ConstSQLs.updateDJSql, GetDJList());

            Connection con = new Connection();

            SqlConnection SQLCon = con.GetSqlConnection();
            SQLCon.Open();
            SqlCommand scCommand = new SqlCommand(updateCommonsql, SQLCon);

            if (scCommand.ExecuteNonQuery() > 0)
            {
                iRes = true;
            }

            string str = null;

            foreach (string updateTableSql in tableList)
            {
                str = string.Format(updateTableSql, GetDJList());

                scCommand = new SqlCommand(str, SQLCon);
                int res = scCommand.ExecuteNonQuery();
               
                if (res > 0)
                {
                    iRes = iRes & true;
                }
            }

            SQLCon.Close();

            if (iRes)
            {
                MessageBox.Show(null, "清理完成", "OK", MessageBoxButtons.OK);
            }

            btnSearch_Click(sender, e);
        }

        private void saveToDisk(List<string> updateSQL)
        {
            string strCurPath = AppDomain.CurrentDomain.BaseDirectory.ToString();
            string strSQLFile = Path.Combine(strCurPath, System.DateTime.Now.ToString("yyyy年MM月dd日_HH_mm_ss") + ".txt");

            if (File.Exists(strSQLFile) == true)
            {
                strSQLFile = strSQLFile + ".SQL";
            }

            StreamWriter sw = File.CreateText(@strSQLFile);
          
            foreach (string sql in updateSQL)
            {
                sw.WriteLine(sql);
            }

            sw.Close();

        }

        private void btnSQLSet_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();

            SQLSetForm sqlSet = new SQLSetForm(con.GetConnectionStr());
            sqlSet.ShowDialog();

            if (con.DoConnection())
            {
                initComboBox();
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbMK.SelectedValue != null)
            {

                string sqlQuery = string.Format(ConstSQLs.queryDJSql, cbMK.SelectedValue.ToString());

                if (tbDJBH.Text != "")
                {
                    sqlQuery = sqlQuery + string.Format("and DJ.DJBH like '%{0}%' \r\n", tbDJBH.Text);
                }

                if (cbOrg.Text != "")
                {
                    sqlQuery = sqlQuery + string.Format("and DJ.BZJGID = {0} \r\n", cbOrg.SelectedValue.ToString());
                }

                Connection con = new Connection();
                DataSet ds = con.ExecuteSQLQuery(sqlQuery);

                dgvDJList.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show(null, "模块名称必选", "提示", MessageBoxButtons.OK);
            }
            
        }

        private string GetDJList()
        {
            string djList = null;
            for (int i = 0; i < dgvDJList.RowCount; i++)
            {
                if (dgvDJList.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")
                {
                    if (djList == null)
                        djList = dgvDJList.Rows[i].Cells[1].EditedFormattedValue.ToString();
                    else
                        djList = djList + "," + dgvDJList.Rows[i].Cells[1].EditedFormattedValue.ToString();
                }
            }
            return djList;
        }

        private int GetDJCount()
        {
            return dgvDJList.RowCount;
        }

        private List<string> getMasterTableList()
        {
            List<string> tableList = new List<string>();
            Connection con = new Connection();
            DataSet ds = con.ExecuteSQLQuery(ConstSQLs.queryMasterTables);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                tableList.Add(string.Format(ConstSQLs.updateMaserTable,ds.Tables[0].Rows[i][0].ToString(), "{0}"));
            }
            return tableList;
        }

        private void dgvDJList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                dgvDJList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;

                //这里保留的数据都是修改前的状态，所以绕行判断是否有选中项
                if (dgvDJList.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.ToString() == "False")
                {
                    btnExecute.Enabled = true;
                    btnSQL.Enabled = true;
                    GetDJJZData(Convert.ToInt32(dgvDJList.Rows[e.RowIndex].Cells["DJID"].Value));
                }
                else if (getChooseDJCount() <= 1)
                {
                    btnExecute.Enabled = false;
                    btnSQL.Enabled = false;
                }
            }
        }

        private void GetDJJZData(int DJID)
        {
            string sqlQuery = string.Format(ConstSQLs.queryDJJZData, DJID);

            Connection con = new Connection();
            DataSet ds = con.ExecuteSQLQuery(sqlQuery);

            dgvJZXX.DataSource = ds.Tables[0];
        }

        private int getChooseDJCount()
        {
            int nDJCount = 0;
            for (int i = 0; i < dgvDJList.RowCount; i++)
            {
                if (dgvDJList.Rows[i].Cells[0].EditedFormattedValue.ToString() == "True")
                {
                    nDJCount++;
                }
            }
            return nDJCount;
        }

        private void btnSQL_Click(object sender, EventArgs e)
        {
            bool iRes = false;
            List<string> tableList = getMasterTableList();

            List<string> tableSql = new List<string>();

            string djIDs = GetDJList();

            string updateCommonsql = string.Format(ConstSQLs.updateDJSql, djIDs);

            Connection con = new Connection();

            SqlConnection SQLCon = con.GetSqlConnection();
            SQLCon.Open();

            SqlCommand scCommand = new SqlCommand(ConstSQLs.beginQuery, SQLCon);
            scCommand.ExecuteNonQuery();

            tableSql.Add("--" + con.GetConnectionStr());
            tableSql.Add(updateCommonsql);
            string str = null;

            foreach (string updateTableSql in tableList)
            {
                str = string.Format(updateTableSql, djIDs);
                scCommand = new SqlCommand(str, SQLCon);
                int res = scCommand.ExecuteNonQuery();

                if (res > 0)
                {
                    iRes = true;
                    tableSql.Add(str);
                }
            }

            scCommand = new SqlCommand(ConstSQLs.endQuery, SQLCon);
            scCommand.ExecuteNonQuery();

            SQLCon.Close();

            if (iRes)
            {
                saveToDisk(tableSql);
                MessageBox.Show(this, "生成成功", "OK", MessageBoxButtons.OK);
            }
        }

    }
}
