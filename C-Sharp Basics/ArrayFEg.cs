using System;
    

namespace C_Sharp_Basics
{
    class ArrayFEg
    { //Array function
      //One-Dimensional Array
      //data type[] arrname=new datatype[size];
      //data type[] arrname=new datatype[size]{value1,value2,..valueN};
        static void Main()
        {
            string[] flower = new string[4]; //0,1,2,3
            flower[0] = "Lily";
            flower[1] = "Rose";
            flower[2] = "Jasmine";
            flower[3] = "Lotus";
            Console.WriteLine(flower[0]);
            for (int i = 0; i < flower.Length; i++)
            {
                Console.WriteLine("index{0};{1}",i, flower[i]);
               
            }
            Console.Read();

            /*int size=4
            int[] marks = new int[4] { 90, 89, 56, 78 };
            Console.WriteLine(marks[0]);
            {
            for(int i=0, i<marks, i++)
                {
                    Console.WriteLine
                }



            */
            //Console.Read();
            
        }
        
    }

    

    

    
}
