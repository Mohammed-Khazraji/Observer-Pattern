using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    public class OctalObserver : Observer
    {
        public OctalObserver (Subject subjectin)
        {
            this.subject = subjectin;
            this.subject.attach(this);

        }
        public override void update()
        {
            Console.WriteLine("convert to octal string : " + this.subject.getState());
        }
    }

}