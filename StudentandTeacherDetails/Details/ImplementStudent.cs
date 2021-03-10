using System;
using System.Collections.Generic;
using System.Text;

namespace StudentandTeacherDetails.Details
{
    class ImplementStudent : Students
    {
        public override string GetClassAndSession()
        {
            return ClassAndSession;
        }

        public override string GetName()
        {
            return Name;
        }

        public override void SetValues(string name, string ClassAndSession)
        {
            this.Name = name;
            this.ClassAndSession = ClassAndSession;
        }
    }
}
