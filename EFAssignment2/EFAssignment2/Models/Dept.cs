﻿using System;
using System.Collections.Generic;

#nullable disable

namespace EFAssignment2.Models
{
    public partial class Dept
    {
        public Dept()
        {
            Emps = new HashSet<Emp>();
        }

        public int Deptno { get; set; }
        public string Dname { get; set; }
        public string Loc { get; set; }

        public virtual ICollection<Emp> Emps { get; set; }
    }
}
