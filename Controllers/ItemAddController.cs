using System;
using Microsoft.AspNetCore.Mvc;
using NewBrandingStyle.Web.Models;
using NewBrandingStyle.Web.Filters;
using NewBrandingStyle.Web.Databases;
using NewBrandingStyle.Web.Entities;
using System.Threading.Tasks;

namespace NewBrandingStyle.Web.Controllers
{
    public class ExchangesController : Controller
    {
        private readonly ExchangesDbContext _dbContext;

        public ExchangesController(ExchangesDbContext dBContext)
        {
            _dbContext = dBContext;
        }

        [ServiceFilter(typeof(MyCustomFilter))]
        public IActionResult Show(string id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(ItemModel item)
        {
            var entity = new ItemEntity
            {
                Name = item.Name,
                Description = item.Description,
                IsVisible = item.IsVisible,
            };

            _dbContext.Items.Add(entity);
            _dbContext.SaveChanges();

            return RedirectToAction("AddConfirmation");
        }

        [HttpGet]
        public IActionResult AddConfirmation()
        {
            ViewBag.Items = _dbContext.Items;
            return View();
        }
    }
}