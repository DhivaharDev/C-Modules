using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    
    class Program
    { 
        private static void print (int c)
        {
            Console.WriteLine("the result  is {0}",c);
        }
        static void Main(string[] args)    
        {
            Console.WriteLine("Dhivahar");
            //math m = new math();
            //int result = m.division(10, 2);
            //print(result);

            //print(0);

            MyStaticClass.myStaticVariable = 100;

            MyStaticClass.MyStaticProperty = 200;

            MyStaticClass.myStaticVariable = 300;

            MyStaticClass.MyStaticProperty = 400;
            
            Console.ReadKey();
        }

        public static class MyStaticClass
        {
            static MyStaticClass()
            {
                Console.WriteLine("Inside static constructor.");
            }
            public static int myStaticVariable = 0;

            public static void myStaticMethod()
            {
                Console.WriteLine("This is static method.");
            }

            public static int MyStaticProperty { get; set; }

        }
    }

    class math :validate
    {
        public int division  (int a,int b)
        {
            if(!IsZero(b))
            {
                return a / b;
            }
            return 0;
        }
    }

    class validate
    {
        protected  Boolean IsZero(Decimal num )
        {
           
            if(num ==0)
            {
                Console.WriteLine("num true:" + num);
                return true;
            }
            return false;
        }
    }
        

}
