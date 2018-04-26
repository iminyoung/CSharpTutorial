using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    class Dog : Animal //concrete class
    {
        public override void Breath() { }
        public override void Sleep() { }
        public override void Eat() { }

        //public void New(); //cannot create method without body
    }
}
