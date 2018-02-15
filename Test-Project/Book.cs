using System;
using System.Collections.Generic;

namespace TestProject
{
    public class Book
    {
        private readonly List<string> books = new List<string>();

        public void AddBook(string book)
        {
            books.Add(book);
        }

        public void RemoveBook(string name)
        {
            int index = books.FindIndex(bookName => bookName == name);

            books.RemoveAt(index);
        }

        public List<string> GetBooks() => books;
    }
}
