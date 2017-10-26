using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace CSharpConceptsExamples
{
    class Program
    {
        const string disallowed = "file";

        public static void Main1()
        {
            IEnumerable<int> powersOf2 = PowersOf2.Power(2, 8);
            // Display powers of 2 up to the exponent of 8:
            foreach (int i in powersOf2)
            {
                Console.Write("{0} ", i);
            }

            string a1, a2;
            int i1, i2;

            i1 = 1;
            i2 = i1;
            i2 = 2;
            Console.WriteLine("i1:" + i1 + ", i2:" + i2);
            ProcInt(i2);
            Console.WriteLine("i1:" + i1 + ", i2:" + i2);

            a1 = "ABC";
            a2 = a1; //This should assign a1 reference to a2
            a2 = "XYZ";  //I expect this should change the a1 value to "XYZ"

            Console.WriteLine("a1:" + a1 + ", a2:" + a2);//Outputs a1:ABC, a2:XYZ
            //Expected: a1:XYZ, a2:XYZ (as string being a ref type)

            Proc(a2); //Altering values of ref types inside a procedure 
                      //should reflect in the variable thats being passed into

            Console.WriteLine("a1: " + a1 + ", a2: " + a2); //Outputs a1:ABC, a2:XYZ
            //Expected: a1:NEW_VAL, a2:NEW_VAL (as string being a ref type)

            Person P = new Person();
            P.Name = "ABC";
            Proc(P.Name);
            Console.WriteLine(P.Name);

            //When we now call the following code:
            double x = 0;
            Func(x);
            Console.WriteLine(x);
            //The result printed to the console is '0'.

            //when we now call following code:
            string s = "s";
            FuncS(s);
            Console.WriteLine(s);
            //The result printed to the console is '0'.
            Console.ReadLine();
        }


        public class PowersOf2
        {
            //static void Main()
            //{
            //    // Display powers of 2 up to the exponent of 8:
            //    foreach (int i in Power(2, 8))
            //    {
            //        Console.Write("{0} ", i);
            //    }
            //}

            public static IEnumerable<int> Power(int number, int exponent)
            {
                int result = 1;

                for (int i = 0; i < exponent; i++)
                {
                    result = result * number;
                    yield return result;
                }
            }

            // Output: 2 4 8 16 32 64 128 256
        }

        static void Func(double d)
        {
            d = 123;
        }

        static void FuncS(string d)
        {
            d = "vish";
        }


        static void Proc(string Val)
        {
            Val = "NEW_VAL";
        }

        static void ProcInt(int Val)
        {
            Val = 3;
        }

    }


    class Person
    {
        public string Name { get; set; }

    }





    //IsAccessAllowed(@"FILE:\\\c:\users\user001\documents\FinancialInfo.txt");

    //private static void IsAccessAllowed(String resource)
    //{
    //    CultureInfo[] cultures = { CultureInfo.CreateSpecificCulture("en-US"),
    //        CultureInfo.CreateSpecificCulture("tr-TR") };
    //    String scheme = null;
    //    int index = resource.IndexOfAny(new Char[] { '\\', '/' });
    //    if (index > 0)
    //        scheme = resource.Substring(0, index - 1);

    //    // Change the current culture and perform the comparison.
    //    foreach (var culture in cultures)
    //    {
    //        Thread.CurrentThread.CurrentCulture = culture;
    //        Console.WriteLine("Culture: {0}", CultureInfo.CurrentCulture.DisplayName);
    //        Console.WriteLine(resource);
    //        Console.WriteLine("Access allowed: {0}", 
    //            !String.Equals(disallowed, scheme, StringComparison.CurrentCultureIgnoreCase));
    //        Console.WriteLine();
    //    }
    //}

    // The example displays the following output:
    //       Culture: English (United States)
    //       FILE:\\\c:\users\user001\documents\FinancialInfo.txt
    //       Access allowed: False
    //       
    //       Culture: Turkish (Turkey)
    //       FILE:\\\c:\users\user001\documents\FinancialInfo.txt
    //       Access allowed: True





    //public static void Main(string[] args)
    //{


    //    Random rnd = new Random();

    //    string str = String.Empty;
    //    StreamWriter sw = new StreamWriter(@".\StringFile.txt",
    //                         false, Encoding.Unicode);

    //    for (int ctr = 0; ctr <= 1000; ctr++)
    //    {
    //        str += Convert.ToChar(rnd.Next(1, 0x0530));
    //        if (str.Length % 60 == 0)
    //            str += Environment.NewLine;
    //    }
    //    sw.Write(str);
    //    sw.Close();

    //    StringBuilder sb = new StringBuilder();
    //    sw = new StreamWriter(@".\StringFile.txt",
    //                                       false, Encoding.Unicode);

    //    for (int ctr = 0; ctr <= 1000; ctr++)
    //    {
    //        sb.Append(Convert.ToChar(rnd.Next(1, 0x0530)));
    //        if (sb.Length % 60 == 0)
    //            sb.AppendLine();
    //    }
    //    sw.Write(sb.ToString());
    //    sw.Close();

    //}

    //private static void SetName(string name)
    //{
    //    name = "Vishwajeet";
    //}




    //Person p = new Person();
    //p.Name = "Kale";
    //SetName(p.Name);
    //Console.WriteLine(p.Name);

    //string name = "MainName";
    //SetName(name);
    //Console.WriteLine(name);





    public struct Point
    {
        public int x, y;

        public static int abc = 400;

        public Point(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }


    public abstract class myabstract
    {
        private string _name;

        const string myConst = "myConstInAbstract";

        public static string myStaticField = "myStaticFieldInAbstract";


        public myabstract(string name)
        {
            _name = name;
        }
    }



    //System.Console.WriteLine("How many strings you want to check? \n");

    //        int numberOfStrings = Convert.ToInt32(Console.ReadLine());

    //string[] inputStringsArray = new string[numberOfStrings];

    //        for (int index = 0; index<numberOfStrings; index++)
    //        {
    //            inputStringsArray[index] = System.Console.ReadLine();
    //        }

    //        for (int i = 0; i<inputStringsArray.Length; i++)
    //        {
    //            if (StringIsComplete(inputStringsArray[i]))
    //                Console.WriteLine("YES");
    //            else
    //                Console.WriteLine("NO");
    //        }
    //        Console.ReadLine();

    //private static bool StringIsComplete(string inputString)
    //{
    //    return true;
    //}



    //Add below statements into the Main method to check struct
    //Point p = new Point();
    //Console.WriteLine(p.x);
    //    Console.WriteLine(p.y);
    //    p.x = 1;
    //    p.y = 2;
    //    Console.WriteLine(p.x);
    //    Console.WriteLine(p.y);

    //    Point b = new Point(10, 20);
    //Console.WriteLine(b.x);
    //    Console.WriteLine(b.y);

    //    Point a;
    //a.x = 1;
    //    a.y = 2;
    //    Console.WriteLine(a.x);
    //    Console.WriteLine(a.y);
    //    Console.ReadLine();


    //static void Main(string[] args)
    //{
    //    BaseClass bc = new BaseClass();
    //    DerivedClass dc = new DerivedClass();
    //    BaseClass bcdc = new DerivedClass();

    //    bc.Method1();
    //    dc.Method1();
    //    dc.Method2();
    //    bcdc.Method1();


    //    BaseC bac = new BaseC();
    //    DerivedC dec = new DerivedC();
    //    BaseC badec = new DerivedC();
    //    badec.Invoke
    //}
    // Output:  
    // Base - Method1  
    // Base - Method1  
    // Derived - Method2  
    // Base - Method1
    //temp change
    //one more temp change
}