using System;
using System.Collections.Generic;
using System.Text;

namespace StudentandTeacherDetails.Details
{
    class Subjects: basicSubject
    {
        public int Maths { get; set; }
        public int English { get; set; }
        public int Science { get; set; }
        public int Social { get; set; }
        public int SecondLanguage { get; set; }

        public Subjects()
        {
            this.Maths = 0;
            this.English = 0;
            this.Science = 0;
            this.Social = 0;
            this.SecondLanguage = 0;
        }
        public override int getTotalMarks()
        {
            return this.Maths + this.English + this.Science + this.Social + this.SecondLanguage;
        }

    }
}
