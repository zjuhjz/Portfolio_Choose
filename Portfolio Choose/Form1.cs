using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Portfolio_Choose
{
    public partial class Form1 : Form
    {
        SqlConnection objConnection;
        List<DemandItem> demandItemList;
        bool demandBoxSelectChanging =false;
        public Form1()
        {
            demandItemList = new List<DemandItem>();
            demandItemList.Add(new DemandItem());

            InitializeComponent();
             
            string strConnection = "user id=portfolio;password=portfolio;";
            strConnection += "initial catalog=portfolio;Server=10.39.1.99;";
            strConnection += "Connect Timeout=30";
            objConnection = new SqlConnection(strConnection);
            objConnection.Open();  //建立连接



            amountTextBox.Text = "0";
            
            demandListBox.Items.Add("");
            
            refreshAll();
            //demandListBox.Items[0] = "111";
            demandListBox.SelectedItem = demandListBox.Items[0];

            //初始化比例、金额。
            ratioText.Text = (5 * (20 - vScrollBar1.Value)).ToString();
            devidedAmountTextBox.Text = (Convert.ToInt32(amountTextBox.Text) * 5 * (20 - vScrollBar1.Value) / 100).ToString();
            demandItemList[demandListBox.SelectedIndex].setRatio(5 * (20 - vScrollBar1.Value));
        }



        //更新需求列表demandItemList中的参数
        //更新用户界面中需求列表的描述
        private void refreshAll()
        {
            string temp = getCurrentDesctription();
            if (demandListBox.SelectedIndex < 0)
            {
                return;
            }
            demandItemList.ElementAt(demandListBox.SelectedIndex).setFluidity(fluidityCheckBox1.Checked, fluidityCheckBox2.Checked, fluidityCheckBox3.Checked);
            demandItemList.ElementAt(demandListBox.SelectedIndex).setRisk(riskCheckBox1.Checked, riskCheckBox2.Checked, riskCheckBox3.Checked, riskCheckBox4.Checked);
            demandListBox.Items[demandListBox.SelectedIndex] = getCurrentDesctription();
            /*if (ratioText.Focused)
            {
                vScrollBar1.Value = 20 - Convert.ToInt32(ratioText.Text) / 5;
            }*/
            demandItemList.ElementAt(demandListBox.SelectedIndex).setRatio(Convert.ToInt32(ratioText.Text));

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
        //根据用户的选项，生成对应的描述语句，以供显示到界面的需求列表中
        private string getCurrentDesctription()
        {
            string description = string.Empty;
            description = Convert.ToString((riskCheckBox1.Checked ? "高," : ""))
                + Convert.ToString((riskCheckBox2.Checked ? "中," : ""))
                + Convert.ToString((riskCheckBox3.Checked ? "低," : ""))
                + Convert.ToString((riskCheckBox4.Checked ? "无," : ""));
            if (description.Length > 1)
            {
                description = description.Substring(0, description.Length - 1) + "风险  ";
            }

            description = description + Convert.ToString((fluidityCheckBox1.Checked ? "高," : ""))
                + Convert.ToString((fluidityCheckBox2.Checked ? "中," : ""))
                + Convert.ToString((fluidityCheckBox3.Checked ? "低," : ""));
            if (description.Length > 1)
            {
                description = description.Substring(0, description.Length - 1) + "流动性  ";
            }

            description += ratioText.Text + "%比例";

            return description;
        }


        //根据用户需求生成产品配置，返回 List<ResultItem>
        private List<ResultItem> getResult(DemandItem demandItem,SqlCommand sqlCommand)
        {
            SqlDataReader sqlDataReader;
            List<ResultItem> resultList = new List<ResultItem>();
            string sqlstr = "select * from dbo.product_info t where 1=1";
            sqlstr += " and t.buttom_amount <=" + Convert.ToString(Convert.ToInt32(amountTextBox.Text)*demandItem.getRatio()/100 * 10000);

            sqlstr += " and product_risk in ( 999," + Convert.ToString((demandItem.getRisk(0) ? 10 : 999)) + " , "
                + Convert.ToString((demandItem.getRisk(1) ? 5 : 999)) + " , "
                + Convert.ToString((demandItem.getRisk(2) ? 1 : 999)) + " , "
                + Convert.ToString((demandItem.getRisk(3) ? 0 : 999))
                + " )";

            //TO-DO   流动性的sql拼接需要修改
            sqlstr += " and fluidity in ( 999, " + Convert.ToString((demandItem.getFluidity(0) ? 1 : 999)) + " , "
                + Convert.ToString((demandItem.getFluidity(1) ? 7 : 999)) + " , "
                + Convert.ToString((demandItem.getFluidity(2) ? 720 : 999))
                 + " ) ";
            sqlstr += " order by l_benifit desc";
            Console.WriteLine(sqlstr);
            sqlCommand.CommandText = sqlstr;
            sqlDataReader = sqlCommand.ExecuteReader();
            //封装
            while (sqlDataReader.Read())
            {
                resultList.Add(new ResultItem(sqlDataReader["product_id"].ToString(),
                    sqlDataReader["product_name"].ToString(),
                    Convert.ToInt32(amountTextBox.Text) * demandItem.getRatio() / 100 * 10000,
                    demandItem.getRatio(), sqlDataReader["l_benifit"].ToString(), 
                    sqlDataReader["h_benifit"].ToString(),
                    Convert.ToInt32(sqlDataReader["product_risk"].ToString()) > 5 ? "高" : (Convert.ToInt32(sqlDataReader["product_risk"].ToString()) > 1?"中":(Convert.ToInt32(sqlDataReader["product_risk"].ToString()) > 0?"低":"无")),
                    Convert.ToInt32(sqlDataReader["fluidity"].ToString()) > 14 ? "弱" : (Convert.ToInt32(sqlDataReader["fluidity"].ToString()) > 3 ? "较好" : "很好")
                    ));
                //Console.WriteLine(sqlDataReader["product_name"]);
            }
            sqlDataReader.Close();
            //Console.WriteLine(resultList.Count);
            return resultList;
        }

        //根据后台数据设置界面上风险、流动性的勾选状态
        private void setCheckItem(DemandItem demandItem)
        {
            riskCheckBox1.Checked = demandItem.getRisk(0);
            riskCheckBox2.Checked = demandItem.getRisk(1);
            riskCheckBox3.Checked = demandItem.getRisk(2);
            riskCheckBox4.Checked = demandItem.getRisk(3);

            fluidityCheckBox1.Checked = demandItem.getFluidity(0);
            fluidityCheckBox2.Checked = demandItem.getFluidity(1);
            fluidityCheckBox3.Checked = demandItem.getFluidity(2);
        }


        public void button1_Click(object sender, EventArgs e)
        {
            SqlCommand myComm = new SqlCommand();
            myComm.Connection = objConnection;
            myComm.CommandText = "select * from dbo.product_info";
            List<ResultItem> tempResult;  //查询结果
           ;   //单个demandItem对应的结果展示集
            //List<List<DataGridItem>> gridItemList = new List<List<DataGridItem>>();  //所有的结果展示集
            string resultText = string.Empty;
            BindingList<DataGridItem> gridItemRowList = new BindingList<DataGridItem>();
            Form2 form2=null;
            int group = 0;


            foreach (DemandItem i in demandItemList)     //查询结果获取，将product_id等关键信息复制进gridItemRowList，以便后续获取详细信息
            {
                tempResult = getResult(i, myComm);
                //gridItemRowList = new BindingList<DataGridItem>();

                if (tempResult.Count!=0)                    
                {
                    int k = 0;
                    foreach (ResultItem j in tempResult)
                    {
                        gridItemRowList.Add(new DataGridItem(j.product_id, j.rate.ToString()+"%", j.amount.ToString(),j.l_benifit,j.h_benifit,j.risk,j.fluidity));
                        if (k == 0) //如果是首选结果，要进行相应的后台数据设定
                        {
                            gridItemRowList[gridItemRowList.Count - 1].setIsFirstPriority(true); //可变（用户可以后续通过操作改变）
                            gridItemRowList[gridItemRowList.Count - 1].setIsFirstItem(true);//不变
                        }
                        gridItemRowList[gridItemRowList.Count - 1].group = group;
                        ++k;
                    }

                }
                group++;
            }

            string sqlStr;
            SqlDataReader sqlDataReader;
            foreach (DataGridItem i in gridItemRowList)         //通过gridItemRowList中product_id进行详细信息的获取补全
            {
                if (i.product_id != null)
                {
                    sqlStr = "select * from product_detail where product_id = " + i.product_id ;
                    
                    myComm.CommandText = sqlStr;
                    sqlDataReader = myComm.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        i.产品名称=sqlDataReader["product_name"].ToString().Trim();
                        i.年化收益率 = sqlDataReader["benifit"].ToString().Trim();
                        i.预期年化收益 = (Convert.ToInt32(i.金额) * (i.h_benifit + i.l_benifit) / 2/100).ToString();
                        i.投资标的 = sqlDataReader["invest_object"].ToString().Trim();
                        i.管理人 = sqlDataReader["manager"].ToString().Trim();
                        i.fluidity = sqlDataReader["fluidity"].ToString().Trim();
                    }
                    sqlDataReader.Close();

                }
            }
            //插入统计行,统计步骤放入form2.cs
            gridItemRowList.Add(new DataGridItem(true));
            gridItemRowList[gridItemRowList.Count - 1].产品名称 = "总计";
            gridItemRowList[gridItemRowList.Count - 1].占比 = "100%";
            gridItemRowList[gridItemRowList.Count - 1].isStat = true;
            gridItemRowList[gridItemRowList.Count - 1].group = -1;  //统计行的组别为-1

            //生成form2窗口
            if (form2 == null || form2.IsDisposed)
             {
                 form2 = new Form2(gridItemRowList);
             }

            //this.IsMdiContainer = true;
            //form2.MdiParent = this; //建立父子关系

            
            
            form2.Show(); //显示子窗口
            
            form2.Focus(); //子窗口获得焦点

            form2.setDataGridView(); //触发form2数据显示
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            refreshAll();
            int ratio = 0;
            ratio = (5 * (20 - vScrollBar1.Value));
            //demandItemList[demandListBox.SelectedIndex].setRatio(5 * (20 - vScrollBar1.Value));
            ratioText.Text = ratio.ToString();
            devidedAmountTextBox.Text = (Convert.ToInt32(amountTextBox.Text) * ratio / 100).ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            refreshAll();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (demandListBox.SelectedIndex < 0) return;
            demandBoxSelectChanging = true;  //关闭check元件的触发

            riskCheckBox1.Checked = demandItemList[demandListBox.SelectedIndex].getRisk(0);
            riskCheckBox2.Checked = demandItemList[demandListBox.SelectedIndex].getRisk(1);
            riskCheckBox3.Checked = demandItemList[demandListBox.SelectedIndex].getRisk(2);
            riskCheckBox4.Checked = demandItemList[demandListBox.SelectedIndex].getRisk(3);
            
            fluidityCheckBox1.Checked = demandItemList[demandListBox.SelectedIndex].getFluidity(0);
            fluidityCheckBox2.Checked = demandItemList[demandListBox.SelectedIndex].getFluidity(1);
            fluidityCheckBox3.Checked = demandItemList[demandListBox.SelectedIndex].getFluidity(2);

            ratioText.Text = demandItemList[demandListBox.SelectedIndex].getRatio().ToString();

            demandBoxSelectChanging = false;
            //refreshAll();

        }

        private void riskCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (demandBoxSelectChanging) return;
            demandBoxSelectChanging = true;
            riskCheckBox2.Checked = false;
            riskCheckBox3.Checked = false;
            riskCheckBox4.Checked = false;
            refreshAll();
            demandBoxSelectChanging = false;
            //refreshAll();
        }

        private void riskCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (demandBoxSelectChanging) return;
            demandBoxSelectChanging = true;
            riskCheckBox1.Checked = false;
            riskCheckBox3.Checked = false;
            riskCheckBox4.Checked = false;
            refreshAll();
            demandBoxSelectChanging = false;
            //Console.WriteLine(riskCheckBox1);
        }

        private void riskCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (demandBoxSelectChanging) return;
            demandBoxSelectChanging = true;
            riskCheckBox1.Checked = false;
            riskCheckBox2.Checked = false;
            riskCheckBox4.Checked = false;
            refreshAll();
            demandBoxSelectChanging = false;
        }

        private void riskCheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (demandBoxSelectChanging) return;
            demandBoxSelectChanging = true;
            riskCheckBox2.Checked = false;
            riskCheckBox3.Checked = false;
            riskCheckBox1.Checked = false;
            refreshAll();
            demandBoxSelectChanging = false;
        }

        private void fluidityCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (demandBoxSelectChanging) return;
            demandBoxSelectChanging = true;
            fluidityCheckBox2.Checked = false;
            fluidityCheckBox3.Checked = false;
            refreshAll();
            demandBoxSelectChanging = false;
        }

        private void fluidityCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (demandBoxSelectChanging) return;
            demandBoxSelectChanging = true;
            fluidityCheckBox1.Checked = false;
            fluidityCheckBox3.Checked = false;
            refreshAll();
            demandBoxSelectChanging = false;
            //Console.WriteLine(sender);
        }

        private void fluidityCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (demandBoxSelectChanging) return;
            demandBoxSelectChanging = true;
            fluidityCheckBox1.Checked = false;
            fluidityCheckBox2.Checked = false;
            refreshAll();
            demandBoxSelectChanging = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {
            int ratio = 0;
            int totalRatio = 0;
            ratio = (5 * (20 - vScrollBar1.Value));
            demandItemList[demandListBox.SelectedIndex].setRatio(5 * (20 - vScrollBar1.Value));
            //检查是否总的占比超过100
            foreach(DemandItem i in demandItemList)
            {
                totalRatio += i.getRatio();
            }
            if (totalRatio > 100)
            {
                ratio = ratio - (totalRatio - 100);
                demandItemList[demandListBox.SelectedIndex].setRatio(ratio);
            }
                        
            //比例界面显示
            ratioText.Text = ratio.ToString();
            devidedAmountTextBox.Text = (Convert.ToInt32(amountTextBox.Text) * ratio / 100).ToString();
        }

        private void ratioText_TextChanged(object sender, EventArgs e)   //比例
        {
            refreshAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            demandItemList.Add(new DemandItem());
            demandListBox.Items.Add(demandListBox.Items.Count);
            demandListBox.SelectedItem = demandListBox.Items[demandListBox.Items.Count-1];
            //demandItemList = new List<DemandItem>();
            
            //Console.WriteLine(demandItemList.Count);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (demandItemList.Count<=1) return;
            int currentIndex = demandListBox.SelectedIndex;
            demandItemList.RemoveAt(demandListBox.SelectedIndex);
            demandListBox.Items.RemoveAt(currentIndex);
            if (currentIndex + 1 <= demandItemList.Count)
                demandListBox.SelectedItem = demandListBox.Items[currentIndex];
            else
                demandListBox.SelectedItem = demandListBox.Items[currentIndex - 1];
            ratioText.Text = "0";

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void devidedAmountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        
    }
}
