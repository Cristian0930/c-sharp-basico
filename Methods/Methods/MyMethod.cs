using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class MyMethod
    {
        // MyMethods
        public void IntegerAddition(int a, int b)
        {
            int Addition = a + b;
            Console.WriteLine("El resultado es " + Addition);
        }

        public int IntegerMultiplication(int a, int b)
        {
            int Multiplication = a * b;
            return Multiplication;
        }

        public float FloatDivision(float a, float b)
        {
            float Division = a / b;
            return Division;
        }
    }
}
