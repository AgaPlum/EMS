using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesTesting
{
    public delegate string MyDelegate(int arg1, int arg2);
    //composable delegate
    public delegate void MyDelegate1(int arg1, int arg2);
    //composable delegate with references
    public delegate void MyDelegate2(int arg1, ref int arg2);
    class DelegateTest
    {
        public string instanceMethod1(int i, int s)
        {
            return ((i + s) * i).ToString();
        }
    }
    class Program
    {
        static string function1(int i, int s)
        {
            return (i * s).ToString();
        }
        static string function2(int i, int s)
        {
            return (i + s).ToString();
        }
        static void function4(int i, int s)
        {
            Console.WriteLine(i+s);
        }
        static void function5(int i, int s)
        {
            string result = (i * s).ToString();
            Console.WriteLine(result);
        }
        static void function6(int i, ref int s)
        {
            string result = (i + s).ToString();
            s += 10;
            Console.WriteLine(result);
        }
        static void function7(int i, ref int s)
        {
            string result = (i + s).ToString();
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            
            //delegates
            Console.WriteLine("==============Test of delegates==============");
            MyDelegate f = function1;
            Console.WriteLine(f(3, 9));
            f = function2;
            Console.WriteLine(f(4, 3));
            f = new DelegateTest().instanceMethod1;
            Console.WriteLine(f(4, 4));

            //anonymous delegates
            Console.WriteLine("==============Test of anonymous delegates==============");
            f = delegate(int i, int s)
            {
                return (i + s).ToString();
            };
            Console.WriteLine(f(4, 5));

            //Composable delegates
            Console.WriteLine("==============Test of Composable delegates==============");
            MyDelegate1 f1 = function4;
            MyDelegate1 f2 = function5;
            MyDelegate1 f3 = f1 + f2;

            Console.WriteLine("Function4:");
            f1(3, 4);
            Console.WriteLine("Function5:");
            f2(5, 4);
            Console.WriteLine("Function4+Function5:");
            f3(1,2);
            Console.WriteLine("Functio4 and 5 after remove Function4:");
            f3 -= f1;
            f3(1, 2);

            //Composable delegates with references

            Console.WriteLine("==============Test of Composable delegates with references==============");
            int a = 10, b = 10;
            MyDelegate2 f4 = function6;
            MyDelegate2 f5 = function7;
            MyDelegate2 f6 = f4 + f5;
            Console.WriteLine("Value of b is {0}",b);
            f6(a, ref b);
            Console.WriteLine("Value of b is {0}", b);
            f6(a, ref b);
           
            string option;
            do
            {
                Console.WriteLine("What is the destination zone?");
                option = Console.ReadLine();
                if (option.Equals("exit") == false)
                {
                    Console.WriteLine("What is the item price?");
                    double itemPrice = Double.Parse(Console.ReadLine());
                    Fee f;
                    switch (option)
                    {
                        case "zone1":
                            f = new Challenge().Zone1;
                            Console.WriteLine("The shiping fees are:{0}", f(itemPrice));
                            break;
                        case "zone2":
                            f = new Challenge().Zone2;
                            Console.WriteLine("The shiping fees are:{0}", f(itemPrice));
                            break;
                        case "zone3":
                            f = new Challenge().Zone3;
                            Console.WriteLine("The shiping fees are:{0}", f(itemPrice));
                            break;
                        case "zone4":
                            f = new Challenge().Zone4;
                            Console.WriteLine("The shiping fees are:{0}", f(itemPrice));
                            break;
                    }
                }
            } while (option.Equals("exit")==false);
            Console.ReadKey();
        }
    }
}
