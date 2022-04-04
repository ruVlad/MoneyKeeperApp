﻿
namespace MoneyKeeper.Data.DB.Tables
{
    public class Transaction
    {
        public int Id { get; set; }
        public decimal Sum { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
        public bool IsDeleted { get; set; }
        public int CategoryId { get; set; }
        public int AccountId { get; set; }
    }
}
