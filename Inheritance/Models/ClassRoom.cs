﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Models
{
    public class ClassRoom
    {
        public string number { get; set; }
        public string  character { get; set; }
        public string FullName() {
            return $"{number}-{character}";
                }
    }
}
