using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01OOP
{
    [Flags]
    internal enum Permissions : byte
    {
        Delete = 1, Excute = 2, Read = 4, Write = 8
    }
}
