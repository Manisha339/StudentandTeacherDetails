﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StudentandTeacherDetails.Details
{
    class Teacher
    {
        public string Name { get; set; }
        public string classandsec { get; set; }

        public virtual string Get1()
        {
            return $"Name: {Name}, Class And Section: {classandsec}";
        }
    }
}
