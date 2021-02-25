using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookArchive.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookArchive.Models
{
    public class Book
    {
        //Author author = new Author();
        [Key]
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