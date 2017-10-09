using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptsExamples
{
    class WK_FirstTest
    {
        //public static void Main()
        //{

        //}
    }

    class myProgram
    {
        public static void MyMain()
        {
            int n1 = 4;
            int n2 = 2;

            UseByRefByVal A = new UseByRefByVal();
            int result = A.addition(ref n1, ref n2);
        }
    }

    class UseByRefByVal
    {
        int number1 = 5;
        int number2 = 10;
        
        public int addition(ref int n1, ref int n2)
        {
            return n1 + n2;
        }

    }
}
