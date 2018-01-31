using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookstore.Models
{
    public class Review : IEntity
    {
        public string Comment { get; set; }
        public virtual Book Book { get; set; }
    }
}