using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAutomation.Task2
{
    class Catalog : IEnumerable<Book>
    {
        private List<Book> books;

        public Catalog()
        {
            books = new List<Book>();
        }

        public IEnumerator<Book> GetEnumerator()
        {
            books.Sort((x, y) => string.Compare(x.Title, y.Title));
            foreach (Book book in books)
            {
                yield return book;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)books).GetEnumerator();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public Book GetByIsbn(string isbn)
        {
            return books.Find(x => x.ISBN == isbn);
        }

        public List<Book> GetByAuthor(string Fname, string Lname)
        {
            Author auth = new Author
            {
                FirstName = Fname,
                LastName = Lname
            };

            return books.FindAll(x => x.author.Contains(auth));
        }

        public List<Book> GetSortedByPublishDate()
        {
            return books.OrderByDescending(x => x.DateOfPublish) as List<Book>;
        }

        public (string authorName, int numberOfBooks) GetNumberOfBookByAuthor(Author author)
        {
            int numberOfBooksByAuthor = (from book in books group book by book.author).Count();
            var result = (authorName: $"{author.FirstName} {author.LastName}", numberOfBooks: numberOfBooksByAuthor);
            return result;
        }
    }
}
