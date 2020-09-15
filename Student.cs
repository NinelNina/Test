using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Student
    {
        public struct Contacts
        {
            public string Tel { set; get; }
            public string address;
        }

        public class Student
        {
            public string firstName;
            public string lastName;
            public byte age;
            public Contacts contacts;
            public int[] balls = new int[5];
            public double Average { get; private set; }
            public double AverageCalc()
            {
                int sum = 0;
                for(int i = 0; i < 5; i++)
                {
                    sum += balls[i];
                }

                Average = sum / 5;

                return Average;
            }
        }
    }
}
