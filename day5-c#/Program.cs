using static day5_c_.PracticeExam;
using static day5_c_.TrueFalseQuestion;

namespace day5_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject math = new Subject("Mathematics");
            math.EnrolledStudents.Add(new Student("Habiba"));
            math.EnrolledStudents.Add(new Student("Ahmed"));

            Exam practice = new PracticeExam(60, 1, math);
            Exam final = new FinalExam(120, 1, math);

            // Setup a question
            var q1 = new ChooseOneQuestion("Q1", "What is 2+2?", 5);
            q1.Choices.Add(new Answer(1, "3"));
            q1.Choices.Add(new Answer(2, "4"));
            var correctQ1 = new AnswerList { new Answer(2, "4") };

            practice.Questions.Add(q1);
            practice.CorrectAnswers.Add(q1, correctQ1);

            final.Questions.Add((Question)q1.Clone());
            final.CorrectAnswers.Add(final.Questions[0], correctQ1);

            Console.WriteLine("Select Exam Type: 1 for Practice, 2 for Final");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                practice.Mode = ExamMode.Starting; // Triggers manual notifications
                practice.ShowExam();
                practice.Mode = ExamMode.Finished;
            }
            else if (choice == "2")
            {
                final.Mode = ExamMode.Starting; // Triggers manual notifications
                final.ShowExam();
                final.Mode = ExamMode.Finished;
            }
        }
    }
}
