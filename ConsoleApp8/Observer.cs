using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    public abstract class Observer
    {

        public Subject subject;
        abstract public void update();
      
    }
}