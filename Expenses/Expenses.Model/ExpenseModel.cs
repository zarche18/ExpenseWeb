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
        [RegularExpression(@"^\d+$", ErrorMessage = "Please enter only numeric values.")]
        [Required]
        public decimal MoneySpent { get; set; }
        [Required]
        [DisplayFormat(ApplyFormatInEditMode =true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ExpenseDay { get; set; }
        [Required]
        public string Category { get; set; }
    }
}
