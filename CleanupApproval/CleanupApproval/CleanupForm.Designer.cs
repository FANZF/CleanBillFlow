namespace CleanupApproval
{
    partial class CleanupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pSet = new System.Windows.Forms.Panel();
            this.btnSQL = new System.Windows.Forms.Button();
            this.cbMK = new System.Windows.Forms.ComboBox();
            this.cbOrg = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSQLSet = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.lbOrgID = new System.Windows.Forms.Label();
            this.lbMKMC = new System.Windows.Forms.Label();
            this.tbDJBH = new System.Windows.Forms.TextBox();
            this.lbDJBH = new System.Windows.Forms.Label();
            this.pView = new System.Windows.Forms.Panel();
            this.dgvDJList = new System.Windows.Forms.DataGridView();
            this.SFXZ = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DJID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DJBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MKMC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BZJG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BZR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BZRQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DJZT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JZBZ = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.JSBZ = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pJZXX = new System.Windows.Forms.Panel();
            this.dgvJZXX = new System.Windows.Forms.DataGridView();
            this.JZDJBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DJLX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JZBZJG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JZBZRQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BZRMC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pSet.SuspendLayout();
            this.pView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDJList)).BeginInit();
            this.pJZXX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJZXX)).BeginInit();
            this.SuspendLayout();
            // 
            // pSet
            // 
            this.pSet.Controls.Add(this.btnSQL);
            this.pSet.Controls.Add(this.cbMK);
            this.pSet.Controls.Add(this.cbOrg);
            this.pSet.Controls.Add(this.btnSearch);
            this.pSet.Controls.Add(this.btnSQLSet);
            this.pSet.Controls.Add(this.btnExecute);
            this.pSet.Controls.Add(this.lbOrgID);
            this.pSet.Controls.Add(this.lbMKMC);
            this.pSet.Controls.Add(this.tbDJBH);
            this.pSet.Controls.Add(this.lbDJBH);
            this.pSet.Location = new System.Drawing.Point(0, 0);
            this.pSet.Name = "pSet";
            this.pSet.Size = new System.Drawing.Size(262, 430);
            this.pSet.TabIndex = 0;
            // 
            // btnSQL
            // 
            this.btnSQL.Location = new System.Drawing.Point(64, 152);
            this.btnSQL.Name = "btnSQL";
            this.btnSQL.Size = new System.Drawing.Size(56, 42);
            this.btnSQL.TabIndex = 7;
            this.btnSQL.Text = "生成清理SQL";
            this.btnSQL.UseVisualStyleBackColor = true;
            this.btnSQL.Click += new System.EventHandler(this.btnSQL_Click);
            // 
            // cbMK
            // 
            this.cbMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMK.FormattingEnabled = true;
            this.cbMK.Location = new System.Drawing.Point(83, 39);
            this.cbMK.Name = "cbMK";
            this.cbMK.Size = new System.Drawing.Size(168, 20);
            this.cbMK.TabIndex = 4;
            // 
            // cbOrg
            // 
            this.cbOrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbOrg.FormattingEnabled = true;
            this.cbOrg.Location = new System.Drawing.Point(83, 72);
            this.cbOrg.Name = "cbOrg";
            this.cbOrg.Size = new System.Drawing.Size(168, 20);
            this.cbOrg.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(4, 152);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 42);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSQLSet
            // 
            this.btnSQLSet.Location = new System.Drawing.Point(184, 152);
            this.btnSQLSet.Name = "btnSQLSet";
            this.btnSQLSet.Size = new System.Drawing.Size(56, 42);
            this.btnSQLSet.TabIndex = 9;
            this.btnSQLSet.Text = "连接\r\n设置";
            this.btnSQLSet.UseVisualStyleBackColor = true;
            this.btnSQLSet.Click += new System.EventHandler(this.btnSQLSet_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(124, 152);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(56, 42);
            this.btnExecute.TabIndex = 8;
            this.btnExecute.Text = "清理\r\n审批";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // lbOrgID
            // 
            this.lbOrgID.AutoSize = true;
            this.lbOrgID.Location = new System.Drawing.Point(12, 80);
            this.lbOrgID.Name = "lbOrgID";
            this.lbOrgID.Size = new System.Drawing.Size(65, 12);
            this.lbOrgID.TabIndex = 2;
            this.lbOrgID.Text = "机构名称：";
            // 
            // lbMKMC
            // 
            this.lbMKMC.AutoSize = true;
            this.lbMKMC.Location = new System.Drawing.Point(12, 47);
            this.lbMKMC.Name = "lbMKMC";
            this.lbMKMC.Size = new System.Drawing.Size(65, 12);
            this.lbMKMC.TabIndex = 1;
            this.lbMKMC.Text = "模块名称：";
            // 
            // tbDJBH
            // 
            this.tbDJBH.Location = new System.Drawing.Point(83, 3);
            this.tbDJBH.Name = "tbDJBH";
            this.tbDJBH.Size = new System.Drawing.Size(168, 21);
            this.tbDJBH.TabIndex = 3;
            // 
            // lbDJBH
            // 
            this.lbDJBH.AutoSize = true;
            this.lbDJBH.Location = new System.Drawing.Point(12, 11);
            this.lbDJBH.Name = "lbDJBH";
            this.lbDJBH.Size = new System.Drawing.Size(65, 12);
            this.lbDJBH.TabIndex = 0;
            this.lbDJBH.Text = "单据编号：";
            // 
            // pView
            // 
            this.pView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pView.Controls.Add(this.dgvDJList);
            this.pView.Location = new System.Drawing.Point(268, 0);
            this.pView.Name = "pView";
            this.pView.Size = new System.Drawing.Size(749, 291);
            this.pView.TabIndex = 1;
            // 
            // dgvDJList
            // 
            this.dgvDJList.AllowUserToAddRows = false;
            this.dgvDJList.AllowUserToDeleteRows = false;
            this.dgvDJList.AllowUserToResizeRows = false;
            this.dgvDJList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDJList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDJList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SFXZ,
            this.DJID,
            this.DJBH,
            this.MKMC,
            this.BZJG,
            this.BZR,
            this.BZRQ,
            this.DJZT,
            this.JZBZ,
            this.JSBZ});
            this.dgvDJList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDJList.Location = new System.Drawing.Point(0, 0);
            this.dgvDJList.Name = "dgvDJList";
            this.dgvDJList.RowTemplate.Height = 23;
            this.dgvDJList.Size = new System.Drawing.Size(749, 291);
            this.dgvDJList.TabIndex = 2;
            this.dgvDJList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDJList_CellMouseClick);
            // 
            // SFXZ
            // 
            this.SFXZ.HeaderText = "选中";
            this.SFXZ.Name = "SFXZ";
            // 
            // DJID
            // 
            this.DJID.DataPropertyName = "DJID";
            this.DJID.HeaderText = "DJID";
            this.DJID.Name = "DJID";
            this.DJID.ReadOnly = true;
            this.DJID.Visible = false;
            // 
            // DJBH
            // 
            this.DJBH.DataPropertyName = "DJBH";
            this.DJBH.HeaderText = "单据编号";
            this.DJBH.Name = "DJBH";
            this.DJBH.ReadOnly = true;
            // 
            // MKMC
            // 
            this.MKMC.DataPropertyName = "MKMC";
            this.MKMC.HeaderText = "模块名称";
            this.MKMC.Name = "MKMC";
            this.MKMC.ReadOnly = true;
            // 
            // BZJG
            // 
            this.BZJG.DataPropertyName = "BZJG";
            this.BZJG.HeaderText = "编制机构";
            this.BZJG.Name = "BZJG";
            this.BZJG.ReadOnly = true;
            // 
            // BZR
            // 
            this.BZR.DataPropertyName = "BZR";
            this.BZR.HeaderText = "编制人";
            this.BZR.Name = "BZR";
            this.BZR.ReadOnly = true;
            // 
            // BZRQ
            // 
            this.BZRQ.DataPropertyName = "BZRQ";
            this.BZRQ.HeaderText = "编制日期";
            this.BZRQ.Name = "BZRQ";
            this.BZRQ.ReadOnly = true;
            // 
            // DJZT
            // 
            this.DJZT.DataPropertyName = "DJZT";
            this.DJZT.HeaderText = "单据状态";
            this.DJZT.Name = "DJZT";
            this.DJZT.ReadOnly = true;
            // 
            // JZBZ
            // 
            this.JZBZ.DataPropertyName = "JZBZ";
            this.JZBZ.HeaderText = "结转标志";
            this.JZBZ.Name = "JZBZ";
            this.JZBZ.ReadOnly = true;
            // 
            // JSBZ
            // 
            this.JSBZ.DataPropertyName = "JSBZ";
            this.JSBZ.HeaderText = "结算标志";
            this.JSBZ.Name = "JSBZ";
            this.JSBZ.ReadOnly = true;
            // 
            // pJZXX
            // 
            this.pJZXX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pJZXX.Controls.Add(this.dgvJZXX);
            this.pJZXX.Location = new System.Drawing.Point(268, 297);
            this.pJZXX.Name = "pJZXX";
            this.pJZXX.Size = new System.Drawing.Size(749, 133);
            this.pJZXX.TabIndex = 2;
            // 
            // dgvJZXX
            // 
            this.dgvJZXX.AllowUserToAddRows = false;
            this.dgvJZXX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJZXX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJZXX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JZDJBH,
            this.DJLX,
            this.JZBZJG,
            this.JZBZRQ,
            this.BZRMC});
            this.dgvJZXX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvJZXX.Location = new System.Drawing.Point(0, 0);
            this.dgvJZXX.Name = "dgvJZXX";
            this.dgvJZXX.RowTemplate.Height = 23;
            this.dgvJZXX.Size = new System.Drawing.Size(749, 133);
            this.dgvJZXX.TabIndex = 0;
            // 
            // JZDJBH
            // 
            this.JZDJBH.DataPropertyName = "DJBH";
            this.JZDJBH.HeaderText = "结转单据编号";
            this.JZDJBH.Name = "JZDJBH";
            this.JZDJBH.ReadOnly = true;
            // 
            // DJLX
            // 
            this.DJLX.DataPropertyName = "DJLX";
            this.DJLX.HeaderText = "单据类型";
            this.DJLX.Name = "DJLX";
            this.DJLX.ReadOnly = true;
            // 
            // JZBZJG
            // 
            this.JZBZJG.DataPropertyName = "BZJG";
            this.JZBZJG.HeaderText = "编制机构";
            this.JZBZJG.Name = "JZBZJG";
            this.JZBZJG.ReadOnly = true;
            // 
            // JZBZRQ
            // 
            this.JZBZRQ.DataPropertyName = "BZRQ";
            this.JZBZRQ.HeaderText = "编制日期";
            this.JZBZRQ.Name = "JZBZRQ";
            this.JZBZRQ.ReadOnly = true;
            // 
            // BZRMC
            // 
            this.BZRMC.DataPropertyName = "BZR";
            this.BZRMC.HeaderText = "编制人";
            this.BZRMC.Name = "BZRMC";
            this.BZRMC.ReadOnly = true;
            // 
            // CleanupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 430);
            this.Controls.Add(this.pJZXX);
            this.Controls.Add(this.pView);
            this.Controls.Add(this.pSet);
            this.Name = "CleanupForm";
            this.Text = "审批工具";
            this.pSet.ResumeLayout(false);
            this.pSet.PerformLayout();
            this.pView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDJList)).EndInit();
            this.pJZXX.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJZXX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pSet;
        private System.Windows.Forms.Panel pView;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label lbOrgID;
        private System.Windows.Forms.Label lbMKMC;
        private System.Windows.Forms.TextBox tbDJBH;
        private System.Windows.Forms.Label lbDJBH;
        private System.Windows.Forms.Button btnSQLSet;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvDJList;
        private System.Windows.Forms.ComboBox cbOrg;
        private System.Windows.Forms.ComboBox cbMK;
        private System.Windows.Forms.Button btnSQL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SFXZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn DJID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DJBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MKMC;
        private System.Windows.Forms.DataGridViewTextBoxColumn BZJG;
        private System.Windows.Forms.DataGridViewTextBoxColumn BZR;
        private System.Windows.Forms.DataGridViewTextBoxColumn BZRQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn DJZT;
        private System.Windows.Forms.DataGridViewCheckBoxColumn JZBZ;
        private System.Windows.Forms.DataGridViewCheckBoxColumn JSBZ;
        private System.Windows.Forms.Panel pJZXX;
        private System.Windows.Forms.DataGridView dgvJZXX;
        private System.Windows.Forms.DataGridViewTextBoxColumn JZDJBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DJLX;
        private System.Windows.Forms.DataGridViewTextBoxColumn JZBZJG;
        private System.Windows.Forms.DataGridViewTextBoxColumn JZBZRQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn BZRMC;
    }
}