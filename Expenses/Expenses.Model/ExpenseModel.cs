using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Expenses.Model
{
    public class ExpenseModel
    {
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public decimal MoneySpent { get; set; }
        [Required]
        public DateTime ExpenseDay { get; set; }
        [Required]
        public string Category { get; set; }
    }
}
