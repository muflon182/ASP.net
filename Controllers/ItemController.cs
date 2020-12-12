using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Web.Models;

namespace WebApplication.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : ControllerBase
    {
        public AddNewItemResponseModel Post(ItemModel item)
        {
            bool userRes = !string.IsNullOrEmpty(item.Description) && !string.IsNullOrEmpty(item.Name);

            var res = new AddNewItemResponseModel
            {
                success = userRes,
                message = userRes ? "" : "Input fields cannot be empty"
            };
            return res;
        }
    }
}

