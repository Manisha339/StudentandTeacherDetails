using System;
using System.Collections.Generic;
using System.Text;

namespace StudentandTeacherDetails.Details
{
    abstract class  OverrideInterface : Teacher
    {
        public string SubjectCode1;

        public abstract string GetSubjectCode();
        public abstract void SetValues(string name, string ClassAndSession, string subject);
    }
}
