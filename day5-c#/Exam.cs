using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5_c_
{
    public abstract class Exam : ICloneable, IComparable<Exam>
    { 
        public int TimeInMinutes { get; set; }
        public int NumberOfQuestions { get; set; }
        public Subject ExamSubject { get; set; }
        public Dictionary<Question, AnswerList> CorrectAnswers { get; set; } = new Dictionary<Question, AnswerList>(); // [cite: 10]
        public QuestionList<Question> Questions { get; set; }

        public ExamMode _mode;
        public ExamMode Mode
        { 
            get => _mode;
            set
            {
                _mode = value;
                if (_mode == ExamMode.Starting)
                {
                    foreach (var student in ExamSubject.EnrolledStudents)
                    {
                        student.NotifyExamStarted(ExamSubject.SubjectName);
                    }
                }
            }
        }
        protected Exam(int time, int numQuestions, Subject subject, string logFile)
        {
            TimeInMinutes = time;
            NumberOfQuestions = numQuestions;
            ExamSubject = subject;
            Questions = new QuestionList<Question>(logFile); // [cite: 6]
            Mode = ExamMode.Queued;
        }

        public abstract void ShowExam(); 
        public abstract object Clone();
        public int CompareTo(Exam other) => TimeInMinutes.CompareTo(other?.TimeInMinutes);
    }
    public class PracticeExam : Exam
    { // 
        public PracticeExam(int time, int numQuestions, Subject sub) : base(time, numQuestions, sub, "PracticeLog.txt") { }

        public override void ShowExam()
        {
            Console.WriteLine($"--- Practice Exam for {ExamSubject.SubjectName} ---");
            foreach (var q in Questions)
            {
                q.Display();
                Console.WriteLine($"Correct Answer(s): ");
                foreach (var ans in CorrectAnswers[q]) Console.WriteLine($"- {ans.Text}"); // Shows answers during/after 
                Console.WriteLine("-------------------------");
            }
        }
        public override object Clone() => new PracticeExam(TimeInMinutes, NumberOfQuestions, ExamSubject);
    }
    public class FinalExam : Exam
        { // 
            public FinalExam(int time, int numQuestions, Subject sub) : base(time, numQuestions, sub, "FinalLog.txt") { }

            public override void ShowExam()
            {
                Console.WriteLine($"--- Final Exam for {ExamSubject.SubjectName} ---");
                foreach (var q in Questions)
                {
                    q.Display(); // Only shows questions and choices 
                    Console.WriteLine("-------------------------");
                }
            }
            public override object Clone() => new FinalExam(TimeInMinutes, NumberOfQuestions, ExamSubject);
        }
    




}