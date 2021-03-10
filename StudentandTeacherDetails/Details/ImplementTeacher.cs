using System;
using System.Collections.Generic;
using System.Text;

namespace StudentandTeacherDetails.Details
{
    class ImplementTeacher : OverrideInterface
    {
        public string SubjectCode1 { get; private set; }

        public override string GetClassAndSession()
        {
            return ClassAndSession;
        }

        public override string GetName()
        {
            return Name;
        }
        public override string GetSubjectCode()
        {
            return subjectcode1;
        }

        public override void SetValues(string name, string ClassAndSession, string subject)
        {
            this.Name = name;
            this.ClassAndSession = ClassAndSession;
            this.SubjectCode1 = subject;
        }
    }
}
