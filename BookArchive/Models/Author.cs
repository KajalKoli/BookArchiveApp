using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookArchive.Models
{
    public class Author
    {
        public int Id { get; set; }
        public String name { get; set; }
        public string email { get; set; }
        public Int64 phone { get; set; }
    }
}