using System;
using System.Collections.Generic;
using System.Text;

namespace StudentandTeacherDetails.Details
{
    abstract class  OverrideInterface : Teacher
    {
        protected string subjectcode1;

        public abstract string GetSubjectCode();
        public abstract void SetValues(string name, string ClassAndSession, string subject);
    }
}
