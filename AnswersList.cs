using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    internal class AnswersList:List<Answers>
    {


        public List<Answers> CorrectAnswrs() {
        
            return this.Where(answers=>answers.IsCorrect).ToList();
        }
    }
}
