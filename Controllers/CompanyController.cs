using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Web.Models;

namespace WebApplication.Web.Controllers
{
    public class CompanyController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Index(CompanyModel company)
        {
            var viewModel = new CompanyAddedViewModel

            {
                NumberOfCharsInName = company.Name.Length,
                NumberOfCharsInDescription = company.Description.Length,
                IsHidden = !company.IsVisible
            };
            return View("CompanyAdded", viewModel);
        }

    }
}
