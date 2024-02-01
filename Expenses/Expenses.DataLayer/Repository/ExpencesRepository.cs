using Expenses.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Expenses.DataLayer.Repository
{
    public class ExpencesRepository : IExpencesRepository
    {
        private readonly ApplicationDbContext _context;
        public ExpencesRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(ExpenseModel expense)
        {
            try
            {
                _context.ExpenseModels.Add(expense);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public void Delete(int id)
        {
            var item = _context.ExpenseModels.Find(id);
            _context.Remove(item);
            _context.SaveChanges();
        }

        public IEnumerable<ExpenseModel> GetAllExpenses()
        {
            try
            {
                var expense = _context.ExpenseModels.ToList();
                return expense;
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public ExpenseModel GetExpenseByID(int id)
        {
             try
            {
                var expense = _context.ExpenseModels.Find(id);
                return expense;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public IEnumerable<ExpenseModel> Search(string searchstring)
        {
            try
            {
                var searchExpense = _context.ExpenseModels.Where(x=> x.Title.Contains(searchstring));
                return searchExpense;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int Update(ExpenseModel expense)
        {
            try
            {
                _context.Entry(expense).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
                return 1;
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
