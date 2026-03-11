using System;

namespace HW3
{
  class Book
  {
    private static int bookCount = 0;
    public int numId = 0;
    private string bookId = "";
    private string title = "";
    private string author = "";

    private bool isAvailable;

    public string BookId
    {
      get
      {
        if (!string.IsNullOrEmpty(bookId))
        {
          return bookId;
        }
        else
        {
          throw new Exception("Id not set");
        }
      }

    }
    public string Title
    {
      get
      {
        if (!string.IsNullOrEmpty(title))
        {
          return title;
        }
        else
        {
          throw new Exception("Title not set");
        }
      }
      set
      {
        title = value;
      }
    }
    public string Author
    {
      get
      {
        if (!string.IsNullOrEmpty(author))
        {
          return author;
        }
        else
        {
          throw new Exception("Author name not set");
        }
      }
      set
      {
        author = value;
      }
    }
    public bool IsAvailable
    {
      get
      {
        return isAvailable;
      }
      set
      {
        isAvailable = value;
      }
    }

    public Book(string title, string author, bool isAvailable)
    {
      bookCount++;
      numId = bookCount;
      bookId = $"B{bookCount:D3}";
      Title = title;
      Author = author;
      IsAvailable = isAvailable;
    }

    public Book()
    {
      bookCount++;
      numId = bookCount;
      bookId = $"B{bookCount:D3}";
    }



  }


  class Program
  {
    static void Main(string[] args)
    {
      int n;

      Console.Write("Enter the number of books (1-10): ");
      n = Convert.ToInt32(Console.ReadLine());
      if (n > 10 || n < 1)
      {
        Console.WriteLine("Error: Number of books must be between 1 and 10.");
        return; 
      }
      Book[] book = new Book[n];
      for (int i = 0; i < n; i++)
      {
        book[i] = new Book();
        System.Console.WriteLine($"Enter details for Book {i + 1}: ");
        System.Console.WriteLine($"Book ID: {book[i].BookId}");
        System.Console.Write("Title: ");
        book[i].Title = Console.ReadLine();
        System.Console.Write("Author: ");
        book[i].Author = Console.ReadLine();
        System.Console.Write("Is the book available? (yes/no): ");
        string input;
        input = Console.ReadLine();
        if (input == "yes")
        {
          book[i].IsAvailable = true;
        }
        else if (input == "no")
        {
          book[i].IsAvailable = false;
        }
      }

      int numAv = 0;


      for (int i = 0; i < n; i++)
      {
        if (book[i].IsAvailable)
        {
          numAv++;
        }
      }

      if (numAv == 0)
      {
        System.Console.WriteLine("No books are currently available. ");
        return;
      }

      System.Console.WriteLine("Available Books: ");


      for (int i = 0; i < n; i++)
      {
        if (book[i].IsAvailable)
        {
          System.Console.WriteLine($"Book ID: {book[i].BookId}, Title: {book[i].Title}, Author: {book[i].Author}");
          numAv++;
        }
      }
    }
  }
}