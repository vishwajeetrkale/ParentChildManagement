using ParentChildManagementCodeFirstProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ParentChildManagementCodeFirstProject
{
    public class MyClassInheritingBaseClass
    {
        public virtual string name { get; set; }

        private const string productName = "PCManagement";

        public const double gravitationlConstant = 6.673e-11;

        const int x = 0;

        public int CalculateChildExpenses(List<ChildDetail> childs)
        {
            const double pi = 3.14;
            return (int)pi;
            //Business logic
            //The area of a circle is:
            //π(Pi) times the Radius squared:	A = π r2
            //or, when you know the Diameter:	A = (π/4) × D2
            //or, when you know the Circumference:	A = C2 / 4π


            //The Pythagorean Theorem
            //If a and b are the lengths of the legs of a right triangle 
            //and c is the length of the hypotenuse, 
            //then the sum of the squares of the lengths of the legs 
            //is equal to the square of the length of the hypotenuse.
            //This relationship is represented by the formula: a² + b² = c²

            



        }

    }
}