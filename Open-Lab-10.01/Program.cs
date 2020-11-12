using System;

namespace Open_Lab_10._01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Book LOTR = new Book();
            
            LOTR.SetBook("Creative name of book", 100);
            
            Console.ReadKey();
        }
    }
    class Book
    {
        public string title;
        
        private int pages;
        
        public void SetBook(string title, int pages)
        {
            this.title = title;
            
            this.pages = pages;
            
            Console.WriteLine(String.Format($"Book \"{title}\" has {pages} pages."));
        }
    }
}
