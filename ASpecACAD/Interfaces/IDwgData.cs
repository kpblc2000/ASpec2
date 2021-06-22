using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASpecACAD.Interfaces
{
    public interface IDwgData
    {
        bool Save(string Data);

        string Read();

    }
}
