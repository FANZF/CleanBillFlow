using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CleanupApproval
{
    public partial class SQLSetForm : Form
    {
        const string CONNSTRING = "Data Source={0};Initial Catalog={1};User ID={2};Password={3};Integrated Security={4}";

        public SQLSetForm(string conString = null)
        {
            InitializeComponent();
            initSqlSet(conString);
        }

        private void initSqlSet(string conString = null)
        {
            if (conString == null)
            {
                cbCatalog.Enabled = false;
            }
            else
            {
                Connection con = new Connection();

                if (con.testConnection(conString) == "OK")
                {
                    DataSet ds = con.ExecuteSQLQuery(ConstSQLs.queryCatalogs, conString);

                    cbCatalog.DataSource = ds.Tables[0];
                    cbCatalog.DisplayMember = "Name";
                    cbCatalog.ValueMember = "Name";

                    cbCatalog.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    cbCatalog.AutoCompleteSource = AutoCompleteSource.ListItems;

                    cbCatalog.Enabled = true;
                }

                string[] spInfo = conString.Split('=', ';');

                tbServerAddress.Text = spInfo[1];
                cbCatalog.SelectedIndex = cbCatalog.FindString(spInfo[3]);
                tbUserName.Text = spInfo[5];
                tbPassword.Text = spInfo[7];
            }
            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (tbServerAddress.Text != "" && cbCatalog.Text != "")
            {
                string conString;

                if (tbServerAddress.Text.Trim() == "127.0.0.1" || tbServerAddress.Text.Trim() == "." || tbServerAddress.Text.Trim().ToUpper() == "LOCALHOST")
                {
                    conString = string.Format(CONNSTRING, tbServerAddress.Text, cbCatalog.Text, null, null, true);
                }
                else
                {
                    conString = string.Format(CONNSTRING, tbServerAddress.Text, cbCatalog.Text, tbUserName.Text, tbPassword.Text, false);
                }

                Connection con = new Connection();

                string conResult = con.testConnection(conString);

                if (conResult == "OK")
                {
                    MessageBox.Show(null, "数据库连接成功", "提示", MessageBoxButtons.OK);
                    con.initConnection(conString);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(null, conResult, "提示", MessageBoxButtons.OK);
                    con.initConnection("");
                }
            }
            else
            {
                MessageBox.Show(null, "请完善连接设置", "提示", MessageBoxButtons.OK);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();

            if (tbServerAddress.Text != "")
            {
                string conString;

                if (tbServerAddress.Text.Trim() == "127.0.0.1" || tbServerAddress.Text.Trim() == "." || tbServerAddress.Text.Trim().ToUpper() == "LOCALHOST")
                {
                    conString = string.Format(CONNSTRING, tbServerAddress.Text, "master", null, null, true);
                }
                else
                {
                    conString = string.Format(CONNSTRING, tbServerAddress.Text, "master", tbUserName.Text, tbPassword.Text, false);
                }

                string conResult = con.testConnection(conString);

                if (conResult == "OK")
                {
                    MessageBox.Show(null, "服务器设置正确，请选择数据库", "提示", MessageBoxButtons.OK);

                    DataSet ds = con.ExecuteSQLQuery(ConstSQLs.queryCatalogs, conString);

                    cbCatalog.DataSource = ds.Tables[0];
                    cbCatalog.DisplayMember = "Name";
                    cbCatalog.ValueMember = "Name";

                    cbCatalog.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    cbCatalog.AutoCompleteSource = AutoCompleteSource.ListItems;

                    cbCatalog.Enabled = true;

                    cbCatalog.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show(null, conResult, "提示", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show(null, "请完善连接设置", "提示", MessageBoxButtons.OK);
            }
        }

    }
}
