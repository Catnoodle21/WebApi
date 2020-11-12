﻿using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Departments
    {
        public Departments()
        {
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
