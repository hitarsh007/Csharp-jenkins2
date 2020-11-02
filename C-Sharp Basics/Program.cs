using System;


namespace C_Sharp_Basics
{
    class Program
    {
        static void Main()

        {
            //Implicit conversion lower to higher 
            //value type
            int salary = 20000;
            float f = salary;
            double d = f;
            Console.WriteLine("Implicit conversion");
            Console.WriteLine("Int:{0}||float{1}||double{2}", salary, f, d);
            Console.WriteLine("---------------------------------------------");

            //Explicit conversion higher to lower
            float sal = 30000.78f;
            int i = Convert.ToInt32(sal);
            Console.WriteLine("Explicit conversion");
            Console.WriteLine("float to int:{0}", salary, f, d);
            Console.WriteLine("---------------------------------------------");
            Console.Read();




        }
    }
}
