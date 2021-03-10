using System;
using System.Collections.Generic;
using System.Text;

namespace StudentandTeacherDetails.Details
{
    class ImplementProgram
    {
        public static void Do()
        {
            Console.WriteLine("Students In Class");
            Console.WriteLine("-------------------------------------------------------");
            ImplementStudent st1 = new ImplementStudent();
            st1.SetValues("Sai", "XI B");
            Console.WriteLine("Student Name: " + st1.GetName() + "\nClass And Session: " + st1.GetClassAndSession());
            ImplementStudent st2 = new ImplementStudent();
            st2.SetValues("Druvita", "X B");
            Console.WriteLine("Name: " + st2.GetName() + "\nClass And Session: " + st2.GetClassAndSession());
            ImplementStudent st3 = new ImplementStudent();
            st3.SetValues("Sree ram", "VI A");
            Console.WriteLine("Name: " + st3.GetName() + "\nClass And Session: " + st3.GetClassAndSession());

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Subjects Thought By Teacher");
            Console.WriteLine("-------------------------------------------------------");
            ImplementTeacher tea1 = new ImplementTeacher();
            tea1.SetValues("Anitha", "XI B", "Maths-1");
            Console.WriteLine("Name: " + tea1.GetName() + "\nClass And Session: " + tea1.GetClassAndSession()+"\nSubject code: "+tea1.GetSubjectCode());
            ImplementTeacher tea2 = new ImplementTeacher();
            tea2.SetValues("Saritha", "X A", "Physics-2");
            Console.WriteLine("Name: " + tea2.GetName() + "\nClass And Session: " + tea2.GetClassAndSession() + "\nSubject code: " + tea2.GetSubjectCode());
            ImplementTeacher tea3 = new ImplementTeacher();
            tea3.SetValues("Gnanesh", "VI B", "Social-3");
            Console.WriteLine("Name: " + tea3.GetName() + "\nClass And Session: " + tea3.GetClassAndSession() + "\nSubject code: " + tea3.GetSubjectCode());
        }
    }
}
