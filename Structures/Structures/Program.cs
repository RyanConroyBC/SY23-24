using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    internal class Program
    {
        struct pokemon
        {
            public int id;
            public string name;
            public int level;
        }
        struct student
        {
            public string name;
            public int grade;
            public int age;
            public gender gender;
            public decimal GPA;

        }
        struct Holiday
        {
            public string date;
            public string name;
            public day day;
        }
        enum gender  {male, female};
        enum day {Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday}

        static void Main(string[] args)
        {
        pokemon pikachu = new pokemon();
            pikachu.name = "Devon";
            pikachu.level = 1;
            pikachu.id = 1;

            student student = new student();
            student.name = "Devon";
            student.age = 50;
            student.grade = 11;
            student.gender = gender.female;
            student.GPA = 3;

            Holiday holiday = new Holiday();
            holiday.name = "MLK Day";
            holiday.day = day.Monday;

        }
    }
}
