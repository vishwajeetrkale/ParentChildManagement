using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpConceptsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }



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
