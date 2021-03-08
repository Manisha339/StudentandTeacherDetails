using System;
using System.Collections.Generic;
using System.Text;

namespace StudentandTeacherDetails.Details
{
    class Subjects: Teacher
    {
        public String Subcode { get; set; }
        

        public override String Get1()
        {
           
            return $"Name: {Name}, Class And Section: {classandsec}, Subject Code: {Subcode}\n";

        }

    }
}
