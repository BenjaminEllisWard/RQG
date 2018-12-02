﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RQG.Models
{
    public class Question
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string Answer { get; set; }
        public string Category { get; set; }
    }
}
