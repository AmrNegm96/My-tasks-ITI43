using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MAIN
{
    internal  class Exam : ICloneable 
    {
        public int duration { get; set; }
        public int numberOfQuestion { get; set; }
        public Dictionary<Questions, String> Question_Answer_dict { get; }
        public Subject Exam_Subject { get; set; }
        public int Grade { get; protected set; }

        public Questions[] questions { get; set; }

        //public QuestionsList quest_list { get; set; }
        public Exam() { }
        public Exam(int duration, int numberOfQuestion, Subject exam_Subject)
        {
            this.duration = duration;
            this.numberOfQuestion = numberOfQuestion;
            Exam_Subject = exam_Subject;
            Question_Answer_dict = new Dictionary<Questions,string >();

           
        }

        public void showExam() { }

        public object Clone()
        {
            Exam ex = new Exam();

            return ex;
        }
    }
    internal class FinalExam : Exam
    {
        
        public FinalExam(int d, int nQ, Subject s) : base(d, nQ, s)
        {
            generateQuestions();
            showExam();
        }
        public object Clone()
        {
            Subject temp = new(this.Exam_Subject.SubjectName);
            return new FinalExam(this.duration,this.numberOfQuestion,temp);
        }
       



        public void showExam()
        {
            double counter=0;
            double totalMarks = 0;
            for (int i = 0; i < quest_list.Count; i++)
            {
                Console.WriteLine(quest_list[i].ToString());
                string x=  Console.ReadLine();
                Question_Answer_dict[quest_list[i]] = x;
                totalMarks += quest_list[i].mark;

            }
            foreach(KeyValuePair<Questions,string> item in Question_Answer_dict)
            {
                if (item.Key.CorrectAnswer == item.Value)
                {
                    counter += item.Key.mark;
                }
            }
            Console.WriteLine("the result in percent ");
            Console.WriteLine((counter/totalMarks)*100+"%");
        }
        QuestionsList quest_list;
        //QuestTF q1;
        //QuestTF q2;
        //QuestTF q3;
        string[] choices = new string[4];
        //QuestChoose q4;
        //QuestChoose q5;
        //QuestChoose q6;

        public void generateQuestions()
        {
            choices[0] = "ans1";
            choices[1] = "ans2";
            choices[2] = "ans3";
            choices[3] = "ans4";

            quest_list = new QuestionsList();
            quest_list.newAdd(new QuestTF(1, "abc?", 2, "Ans1"));
            quest_list.newAdd(new QuestTF(2, "xyz?", 2, "Ans1"));
            quest_list.newAdd(new QuestTF(3, "abc?", 2, "Ans1"));
            quest_list.newAdd(new QuestTF(4, "klm?", 2, "Ans1"));
            quest_list.newAdd(new QuestChoose(5, "abc?", 2, "Ans1", choices));
            quest_list.newAdd(new QuestChoose(6, "xyz?", 2, "Ans1", choices));
            quest_list.newAdd(new QuestChoose(7, "klm?", 2, "Ans1", choices));
            quest_list.newAdd(new QuestChoose(8, "klm?", 2, "Ans1", choices));
            quest_list.newAdd(new QuestChoose(9, "klm?", 2, "Ans1", choices));
            quest_list.newAdd(new QuestChoose(10, "klm?", 2, "Ans1", choices));

        }
        public override string ToString()
        {
            return $"";
        }
    }

    internal class PracticeExam : Exam
    {
        public PracticeExam(int d, int nQ, Subject s) : base(d, nQ, s)
        {
            generateQuestions();
            showExam();
        }
        public  void showExam()
        {
            double counter = 0;
            double totalMarks = 0;
            for (int i = 0; i < quest_list.Count; i++)
            {
                Console.WriteLine(quest_list[i].ToString());
                string x = Console.ReadLine();
                Question_Answer_dict[quest_list[i]] = x;
                totalMarks += quest_list[i].mark;
            }
            foreach (KeyValuePair<Questions, string> item in Question_Answer_dict)
            {
                if (item.Key.CorrectAnswer == item.Value)
                {
                    counter += item.Key.mark;
                }
                
            }
            Console.WriteLine("the result in percent ");
            Console.WriteLine((counter / totalMarks) * 100);
            for (int i=0;i<quest_list.Count;i++)
            {
                Console.WriteLine(quest_list[i].CorrectAnswer);
            }
        }
        QuestionsList quest_list;
        string[] choices = new string[4];
        public void generateQuestions()
        {
            choices[0] = "ans1";
            choices[1] = "ans2";
            choices[2] = "ans3";
            choices[3] = "ans4";

            quest_list = new QuestionsList();
            quest_list.newAdd(new QuestTF(1, "abc?", 2, "Ans1"));
            quest_list.newAdd(new QuestTF(2, "xyz?", 2, "Ans1"));
            quest_list.newAdd(new QuestTF(3, "abc?", 2, "Ans1"));
            quest_list.newAdd(new QuestTF(4, "klm?", 2, "Ans1"));
            quest_list.newAdd(new QuestChoose(5, "abc?", 2, "Ans1", choices));
            quest_list.newAdd(new QuestChoose(6, "xyz?", 2, "Ans2", choices));
            quest_list.newAdd(new QuestChoose(7, "klm?", 2, "Ans3", choices));
            quest_list.newAdd(new QuestChoose(8, "klm?", 2, "Ans4", choices));
            quest_list.newAdd(new QuestChoose(9, "klm?", 2, "Ans5", choices));
            quest_list.newAdd(new QuestChoose(10, "klm?", 2, "Ans6", choices));

        }
    }

    public class Subject
    {
        public string SubjectName { get; set; }
        public Subject(string _SubjectName)
        {
            SubjectName = _SubjectName;
        }
    }


    internal class ExamComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if ((x is Exam L) && (y is Exam R))
                return L.duration.CompareTo(R.duration);
            return -1;
        }
    }
}
