using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TrainingAutomation.Task2;

namespace TrainingAutomation
{
    class Book
    {
        private string isbn;
        //Regex regex = new Regex("[0-9]{3}-[0-9]{1}-[0-9]{2}-[0-9]{6}-[0-9]{1}");
        string regex = @"[0-9]{3}-[0-9]{1}-[0-9]{2}-[0-9]{6}-[0-9]{1}";
        string regexpSec = @"[0-9]{13}";
        public string ISBN
        {
            get 
            {
                return isbn;
            }
            set 
            {
                if (Regex.IsMatch(value, regex) || Regex.IsMatch(value, regexpSec))
                {
                    isbn = value;
                }
                else 
                {
                    Console.WriteLine("Not correct ISBN number");
                }
            }
        }

        public override bool Equals(object obj)
        {
            Book b = obj as Book;
            return this.ISBN == b.ISBN;
        }

        private string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    //Console.WriteLine("Invalid Text value");
                    throw new ArgumentNullException();
                }

                else
                if (value.Length > 10000)
                {
                    title = value.Substring(0, 9999);
                }
                else
                {
                    title = value;
                }
            }
        }

        private DateTime dateOfPublish;

        public DateTime DateOfPublish
        {
            get
            {
                return dateOfPublish;
            }
            set
            {
                dateOfPublish = value;
            }
        }

        public List<Author> author = new List<Author>();
    }
}
