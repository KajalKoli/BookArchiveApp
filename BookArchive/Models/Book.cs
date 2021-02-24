using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookArchive.Models;

namespace BookArchive.Models
{
    public class Book
    {
        //Author author = new Author();

        public string ISBN { get; set; }
        public string name { get; set; }
        public string authorId { get; set; }
        public HttpPostedFile frontCover { get; set; }
        public HttpPostedFile backCover { get; set; }
        public float price { get; set; }
        public int yearPublish { get; set; }
        public string edition { get; set; }
        public String Publisher { get; set; }
        public HttpPostedFile bookFile { get; set; }

    }
}