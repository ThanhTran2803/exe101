﻿using System;
using System.Collections.Generic;

namespace EXE101.DataAccess
{
    public partial class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
