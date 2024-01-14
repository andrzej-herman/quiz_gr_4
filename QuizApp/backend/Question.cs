﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.backend
{
    public class Question
    {
        public int Category { get; set; }
        public string Content { get; set; }
        public List<string> Answers { get; set; } = new List<string>();
    }
}