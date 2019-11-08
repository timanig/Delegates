using System;
namespace Delegates
{
    public class Master
    {
        delegate void del();
        public Master()
        {
            Console.WriteLine("Normal funciton call");
            WhatAmI();


            Console.WriteLine("Using Delegates");
            del d = WhatAmI;
            d += WhatAmI;
            d();
        }

        public void WhatAmI()
        {
            Console.WriteLine("You are a member of the master c");
        }
    }
}
