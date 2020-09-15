﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class CLI
    {
        public static void Welcome()
        {
            Console.WriteLine("*****************");
            Console.WriteLine("* S T U D E N T *");
            Console.WriteLine("*****************");
            Console.WriteLine();

        }
        public static Student InputStudent()
        {
            Console.Write("Введите имя студента - ");
            string firstName = Console.ReadLine();

            Console.Write("Введите фамилию студента - ");
            string lastName = Console.ReadLine();

            Console.Write("Введите дату рождения студента - ");
            DateTime birthday;
            DateTime.TryParse(Console.ReadLine(), out birthday);

            Console.Write("Введите телефон студента - ");
            string tel = Console.ReadLine();

            Console.Write("Введите адрес студента - ");
            string address = Console.ReadLine();

            Console.Write("Введите Y, если необходимо ввести оценки - ");
            string yesNo = Console.ReadLine();
            List<byte> balls = new List<byte>();
            while (yesNo == "Y" || yesNo == "y")
            {
                Console.Write("Введите оценку студента - ");
                byte ball = Convert.ToByte(Console.ReadLine());
                balls.Add(ball);

                Console.Write("Введите Y, если необходимо продолжить ввод оценок - ");
                yesNo = Console.ReadLine();
            }

            Student student = new Student(firstName, lastName, birthday);
            student.contacts.address = address;
            student.contacts.Tel = tel;

            return student;
        }

        public static void OutputStudent(Student student)
        {
            Console.WriteLine("=== Studnet ===");
            Console.WriteLine($"Имя: {student.firstName}");
            Console.WriteLine($"Фамилия: {student.lastName}");
            Console.WriteLine($"Возраст: {student.AgeCalc()}");
            Console.WriteLine($"Дата рождения: {student.birthday.ToString()}");
            Console.WriteLine($"Телефон: {student.contacts.Tel}");
            Console.WriteLine($"Адрес: {student.contacts.address}");
            Console.WriteLine($"Оценки: ");
            foreach (var ball in student.balls)
            {
                Console.Write($"{ball} | ");
            }
            Console.WriteLine();
            Console.WriteLine($"Средняя оценка: {student.AverageCalc()}");
        }
    }
}
