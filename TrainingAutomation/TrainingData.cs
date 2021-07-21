using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TrainingAutomation
{
    public class TrainingData
    {
        public override string ToString()
        {
            return Description;
        }

        private string desc;
        public Guid Id { get; set; }
        public string Description
        {
            get
            {
                return desc;
            }
            set
            {
                if (value.Length > 256)
                {
                    desc = value.Substring(0, 255);
                }
                else
                {
                    desc = value;
                }
            }
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            TrainingData trData = obj as TrainingData;
            if (trData is null)
            {
                return false;
            }
            return (this.Id == trData.Id);
        }
    }

    public static class ExtentionTrainingData
    {
        public static void GenerateGuid(this TrainingData trData)
        {
            trData.Id = Guid.NewGuid();
        }
    }
}
