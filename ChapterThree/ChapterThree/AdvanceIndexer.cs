using System;
namespace ChapterThree{
    public class Book{
        // Data Model
        public string Title { get; set; }
        public string Author { get; set; }
        public Book(string title,string author){
            Title = title;
            Author = author;
        }
        
    }
    
    public class Library{
        // Indexer
        private List<Book> books = new List<Book>();
        public Book this[int index]{
            get{
                if(index>=0 && index<books.Count){
                    return books[index];
                }
                throw new IndexOutOfRangeException("Index out of range");
            }
            set{
                if(index>=0 && index<books.Count){
                    books[index] = value;
                }else{
                    throw new IndexOutOfRangeException("Index out of range");
                }
            }
        }
        public void AddBook(Book book){
        books.Add(book);
    }
    }
    public class AdvanceIndexer{
        static void Main(string[] args)
        {
            Library lib = new Library();
            lib.AddBook(new Book("asda","asda"));
           lib.AddBook( new Book("ram","asd"));
           for(int i=0; i<2;i++){
            Console.Write("Title: "+lib[i].Title);
            Console.WriteLine(" Author: "+lib[i].Author);
           }

        }
    }
}