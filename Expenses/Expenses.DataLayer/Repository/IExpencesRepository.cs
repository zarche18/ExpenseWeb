using Expenses.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Expenses.DataLayer.Repository
{
    public interface IExpencesRepository
    {
        IEnumerable<ExpenseModel> GetAllExpenses();
        IEnumerable<ExpenseModel> Search(string searchstring);
        void Add(ExpenseModel expense);
        int Update(ExpenseModel expense);
        ExpenseModel GetExpenseByID(int id);
        void Delete(int id);
    }
}
