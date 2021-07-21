using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAutomation
{
    class VideoLesson : TrainingData, Interfaces.IVersionable
    {
        private string uri;

        public string UriVideo
        {
            get
            {
                return uri;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Uri Should be not Empty!");
                }
                else
                {
                    uri = value;
                }
            }
        }

        public string UriPicture { get; set; }
        public Enums.VideoFormat Format { get; set; }

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
            for (int i = 0; i< 8; i++)
            {
                version[i] = ver[i];
            }
            return true;
        }
    }
}
