using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptsExamples
{
    class WhenToUseOverrideAndNewKeywords
    {
    }

    class BaseClass
    {
        public void Method1()
        {
            Console.WriteLine("Base - Method1");
        }
    }

    class DerivedClass : BaseClass
    {
        public void Method2()
        {
            Console.WriteLine("Derived - Method2");
        }
    }

    public class BaseC
    {
        public int x;
        public virtual void Invoke() { }
    }

    public class DerivedC : BaseC
    {
        public override void Invoke() { }
    }

}
