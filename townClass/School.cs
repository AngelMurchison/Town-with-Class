using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace town
{
public class School : Building
    {
        public School(string buildingtype):base(buildingtype) { }
  
        public int NumberofStudents { get; set; }
        public bool InSession { get; set; }
        public int NumberofTeachers { get; set; }

        public string DisplayName()
        {
            return $"{Name}";
        }

        public override string ToString()
        {
            return $"{BuildingType}: {Name}";
        }

        int GCD(int[] args)
        {
            return args.Aggregate((gcd, arg) => GCD(gcd, arg));
        }

        void Simplify(int[] numbers)
        {
            int gcd = GCD(numbers);
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] /= gcd;
        }
        int GCD(int a, int b)
        {
            while (b > 0)
            {
                int rem = a % b;
                a = b;
                b = rem;
            }
            return a;
        }

        public string teacherToStudentRatio(int a, int b)
        {
           int gcd = GCD(a, b);
            int teacher = a / gcd;
            int student = b / gcd;
            return $"{teacher}:{student}";
        }

        static void Main(string[] args)
        {
            int teachers = 40;
            int students = 5;
            string ratio = "";
            School TIY = new School(ratio);
            Console.WriteLine(TIY.teacherToStudentRatio(teachers, students));
            Console.ReadLine();
                 
        }
    }
}
