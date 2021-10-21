using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAutomation.Task2
{
    class Author
    {
        private string firstName;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    //Console.WriteLine("Invalid Text value");
                    throw new ArgumentNullException();
                }

                else
                if (value.Length > 200)
                {
                    firstName = value.Substring(0, 199);
                }
                else
                {
                    firstName = value;
                }
            }
        }
        private string lastName;
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    //Console.WriteLine("Invalid Text value");
                    throw new ArgumentNullException();
                }

                else
                if (value.Length > 200)
                {
                    lastName = value.Substring(0, 199);
                }
                else
                {
                    lastName = value;
                }
            }
        }
    }
}
