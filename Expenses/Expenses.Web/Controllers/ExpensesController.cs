using Expenses.DataLayer.Repository;
using Expenses.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Expenses.Web.Controllers
{
    public class ExpensesController : Controller
    {
        private readonly IExpencesRepository _expencesRepository;
        public ExpensesController(IExpencesRepository expencesRepository)
        {
            _expencesRepository = expencesRepository;
        }
        public IActionResult Index(string searching)
        {
            List<ExpenseModel> lists = new List<ExpenseModel>();
            if(string.IsNullOrEmpty(searching))
            {
                lists = _expencesRepository.GetAllExpenses().ToList();
            }
            else
            {
                lists = _expencesRepository.Search(searching).ToList();
            }
            return View(lists);
        }

        [HttpGet]
        public IActionResult ExpenseData(int id)
        {
            ExpenseModel expenseModel = new ExpenseModel();
            if(id > 0)
            {
                expenseModel = _expencesRepository.GetExpenseByID(id);
            }
            return PartialView("_AddEditForm",expenseModel);
        }
        [HttpPost]
        public IActionResult ExpenseData(ExpenseModel model)
        {
            if (model.ID > 0)
            {
                _expencesRepository.Update(model);
            }
            else 
            {
                _expencesRepository.Add(model);
            }
            return View("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create([Bind(include: "ID,Title,MoneySpent,ExpenseDay,Category")]ExpenseModel model)
        {
            if(ModelState.IsValid)
            {
                model.ExpenseDay = DateTime.Now;
                _expencesRepository.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
             
            ExpenseModel model = _expencesRepository.GetExpenseByID(id);
            if (model == null)
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            else
                return View(model);
             
        }
        [HttpPost]
        public ActionResult Edit(int id, ExpenseModel model)
        {
            try
            {
               if(ModelState.IsValid)
                {
                    _expencesRepository.Update(model);
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Details(int id)
        {
            var item = _expencesRepository.GetExpenseByID(id);
            if (item == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            else
                return View(item);
        }
    }

    internal class HttpStatusCodeResult : ActionResult
    {
        private object badRequest;

        public HttpStatusCodeResult(object badRequest)
        {
            this.badRequest = badRequest;
        }
    }
}
