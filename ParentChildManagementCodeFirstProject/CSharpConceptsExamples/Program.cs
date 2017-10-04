using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new BaseClass();
            DerivedClass dc = new DerivedClass();
            BaseClass bcdc = new DerivedClass();

            bc.Method1();
            dc.Method1();
            dc.Method2();
            bcdc.Method1();


            BaseC bac = new BaseC();
            DerivedC dec = new DerivedC();
            BaseC badec = new DerivedC();
            badec.Invoke
        }
        // Output:  
        // Base - Method1  
        // Base - Method1  
        // Derived - Method2  
        // Base - Method1
        //temp change
        //one more temp change
    }
}
