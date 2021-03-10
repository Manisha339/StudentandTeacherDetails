using System;
using System.Collections.Generic;
using System.Text;

namespace StudentandTeacherDetails.Details
{
    class ImplementProgram
    {
        public static void Do()
        {
            Console.WriteLine("----------------------Student Details-------------------------");
            ImplementStudent st1 = new ImplementStudent();
            st1.SetValues("Jithin Allu", "VIII B");
            Console.WriteLine("Name: " + st1.GetName() + "  Class And Session: " + st1.GetClassAndSession());
            ImplementStudent st2 = new ImplementStudent();
            st2.SetValues("Naresh Babu", "VI B");
            Console.WriteLine("Name: " + st2.GetName() + "  Class And Session: " + st2.GetClassAndSession());
            ImplementStudent st3 = new ImplementStudent();
            st3.SetValues("Jamuna", "XI A");
            Console.WriteLine("Name: " + st3.GetName() + "  Class And Session: " + st3.GetClassAndSession());


            Console.WriteLine("----------------------Teacher Details-------------------------");
            ImplementTeacher tea1 = new ImplementTeacher();
            tea1.SetValues("Ramu", "VII B", "Maths-01");
            Console.WriteLine("Name: " + tea1.GetName() + "  Class And Session: " + tea1.GetClassAndSession()+"Subject code: "+tea1.GetSubjectCode());
            ImplementTeacher tea2 = new ImplementTeacher();
            tea2.SetValues("Ramu", "VII B", "Maths-01");
            Console.WriteLine("Name: " + tea2.GetName() + "  Class And Session: " + tea2.GetClassAndSession() + "Subject code: " + tea2.GetSubjectCode());
            ImplementTeacher tea3 = new ImplementTeacher();
            tea3.SetValues("Ramu", "VII B", "Maths-01");
            Console.WriteLine("Name: " + tea3.GetName() + "  Class And Session: " + tea3.GetClassAndSession() + "Subject code: " + tea3.GetSubjectCode());
        }
    }
}
