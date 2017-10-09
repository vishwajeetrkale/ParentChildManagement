//The .Net Framework has a few interfaces that you can use on your own types.
//When implementing those interfaces, your classes can be used in the infrastructure that the .Net Framework offers

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConceptsExamples
{
    class ImplementingStdDNetFrmwrkInterfaces
    {

        //IComparable
        //The IComaparable interface features a single method, as shown below
        public interface IComparable
        {
            int CompareTo(object obj);
        } 

        //This interface is used to sort elements. The CompareTo method returns an int value that shows how two
        //elements are related.

        class order : IComparable
        {
            public DateTime Created { get; set; }

            int IComparable.CompareTo(object obj)
            {
                throw new NotImplementedException();
            }

            //public int CompareTo(object obj)
            //{
            //    throw new NotImplementedException();
            //}
        }



        class Person
        {
            public Person(string firstname, string lastname)
            {
                FirstName = firstname;
                LastName = lastname;
            }

            public string FirstName { get; private set; }
            public string LastName { get; private set; }

            public override string ToString()
            {
                return FirstName + " " + LastName;
            }
        }

        class People : IEnumerable<Person>
        {
            public People(Person[] people)
            {
                this.people = people;
            }

            Person[] people;

            public IEnumerator<Person> GetEnumerator()
            {
                for (int index = 0; index < people.Length; index++)
                {
                    yield return people[index];
                    //Notice the yield return in the GetEnumerator function.
                    //Yield is a special keyward that can be used only in the context of iterators.
                    //It instructs the compiler to convert this regular code to state machine.
                }
            }
            //The generated code keeps track of where you are in the collection and it implements
            //methods such as MoveNext and Current.

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

    }
}
