using System;
using System.ComponentModel.DataAnnotations;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus Stats { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        { 
        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus stats, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Stats = stats;
            Seller = seller;
        }
    }
}
