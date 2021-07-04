using System;

namespace Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boxing
            int i = 123;
            object box = i;


            //Unboxing

            object unbox = 12;
            int z = (int)box;
        }
    }
}
