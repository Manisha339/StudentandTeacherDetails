using System;
using System.Collections.Generic;
using System.Text;

namespace StudentandTeacherDetails.Details
{
    class ImplementProgram
    {
        public static void Do()
        {
            Teacher teacher = new Teacher();
            teacher.Name = " Anitha";
            teacher.classandsec = "XI B";
            Subjects sub1 = new Subjects();
            sub1.Subcode = "Maths-1";

            Teacher teacher1 = new Teacher();
            teacher1.Name = " Saritha";
            teacher1.classandsec = "X A";
            Subjects sub2= new Subjects();
            sub2.Subcode = "Physics-2";

            Teacher teacher2 = new Teacher();
            teacher2.Name = " Gnanesh";
            teacher2.classandsec = "VI B";
            Subjects sub3 = new Subjects();
            sub3.Subcode = "Social";

            Students students = new Students();
            students.Name = "Sai";
            students.classandses1 = "XI B";

            Students students1 = new Students();
            students1.Name = "Druvita";
            students1.classandses1 = "X B";

            Students students2 = new Students();
            students2.Name = "Sree ram";
            students2.classandses1 = "VI A";
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("Student In Class");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("Student Name: " + students.Name + "\nClass And Session: " + students.classandses1 +  "\n");
            Console.WriteLine("Student Name: " + students1.Name + "\nClass And Session: " + students1.classandses1 + "\n");
            Console.WriteLine("Student Name: " + students2.Name + "\nClass And Session: " + students2.classandses1 + "\n");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("Subjects Thought By Teacher");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("Name: "+teacher.Name+"\nClass And Session: "+teacher.classandsec+"\nSubjectCode: "+sub1.Subcode);
            Console.WriteLine("Name: " + teacher1.Name + "\nClass And Session: " + teacher1.classandsec + "\nSubjectCode: " + sub2.Subcode);
            Console.WriteLine("Name: " + teacher2.Name + "\nClass And Session: " + teacher2.classandsec + "\nSubjectCode: " + sub3.Subcode);
            

        }
    }
}
