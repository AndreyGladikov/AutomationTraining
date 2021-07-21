using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAutomation
{
    class TextLesson : TrainingData
    {
        private string txt;

        public string Text
        {
            get
            {
                return txt;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Invalid Text value");
                }
                else
                if (value.Length > 10000)
                {
                    txt = value.Substring(0, 9999);
                }
                else
                {
                    txt = value;
                }
            }
        }
    }
}
