namespace CleanupApproval
{
    partial class SQLSetForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbServerAddress = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbCatalog = new System.Windows.Forms.Label();
            this.pSQLSet = new System.Windows.Forms.Panel();
            this.btnTest = new System.Windows.Forms.Button();
            this.cbCatalog = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbServerAddress = new System.Windows.Forms.TextBox();
            this.pSQLSet.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbServerAddress
            // 
            this.lbServerAddress.AutoSize = true;
            this.lbServerAddress.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbServerAddress.Location = new System.Drawing.Point(23, 37);
            this.lbServerAddress.Name = "lbServerAddress";
            this.lbServerAddress.Size = new System.Drawing.Size(65, 12);
            this.lbServerAddress.TabIndex = 0;
            this.lbServerAddress.Text = "数据库地址";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbUserName.Location = new System.Drawing.Point(23, 77);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(41, 12);
            this.lbUserName.TabIndex = 1;
            this.lbUserName.Text = "用户名";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbPassword.Location = new System.Drawing.Point(23, 115);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(29, 12);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "密码";
            // 
            // lbCatalog
            // 
            this.lbCatalog.AutoSize = true;
            this.lbCatalog.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCatalog.Location = new System.Drawing.Point(23, 153);
            this.lbCatalog.Name = "lbCatalog";
            this.lbCatalog.Size = new System.Drawing.Size(65, 12);
            this.lbCatalog.TabIndex = 3;
            this.lbCatalog.Text = "数据库名称";
            // 
            // pSQLSet
            // 
            this.pSQLSet.Controls.Add(this.btnTest);
            this.pSQLSet.Controls.Add(this.cbCatalog);
            this.pSQLSet.Controls.Add(this.btnConnect);
            this.pSQLSet.Controls.Add(this.tbUserName);
            this.pSQLSet.Controls.Add(this.tbPassword);
            this.pSQLSet.Controls.Add(this.tbServerAddress);
            this.pSQLSet.Controls.Add(this.lbServerAddress);
            this.pSQLSet.Controls.Add(this.lbCatalog);
            this.pSQLSet.Controls.Add(this.lbUserName);
            this.pSQLSet.Controls.Add(this.lbPassword);
            this.pSQLSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSQLSet.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pSQLSet.Location = new System.Drawing.Point(0, 0);
            this.pSQLSet.Name = "pSQLSet";
            this.pSQLSet.Size = new System.Drawing.Size(259, 225);
            this.pSQLSet.TabIndex = 0;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(25, 180);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 7;
            this.btnTest.Text = "测试登录";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // cbCatalog
            // 
            this.cbCatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCatalog.FormattingEnabled = true;
            this.cbCatalog.Location = new System.Drawing.Point(103, 145);
            this.cbCatalog.Name = "cbCatalog";
            this.cbCatalog.Size = new System.Drawing.Size(132, 20);
            this.cbCatalog.TabIndex = 8;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(162, 180);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(105, 68);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(132, 21);
            this.tbUserName.TabIndex = 5;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(105, 106);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(130, 21);
            this.tbPassword.TabIndex = 6;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbServerAddress
            // 
            this.tbServerAddress.Location = new System.Drawing.Point(105, 28);
            this.tbServerAddress.Name = "tbServerAddress";
            this.tbServerAddress.Size = new System.Drawing.Size(130, 21);
            this.tbServerAddress.TabIndex = 4;
            // 
            // SQLSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 225);
            this.Controls.Add(this.pSQLSet);
            this.Name = "SQLSetForm";
            this.Text = "数据库连接设置";
            this.pSQLSet.ResumeLayout(false);
            this.pSQLSet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbServerAddress;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbCatalog;
        private System.Windows.Forms.Panel pSQLSet;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbServerAddress;
        private System.Windows.Forms.ComboBox cbCatalog;
        private System.Windows.Forms.Button btnTest;
    }
}

