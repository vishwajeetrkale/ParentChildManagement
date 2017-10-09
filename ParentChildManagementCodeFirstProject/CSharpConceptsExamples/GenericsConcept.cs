using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptsExamples
{
    class GenericsConcept
    {
    }


    // Declare the generic class.
    public class GenericList<T>
    {
        void Add(T input) { }
    }

    class TestGenericList
    {
        private class ExampleClass { }
        //static void Main()
        //{
        //    // Declare a list of type int.
        //    GenericList<int> list1 = new GenericList<int>();

        //    // Declare a list of type string.
        //    GenericList<string> list2 = new GenericList<string>();

        //    // Declare a list of type ExampleClass.
        //    GenericList<ExampleClass> list3 = new GenericList<ExampleClass>();
        //}
    }


    //A generic type uses Type Parameters instead of using hard-coding all the types
    //One area in .Net Framework in which you can see the use of generics is in the support for Nullables.
    //A reference type can have actual value of null, meaning it has no value.
    //A value type can't have a value of null, however.
    //For 


}
