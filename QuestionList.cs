using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    internal class QuestionList : List<Quesion>
    {

        public int TotalMarks()
        {
            int marks = 0;
            foreach (var question in this)
            {
                marks += question.Mark;
            }
            return marks;
        }
    }
}
