using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models.Enums;

namespace SalesWebMVC.Models
{
    public class SalesRecord
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int iD, DateTime date, double Amount, SaleStatus Status, Seller seller)
        {
            ID = iD;
            Date = date;
            this.Amount = Amount;
            this.Status = Status;
            Seller = seller;
        }
    }
}
