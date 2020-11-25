using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace 航天金税接口
{
    public partial class Form1 : Form
    {
        public bool exportSuccess = false;
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            this.dataGridView1.AutoGenerateColumns = false;
        }



        private void 基础设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BaseData().ShowDialog();
        }



        private void button1_Click_2(object sender, EventArgs e)
        {
            string filepath = "";
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Multiselect = false;
                fileDialog.Title = "请选择要导入的Excel模板";
                fileDialog.Filter = "office2003|*.xls|office2007|*.xlsx";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    filepath = fileDialog.FileName;
                }
            }
            if (!string.IsNullOrEmpty(filepath))
            {
                DataTable data = NPOIHelper.ImportExcel(filepath, true);
                if (data == null || data.Rows.Count == 0)
                {
                    MessageBox.Show("对不起，导入过程失败，请检查导入的excel模板是否是最新、是否标准、是否有额外注释");
                    return;
                }

                data.Columns.Add("计量单位");
                data.Columns.Add("规格型号");
                data.Columns.Add("税率");
                data.Columns.Add("复核人");
                data.Columns.Add("收款人");

                data.Columns.Add("开票人");
                data.Columns.Add("销方名称");
                data.Columns.Add("销方纳税识别号");
                data.Columns.Add("销方地址电话");
                data.Columns.Add("销方银行账号");


                NameValueCollection collection = ConfigurationManager.AppSettings;
                for (int i = data.Rows.Count - 1; i >= 0; i--)
                {
                    //data.Rows[i]["商品编码"] = collection["spbm"];
                    //data.Rows[i]["商品名称"] = collection["spmc"];
                    data.Rows[i]["计量单位"] = collection["dw"];
                    data.Rows[i]["规格型号"] = collection["ggxh"];
                    data.Rows[i]["税率"] = collection["slv"];
                    data.Rows[i]["复核人"] = collection["fhr"];
                    data.Rows[i]["收款人"] = collection["skr"];

                    data.Rows[i]["开票人"] = collection["kpr"];
                    data.Rows[i]["销方名称"] = collection["xfmc"];
                    data.Rows[i]["销方纳税识别号"] = collection["xfnssbh"];
                    data.Rows[i]["销方地址电话"] = collection["xfdzdh"];
                    data.Rows[i]["销方银行账号"] = collection["xfyhzh"];
                    if (string.IsNullOrEmpty(data.Rows[i]["购方名称"].ToString().Trim()))
                    {
                        data.Rows.RemoveAt(i);
                    }
                }
                this.dataGridView1.DataSource = data;
            }
        }

        private void linkLabel1_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(System.Windows.Forms.Application.StartupPath + "/发票导入模板.xls");
        }

        private void 导入EXCEL文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click_2(sender, e);
        }

        private void 导出XML文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }
        /// <summary>
        /// 导出xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //导出地址
            string exportPath = "";
            string exportPath_zhizhi = ConfigurationManager.AppSettings["exportPath_zhizhi"];
            string exportPath_dianzi = ConfigurationManager.AppSettings["exportPath_dianzi"];

            if (string.IsNullOrEmpty(exportPath_dianzi) || string.IsNullOrEmpty(exportPath_dianzi))
            {
                MessageBox.Show("请先到“基础设置”功能区设置与金税软件导入目录对应的发票文件导出目录");
                return;
            }
            int zsl = dataGridView1.Rows.Count;//单据数量
            if (zsl == 0)
            {
                MessageBox.Show("请先通过EXCEL导入数据");
                return;
            }
            DataGridViewRowCollection dgvrc = dataGridView1.Rows;
            Action<DataGridViewRowCollection> action = (rows) =>
            {
                if (rows == null || rows.Count == 0)
                {
                    return;
                }
                button2.Enabled = false;
                //错误信息
                string errMsg = "";
                //生成随机单据号
                string djh = DateTime.Now.ToString("yyyyMMddHHmmss") + new Random().Next(111, 999);
                for (int i = 0; i < zsl; i++)
                {
                    Thread.Sleep(1000);
                    //只有目录下没有文件的时候才会生成新的文件，保证顺序一致
                    while (Directory.GetFiles(exportPath_zhizhi).Length != 0 || Directory.GetFiles(exportPath_dianzi).Length != 0)
                    {
                        continue;
                    }
                    DataGridViewRow row = rows[i];
                    string gfmc = row.Cells["购方名称"].Value.ToString();
                    string gfsh = row.Cells["购方税号"].Value.ToString();
                    string gfyhzh = row.Cells["购方银行账号"].Value.ToString();
                    string gfdzdh = row.Cells["购方地址电话"].Value.ToString();
                    string xfmc = row.Cells["销方名称"].Value.ToString();
                    string xfsh = row.Cells["销方纳税识别号"].Value.ToString();
                    string xfyhzh = row.Cells["销方银行账号"].Value.ToString();
                    string xfdzdh = row.Cells["销方地址电话"].Value.ToString();
                    string spbm = row.Cells["商品编码"].Value.ToString();
                    string spmc = row.Cells["商品名称"].Value.ToString();
                    string jldw = row.Cells["计量单位"].Value.ToString();
                    string ggxh = row.Cells["规格型号"].Value.ToString();
                    string hsje = row.Cells["含税金额"].Value.ToString();
                    string slv = row.Cells["税率"].Value.ToString();
                    string bz = row.Cells["备注"].Value.ToString();
                    string kpr = row.Cells["开票人"].Value.ToString();
                    string fhr = row.Cells["复核人"].Value.ToString();
                    string skr = row.Cells["收款人"].Value.ToString();
                    string fplb = row.Cells["发票类别"].Value.ToString();
                    string sl = row.Cells["数量"].Value.ToString();
                    string dj = row.Cells["含税单价"].Value.ToString();


                    #region 计算无税金额单价
                    decimal wsje = 0;//无税金额
                    decimal wsdj = 0;//无税单价
                    try
                    {
                        wsje = decimal.Parse(hsje) / (1 + decimal.Parse(slv));
                        wsdj = wsje / decimal.Parse(sl);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("计算无税金额过程中出错，行数" + i + 1 + "详细信息：" + ex.Message);
                    }
                    #endregion
                    decimal se = (decimal.Parse(hsje) - wsje);//税额
                    StringBuilder sbXML = new StringBuilder("<?xml version=\"1.0\" encoding=\"GBK\" ?>");
                    if (fplb.Equals("电子发票"))
                    {
                        exportPath = exportPath_dianzi;

                        #region 电子发票V1.0
                        //sbXML.Append("<business id=\"FPKJ\" comment=\"发票开具\">");
                        //sbXML.Append("<REQUEST_COMMON_FPKJ class=\"REQUEST_COMMON_FPKJ\">");
                        //sbXML.Append("<COMMON_FPKJ_FPT class=\"COMMON_FPKJ_FPT\">");
                        //sbXML.Append("<FPQQLSH>" + djh + "</FPQQLSH>");
                        //sbXML.Append("<KPLX>0</KPLX>");
                        //sbXML.Append("<BMB_BBH>1</BMB_BBH>");
                        //sbXML.Append("<XSF_NSRSBH>" + xfsh + "</XSF_NSRSBH>");
                        //sbXML.Append("<XSF_MC>" + xfmc + "</XSF_MC>");
                        //sbXML.Append("<XSF_DZDH>" + xfdzdh + "</XSF_DZDH>");
                        //sbXML.Append("<XSF_YHZH>" + xfyhzh + "</XSF_YHZH>");
                        //sbXML.Append("<GMF_NSRSBH>" + gfsh + "</GMF_NSRSBH>");
                        //sbXML.Append("<GMF_MC>" + gfmc + "</GMF_MC>");
                        //sbXML.Append("<GMF_DZDH>" + gfdzdh + "</GMF_DZDH>");
                        //sbXML.Append("<GMF_YHZH>" + gfyhzh + "</GMF_YHZH>");
                        //sbXML.Append("<KPR>" + kpr + "</KPR>");
                        //sbXML.Append("<SKR>" + skr + "</SKR>");
                        //sbXML.Append("<FHR>" + fhr + "</FHR>");
                        //sbXML.Append("<YFP_DM/>");//原发票代码  红字发票需要
                        //sbXML.Append("<YFP_HM/>");//原发票号码
                        //sbXML.Append("<JSHJ>" + hsje + "</JSHJ>");
                        //sbXML.Append("<HJJE>" + wsje + "</HJJE>");
                        //sbXML.Append("<HJSE>" + (decimal.Parse(hsje) - wsje) + "</HJSE>");
                        //sbXML.Append("<BZ>" + bz + "</BZ>");
                        //sbXML.Append("</COMMON_FPKJ_FPT>");
                        //sbXML.Append("<COMMON_FPKJ_XMXXS class=\"COMMON_FPKJ_XMXX\" size=\"1\">");
                        //sbXML.Append("<COMMON_FPKJ_XMXX>");
                        //sbXML.Append("<FPHXZ>0</FPHXZ>");//0 正常行、1折扣行、2被折扣行
                        //sbXML.Append("<XMMC>" + spmc + "</XMMC>");
                        //sbXML.Append("<SPBM>" + spbm + "</SPBM>");
                        //sbXML.Append("<ZXBM></ZXBM>");
                        //sbXML.Append("<YHZCBS/>");//优惠政策标识
                        //sbXML.Append("<LSLBS/>");//税率标识
                        //sbXML.Append("<ZZSTSGL/>");//增值税特殊管理
                        //sbXML.Append("<GGXH>" + ggxh + "</GGXH>");
                        //sbXML.Append("<DW>" + jldw + "</DW>");
                        //sbXML.Append("<XMSL/>");//数量
                        //sbXML.Append("<XMDJ/>");//单价
                        //sbXML.Append("<XMJE>" + wsje + "</XMJE> ");
                        //sbXML.Append("<SL>" + slv + "</SL>");
                        //sbXML.Append("<SE>" + se + "</SE>");

                        //sbXML.Append("</COMMON_FPKJ_XMXX>");
                        //sbXML.Append("</COMMON_FPKJ_XMXXS>");
                        //sbXML.Append("</REQUEST_COMMON_FPKJ>");
                        //sbXML.Append("</business>");
                        #endregion

                        #region 电子发票V1.1
                        sbXML.Append("<business>");
                        sbXML.Append("<REQUEST_COMMON_FPKJ>");
                        sbXML.Append("<COMMON_FPKJ_FPT>");
                        sbXML.Append("<FPQQLSH>" + djh + "</FPQQLSH>");
                        sbXML.Append("<KPLX>0</KPLX>");
                        sbXML.Append("<BMB_BBH>1</BMB_BBH>");
                        sbXML.Append("<XSF_NSRSBH>" + xfsh + "</XSF_NSRSBH>");
                        sbXML.Append("<XSF_MC>" + xfmc + "</XSF_MC>");
                        sbXML.Append("<XSF_DZDH>" + xfdzdh + "</XSF_DZDH>");
                        sbXML.Append("<XSF_YHZH>" + xfyhzh + "</XSF_YHZH>");
                        sbXML.Append("<GMF_NSRSBH>" + gfsh + "</GMF_NSRSBH>");
                        sbXML.Append("<GMF_MC>" + gfmc + "</GMF_MC>");
                        sbXML.Append("<GMF_DZDH>" + gfdzdh + "</GMF_DZDH>");
                        sbXML.Append("<GMF_YHZH>" + gfyhzh + "</GMF_YHZH>");
                        sbXML.Append("<KPR>" + kpr + "</KPR>");
                        sbXML.Append("<SKR>" + skr + "</SKR>");
                        sbXML.Append("<FHR>" + fhr + "</FHR>");
                        sbXML.Append("<YFP_DM/>");//原发票代码  红字发票需要
                        sbXML.Append("<YFP_HM/>");//原发票号码
                        sbXML.Append("<JSHJ>" + hsje + "</JSHJ>");
                        sbXML.Append("<HJJE>" + wsje + "</HJJE>");
                        sbXML.Append("<HJSE>" + (decimal.Parse(hsje) - wsje) + "</HJSE>");
                        sbXML.Append("<BZ>" + bz + "</BZ>");
                        sbXML.Append("<HSBZLX/>");
                        sbXML.Append("<HSBZ/>");
                        sbXML.Append("<INVOICELINE>");
                        sbXML.Append("</INVOICELINE>");
                        sbXML.Append("</COMMON_FPKJ_FPT>");

                        sbXML.Append("<COMMON_FPKJ_XMXXS>");
                        sbXML.Append("<COMMON_FPKJ_XMXX>");
                        sbXML.Append("<FPHXZ>0</FPHXZ>");//0 正常行、1折扣行、2被折扣行
                        sbXML.Append("<XMMC>" + spmc + "</XMMC>");
                        sbXML.Append("<GGXH>" + ggxh + "</GGXH>");
                        sbXML.Append("<DW>" + jldw + "</DW>");
                        sbXML.Append("<XMSL>" + sl + "</XMSL>");//数量
                        sbXML.Append("<XMDJ>" + wsdj + "</XMDJ>");//单价
                        sbXML.Append("<XMDJHS>" + dj + "</XMDJHS>");//含税单价 nono
                        sbXML.Append("<XMJE>" + wsje + "</XMJE>");
                        sbXML.Append("<SL>" + slv + "</SL>");
                        sbXML.Append("<SE>" + se + "</SE>");

                        sbXML.Append("<SPBM>" + spbm + "</SPBM>");
                        sbXML.Append("<ZXBM></ZXBM>");
                        sbXML.Append("<YHZCBS/>");//优惠政策标识
                        sbXML.Append("<ZZSTSGL/>");//增值税特殊管理
                        sbXML.Append("<LSLBS/>");//税率标识

                        sbXML.Append("<KCE>0</KCE>");



                        sbXML.Append("</COMMON_FPKJ_XMXX>");
                        sbXML.Append("</COMMON_FPKJ_XMXXS>");
                        sbXML.Append("</REQUEST_COMMON_FPKJ>");
                        sbXML.Append("</business>");
                        #endregion

                        #region 电子发票V2.0
                        //sbXML.Append("<Kp>");
                        //sbXML.Append("<Version>2.0</Version>");
                        //sbXML.Append("<Fpxx>");
                        //sbXML.Append("<Zsl>1</Zsl>");//此文件含有的单据信息数量
                        //sbXML.Append("<Fpsj>");
                        //sbXML.Append("<Fp>");
                        //sbXML.AppendFormat("<Djh>{0}</Djh>", djh);                    //单据号（20字节）
                        //sbXML.AppendFormat("<Gfmc>{0}</Gfmc>",gfmc);            //购方名称（100字节）
                        //sbXML.AppendFormat("<Gfsh>{0}</Gfsh>",gfsh);  //购方税号
                        //sbXML.AppendFormat("<Gfyhzh>{0}</Gfyhzh>",gfyhzh);   //购方银行账号（100字节）
                        //sbXML.AppendFormat("<Gfdzdh>{0}</Gfdzdh>",gfdzdh);   //购方地址电话（100字节）
                        //sbXML.AppendFormat("<Bz>{0}</Bz>",bz);                      //备注（240字节）
                        //sbXML.AppendFormat("<Fhr>{0}</Fhr>",fhr);                   //复核人（8字节）
                        //sbXML.AppendFormat("<Skr>{0}</Skr>",skr);                   //收款人（8字节）
                        //sbXML.AppendFormat("<Spbmbbh>{0}</Spbmbbh>", "商品编码版本号");  //商品编码版本号(20字节)（必输项）
                        //sbXML.AppendFormat("<Hsbz>{0}</Hsbz>",1);	//含税标志 0：不含税税率，1：含税税率，2：差额
                        //sbXML.Append("<Spxx>");
                        //sbXML.Append("<Sph>");
                        //sbXML.Append("<Xh>1</Xh>"); 		         //序号
                        //sbXML.AppendFormat("<Spmc>{0}</Spmc>",spmc);   //商品名称，金额为负数时此行是折扣行，折扣行的商品名称应与上一行的商品名称一致（100字节）
                        //sbXML.AppendFormat("<Ggxh>{0}</Ggxh>",ggxh);   //规格型号（40字节）
                        //sbXML.AppendFormat("<Jldw>{0}</Jldw>",jldw);   //计量单位（32字节）
                        //sbXML.AppendFormat("<Spbm>{0}</Spbm>",spbm);   //商品编码(19字节)（必输项）
                        //sbXML.AppendFormat("<Qyspbm>{0}</Qyspbm>", "企业商品编码"); //企业商品编码（20字节）
                        //sbXML.Append("<Syyhzcbz></Syyhzcbz>"); //是否使用优惠政策标识0：不使用，1：使用（1字节）
                        //sbXML.Append("<Lslbz></Lslbz>");   //零税率标识   空：非零税率，0：出口退税，1：免税，2：不征收，3普通零税率（1字节）
                        //sbXML.AppendFormat("<Yhzcsm></Yhzcsm>");   //优惠政策说明（50字节）
                        //sbXML.Append("<Dj></Dj>"); 	        //单价（中外合作油气田（原海洋石油）5%税率，单价为含税单价）
                        //sbXML.Append("<Sl></Sl>"); 		    //数量
                        //sbXML.AppendFormat("<Je>{0}</Je>",wsje); 		//金额，当金额为负数时为折扣行
                        //sbXML.AppendFormat("<Slv>{0}</Slv>",slv); 		//税率
                        //sbXML.AppendFormat("<Se>{0}</Se>",se); 		//税额
                        //sbXML.AppendFormat("<Kce></Kce>");      //扣除额，用于差额税计算
                        //sbXML.Append("</Sph>");
                        //sbXML.Append("</Spxx>");
                        //sbXML.Append("</Fp>");
                        //sbXML.Append("</Fpsj>");
                        //sbXML.Append("</Fpxx>");
                        //sbXML.Append("</Kp>");
                        #endregion
                    }
                    else if (fplb.Equals("纸质发票"))
                    {
                        exportPath = exportPath_zhizhi;
                        #region 纸质发票

                        sbXML.Append("<Kp>");
                        sbXML.Append("<Version>2.0</Version>");//有此节点，则表示用带分类编码
                        sbXML.Append("<Fpxx>");
                        sbXML.Append("<Zsl>" + 1 + "</Zsl>");
                        sbXML.Append("<Fpsj>");

                        sbXML.Append("<Fp>");
                        sbXML.Append("<Djh>" + djh + "</Djh>");//单据号（20字节）
                        sbXML.Append("<Gfmc>" + gfmc + "</Gfmc>");//购方名称100字节
                        sbXML.Append("<Gfsh>" + gfsh + "</Gfsh>");//购方税号
                        sbXML.Append("<Gfyhzh>" + gfyhzh + "</Gfyhzh>");//购方银行账号
                        sbXML.Append("<Gfdzdh>" + gfdzdh + "</Gfdzdh>");//购方地址电话
                        sbXML.Append("<Bz>" + bz + "</Bz>");//备注
                        sbXML.Append("<Fhr>" + fhr + "</Fhr>");
                        sbXML.Append("<Skr>" + skr + "</Skr>");
                        sbXML.Append("<Spbmbbh>1</Spbmbbh>");//商品编码版本号
                        sbXML.Append("<Hsbz>0</Hsbz>");//含税标志 0：不含税税率，1：含税税率，2：差额税;中外合作油气田（原海洋石油）5%税率、1.5%税率为1，差额税为2，其他为0

                        sbXML.Append("<Spxx>");
                        sbXML.Append("<Sph>");

                        sbXML.Append("<Xh>1</Xh>");
                        sbXML.Append("<Spmc>" + spmc + "</Spmc>");//商品名称，金额为负数时此行是折扣行，折扣行的商品名称应与上一行的商品名称一致（100字节）
                        sbXML.Append("<Ggxh>" + ggxh + "</Ggxh>");
                        sbXML.Append("<Jldw>" + jldw + "</Jldw>");
                        sbXML.Append("<Spbm>" + spbm + "</Spbm>");
                        sbXML.Append("<Qyspbm/>");//企业商品编码20
                        sbXML.Append("<Syyhzcbz/>");//是否使用优惠政策标识 0不使用 1使用
                        sbXML.Append("<Lslbz/>");//零税率标识 空：非零税率，0：出口退税，1：免税，2：不征收，3普通零税率（1字节）
                        sbXML.Append("<Yhzcsm/>");//优惠政策说明 50字节
                        sbXML.Append("<Dj/>");//单价
                        sbXML.Append("<Sl/>");//数量
                        sbXML.Append("<Je>" + wsje + "</Je>");//金额，当金额为负数时为折扣行
                        sbXML.Append("<Slv>" + slv + "</Slv>");//税率
                        sbXML.Append("<Kce/>");
                        sbXML.Append("</Sph>");
                        sbXML.Append("</Spxx>");
                        sbXML.Append("</Fp>");
                        sbXML.Append("</Fpsj>");
                        sbXML.Append("</Fpxx>");
                        sbXML.Append("</Kp>");
                        #endregion
                    }
                    else
                    {
                        errMsg += "第" + i + 1 + "行发票类别不正确，只有‘电子发票’和‘纸质发票’两种可以选择，其他已经导入成功，请把对应行记录重新导入一遍。";
                    }
                    File.AppendAllText(exportPath + "/" + DateTime.Now.ToString("yyy-MM-dd-HH-mm-ss") + i + ".xml", sbXML.ToString(), Encoding.Default);
                }
                if (!string.IsNullOrEmpty(errMsg))
                {
                    MessageBox.Show(errMsg);
                }
            };
            //回调函数
            AsyncCallback call = delegate (IAsyncResult rel)
            {
                this.dataGridView1.DataSource = new DataTable();
            };
            IAsyncResult asyncRel = action.BeginInvoke(dgvrc, call, null);
            //等待异步执行结束
            action.EndInvoke(asyncRel);
            if (asyncRel.IsCompleted)
            {
                MessageBox.Show("XML文件成功导出！");
                button2.Enabled = true;
            }
        }
        private bool hasFile(string path)
        {
            string[] arrFiles = Directory.GetFiles(path);
            return arrFiles.Length > 0;
        }
        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Help().ShowDialog();
        }
    }
}
