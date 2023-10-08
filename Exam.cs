using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    internal class Exam
    {
        internal string Subject { get; set; }

        internal TimeSpan TimeSpan { get; set; }
        internal int NumOfQuestions { get; set; }
        internal Dictionary<Quesion,AnswersList> QuestionAnswers { get; set; }

        public Exam(string subject,TimeSpan timeSpan, int numOfQuestions, Dictionary<Quesion, AnswersList> questionAnswers)
        {
            Subject = subject;
            NumOfQuestions = numOfQuestions;
            QuestionAnswers = questionAnswers;
            TimeSpan= timeSpan;
        }

        public Exam(string subject, int numOfQuestions, Dictionary<Quesion, AnswersList> questionAnswers)
        {
            Subject = subject;
            NumOfQuestions = numOfQuestions;
            QuestionAnswers = questionAnswers;
        }

        public virtual void ShowExam() {
            Console.WriteLine($"Subject: {Subject}");
            Console.WriteLine($"Exam Time: {TimeSpan.TotalMinutes} minutes");
            Console.WriteLine($"Number of Questions: {NumOfQuestions}");
            Console.WriteLine($"Questions answers count: {QuestionAnswers.Count}");
        }
    }
}
