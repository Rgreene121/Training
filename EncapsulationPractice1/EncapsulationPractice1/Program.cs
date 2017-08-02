using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Program p = new Program();

            Student s1 = new Student();
            Student s2 = new Student();


            s.IdNumber = 1001;
            s.FirstName = "Rabi";
            s.LastName = "Basir";
            p.ShowStudent(s);
            s.GPA = 5 * 6;

        }
        public void ShowStudent(Student scholar)
        {
            Console.WriteLine($"My Id Number is {scholar.IdNumber} and my name is {scholar.FirstName} and my GPA is {5 * 6}");
            Console.ReadLine();
        }
        
    }
}
