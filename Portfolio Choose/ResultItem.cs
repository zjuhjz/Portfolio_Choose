using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portfolio_Choose
{
    class ResultItem
    {
        public string product_id { get; set; }
        public string product_name { get; set; }
        public double amount;
        public double rate;
        public double l_benifit;
        public double h_benifit;
        public string fluidity;
        public string risk;

        public ResultItem(string product_id, string product_name, double amount, double rate, string l_benifit, string h_benifit, string risk, string fluidity)
        {
            this.product_id = product_id;
            this.product_name = product_name;
            this.amount = amount;
            this.rate = rate;
            this.l_benifit = Convert.ToDouble(l_benifit);
            this.h_benifit = Convert.ToDouble(h_benifit);
            this.fluidity = fluidity;
            this.risk = risk;
        }
        public ResultItem()
        {
            this.product_id = null;
            this.product_name = null;
            this.amount = 0;
            this.rate = 0;
        }

    }
}
