using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    sealed class SealedClass : IAnimal
    {
        public void SealedMethod()
        {

        }
        public void SampleMethod() { }
        public int SampleProperty { get; set; }
        public void Breath() { }
        public void Sleep() { } 
        public void Eat() { }
        public void Bark() { } 
    }
    interface IAnimal
    {
        void Sleep();
        void Eat();
        void Bark();
        int SampleProperty { get; set; }
        //int Inte; //cannot create variable
        //public int Run() { return 123; } //cannot have a body
        //public int SampleProperty { get; set; } // no public

    }
    abstract class Animal : IAnimal 
    {
        public int SampleProperty { get; set; }
        private int Age;
        public int Run() { return 123; }
        public void SampleMethod() { }
        public abstract void Breath();
        public abstract void Sleep(); //--- INTERFACE DAPAT ANG PIPILIIn
        public abstract void Eat();
        public void Bark() { } // ABSTRACT DAPAT ANG PIPILIIN
        //public void NewMethod(); //cannot create no body method without abstract type
    }
}
