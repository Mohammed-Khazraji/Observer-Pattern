using System;

namespace ConsoleApp8
{
   

    public class program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();

            new HexObserver(subject);
            new OctalObserver(subject);

            Console.WriteLine("first step change : 15");
            subject.setState(15);
            Console.WriteLine("first step change : 30");
            subject.setState(30);
            Console.ReadKey();
        }
    }
}
