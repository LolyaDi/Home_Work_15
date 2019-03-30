using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Home_Work_15
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> bookList = new List<Book>() { new Book("Язык программирования C# 5.0 и платформа .NET 4.5", 9999, "Эндрю Троелсен", 2015) };

            BinaryFormatter binaryFormatter = new BinaryFormatter();

            using (FileStream fileStream = new FileStream("Book.dat", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fileStream, bookList);
            }


            using (FileStream fileStream = new FileStream("Book.dat", FileMode.OpenOrCreate))
            {
                
                List<Book> books = binaryFormatter.Deserialize(fileStream) as List<Book>;

                foreach (var book in books)
                {
                    Console.WriteLine($"Название книги - {book.Name}\n");
                    Console.WriteLine($"Автор книги - {book.Author}\n");
                    Console.WriteLine($"Год выпуска - {book.PublicYear}\n");
                    Console.WriteLine($"Цена - {book.Cost}");
                }
            }

            Console.ReadKey();
        }
    }
}
