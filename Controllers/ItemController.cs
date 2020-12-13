using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewBrandingStyle.Web.Models;

namespace NewBrandingStyle.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : ControllerBase
    {
        public AddNewItemResponseModel Post(ItemModel item)
        {
            bool _succes = !string.IsNullOrEmpty(item.Description) && !string.IsNullOrEmpty(item.Name);
            string _message = _succes ? "" : "Fields cannot be empty!";

            var response = new AddNewItemResponseModel
            {
                succes = _succes,
                message = _succes ? "" : _message
            };

            return response;
        }
    }
}