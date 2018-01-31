using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookstore.Models
{
    public class Category : IEntity
    {
        public string Name { get; set; }
    }
}