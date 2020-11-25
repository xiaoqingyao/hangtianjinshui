namespace 航天金税接口
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.plContent = new System.Windows.Forms.Panel();
            this.plGv = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.plTop = new System.Windows.Forms.Panel();
            this.gpExport = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.基础设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入EXCEL文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出XML文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.购方名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.购方税号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.购方银行账号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.购方地址电话 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.计量单位 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.规格型号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.含税金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.税率 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.复核人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.收款人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.开票人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.发票类别 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.销方名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.销方地址电话 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.销方银行账号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.销方纳税识别号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.产品编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.含税单价 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plContent.SuspendLayout();
            this.plGv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.plTop.SuspendLayout();
            this.gpExport.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // plContent
            // 
            this.plContent.Controls.Add(this.plGv);
            this.plContent.Controls.Add(this.plTop);
            this.plContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plContent.Location = new System.Drawing.Point(0, 0);
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(1052, 479);
            this.plContent.TabIndex = 0;
            // 
            // plGv
            // 
            this.plGv.Controls.Add(this.dataGridView1);
            this.plGv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plGv.Location = new System.Drawing.Point(0, 135);
            this.plGv.Name = "plGv";
            this.plGv.Size = new System.Drawing.Size(1052, 344);
            this.plGv.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.购方名称,
            this.购方税号,
            this.购方银行账号,
            this.购方地址电话,
            this.商品编码,
            this.商品名称,
            this.计量单位,
            this.规格型号,
            this.含税金额,
            this.税率,
            this.复核人,
            this.收款人,
            this.开票人,
            this.发票类别,
            this.备注,
            this.销方名称,
            this.销方地址电话,
            this.销方银行账号,
            this.销方纳税识别号,
            this.产品编码,
            this.数量,
            this.含税单价});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1052, 344);
            this.dataGridView1.TabIndex = 0;
            // 
            // plTop
            // 
            this.plTop.Controls.Add(this.gpExport);
            this.plTop.Controls.Add(this.groupBox1);
            this.plTop.Controls.Add(this.menuStrip1);
            this.plTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTop.Location = new System.Drawing.Point(0, 0);
            this.plTop.Name = "plTop";
            this.plTop.Size = new System.Drawing.Size(1052, 135);
            this.plTop.TabIndex = 0;
            // 
            // gpExport
            // 
            this.gpExport.Controls.Add(this.label1);
            this.gpExport.Controls.Add(this.button2);
            this.gpExport.Location = new System.Drawing.Point(3, 76);
            this.gpExport.Name = "gpExport";
            this.gpExport.Size = new System.Drawing.Size(1052, 49);
            this.gpExport.TabIndex = 5;
            this.gpExport.TabStop = false;
            this.gpExport.Text = "导出XML文件";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(113, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "确认下方表格无误后，单击“导出XML”按钮保存XML，然后直接将XML文件导入航天金税接口即可。";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "导出XML文件";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(3, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1052, 49);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "导入Excel";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(113, 25);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(149, 12);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "第一次使用？下载导入模板";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_2);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "选择Excel文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基础设置ToolStripMenuItem,
            this.导入EXCEL文件ToolStripMenuItem,
            this.导出XML文件ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1052, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 基础设置ToolStripMenuItem
            // 
            this.基础设置ToolStripMenuItem.Name = "基础设置ToolStripMenuItem";
            this.基础设置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.基础设置ToolStripMenuItem.Text = "基础设置";
            this.基础设置ToolStripMenuItem.Click += new System.EventHandler(this.基础设置ToolStripMenuItem_Click);
            // 
            // 导入EXCEL文件ToolStripMenuItem
            // 
            this.导入EXCEL文件ToolStripMenuItem.Name = "导入EXCEL文件ToolStripMenuItem";
            this.导入EXCEL文件ToolStripMenuItem.Size = new System.Drawing.Size(104, 21);
            this.导入EXCEL文件ToolStripMenuItem.Text = "导入EXCEL文件";
            this.导入EXCEL文件ToolStripMenuItem.Click += new System.EventHandler(this.导入EXCEL文件ToolStripMenuItem_Click);
            // 
            // 导出XML文件ToolStripMenuItem
            // 
            this.导出XML文件ToolStripMenuItem.Name = "导出XML文件ToolStripMenuItem";
            this.导出XML文件ToolStripMenuItem.Size = new System.Drawing.Size(94, 21);
            this.导出XML文件ToolStripMenuItem.Text = "导出XML文件";
            this.导出XML文件ToolStripMenuItem.Click += new System.EventHandler(this.导出XML文件ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // 购方名称
            // 
            this.购方名称.DataPropertyName = "购方名称";
            this.购方名称.HeaderText = "购方名称";
            this.购方名称.Name = "购方名称";
            // 
            // 购方税号
            // 
            this.购方税号.DataPropertyName = "购方税号";
            this.购方税号.HeaderText = "购方税号";
            this.购方税号.Name = "购方税号";
            // 
            // 购方银行账号
            // 
            this.购方银行账号.DataPropertyName = "购方银行账号";
            this.购方银行账号.HeaderText = "购方银行账号";
            this.购方银行账号.Name = "购方银行账号";
            // 
            // 购方地址电话
            // 
            this.购方地址电话.DataPropertyName = "购方地址电话";
            this.购方地址电话.HeaderText = "购方地址电话";
            this.购方地址电话.Name = "购方地址电话";
            // 
            // 商品编码
            // 
            this.商品编码.DataPropertyName = "商品编码";
            this.商品编码.HeaderText = "商品编码";
            this.商品编码.Name = "商品编码";
            // 
            // 商品名称
            // 
            this.商品名称.DataPropertyName = "商品名称";
            this.商品名称.HeaderText = "商品名称";
            this.商品名称.Name = "商品名称";
            // 
            // 计量单位
            // 
            this.计量单位.DataPropertyName = "计量单位";
            this.计量单位.HeaderText = "计量单位";
            this.计量单位.Name = "计量单位";
            // 
            // 规格型号
            // 
            this.规格型号.DataPropertyName = "规格型号";
            this.规格型号.HeaderText = "规格型号";
            this.规格型号.Name = "规格型号";
            // 
            // 含税金额
            // 
            this.含税金额.DataPropertyName = "含税金额";
            this.含税金额.HeaderText = "含税金额";
            this.含税金额.Name = "含税金额";
            this.含税金额.ReadOnly = true;
            // 
            // 税率
            // 
            this.税率.DataPropertyName = "税率";
            this.税率.HeaderText = "税率";
            this.税率.Name = "税率";
            this.税率.ReadOnly = true;
            // 
            // 复核人
            // 
            this.复核人.DataPropertyName = "复核人";
            this.复核人.HeaderText = "复核人";
            this.复核人.Name = "复核人";
            // 
            // 收款人
            // 
            this.收款人.DataPropertyName = "收款人";
            this.收款人.HeaderText = "收款人";
            this.收款人.Name = "收款人";
            // 
            // 开票人
            // 
            this.开票人.DataPropertyName = "开票人";
            this.开票人.HeaderText = "开票人";
            this.开票人.Name = "开票人";
            // 
            // 发票类别
            // 
            this.发票类别.DataPropertyName = "发票类别";
            this.发票类别.HeaderText = "发票类别";
            this.发票类别.Name = "发票类别";
            // 
            // 备注
            // 
            this.备注.DataPropertyName = "备注";
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            // 
            // 销方名称
            // 
            this.销方名称.DataPropertyName = "销方名称";
            this.销方名称.HeaderText = "销方名称";
            this.销方名称.Name = "销方名称";
            // 
            // 销方地址电话
            // 
            this.销方地址电话.DataPropertyName = "销方地址电话";
            this.销方地址电话.HeaderText = "销方地址电话";
            this.销方地址电话.Name = "销方地址电话";
            // 
            // 销方银行账号
            // 
            this.销方银行账号.DataPropertyName = "销方银行账号";
            this.销方银行账号.HeaderText = "销方银行账号";
            this.销方银行账号.Name = "销方银行账号";
            // 
            // 销方纳税识别号
            // 
            this.销方纳税识别号.DataPropertyName = "销方纳税识别号";
            this.销方纳税识别号.HeaderText = "销方纳税识别号";
            this.销方纳税识别号.Name = "销方纳税识别号";
            // 
            // 产品编码
            // 
            this.产品编码.DataPropertyName = "产品编码";
            this.产品编码.HeaderText = "产品编码";
            this.产品编码.Name = "产品编码";
            // 
            // 数量
            // 
            this.数量.DataPropertyName = "数量";
            this.数量.HeaderText = "数量";
            this.数量.Name = "数量";
            // 
            // 含税单价
            // 
            this.含税单价.DataPropertyName = "含税单价";
            this.含税单价.HeaderText = "含税单价";
            this.含税单价.Name = "含税单价";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 479);
            this.Controls.Add(this.plContent);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "航天金税接口";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.plContent.ResumeLayout(false);
            this.plGv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.plTop.ResumeLayout(false);
            this.plTop.PerformLayout();
            this.gpExport.ResumeLayout(false);
            this.gpExport.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plContent;
        private System.Windows.Forms.Panel plTop;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 基础设置ToolStripMenuItem;
        private System.Windows.Forms.Panel plGv;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gpExport;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 导入EXCEL文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出XML文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn 购方名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 购方税号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 购方银行账号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 购方地址电话;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 计量单位;
        private System.Windows.Forms.DataGridViewTextBoxColumn 规格型号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 含税金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 税率;
        private System.Windows.Forms.DataGridViewTextBoxColumn 复核人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 收款人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 开票人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 发票类别;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
        private System.Windows.Forms.DataGridViewTextBoxColumn 销方名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 销方地址电话;
        private System.Windows.Forms.DataGridViewTextBoxColumn 销方银行账号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 销方纳税识别号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 产品编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数量;
        private System.Windows.Forms.DataGridViewTextBoxColumn 含税单价;
    }
}

