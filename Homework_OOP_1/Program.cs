class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    private int pages;
    public int Pages
    {
        get { return pages; }
        set
        {
            if (value > 0)
                pages = value;
            else
                throw new System.ArgumentException();
        }
    }
    public Book(string title, string author, int pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
    }
    public string Info()
    {
        return Title + " by " + Author + ", " + Pages + " pages";
    }
}
class Program
{
    static void Main()
    {
        Book[] books = new Book[3];
        books[0] = new Book("Suç ve Ceza", "Dostoyevski", 687);
        books[1] = new Book("Sefiller", "Victor Hugo", 550);
        books[2] = new Book("3 Silahşörler", "Alexandre Dumas", 500);
        foreach (Book book in books)
        {
            Console.WriteLine(book.Info());
        }
        Book mostPages = books[0];
        foreach (Book book in books)
        {
            if (book.Pages > mostPages.Pages)
                mostPages = book;
        }
        Console.WriteLine("Most pages: " + mostPages.Info());
    }
}