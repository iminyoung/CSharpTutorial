//using Avanade.Cebu;
//using Avanade.Manila;
//using BigBox;
//using System;

//namespace ConsoleApplication1
//{
//    class Program
//    {
//        //static void Main(string[] args)
//        //{
//        //    Console.WriteLine("");
//        //    MediumBox.SmallBox();
//        //    //AppdevCebu.MethodA();
//        //    //AppdevManila.MethodA();
//        //    Console.Read();
//        //}
//    }
//}

//namespace BigBox
//{
//    class MediumBox
//    {
//        public static void SmallBox()
//        {
//            //Currency unitedstatesCurrency = new Currency("USD", "$"); //with constructor
//            Currency unitedstatesCurrency = new Currency(); //without constructor

//            //unitedstatesCurrency.currencyCode = "USD"; //set variable public
//            //unitedstatesCurrency.SetCurrencyCode("USD"); //set method private
//            unitedstatesCurrency.CurrencyCode = "USD"; //set property method private

//            //unitedstatesCurrency.currencySymbol = "$"; //set variable public 
//            //unitedstatesCurrency.SetCurrencySymbol("$"); //set method private 
//            unitedstatesCurrency.CurrencySymbol = "$"; //set property method private

//            //Console.WriteLine(unitedstatesCurrency.GetCurrencyCode()); //get method
//            //Console.WriteLine(unitedstatesCurrency.GetCurrencySymbol()); //get method
//            Console.WriteLine(unitedstatesCurrency.CurrencyCode);
//            Console.WriteLine(unitedstatesCurrency.CurrencySymbol);
//        }
//    }
//    class Currency
//    {

//        string currencyCode; //implicitly private
//        private string currencySymbol; //explicitly private

//        //automatic property
//        public string CurrencySymbol { get; set; } //shortcut approach property
//        public string CurrencyCode { get; set; } //shortcut approach property

//        //not automatic property
//        //public string CurrencyCode //longcut approach property
//        //{
//        //    get { return currencyCode; } //get property
//        //    set { currencyCode = value; } //set propert
//        //}   
//        //public string CurrencySymbol
//        //{
//        //    get { return currencySymbol; } //get property
//        //    set { currencySymbol = value; } //set property
//        //}
//        //public string GetCurrencyCode() //get method
//        //{
//        //    return currencyCode;
//        //}
//        //public void SetCurrencyCode(string code)
//        //{
//        //    currencyCode = code;
//        //} //set method
//        //public string GetCurrencySymbol()
//        //{
//        //    return currencySymbol;
//        //} //get method
//        //public void SetCurrencySymbol(string symbol) //set method
//        //{
//        //    currencySymbol = symbol;
//        //}
//        //public string currencyCode;
//        //public string currencySymbol;
//        //public Currency(string code, string symbol) //constructor
//        //{
//        //    currencyCode = code;
//        //    currencySymbol = symbol;
//        //}
//    }
//}

//namespace GroupOne
//{
//    class ClassA
//    {
//        public static void MethodA()
//        {

//        }
//    }
//    class ClassB
//    {
//        public static void MethodA()
//        {

//        }
//    }
//}

//namespace Avanade
//{
//    namespace Manila
//    {
//        class AppdevManila
//        {
//            public static void MethodA()
//            {

//            }
//        }
//        struct Car
//        {

//        }
//    }

//    namespace Cebu
//    {
//        class AppdevCebu //reference type class
//        {
//            public static void MethodA()
//            {
//                Currency philippineCurrency = new Currency("P", "PHP"); //custom
//                Console.WriteLine(philippineCurrency.currencySymbol);
//                Console.WriteLine(philippineCurrency.currencyCode);
//                Currency japanCurrency = new Currency("Y", "JPY"); //custom
//                Console.WriteLine(japanCurrency.currencySymbol);
//                Console.WriteLine(japanCurrency.currencyCode);
//            }
//        }
//        struct Currency //value type structure
//        {
//            public string currencySymbol; //field
//            public string currencyCode; //field

//            public Currency(string symbol, string code)
//            {
//                currencySymbol = symbol;
//                currencyCode = code;
//            }
//            public void Method()
//            {

//            }
//        }
//    }
//}