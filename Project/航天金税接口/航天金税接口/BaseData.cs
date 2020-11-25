using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 航天金税接口
{
    public partial class BaseData : Form
    {
        public BaseData()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Click(object sender, EventArgs e)
        {
            ConfigHelper.SetValue("fhr", this.fhr.Text);
            ConfigHelper.SetValue("kpr", this.txtkpr.Text);
            ConfigHelper.SetValue("skr", this.skr.Text);
            ConfigHelper.SetValue("spbm", this.tyspbm.Text);
            ConfigHelper.SetValue("spmc", this.tyspmc.Text);
            ConfigHelper.SetValue("ggxh", this.ggxh.Text);
            ConfigHelper.SetValue("dw", this.dw.Text);
            ConfigHelper.SetValue("slv", this.slv.Text);
            ConfigHelper.SetValue("exportPath_zhizhi", this.textBox1.Text);
            ConfigHelper.SetValue("exportPath_dianzi", this.txtdianzifapiao.Text);

            ConfigHelper.SetValue("xfmc", this.xfmc.Text);
            ConfigHelper.SetValue("xfnssbh", this.xfnssbh.Text);
            ConfigHelper.SetValue("xfyhzh", this.xfyhzh.Text);
            ConfigHelper.SetValue("xfdzdh", this.xfdzdh.Text);
            this.Dispose();
        }

        private void BaseData_Load(object sender, EventArgs e)
        {
            //读取配置项
            NameValueCollection collection = ConfigurationManager.AppSettings;
            this.fhr.Text = collection["fhr"];
            this.skr.Text = collection["skr"];
            this.tyspbm.Text = collection["spbm"];
            this.tyspmc.Text = collection["spmc"];
            this.ggxh.Text = collection["ggxh"];
            this.dw.Text = collection["dw"];
            this.slv.Text = collection["slv"];
            this.textBox1.Text = collection["exportPath_zhizhi"];
            this.txtdianzifapiao.Text= collection["exportPath_dianzi"];
            this.txtkpr.Text = collection["kpr"];

            this.xfmc.Text= collection["xfmc"];
            this.xfnssbh.Text = collection["xfnssbh"];
            this.xfyhzh.Text = collection["xfyhzh"];
            this.xfdzdh.Text = collection["xfdzdh"];
        }

        /// <summary>
        /// 选择路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text = dialog.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtdianzifapiao.Text = dialog.SelectedPath;
            }
        }
    }
}
