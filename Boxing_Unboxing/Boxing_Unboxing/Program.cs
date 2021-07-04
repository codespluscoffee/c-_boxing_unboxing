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
            Console.WriteLine(box.ToString());

            //Unboxing
            object unbox = 123;
            int z = (int)unbox;
            Console.WriteLine(z);

        }
    }
}

