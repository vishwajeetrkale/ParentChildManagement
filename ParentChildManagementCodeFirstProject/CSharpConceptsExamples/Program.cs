using System;

namespace CSharpConceptsExamples
{
    class Program
    {

        public static void Main(string[] args)
        {
            const int abc = 123;
            int abcd = 1234;

            Console.WriteLine(mystatic.Name);

            mystatic.Name = "abc";

            myabstract.myStaticField = "";

        }


        public struct Point
        {
            public int x,y;

            public static int abc = 400;

            public Point(int p1, int p2)
            {
                x = p1;
                y = p2;
            }
        }


        public static class mystatic
        {
            static mystatic()
            {
                Name = "defName";
            }
            public static string Name;
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
}
