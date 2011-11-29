using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portfolio_Choose
{
    public class DataGridItem
    {
        public bool firstPriority { get; set; }
        //public bool 选择 { get; set; }
        public string 产品名称 { get; set; }
        public string product_id;
        public string 占比 { get; set; }
        public string 金额 { get; set; }
        public string 风险 { get; set; }
        public string 流动性 { get; set; }
        public string 年化收益率 { get; set; }
        public string 预期年化收益 { get; set; }
        public string 占总收益 { get; set; }
        public string 投资标的;// { get; set; }
        public string 管理人;// { get; set; }
        public string fluidity;
        //= false ;
        bool firstItem = false;
        public bool isStat = false;

        public int group;
        public double h_benifit;
        public double l_benifit;


        public DataGridItem(string a1, string a2, string a3, double l_benifit, double h_benifit, string risk, string fluidity) //product ID 占比 金额
        {
            product_id = a1;
            占比 = a2;
            金额 = a3;
            this.l_benifit = l_benifit;
            this.h_benifit = h_benifit;
            this.风险 = risk;
            this.流动性 = fluidity;
        }

        public DataGridItem(string a1, string a2, string a3, string a4, string a5, string a6)
        {
            产品名称=a1;
            占比=a2;
            金额=a3;
            年化收益率 = a4;
            预期年化收益=a5;
            占总收益=a6;
        }
        public DataGridItem(bool isStat)
        {
            this.isStat = isStat;
        }

        public bool isFirstPriority()
        {
            return firstPriority;
        }
        public void setIsFirstPriority(bool a)
        {
            this.firstPriority = a;
        }
        public bool isFirstItem()
        {
            return firstItem;
        }
        public void setIsFirstItem(bool a)
        {
            this.firstItem = a;
        }
        
    }
}
