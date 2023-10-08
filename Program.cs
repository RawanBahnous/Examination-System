//using System;
//using System.Collections.Generic;

//namespace ExamSystem
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//            Console.WriteLine("This is an Examination System practicing OOP");

//            QuestionList questions = new QuestionList();

//            TrueOrFalse Q1 = new TrueOrFalse(5, "Header Text: This is TrueOrFalse Type", "5+9 = 14", true);
//            TrueOrFalse Q2 = new TrueOrFalse(5, "Header Text: This is TrueOrFalse Type", "5+2 = 8", false);

//            List<string> choices1 = new List<string> { "A", "B", "C", "D" };
//            ChooseAll Q3 = new ChooseAll(10, "Header Text: This is Choose All Type", "Men Aksar Haywan fe l 3alam 7ywana?", choices1);

//            AnswersList answers1 = new AnswersList();
//            answers1.Add(new Answers("True", true));
//            answers1.Add(new Answers("False", false));
//            Q1.AnswerList = answers1;

//            AnswersList answers2 = new AnswersList();
//            answers2.Add(new Answers("True", false));
//            answers2.Add(new Answers("False", true));
//            Q2.AnswerList = answers2;

//            AnswersList answers3 = new AnswersList();
//            answers3.Add(new Answers("A", true));
//            answers3.Add(new Answers("B", false));
//            answers3.Add(new Answers("C", false));
//            answers3.Add(new Answers("D", true));
//            Q3.AnswerList = answers3;

//            questions.Add(Q1);
//            questions.Add(Q2);
//            questions.Add(Q3);

//            Dictionary<Quesion, AnswersList> questionAnswers = new Dictionary<Quesion, AnswersList>();
//            questionAnswers.Add(Q1, answers1);
//            questionAnswers.Add(Q2, answers2);
//            questionAnswers.Add(Q3, answers3);

//            foreach (var q in questions)
//            {
//                q.AddQuestion();
//            }

//            Exam selectedType = null;

//            Console.WriteLine("Choose what type of Exam You Want?");
//            Console.WriteLine("1- Practice Exam\n2- Final Exam");

//            string selectedUser = Console.ReadLine();

//            if (selectedUser == "1")
//            {
//                selectedType = new PracticeExam("Various", TimeSpan.FromMinutes(60), questions.Count, questionAnswers);
//            }
//            else if (selectedUser == "2")
//            {
//                selectedType = new FinalExam("Various", TimeSpan.FromMinutes(60), questions.Count, questionAnswers);
//            }
//            else
//            {
//                Console.WriteLine("Wrong Selected. Please enter 1 for Practice or 2 for Final.");
//            }

//            if (selectedType != null)
//            {
//                Console.WriteLine("Start answering the questions:");

//                foreach (var question in questions)
//                {
//                    Console.WriteLine(question.Header);
//                    string userAnswer = Console.ReadLine();

//                    // Check the user's answer against the correct answer
//                    bool isCorrect = false;
//                    foreach (var answer in question.AnswerList)
//                    {
//                        if (userAnswer == answer.Text && answer.IsCorrect)
//                        {
//                            isCorrect = true;
//                            break;
//                        }
//                    }

//                    Console.WriteLine($"Your answer is {(isCorrect ? "correct" : "incorrect")}\n");
//                }
//                selectedType.ShowExam();


//            }
//        }
//    }
//}




using System;
using System.Collections.Generic;

namespace ExamSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this is a Console App For Examination system");


            List<string> choices1 = new List<string>() { "A" ,"B","C","D"};

            QuestionList quesions = new QuestionList()
            {
                new TrueOrFalse(5, "Header Text: This is TrueOrFalse Type", "5+9 = 14", true),
                new TrueOrFalse(5, "Header Text: This is TrueOrFalse Type", "5+2 = 8", false),
                new ChooseAll(10, "Header Text: This is Choose All Type", "Men Aksar Haywan fe l 3alam 7ywana?", choices1),
            };

            AnswersList answers1 = new AnswersList();
            answers1.Add(new("True", true));
            answers1.Add(new("False", false));
            quesions[0].AnswerList = answers1;

            AnswersList answers2 = new AnswersList();
            answers2.Add(new("True", false));
            answers2.Add(new("False", true));
            quesions[1].AnswerList = answers2;

            AnswersList answers3 = new AnswersList();
            answers3.Add(new Answers("A", true));
            answers3.Add(new Answers("B", false));
            answers3.Add(new Answers("C", false));
            answers3.Add(new Answers("D", true));
            quesions[2].AnswerList = answers3;

            Dictionary<Quesion, AnswersList> QuestionAnswers = new Dictionary<Quesion, AnswersList>();


            foreach (var question in quesions)
            {
                QuestionAnswers.Add(question,question.AnswerList);
            }

            Console.WriteLine("Choose what type of Exam You Want?");
            Console.WriteLine("1- Practice Exam\n2- Final Exam");

            string selectedUser = Console.ReadLine();
            Exam selectedType = null;

            if (selectedUser == "1")
            {
                selectedType = new PracticeExam("Various", TimeSpan.FromMinutes(60), quesions.Count, QuestionAnswers);
            }
            else if (selectedUser == "2")
            {
                selectedType = new FinalExam("Various", TimeSpan.FromMinutes(60), quesions.Count, QuestionAnswers);
            }
            else
            {
                Console.WriteLine("Wrong Selection. Please enter 1 for Practice or 2 for Final.");
            }
            if (selectedType!=null)
            {
                Console.WriteLine("Starting Exam Time");
                foreach (var q in quesions)
                {
                    q.AddQuestion();
                    var UserAnswer = Console.ReadLine();
                    bool isCorrect = false;
                    foreach (var ans in q.AnswerList)
                    {
                        if (UserAnswer == ans.Text && ans.IsCorrect)
                        {
                             isCorrect = true;
                            Console.WriteLine($"Your Answer is {(isCorrect?"Correct" : "Wrong")}");
                        }
                    }

                }

                selectedType.ShowExam();
            }

        }
    }
}

