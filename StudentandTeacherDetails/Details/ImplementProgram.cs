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
            teacher.Address = " Mumbai";
            teacher.Age = "45";
            teacher.subject = "Maths";

            Teacher teacher1 = new Teacher();
            teacher1.Name = " Saritha";
            teacher1.Address = " Andhra";
            teacher1.Age = "47";
            teacher1.subject = "science";

            Teacher teacher2 = new Teacher();
            teacher2.Name = "Ramu ";
            teacher2.Address = " Chennai";
            teacher2.Age = "35";
            teacher2.subject = "Social";

            Teacher teacher3 = new Teacher();
            teacher3.Name = "Ram ";
            teacher3.Address = " Chennai";
            teacher3.Age = "39";
            teacher3.subject = "SecondLanguage";

            Teacher teacher4 = new Teacher();
            teacher4.Name = "Roy ";
            teacher4.Address = " Hydrabad";
            teacher4.Age = "37";
            teacher4.subject = "English";

            Students students = new Students();
            students.Name = "Sai";
            students.Address = " Chennai";
            students.Grade = " X";

            Students students1 = new Students();
            students1.Name = "Druvita";
            students1.Address = " pune";
            students1.Grade = " IX";

            Students students2 = new Students();
            students2.Name = "Sree ram";
            students2.Address = " Delhi";
            students2.Grade = " XI";

            Subjects s1 = new Subjects();
            s1.Maths = 94;
            s1.Science = 64;
            s1.SecondLanguage = 76;
            s1.Social = 87;
            s1.English = 66;

            Subjects s2 = new Subjects();
            s2.Maths = 84;
            s2.Science = 77;
            s2.SecondLanguage = 56;
            s2.Social = 82;
            s2.English = 96;

            Subjects s3 = new Subjects();
            s3.Maths = 45;
            s3.Science = 74;
            s3.SecondLanguage = 88;
            s3.Social = 75;
            s3.English = 63;
            Console.WriteLine("Teacher Details:\n");
            Console.WriteLine("Name: " + teacher.Name + "\nAddress: " + teacher.Address + "\nAge: " + teacher.Age + "\nSubject: " + teacher.subject+"\n");
            Console.WriteLine("Name: " + teacher1.Name + "\nAddress: " + teacher1.Address + "\nAge: " + teacher1.Age + "\nSubject: " + teacher1.subject + "\n");
            Console.WriteLine("Name: " + teacher2.Name + "\nAddress: " + teacher2.Address + "\nAge: " + teacher2.Age + "\nSubject: " + teacher2.subject + "\n");
            Console.WriteLine("Name: " + teacher3.Name + "\nAddress: " + teacher3.Address + "\nAge: " + teacher3.Age + "\nSubject: " + teacher3.subject + "\n");
            Console.WriteLine("Name: " + teacher4.Name + "\nAddress: " + teacher4.Address + "\nAge: " + teacher4.Age + "\nSubject: " + teacher4.subject + "\n");
            Console.WriteLine("Student Details:\n");
            Console.WriteLine("Student Name: " + students.Name + "\nAddress " + students.Address + "\nGrade " + students.Grade + "\nMarks Obtained: " + s1.getTotalMarks() + "\n");
            Console.WriteLine("Student Name: " + students1.Name + "\nAddress " + students1.Address + "\nGrade " + students1.Grade + "\nMarks Obtained: " + s2.getTotalMarks() + "\n");
            Console.WriteLine("Student Name: " + students2.Name + "\nAddress " + students2.Address + "\nGrade " + students2.Grade + "\nMarks Obtained: " + s3.getTotalMarks() + "\n");

            
        }
    }
}
