using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Entities
{
    public  class Book
    {
        [Key]
        public int ISBN { set; get; }
        public string Title { set; get; }
        public string Description { set; get; }
        public decimal Price { set; get; }
        public string Specializtion { set; get; }
    }
}
