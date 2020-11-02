using System;


namespace C_Sharp_Basics
{
    class StringEg
    {
        static void Main()
        {
            string firstname = "Hitarsh";
            Console.WriteLine("Length of string:{0}", firstname.Length);
            Console.WriteLine("Converting to Uppercase:{0}", firstname.ToUpper());
            Console.WriteLine("Length of string:{0}", firstname.Length);
            Console.WriteLine("Contains:{0}", firstname.Contains("shar"));
            Console.WriteLine("made changes");
            Console.Read();



        }
    }
}
