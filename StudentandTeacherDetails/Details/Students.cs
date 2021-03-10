using System;
using System.Collections.Generic;
using System.Text;

namespace StudentandTeacherDetails.Details
{
    abstract class Students
    {
        protected String Name;
        protected String ClassAndSession;

        public abstract String GetName();
        public abstract String GetClassAndSession();
        public abstract void SetValues(string name, String ClassAndSession);

    }
}
