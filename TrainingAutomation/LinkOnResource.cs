using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAutomation
{
    class LinkOnResource : TrainingData
    {
        private string content;

        public string UriContent
        {
            get
            {
                return content;
            }
            set
            {
                if (string.IsNullOrEmpty(value.ToString()))
                {
                    Console.WriteLine("Uri Should be not Empty!");
                }
                else
                {
                    content = value;
                }
            }
        }

        public Enums.LinkType TypeOfLink { get; set; }
    }
}
