using System;
using System.Threading;

namespace TestProject
{
    class Program
    {
        static void Main()
        {
            Book book = new Book();

            book.AddBook("My First Book");

            Console.WriteLine("New List Of Books");

            book.GetBooks().ForEach(Console.WriteLine);

            Thread.Sleep(3000);

            book.AddBook("My Second Book");

            Console.WriteLine("New List Of Books");

            book.GetBooks().ForEach(Console.WriteLine);

            Thread.Sleep(3000);

            book.RemoveBook("My First Book");

            Console.WriteLine("Should remove first book..");

            Console.WriteLine("New List Of Books");

            book.GetBooks().ForEach(Console.WriteLine);

        }
    }
}