using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.Linq;
=======
>>>>>>> 6bac00d96c360a70e0a2ce5504cf056db69abf0c

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
<<<<<<< HEAD
            //Person p = new Person();
            //p.Name = "Kale";
            //p.SetName();
            //Console.WriteLine(p.Name);

            Name = "Kale";
            SetName();
            Console.WriteLine(Name);

        }

        public static string Name { get; set; }

        public static void SetName()
        {
            Name = "Vishwajeet";
=======
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
>>>>>>> 6bac00d96c360a70e0a2ce5504cf056db69abf0c
        }



<<<<<<< HEAD
=======













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
>>>>>>> 6bac00d96c360a70e0a2ce5504cf056db69abf0c
    }

    class Person
    {
        public string Name { get; set; }

        public void SetName()
        {
            Name = "Vishwajeet";
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
