using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    internal class TrueOrFalse : Quesion
    {
        internal bool IsTrue { get; set; }
        public TrueOrFalse(int mark, string header, string body,bool istrue) : base(mark, header, body)
        {
            IsTrue = istrue;
        }

        public override void AddQuestion()
        {
            base.AddQuestion();
            Console.WriteLine($"{IsTrue}");
        }
    }
}
