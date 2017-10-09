using System;

namespace CSharpConceptsExamples
{
    class ExplicitAndImplicitInterfaces
    {
        interface IDal
        {
            void Add();
            void Update();
        }

        public class Person : IDal
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public void Add()
            {
                throw new NotImplementedException();
            }

            public void Update()
            {
                throw new NotImplementedException();
            }
        }



        public class PersonExplicit : IDal
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            void IDal.Add()
            {
                throw new NotImplementedException();
            }

            void IDal.Update()
            {
                throw new NotImplementedException();
            }
        }



    }
}
