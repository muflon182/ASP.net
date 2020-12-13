using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewBrandingStyle.Web.Entities
{
    public class ItemEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsVisible { get; set; }
    }
}