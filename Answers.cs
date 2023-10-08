﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    internal class Answers
    {
        public string Text { get; set; }
        public bool IsCorrect { get; set; }

        public Answers(string text, bool isCorrect)
        {
            Text = text;
            IsCorrect = isCorrect;
        }

    }
}
