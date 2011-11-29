using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Portfolio_Choose
{
    public partial class Form2 : Form
    {
        BindingList<DataGridItem> gridItemRowList;
        public Form2(BindingList<DataGridItem> gridItemRowList)
        {
            this.gridItemRowList = gridItemRowList;
            InitializeComponent();
            //this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellContentClick);
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void refreshItemList()
        {
            double total_benifit = 0;
            double total_amount = 0;
            foreach (DataGridItem i in gridItemRowList)
            {
                i.占总收益 = "";
            }
            foreach (DataGridItem i in gridItemRowList)
            {
                if (i.isFirstPriority())
                {
                    total_benifit += Convert.ToDouble(i.预期年化收益);
                    total_amount += Convert.ToDouble(i.金额);
                }
            }
            foreach (DataGridItem i in gridItemRowList)
            {
                if (i.isFirstPriority())
                {
                    i.占总收益 = (Convert.ToDouble(i.预期年化收益) / total_benifit*100).ToString("0.00")+"%";
                }
            }
            gridItemRowList.ElementAt(gridItemRowList.Count - 1).金额 = total_amount.ToString("0");
            gridItemRowList.ElementAt(gridItemRowList.Count - 1).预期年化收益 = total_benifit.ToString("0");
            gridItemRowList.ElementAt(gridItemRowList.Count - 1).年化收益率 = (total_benifit / total_amount*100).ToString("0.00")+"%";
        }

        public void setDataGridView()//BindingList<DataGridItem> gridItemRowList)
        {
            //dataGridView1[0, 0].Value = "1";
            //dataGridView1[1, 1].Value = "1";

            dataGridView1.DataSource = gridItemRowList;
            dataGridView1.DefaultCellStyle.Font = new Font("微软雅黑", 14, FontStyle.Italic);
            dataGridView1.DefaultCellStyle.ForeColor = Color.Gray;
            foreach (DataGridItem i in gridItemRowList)
            {
                if (i.isFirstPriority()||(i.isStat))
                {
                    int tempIndex = gridItemRowList.IndexOf(i);
                    dataGridView1.Rows[tempIndex].DefaultCellStyle.Font = new Font("微软雅黑", 14, FontStyle.Bold);
                    dataGridView1.Rows[tempIndex].DefaultCellStyle.ForeColor = Color.Black;
                    dataGridView1[1,tempIndex].Style.Font = new Font("微软雅黑", 14, FontStyle.Underline | FontStyle.Bold);
                    dataGridView1[1, tempIndex].Style.ForeColor = Color.Blue;
                }
            }
            dataGridView1.Columns[1].DefaultCellStyle.Font = new Font("微软雅黑", 14, FontStyle.Underline | FontStyle.Bold);
            dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Blue;
            dataGridView1.Columns[0].HeaderText = "选择";
            setIntroductionText(dataGridView1.CurrentCell.RowIndex);
            refreshItemList();
            
            
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void setIntroductionText(int index)
        {
            textBox1.Text = "产品名称：" + gridItemRowList[index].产品名称 + Environment.NewLine ;
            textBox1.Text += "流动性：" + gridItemRowList[index].fluidity + Environment.NewLine + Environment.NewLine;
            textBox1.Text = textBox1.Text + gridItemRowList[index].投资标的;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex <= 1 && dataGridView1.CurrentCell.RowIndex != dataGridView1.RowCount-1)
            {
                setIntroductionText(dataGridView1.CurrentCell.RowIndex);
            }
            if (dataGridView1.CurrentCell.ColumnIndex != 0) return;
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            int group = ((BindingList<DataGridItem>)dataGridView1.DataSource).ElementAt(rowIndex).group;
            foreach(DataGridItem i in (BindingList<DataGridItem>)dataGridView1.DataSource)
            {
                if (i.group == group)
                {
                    i.setIsFirstPriority(false);
                }
            }
            dataGridView1.EndEdit();
            refreshItemList();
            dataGridView1.Refresh();
            //gridItemRowList[index].product_id;
        }
        //private void 
    }
}
