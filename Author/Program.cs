using System;
using System.Collections.Generic;

namespace Author
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var author in AuthorAddList())
            {
                if (author.Age >= 40)
                {
                    Console.WriteLine(author.Name +" " + author.Surname);
                }
            }

        }
        private static List<Author> AuthorAddList()
        {

            Author author = new Author();
            author.Name = "Vasili";
            author.Surname = "Vasilevich";
            author.Age = 36;
            Author author1 = new Author();
            author1.Name = "Vladimir";
            author1.Surname = "Putin";
            author1.Age = 73;
            Author author2 = new Author();
            author2.Name = "Che";
            author2.Surname = "Luing";
            author2.Age = 46;
            Author author3 = new Author();
            author3.Name = "Joe";
            author3.Surname = "Biden";
            author3.Age = 56;
            List<Author> auth = new List<Author>();
            auth.Add(author);
            auth.Add(author1);
            auth.Add(author2);
            auth.Add(author3);
            return auth;
        }
        
    }
}
