using System;


namespace C_Sharp_Basics
{
    class Boxing_Unboxing
    {
        static void Main()
        {
            //valuetype
            int petrol = 100;
            //reference type
            //boxing
            object o = petrol;
            Console.WriteLine("Boxing converting value type to reference type:{0}", o);
        }

    }
        
    
}
