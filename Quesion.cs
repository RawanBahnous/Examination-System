using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    internal class Quesion
    {
        internal string Header { get; set; }
        internal string Body { get; set; }
        internal int Mark { get; set; }

        internal AnswersList AnswerList { get; set; }

        public Quesion(int mark , string header,string body)
        {
            Mark = mark;
            Header = header;
            Body = body;
        }

        public virtual void AddQuestion()
        {
            Console.WriteLine($"Header {Header} ----------- Mark Of the Question :{Mark} Marks \n" +
                $"-------------------------------\n" +
                $"{Body} \n");
        }


    }
}
