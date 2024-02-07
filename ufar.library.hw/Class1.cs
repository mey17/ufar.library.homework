using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

       
        public static Book CreateNewBook()
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
                        category.CategoryName = CategoryName.Adventure;
                        category.Description = "Adventure books feature fast-paced \n and action-packet plots, and a hero that has to \n complete an unexpected quest or journey in a \n short period of time. ";
                        break;
                    case 1:
                        category.CategoryName = CategoryName.Horror;
                        category.Description = "horror story, a story in which the focus is on creating a feeling of fear. Such tales\n are of ancient origin and form a substantial part \nof the body of folk literature.";
                        break;
                    case 2:
                        category.CategoryName = CategoryName.Comedy;
                        category.Description = "Sarcasm, irony, parody, and innuendo kick in for audiences around 12-15. After 15, pretty much anything goes,\n allowing you to set up more complex humor writing like \n elaborate running gags, self-reflexive jokes,\n running gags, self-reflexive jokes, or even running gags.";
                        break;
                    default:
                        Console.WriteLine("Wrong answer!!!!!");
                        check = false;
                        break;
                }
            } while (!check);
            
            
             
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
            Console.WriteLine($"ID: {book.Id}, Title: {book.Title}, Author: {book.Author.Name},\n Category: {book.Category.CategoryName},Category Description: {book.Category.Description},\n Year: {book.Year},\n Price: {book.Price}\n");
        }
    }

}


    class Author
    {   
        public string Name;
        public string Biography;
    
 
        

    public Author(string name, string bio) {

        Name = name;
        Biography = bio;
    }

    private List<Author> authors = new List<Author>();
    
}
enum CategoryName
{
    Adventure,
    Horror,
    Comedy
}

enum Description
{

}
class Category
{
        public dynamic CategoryName;
        public string Description;
    
 }





