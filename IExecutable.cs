using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public interface IExecutable
    {
        void Process(FileInfo f);
    }
}
