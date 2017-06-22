using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using National_Technology.Models;

namespace National_Technology.Controllers
{
    public class BookController : Controller
    {
        private List<Book> Librarys_Books;
        // GET: Book
        public ActionResult Index()
        {
            if (Librarys_Books == null)
            {
                Librarys_Books = new List<Book>(Generate_Books());
            }
            return View(Librarys_Books);
        }
        protected ActionResult Button1_Click(object sender, EventArgs e)
        {
            //Do somthing
            Librarys_Books = new List<Book>();
            return View(Librarys_Books);
        }

        public List<Book> Generate_Books()
        {
            List<Book> books_in_Library = new List<Book>();
            books_in_Library.Add(new Book
            {
                ID = 1,
                Author = "J. K. Rowling",
                Title = "Harry Potter and the Philosopher's Stone",
                Price = 100,
                Reserved = 0
            });

            books_in_Library.Add(new Book
            {
                ID = 2,
                Author = "J. K. Rowling",
                Title = "Harry Potter and the Chamber of Secrets",
                Price = 100,
                Reserved = 0
            });

            books_in_Library.Add(new Book
            {
                ID = 3,
                Author = "J. K. Rowling",
                Title = "HHarry Potter and the Prisoner of Azkaban",
                Price = 100,
                Reserved = 0
            });

            books_in_Library.Add(new Book
            {
                ID = 4,
                Author = "J. K. Rowling",
                Title = "Harry Potter and the Goblet of Fire",
                Price = 100,
                Reserved = 0
            });

            books_in_Library.Add(new Book
            {
                ID = 5,
                Author = "J. K. Rowling",
                Title = "Harry Potter and the Order of the Phoenix",
                Price = 100,
                Reserved = 0
            });

            books_in_Library.Add(new Book
            {
                ID = 6,
                Author = "J. K. Rowling",
                Title = "Harry Potter and the Half-Blood Prince",
                Price = 100,
                Reserved = 0
            });

            books_in_Library.Add(new Book
            {
                ID = 7,
                Author = "J. K. Rowling",
                Title = "Harry Potter and the Deathly Hallows",
                Price = 100,
                Reserved = 0
            });

            books_in_Library.Add(new Book
            {
                ID = 8,
                Author = "J. K. Rowling",
                Title = "Fantastic Beasts and Where to Find Them",
                Price = 100,
                Reserved = 0
            });
            return books_in_Library;
        }
    }
}
