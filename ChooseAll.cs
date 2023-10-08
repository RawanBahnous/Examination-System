using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem
{
    internal class ChooseAll : Quesion
    {

        internal List<string> Choices { get; set; }
        public ChooseAll(int mark, string header, string body, List<string> choices) : base(mark, header, body)
        {
            Choices = choices ?? new List<string>();
        }

        public void AddChoices(string Choice)
        {
            Choices.Add(Choice);
        }
        public override void AddQuestion()
        {
            base.AddQuestion();
            foreach (var choice in Choices)
            {
                Console.WriteLine($"Choices: {choice}");
            }
        }
    }
}
