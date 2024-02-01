using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ufar.library.hw
{

    
    
    internal class Library
    {
        static void Main(string[] args)
        {
            //var lolita = new Book("Lolita", new Author { Name = "Vladimir Nabokov", Biography = ":)" },
            //          new Category { CategoryName = "Horror", Description = "lkjhgfdsadfghjkl" },
            //          1998, 25);

            int answer;
            Console.WriteLine("\t Hello, Welcome to the Ufar's Library");
            do
            {
                Console.WriteLine("{1} Add Book ");
                Console.WriteLine("{2} Remove Book ");
                Console.WriteLine("{3} List All Books ");
                Console.WriteLine("{0} exit ");
                Console.Write("Please choose the action: ");
                answer = int.Parse(Console.ReadLine());
                Library library = new Library();


                switch (answer)
                {

                    case 1:
                        library.AddBook(Book.CreateBook());
                        break;
                    case 2:
                        break;
                    case 3:
                        library.ListAllBooks();
                        break;
                }
            } while (answer != 0);

            
           
           

        }
    }
}
