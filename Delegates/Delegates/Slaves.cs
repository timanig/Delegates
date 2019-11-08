using System;
namespace Delegates
{
    public class Slaves
    {
        delegate int _del(int x,int y);
        public Slaves()
        {
            //Run function normally
            Console.WriteLine(SumOfSlaves(1,2));

            //Run function normally
            _del e = SumOfSlaves;
            e += SumOfSlaves;
            e += SumOfSlaves;
            Console.WriteLine(e(2,4));
        }
        public int SumOfSlaves(int x, int y)
        {
            return x + y;
        }
    }
}
