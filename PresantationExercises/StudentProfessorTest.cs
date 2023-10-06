using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresantationExercises
{
    public class StudentProfessorTest
    {
        public static void Main()
        {
            Person person = new Person();
            person.Greet();

            Student student = new Student();
            student.SetAge(19);
            student.Greet();
            student.ShowAge();

            Professor professor = new Professor();
            professor.SetAge(45);
            professor.Greet();
            professor.Explain();
        }
    }
}
