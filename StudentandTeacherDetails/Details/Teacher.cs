﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StudentandTeacherDetails.Details
{
    abstract class Teacher
    {
        protected String Name;
        protected String ClassAndSession;

        public abstract String GetName();
        public abstract String GetClassAndSession();
        
    }
}
