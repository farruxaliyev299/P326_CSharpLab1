using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Models
{
    internal class PrintFile
    {
        public void Print(IPrintableFile file)
        {
            file.Print();
        }
    }
}
