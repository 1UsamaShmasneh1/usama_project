using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkProperties
{
    class Quotation
    {
        private string customerName;
        public string CustomerName { get; private set; }
        private double[] sumLines;
        public double[] SumLines { get; set; }
        private double docSum = 0;
        public double DocSum { get { 
                for(int i = 0; i < this.sumLines.Length; i++)
                {
                    this.docSum += this.sumLines[i];
                }
                return this.docSum;
            }; }
        private DateTime validUntil;
        public DateTime ValidUntil { get; private set; }
        public Quotation(string customerName, DateTime validUntil, int numOfLines)
        {
            this.customerName = customerName;
            this.validUntil = validUntil;
            this.sumLines = new double[numOfLines];
        }
        public void ChangeMainDetails(string costumerName, DateTime validUntil)
        {
            this.customerName = costumerName;
            this.validUntil = validUntil;
        }
    }
}
