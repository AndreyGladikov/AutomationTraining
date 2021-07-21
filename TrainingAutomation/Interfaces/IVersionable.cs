using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAutomation.Interfaces
{
    interface IVersionable
    {
        byte[] getVersion();
        bool setVersion(byte[] ver);
    }
}
