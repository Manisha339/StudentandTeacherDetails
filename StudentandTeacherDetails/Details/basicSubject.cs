using System;
using System.Collections.Generic;
using System.Text;

namespace StudentandTeacherDetails.Details
{
    class basicSubject
    {
        protected int totalMarks;
        
        public basicSubject()
        {
            totalMarks = 0;
        }

        public virtual int getTotalMarks()
        {
            return totalMarks;
        }
    }
}
