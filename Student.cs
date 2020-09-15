using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
        
    public struct Contacts
    {
        public string Tel { set; get; }
        public string address;
    }

    public class Student
    {

        public readonly string firstName;
        public readonly string lastName;
        public readonly DateTime birthday;
        public byte Age { get; private set; }
        public Contacts contacts;
        public List<byte> balls;
        public double Average { get; private set; }

        public Student(string firstName, string lastName, DateTime birthday)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthday = birthday;
        }

        public double AverageCalc()
            {
                int sum = 0;
                for(int i = 0; i < 5; i++)
                {
                    sum += balls[i];
                }
                //balls.Average();

                Average = sum / 5;

                return Average;
            }
            public byte AgeCalc()
            {

                return Age;
            }
        }
    
}
