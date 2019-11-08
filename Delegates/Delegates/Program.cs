using System;

namespace Delegates
{
    class Program
    {
        delegate void del();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var m = new Master();


            Console.WriteLine();
            m.WhatAmI();

            del d = m.WhatAmI;
            d += m.WhatAmI;
            d();
        }
    }
}
