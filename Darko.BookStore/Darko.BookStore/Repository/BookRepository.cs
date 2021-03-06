﻿using Darko.BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Darko.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string author)
        {
            // return DataSource().Where(x => x.Title == title && x.Author == author).ToList();
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(author)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {

           new BookModel(){Id = 1, Title = "MVC", Author = "Darko" },
           new BookModel(){Id = 2, Title = "Java", Author = "John" },
           new BookModel(){Id = 3, Title = "C#", Author = "Kudvenkat" },
           new BookModel(){Id = 4, Title = "JavaScript", Author = "Lil Peep" },
            };
        }
    }
}
