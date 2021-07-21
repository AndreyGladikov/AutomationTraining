using System;
using System.Collections.Generic;
using TrainingAutomation.Enums;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAutomation
{
    class TrainingLesson : Interfaces.IVersionable, ICloneable
    {
        public TrainingData[] LessonMaterialsArray { get; set; }

        public Enums.TrainingType GetLessonType()
        {
            var lessonType = Enums.TrainingType.TextLesson;
            foreach (var lessonMaterial in LessonMaterialsArray)
            {
                if (lessonMaterial.GetType() == typeof(VideoLesson))
                {
                    lessonType = Enums.TrainingType.VideoLesson;
                    break;
                }
            }
            return lessonType;
        }

        byte[] version = new byte[8];
        public byte[] getVersion()
        {
            return version;
        }

        public bool setVersion(byte[] ver)
        {
            if (ver.Length != 8)
            {
                return false;
            }
            for (int i = 0; i < 8; i++)
            {
                version[i] = ver[i];
            }
            return true;
        }

        public object Clone()
        {

            TrainingLesson lessonClone = new TrainingLesson();

            for (int i = 0; i < this.LessonMaterialsArray.Length; i++)
            {
                lessonClone.LessonMaterialsArray[i] = this.LessonMaterialsArray[i];
            }
            return lessonClone;
        }
    }

}
