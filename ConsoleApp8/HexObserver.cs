using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    public class HexObserver : Observer
    {
        public HexObserver(Subject subjectin)
        {
            this.subject = subjectin;
            this.subject.attach(this);

        }


        public override void update()
        {
            Console.WriteLine("convert to Hex string : " + this.subject.getState());
        }
    }
}