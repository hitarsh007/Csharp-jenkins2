using System;


namespace C_Sharp_Basics
{
    enum Feedback
    {
        poor, fair, good, excellect

    }
    class EnumerationEg

    {
        static void Main()
        {
            string Ename = "Hitarsh";
            Console.WriteLine("name:{0}||feedback:{1}", Ename, Feedback.good);
            Console.WriteLine("name:{0}||feedback:{1}", Ename, (int)Feedback.good);
            Console.WriteLine("name:{0}||feedback:{1}", Ename, Convert.ToInt32(Feedback.good));
            Console.Read();

        }




    }

    
}
