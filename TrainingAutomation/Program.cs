using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingAutomation.Task2;

namespace TrainingAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            //TrainingData trainingData = new TrainingData();
            //trainingData.GenerateGuid();
            //trainingData.Description = "sourceDescription";

            //TextLesson textLesson = new TextLesson();
            //textLesson.GenerateGuid();
            //try
            //{
            //    textLesson.Text = "";
            //}
            //catch
            //{
            //    Console.WriteLine("Exception");
            //}
            //textLesson.Description = "Description of text lesson";

            //VideoLesson videoLesson = new VideoLesson();
            //videoLesson.GenerateGuid();
            //videoLesson.UriVideo = "www.video.com";
            //videoLesson.Description = "Description of video lesson";

            //LinkOnResource link = new LinkOnResource();
            //link.UriContent = "www.content.con";

            //TrainingData[] testMass = new TrainingData[] {trainingData};
            //TrainingLesson sourcedTrainingLesson = new TrainingLesson();
            //sourcedTrainingLesson.LessonMaterialsArray = testMass;
            //TrainingLesson clonedTrainingLesson = new TrainingLesson();

            //clonedTrainingLesson = sourcedTrainingLesson.Clone() as TrainingLesson;
            //trainingData.Description = "newDescription";
            //var a = sourcedTrainingLesson;
            //var b = clonedTrainingLesson;



            //TrainingData[] trDataArry = new TrainingData[] { textLesson, videoLesson, link };


            //Console.WriteLine(textLesson.Id.ToString());
            //Console.WriteLine(textLesson.Text);
            //Console.WriteLine(trainingData.Id.ToString());
            //Console.WriteLine(trainingData.Description);
            
            Author king = new Author();
            king.FirstName = "Steven";
            king.LastName = "King";

            Author lewis = new Author();
            lewis.FirstName = "Alice";
            lewis.LastName = "Carrol";

            Author myTest = new Author();
            myTest.FirstName = "Andrey";
            myTest.LastName = "Gladikov";

            List<Author> authorsForAlice = new List<Author> {lewis, myTest };
            List<Author> authorsForIt = new List<Author> { king };
            List<Author> authorsForMyBook = new List<Author> { myTest };

            Book it = new Book();
            it.DateOfPublish = DateTime.Today;
            it.author = authorsForIt;
            it.ISBN = "1234512345123";
            it.Title = "IT";

            Book alice = new Book();
            DateTime dateOfAlice = new DateTime(2015, 7, 20);
            alice.DateOfPublish = dateOfAlice;
            alice.author = authorsForAlice;
            alice.ISBN = "987654321021";
            alice.Title = "AliceInWonderLand";

            Book myBook = new Book();
            DateTime dateOfMyBook = new DateTime(2021, 10, 20);
            myBook.DateOfPublish = dateOfMyBook;
            myBook.author = authorsForMyBook;
            myBook.ISBN = "333-1-22-666666-1";
            myBook.Title = "MyBook";

            Catalog cat = new Catalog();
            cat.AddBook(myBook);
            cat.AddBook(it);
            cat.AddBook(alice);

            var B = cat.GetByAuthor("Steven", "King");
            var C = cat.GetByIsbn("333-1-22-666666-1");
            cat.GetSortedByPublishDate();
           
            foreach (var book in cat)
            {
                foreach ( var item in book.author)
                Console.WriteLine(item.FirstName + " " + item.LastName + "-" + book.Title);
            }

            Book test_find = cat.GetByIsbn("1234512345123");
            if (test_find != null)
                foreach (var item in test_find.author)
                Console.WriteLine(item.FirstName + " " +item.LastName + " - " + test_find.Title);
            else
                Console.WriteLine("can't find the book");

            var found_book = cat.Where(x => x.Title == "mybook");
            if (found_book != null)
            {
                foreach (var b in found_book)
                {
                    Console.WriteLine(b.author + " - " + b.Title);
                }
            }
        }

    }
}
      
    


