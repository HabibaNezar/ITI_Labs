using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5_c_
{
    public abstract  class Question : ICloneable, IComparable<Question>
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Marks { get; set; }
        public AnswerList Choices { get; set; } = new AnswerList();

        #region constructor chaining
        public Question() : this("default header", "default body", 1) { }
        public Question(string header, string body, int marks)
        {
            Header = header;
            Body = body;
            Marks = marks;
        }
        #endregion

        #region methods
        public abstract void Display();

        public void DisplayChoices()
        {
            foreach (var choice in Choices)
            {
                Console.WriteLine($"{choice.AnswerId}. {choice
                    .Text}");
                Console.WriteLine();
            }
        }

        public abstract object Clone();
        public int CompareTo(Question other) => Marks.CompareTo(other?.Marks);
        public override string ToString() => $"{Header}: {Body} ({Marks} Marks)";
        public override bool Equals(object obj) => obj is Question q && Header == q.Header && Body == q.Body;
        public override int GetHashCode() => HashCode.Combine(Header, Body);
        #endregion
    }

    public class TrueFalseQuestion : Question
    { // 
        public TrueFalseQuestion(string header, string body, int marks) : base(header, body, marks)
        {
            Choices.Add(new Answer(1, "True"));
            Choices.Add(new Answer(2, "False"));
        }
        public override void Display()
        {
            Console.WriteLine($"[T/F] {ToString()}");
            DisplayChoices();
        }
        public override object Clone() => new TrueFalseQuestion(Header, Body, Marks) { Choices = (AnswerList)Choices.Clone() };
    }
    public class ChooseOneQuestion : Question
    { // 
        public ChooseOneQuestion(string header, string body, int marks) : base(header, body, marks) { }
        public override void Display()
        {
            Console.WriteLine($"[MCQ - Choose One] {ToString()}");
            DisplayChoices();
        }
        public override object Clone() => new ChooseOneQuestion(Header, Body, Marks) { Choices = (AnswerList)Choices.Clone() };
    }
        public class ChooseAllQuestion : Question
            { // 
                public ChooseAllQuestion(string header, string body, int marks) : base(header, body, marks) { }
                public override void Display()
                {
                    Console.WriteLine($"[MCQ - Choose All] {ToString()}");
                    DisplayChoices();
                }
                public override object Clone() => new ChooseAllQuestion(Header, Body, Marks) { Choices = (AnswerList)Choices.Clone() };
            }
        public class QuestionList<T> : List<T> where T : Question
            {
                public string LogFileName { get; set; }

                public QuestionList(string logFileName)
                {
                    LogFileName = logFileName;
                }

                public new void Add(T item)
                {
                    base.Add(item);
                    using (TextWriter writer = new StreamWriter(LogFileName, true))
                    {
                        writer.WriteLine($"[{DateTime.Now}] Added Question: {item.ToString()}");
                    }
                }
            }


    }

