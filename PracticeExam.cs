using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    internal class PracticeExam : Exam //show the right answers after finishing the exam
    {
        public PracticeExam(string subject,TimeSpan timeSpan, int numOfQuestions, 
            Dictionary<Quesion, AnswersList> questionAnswers) 
            : base(subject, timeSpan, numOfQuestions, questionAnswers)
        {
        }
        

        public override void ShowExam()
        {
            base.ShowExam();
            Console.WriteLine($"Practice Exam - Shows  questions and right answers.");
            foreach (var question in QuestionAnswers.Keys)
            {
                Console.WriteLine($"Question: {question.Header}");
                Console.WriteLine($"Marks: {question.Mark}");
                Console.WriteLine($"Body: {question.Body}");
                Console.WriteLine("Correct Answers:");

                var correctAnswers = QuestionAnswers[question].Where(answer => answer.IsCorrect);

                foreach (var answer in correctAnswers)
                {
                    Console.WriteLine(answer.Text);
                }

                Console.WriteLine();
            }
        
    }

    }
}
