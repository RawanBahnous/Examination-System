using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    internal class FinalExam : Exam //Only Shows The Question and Answers . 
    {
        public FinalExam(string subject, TimeSpan timeSpan, int numOfQuestions, Dictionary<Quesion, AnswersList> questionAnswers) : base(subject, timeSpan, numOfQuestions, questionAnswers)
        {
        }

        public override void ShowExam()
        {
            base.ShowExam();
            Console.WriteLine($"Final Exam - Shows only questions and answers.\n\n");
            var count = 1;
            foreach (var q in QuestionAnswers.Keys)
            {
                Console.WriteLine($"Question {count} Header Description: {q.Header}");
                Console.WriteLine($"Question : {q.Body}");
                Console.WriteLine($"Question Mark : {q.Mark}");
                count++;
            }
        }
    }
}
