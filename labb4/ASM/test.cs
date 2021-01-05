using System;
using System.Collections.Generic;
using System.Text;

namespace asm
{
    class test
    {
        static void Main(string[] arg)
        {
            medicine objmedi = new medicine();
            sale objsale = new sale();
            objmedi.Accept();
            objmedi.Print();
            Console.WriteLine();
            objsale.Accpect();
            objsale.Display();
        }
        
    }
}
