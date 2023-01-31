﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDomain.Entity
{
    public class User
    {
        public int Id { get; set; }
        public Role Role { get; set; }
        public string? Name { get; set; }

        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public double? Balance { get; set; }
    }
}