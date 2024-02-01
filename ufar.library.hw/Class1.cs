using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ufar.library.hw;

namespace ufar.library.hw
{
    
    class Book
    {   private static int nextId=1;
        public int Id { get; }
        public string Title;
        public Author Author;
        public Category Category;
        public int Year;
        public double Price;

     
        public Book(string title, Author author, Category category, int year, double price)
        {
            Id = nextId++;
            Title = title;
            Author = author;
            Category = category;
            Year = year;
            Price = price;
        }

       
        public static Book CreatenewBook()
        {

            Console.WriteLine("Enter Book's Title: ");
            string title = Console.ReadLine();

            Console.WriteLine("Enter Author's Name: ");
            string authorName = Console.ReadLine();

            Console.WriteLine("Enter Author's Biography: ");
            string authorBiography = Console.ReadLine();
            bool check = true;
            Category category = new Category { };
            do
            {
            Console.WriteLine("Enter Category Name: ");
            Console.WriteLine("{0} Adventure ");
            Console.WriteLine("{1} Horror");
            Console.WriteLine("{2} Comedy");
            Console.Write("Choose the answer: ");
           
            int answer = int.Parse(Console.ReadLine());
            
                switch (answer)
                {
                    case 0:
                        category.CategoryName = "Adventure";
                        break;
                    case 1:
                        category.CategoryName = "Horror";
                        break;
                    case 2:
                        category.CategoryName = "Comedy";
                        break;
                    default:
                        Console.WriteLine("Wrong answer!!!!!");
                        check = false;
                        break;
                }
            } while (!check);
            Console.WriteLine("Enter Category Description: ");
            string categoryDescription = Console.ReadLine();
            category.Description = categoryDescription;
            Console.WriteLine("Enter Book's Year: ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Book's Price: ");
            double price = double.Parse(Console.ReadLine());

       
            Author author = new Author { Name = authorName, Biography = authorBiography };
            
            
            Console.WriteLine("Book added successfully");
           
            return new Book(title, author, category, year, price);

           

        }

    }

      

    }

class Library
{
    private List<Book> books = new List<Book>();
    public void AddBook(Book book)
    {
        books.Add(book);
    }
    public void ListAllBooks()
    {
        Console.WriteLine("List of all books:");
        foreach (var book in books)
        {
            Console.WriteLine($"ID: {book.Id}, Title: {book.Title}, Author: {book.Author.Name}, Category: {book.Category.CategoryName}, Year: {book.Year}, Price: {book.Price}");
        }
    }
}

    class Author
    {
        public string Name;
        public string Biography;
    }
enum CategoryName
{
    Adventure,
    Horror,
    Comedy
}
class Category
{
        public string CategoryName;
        public string Description;
    
 }





