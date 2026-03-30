using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5_c_
{
    public class Answer:ICloneable
    {
        public int AnswerId { get; set; }
        public string Text { get; set; }
        public Answer(int id, string text)
        {
            AnswerId = id;
            Text = text;
        }

        public object Clone()
        {
            return new Answer(AnswerId, Text);
        }
    }

    public class AnswerList : List<Answer>, ICloneable
    {
        public object Clone()
        {
           var clone = new AnswerList();
            foreach (var ans in this) clone.Add((Answer)ans.Clone());
            return clone;
        }

    }

}
