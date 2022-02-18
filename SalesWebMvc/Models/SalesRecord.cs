using System;
using System.ComponentModel.DataAnnotations;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }

        [DisplayFormat( DataFormatString = "{0:dd/MM/yyyy}" )]
        public DateTime Date { get; set; }

        [DisplayFormat( DataFormatString = "{0:F2}" )]
        public double Amount { get; set; }
        public SaleStatus Stats { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord( )
        {
        }

        public SalesRecord( int id, DateTime date, double amount, SaleStatus stats, Seller seller )
        {
            Id = id;
            Date = date;
            Amount = amount;
            Stats = stats;
            Seller = seller;
        }
    }
}
