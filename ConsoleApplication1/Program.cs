using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Demo;



#region IsOperator

//class GreatGrandParent
//{
//    public void Hunt() { }
//}
//class GrandParent : GreatGrandParent
//{
//    public GrandParent() : base()
//    {

//    }
//    public void Chacha() { }
//}
//class Parent : GrandParent
//{
//    public Parent() : base()
//    {

//    }
//    public void Sing() { }
//}
//class Child : Parent
//{
//    public Child() : base()
//    {

//    }
//    public void Play() { }
//}
//class MyClass
//{
//    static void Main(string[] args)
//    {
//        //c,p,gp,ggp
//        Child child = new Child();
//        GrandParent gp = null;

//        if(child is GrandParent)
//        {
//            gp = (GrandParent)child;
//        }

//        if(gp != null)
//        {
//            gp.Chacha();
//            gp.Hunt();
//        }
//    }
//}
#endregion

#region Object Explicit
//class GreatGrandParent
//{
//    public void Hunt() { }
//}
//class GrandParent : GreatGrandParent
//{ 
//    public GrandParent():base()
//{

//}
//    public void Chacha() { }
//}
//class Parent : GrandParent
//{
//    public Parent():base()
//    {

//    }
//    public void Sing() { }
//}
//class Child : Parent
//{
//    public Child():base()
//    {

//    }
//    public void Play() { }
//}
//class MyClass
//{
//    static void Main(string[] args)
//    {
//        //c,p,gp,ggp
//        Child child = new Child();
//        //p,gp,ggp
//        Parent parent = new Parent();
//        //gp,ggp
//        GrandParent grandParent = new GrandParent();
//        //ggp
//        GreatGrandParent greatGrandParent = new GreatGrandParent();

//        greatGrandParent = child;
//        greatGrandParent = parent;
//        greatGrandParent = grandParent;

//        grandParent = child;
//        grandParent = parent;

//        parent = child;

//        //Dog dogB = (Dog)animalB; //explicit conversion - build success - runtime error
//        //dog.Sleep();
//        //dog.Bark();
//        //dog.Eat();
//    }
//}
#endregion

#region Explicit Conversion
//class MyClass
//{
//    static void Main(string[] args)
//    {
//        long x = 100;
//        int y = (int)x; //explicit
//    }
//}
#endregion

#region Implicit Conversion
//class MyClass
//{
//    static void Main(string[] args)
//    {
//        int x = 100;
//        long y = x; //implicit
//    }
//}
#endregion

#region Partial
//partial class Dog
//{
//    public int Age { get; set; }
//    public string Breed { get; set; }
//    public string Color { get; set; }
//    partial void Play();
//}
// abstract partial class Dog
//{
//    public  void Bark() { }
//    partial void Play() { }
//    public void Run() { }
//    public void CallPlay()
//    {
//        Play();
//    }
//}
//sealed partial class Puppy : Dog
//{

//}
//class MyClass
//{
//    static void Main(string[] args)
//    {
//        Dog dog = new Dog();
//        dog.CallPlay();
//        Puppy p = new Puppy();
//    }
//}
#endregion

#region Sealed
//class Animal
//{
//    public virtual void Sleep() { }
//    public virtual void Eat() { }
//}
//class Dog : Animal 
//{
//    public  override void Sleep() { }
//    public  override void Eat() { }
//}
//class Puppy : Dog
//{
//     public sealed override void Sleep() { }
//     public sealed override void Eat() { }
//}
//class Shihtzu : Puppy
//{
//    new public virtual void Sleep() { }
//    new public void Eat() { }
//}
//class QT : Shihtzu
//{
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Animal animal = new Animal();
//        animal.Sleep();
//        animal.Eat();

//        Dog dog = new Dog();
//        dog.Sleep();
//        dog.Eat();

//        Puppy puppy = new Puppy();
//        puppy.Sleep();
//        puppy.Eat();

//        Shihtzu shitz = new Shihtzu();
//        shitz.Sleep();

//        QT da = new QT();
//        da.Sleep();
//    }
//}

#endregion

#region Abstract
//class Program
//{
//    static void Main(string[] args)
//    {
//        //AbstractClass abstractObject = new AbstractClass();
//        Dog dog = new Dog();

//        dog.SampleProperty = 100;
//        dog.SampleMethod();
//        dog.Sleep();
//        //dog.Age = 1; //no protected private

//        SealedClass sc = new SealedClass();
//        sc.SealedMethod();
//        sc.Eat();
//        sc.SampleProperty = 1;
//    }
//}
#endregion

#region Interface
//interface IAnimal
//{
//    int Age { get; set; } //property
//    void Sleep(); //method
//    void Eat(); //method
//}
//interface ILivingThing
//{
//    void Excrite();
//    void Breath();
//}
////class - blueprint : interface - contract
//class Animal : IAnimal, ILivingThing
//{
//    public virtual int Age { get; set; }
//    public virtual void Sleep() { }
//    public virtual void Eat() { }
//    public void Excrite() { }
//    public void Breath() { }
//}
//class Dog : ILivingThing
//{
//    public void Excrite() { }
//    public void Breath() { }
//}
//class Cat : Animal, IAnimal, ILivingThing
//{
//    public override int Age { get; set; }
//}
//class MyClass
//{
//    static void Main(string[] args)
//    {
//        Animal animal = new Animal();
//        IAnimal iAnimal = animal;
//        iAnimal.Sleep();
//        iAnimal.Age = 1;
//        iAnimal.Eat();

//        ILivingThing iLivingThing = animal;
//    }
//}
#endregion

#region Polymorphism
//class GrandPaprent
//{
//    protected virtual void Cook()
//    {
//        Console.WriteLine("Grandparent is cooking.");
//    }
//    public void ManageCook()
//    {
//        Cook();
//    }
//}
//class Parent : GrandPaprent
//{
//    protected override void Cook()
//    {
//        Console.WriteLine("Parent is cooking.");
//    }
//}
//class Child : Parent
//{
//    protected override void Cook()
//    {
//        Console.WriteLine("Child is cooking.");
//    }
//}
//    class Program
//{
//    static void Main(string[] args)
//    {
//        GrandPaprent grandParent = new GrandPaprent();
//        grandParent.ManageCook();

//        Parent parent = new Parent();
//        parent.ManageCook();

//        Child child = new Child();
//        child.ManageCook();

//        Console.Read();
//    }
//}
#endregion

#region Inheritance
//class Animal
//{
//    public int Age { get; set; }
//    public string Gender { get; set; }

//    public void Sleep() { }
//    protected void Eat() { }
//}
//class Canine : Animal //inherit animal to canine
//{
//    public void Run() {
//        Eat();
//    }

//}
//class Dog : Canine //inherit canine to dog
//{
//    public void Bark() { }
//}
//class MyClass
//{
//    static void Main(string[] args)
//    {
//        Animal animal = new Animal();
//        animal.Age = 10;
//        animal.Sleep();

//        Canine canine = new Canine();
//        canine.Age = 3;
//        canine.Run();
//        canine.Sleep();

//        Dog dog = new Dog();
//        dog.Age = 2;
//        dog.Gender = "female";
//        dog.Run();
//        dog.Sleep();
//        dog.Bark();
//    }
//}
#endregion

#region Encapsulation
//public class Program
//{
//    static void Main(string[] args)
//    {
//        Dog dog = new Dog();


//    }
//}

//class Dog //encapsulation, abstraction
//{
//    public int Age { get; set; }
//    public int Color { get; set; }
//    //public int NumberOfDoor { get; set; }
//    public int Breed{ get; set; }
//    //public int LastName{ get; set; }

//    public void Bark() { }
//    //public void Fly() { }
//    public void Sleep() { }
//    //public void Pur() { }
//    public void Eat() { }
//}
#endregion

#region Continue
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//        int count = 0;
//        string[] array2 = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };

//        while (array.Length > count)
//        {
//            if (array[count] == 5)
//            {
//                count++;
//                continue;
//            }
//            Console.WriteLine("Current value of element {0} {1}", array[count], array2[count]);
//            count++;
//        }
//        Console.Read();
//    }
//}
#endregion

#region Break
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//        int count = 0;

//        while (array.Length > count)
//        {
//            if (array[count] == 5)
//            {
//                break;
//            }
//            Console.WriteLine("Current value of element {0}", array[count]);
//            count++;
//        }
//        Console.Read();
//    }
//}
#endregion

#region ForEach
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//        ArrayList array2 = new ArrayList { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//        ArrayList array3 = new ArrayList() { "This is a text", 2.22D, 3, true, DateTime.Now, 'B', 7.4f, new Program(), 1m };
//        List<int> array4 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//        foreach (int element in array4)
//        {
//            Console.WriteLine("Current value of element {0}.", element);
//        }
//        int counter = 0;
//        do
//        {
//            Console.WriteLine("Current value of element {0}.", array3[counter]);
//            counter++;
//        } while (counter < array3.Count);
//        Console.Read();
//    }
//}
#endregion

#region For
//class Program
//{
//    static void Main(string[] args)
//    {
//        for (int x = 1; x <= 10; x++)
//        {
//            Console.WriteLine("Counter {0}", x);
//        }
//        Console.Read();
//    }
//}
#endregion

#region While
//class Program
//{
//    static void Main(string[] args)
//    {
//        int x = 1;
//        while (x <= 10)
//        {
//            Console.WriteLine("Counter {0}", x);
//            x++;
//        }
//        Console.Read();
//    }
//}
#endregion

#region DoWhile
//class Program
//{
//    static void Main(string[] args)
//    {
//        int x = 1;
//        do
//        {
//            Console.WriteLine("Counter {0}", x);
//            x++;
//        } while (x <= 10);
//        Console.Read();
//    }
//}
#endregion

#region Switch Cases
//enum Days//enumeration | custom / value type 
//{ //cheat sheet lookalike
//    Sunday = 1,
//    Monday,
//    Tuesday,
//    Wednesday,
//    Thursday,
//    Friday,
//    Saturday //enumerator
//} //enumerator list
//class Program
//{
//    static void Main(string[] args)
//    {
//        Days caseSwitch = Days.Friday;

//        switch (caseSwitch)
//        {
//            case Days.Monday:
//            case Days.Tuesday:
//            case Days.Wednesday:
//            case Days.Thursday:
//                Console.WriteLine("Case Mon-Thurs");
//                break;
//            case Days.Friday:
//            case Days.Saturday:
//                Console.WriteLine("Case Fri-Sat");
//                break;
//            default:
//                Console.WriteLine("Default case ");
//                break;
//        }
//    }
//}
#endregion

#region If Else Else if
//class Program
//{
//    static void Main(string[] args)
//    {
//        int a = 100;
//        if (a > 100){

//        }else if (a > 50){

//        }else{

//        }
//    }
//}
#endregion

#region Enumeration
//enum Days//enumeration | custom / value type 
//{ //cheat sheet lookalike
//    Sunday = 1,
//    Monday,
//    Tuesday,
//    Wednesday,
//    Thursday,
//    Friday,
//    Saturday //enumerator
//} //enumerator list

//class Program
//{
//    static void Main(string[] args)
//    {
//        Days today = Days.Monday;
//        int dayNumber = (int)today;


//Console.ForegroundColor = ConsoleColor.Green;
//        Console.Clear();

//        Console.WriteLine(today);
//        Console.WriteLine((int) today);
//        Console.WriteLine("Hello mars!");
//        Console.Read();
//    }
//}
#endregion

#region List
//class Program
//{
//    static void Main(string[] args)
//    {
//        List<int> genericListA = new List<int>() {1,2,3,4,5,6,7,8,9,0 }; //only int
//        genericListA.Add(100);
//        int a = genericListA[0];
//        genericListA.Remove(1);//data 1
//        genericListA.RemoveAt(0);//remove data from index 0
//        genericListA.RemoveRange(5, 3); //from index 5 then count to 3 times

//        List<string> genericListB = new List<string>(); //only string
//        genericListB.Add("String");
//        string b = genericListB[0];
//    }
//}
#endregion

#region ArrayList
//class Program
//{
//    static void Main(string[] args)
//    {
//        ArrayList arrayListA = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//        ArrayList arrayListB = new ArrayList() { "This is a text", 2.22D, 3, true, DateTime.Now, 'B', 7.4f, new Program(), 1m };

//        arrayListA.Add(20);
//        arrayListB.Add("New");
//        arrayListA.Add(new Dog());

//        int a = (int)arrayListA[0];

//        bool b = (bool)arrayListB[3];
//        DateTime d = (DateTime)arrayListB[4];
//        arrayListA.Remove(1); //remove the data 1
//        arrayListB.RemoveAt(5); //remove the index 5
//        arrayListB.RemoveRange(2,3);

//        var o = arrayListA[1];
//        Console.WriteLine(o);
//        Console.Read();
//    }
//}
//class Dog
//{

//}
#endregion

#region Initialize Array
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] arrayA = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; 
//        int[] arrayB = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//        int[] arrayC;
//        arrayC = new int[] { 0, 2, 4, 6 };

//        string[] arrayD = new string[5]
//        {
//            "hats",
//            "jackets",
//            "shirts",
//            "undies",
//            "pants"
//        };
//        arrayA[0] = 100;
//        arrayA[1] = 200;
//        arrayA[2] = 300;
//        arrayA[3] = 400;
//        arrayA[4] = 500;

//        Console.WriteLine(arrayC[2]); //will display array[0]
//        int x = arrayA[4]; //x = 500
//        Console.Read();
//    }
//}
#endregion

#region TryCatch
//class Program
//{
//    static void Main(string[] args)
//    {
//        try
//        {
//            Console.WriteLine("Enter first number");
//            int addendA = int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter second number");
//            int addendB = int.Parse(Console.ReadLine());
//        }
//        catch (OverflowException caught)
//        {
//            Console.WriteLine(caught.Message);
//        }
//        catch (FormatException caught)
//        {
//            Console.WriteLine(caught);
//        }
//        catch (DivideByZeroException caught)
//        {
//            Console.WriteLine(caught);
//        }
//        catch (Exception caught)
//        {
//            Console.WriteLine(caught);
//        }
//        finally
//        {
//            Console.WriteLine("Finally block is called.");
//        }
//        Console.Read(); //General Class Block
//    }
//}
#endregion

#region Exceptions
//class CustomException : Exception
//{
//    public CustomException(string message)
//    {
//        Console.WriteLine(message);
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        CustomException ex = new CustomException("Custom exception");
//        throw ex;
//    }
//}
#endregion

#region Method Return V3
//class Program
//{
//    static void Main(string[] args)
//    {
//        Car car = Method();
//        car.Color = "Blue";
//        Car newCar = Method();
//        Console.WriteLine(newCar.Color);
//        Console.WriteLine(car.Color);
//        car = newCar;
//        Console.WriteLine(newCar.Color);
//        Console.WriteLine(car.Color);
//        Console.Read();
//    }

//    static Car Method()
//    {
//        return new Car() { Color = "red", Brand = "Jeep", Model = "PUJ" }; //less variable

//        //Car car = new Car() { Color = "red", Brand = "Jeep", Model = "PUJ" };
//        //return car; //Memory address return e.g 100E: Car object
//    }
//}

//class Car
//{
//    public string Color { get; set; }
//    public string Brand { get; set; }
//    public string Model { get; set; }
//}
#endregion

#region Method Return V2
//class Program
//{
//    static void Main(string[] args)
//    {
//        string myString = Method();
//        Console.WriteLine(myString);
//        int returnValue = Console.Read();
//        Console.WriteLine(returnValue);
//        Console.Read();
//    }
//    static string Method()
//    {
//        string s = "This is a sample text.";
//        return s;
//    }
//}
#endregion

#region Pass By Out Parameter
//class Program
//{
//    static void Main(string[] args)
//    {
//        int sampleVariable = 100;
//        SampleClass sampleClass = new SampleClass();
//        sampleClass.SampleMethod(out sampleVariable);
//        Console.WriteLine(sampleVariable);
//        Console.Read();
//    }
//}

//class SampleClass
//{
//    public void SampleMethod(out int parameter)
//    {
//        parameter = 100;
//        parameter++;
//    }
//}
#endregion

#region Pass By Reference Parameter
//class Program
//{
//    static void Main(string[] args)
//    {
//        int sampleVariable = 100;
//        SampleClass sampleClass = new SampleClass();
//        sampleClass.SampleMethod(ref sampleVariable);
//        Console.WriteLine(sampleVariable);
//        Console.Read();
//    }
//}

//class SampleClass
//{
//    public void SampleMethod(ref int parameter)
//    {
//        parameter++;
//    }
//}
#endregion

#region Pass By Value Parameter
//class Program
//{
//    static void Main(string[] args)
//    {
//        int sampleVariable = 100;
//        SampleClass sampleClass = new SampleClass();
//        sampleClass.SampleMethod(sampleVariable);
//        Console.WriteLine(sampleVariable);
//        Console.Read();
//    }
//}

//class SampleClass
//{
//    public void SampleMethod(int parameter)
//    {
//        parameter++;
//    }
//}
#endregion

//pass by value      = in
//pass by reference  = in/out
//pass by out/output = out

#region Method Return
//class MyClass
//{
//    static void Main(string[] args)
//    {
//        int sampleVariable = 100;
//        SampleClass sampleClass = new SampleClass();
//        int returnedValue = sampleClass.SampleMethod(sampleVariable);
//    }
//}
//class SampleClass
//{
//    public int SampleMethod(int parameter)
//    {
//        return parameter + 100;
//    }
//}
#endregion

#region Method Overloading

//class MyClass
//{
//    static void Main(string[] args)
//    {
//        SampleClass sampleClass = new SampleClass();
//        sampleClass.SampleMethod();
//        sampleClass.SampleMethod("This is a sample text");
//        sampleClass.SampleMethod(100, "This is a sample text"); //argument(s) is the inside of these parenthesis
//        Console.WriteLine();
//    }
//}
//class SampleClass
//{
//    public void SampleMethod() { }
//    public void SampleMethod(string parameterA) { }
//    public void SampleMethod(int parameterA, string parameterB) { } //parameter(s) is the inside of these parenthesis
//}
#endregion

#region Method
//class MyClass
//{
//    static void Main(string[] args)
//    {
//        SampleClass sampleClass = new SampleClass();
//        sampleClass.SampleMethodA();
//        sampleClass.SampleMethodB("This is a sample text");
//        sampleClass.SampleMethodC(100, "This is a sample text"); //argument(s) is the inside of these parenthesis
//    }
//}
//class SampleClass
//{
//    public void SampleMethodA() { }
//    public void SampleMethodB(string parameterA) { }
//    public void SampleMethodC(int parameterA, string parameterB) { } //parameter(s) is the inside of these parenthesis
//}
#endregion

#region AnonymouseType
//class MyClass
//{
//    static void Main(string[] args)
//    {
//        //Anonymous__234134
//        var car = new
//        {
//            Color = "blue",
//            Brand = "ford",
//            Model = "explorer"
//        };

//        Console.WriteLine(car.Color);
//    }
//}
#endregion

#region Static
//class MyClass
//{
//    static void Main(string[] args)
//    {
//        Car.color = "blue";
//        Car carA = new Car();
//        carA.Brand = "";
//        carA.Model = "";

//        carA.StartEngine();
//        carA.StopEngine();
//        carA.Accelerate();
//        carA.Break();

//        Car carB = new Car();
//        carB.Brand = "";
//        carB.Model = "";

//        #region MultipleInitialize
//        //Car[] toyota = new Car[40];

//        //for (int i = 0; i < toyota.Length; ++i)
//        //{
//        //    toyota[i] = new Car();
//        //}

//        //for (int i = 0; i < toyota.Length; i++)
//        //{
//        //    if (i >= 0 && i <= 10)
//        //    {
//        //        toyota[i].Model = "black";
//        //    }
//        //    else if ( i >= 10 && i <= 20 )
//        //    {
//        //        toyota[i].Model = "pink";
//        //    }
//        //    else
//        //    {
//        //        toyota[i].Model = "blue";
//        //    }
//        //    Console.WriteLine(toyota[i].Model);
//        //}
//        //Console.Read();
//        #endregion
//    }
//}

// class Car
//{
//    public static string color; //all class level have the same value

//    public  string Brand { get; set; }
//    public  string Model { get; set; }
//    public  static string StaticModel { get; set; }

//    public  void StartEngine() { }

//    public void StopEngine()
//    {
//        Model = "New model";
//        Brand = "New Brand";
//        StaticModel = "New static model";
//    }
//    public  void Accelerate() { }
//    public  void Break() { }
//}
#endregion

#region StackHeap
//class MyClass
//{
//    static void Main(string[] args)
//    {
//        Car ivs = new Car() { Color = "pink" };

//        Car ryan = new Car() { Color = "red" };

//        Car jap = ivs;
//    }
//}

//class Car
//{
//    public string Color { get; set; }

//    public void StartEngint() { }
//}
#endregion

#region Nested class
//class Demo
//{
//    static void Main(string[] args)
//    {
//        Vehicle.Car car = new Vehicle.Car() { Color = "pink", Brand = "toyota", Model = "vios" };
//        Vehicle.Truck truck = new Vehicle.Truck() { Color = "pink", Brand = "toyota", Model = "vios" };
//        car.StartEngine();
//        truck.StartEngine();

//    }
//}

//class Vehicle
//{
//    public class Car
//    {
//        public string Color { get; set; }
//        public string Brand { get; set; }   
//        public string Model { get; set; }

//        public void StartEngine() { }
//        public void StopEngine() { }
//    }

//    public class Truck
//    {
//        public string Color { get; set; }
//        public string Brand { get; set; }
//        public string Model { get; set; }

//        public void StartEngine() { }
//        public void StopEngine() { }
//    }

//}
#endregion

#region Destructor
//class Demo
//{
//    static void Main(string[] args)
//    {
//        Car car = new Car();//object
//        Dog dog = new Dog();
//    }
//}

//class Car
//{
//    ~Car()
//    {
//        Console.WriteLine("Car will be destroyed.");
//    }
//}

//class Dog
//{
//    public Dog()
//    {

//    }

//    ~Dog()
//    {
//        Console.WriteLine("Dog will be destroyed.");
//    }
//}
#endregion

#region Initializer
//class Program
//{
//    static void Main(string[] args)
//    {
//        Dog bantay = new Dog { Age = 5 };
//        bantay.Age = 5;
//        bantay.Breed = "Askal";
//        bantay.Color = "Black";

//        Dog brownie = new Dog { Age = 3, Breed = "Chihuahua", Color = "Brown" };

//        Dog salakat = new Dog() { Age = 2, Breed = "Labrador", Color = "Brown" }; //object initializer

//    }
//}

//class Dog
//{
//    public int Age { get; set; }
//    public string Breed { get; set; }
//    public string Color { get; set; }

//    ~Dog()
//    {
//        Console.WriteLine("Object will be destroyed.");
//        Console.Read();
//    }

//    #region Constuctor comments

//    //public Dog()
//    //{

//    //}

//    //public Dog(int age)
//    //{
//    //    Age = age;
//    //}

//    //public Dog(int age, string breed)
//    //{
//    //    Age = age;
//    //    Breed = breed;
//    //}

//    //public Dog(int age, string breed, string color)
//    //{
//    //    Age = age;
//    //    Breed = breed;
//    //    Color = color;
//    //}
//    #endregion

//    public void Bark()
//    {
//        Console.WriteLine("Dog is barking.");
//    }

//    public void Sleep()
//    {
//        Console.WriteLine("Dog is sleeping.");
//    }


//}
#endregion

#region Constructor initializer example

//namespace ConsoleApplication1
//{
//    class Program2
//    {
//        static void Main(string[] args)
//        {
//            //Car carA = new Car("red", "honda", "civic"); //object constructor
//            Car carA = new Car() { Color = "red", Brand = "honda", Model = "civic" }; //object initializer //ganto na mga approach
//            //carA.Color = "red"; //initialize
//            carA.StartEngine();
//            carA.Accelerate();

//            //Car carB = new Car("blue", "toyota", "vios"); //object
//            Car carB = new Car() { Color = "blue", Brand = "toyota", Model = "vios" }; //object initializer //ganto na mga approach
//            carB.StartEngine();
//            carB.StopEngine();

//            //Car carC = new Car("green", "ford", "ford"); //object
//            Car carC = new Car() { Color = "green", Brand = "ford", Model = "fiesta" }; //object initializer //ganto na mga approach
//            carC.StartEngine();
//            carC.Break();

//            Console.Read();
//        }
//    }
//    class Car //blue print
//    {
//        #region Properties
//        public string Color { get; set; }
//        public string Brand { get; set; }
//        public string Model { get; set; }
//        #endregion

//        public const int Speed = 100;

//        //#region Constructor
//        //public Car(string color, string brand, string model) //explicit default constructor
//        //{
//        //    Color = color;
//        //    Brand = brand;
//        //    Model = model;
//        //}
//        //#endregion

//        #region Methods
//        public void StartEngine()
//        {
//            Console.WriteLine("Car engine is starting.");
//        }

//        public void Accelerate()
//        {
//            Console.WriteLine("Car engine is accelerating.");
//        }

//        public void Break()
//        {
//            Console.WriteLine("Car breaks."); 
//        }

//        public void StopEngine()
//        {
//            Console.WriteLine("Car engine is stopping.");
//        }
//        #endregion
//    }
//}
#endregion

