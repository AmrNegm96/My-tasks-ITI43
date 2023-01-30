using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace MAIN
{
    internal class QuestChoose : Questions
    {
        public Answers Choices { get; set; }

        //static int counter = 0;
        public override string ToString()
        {
            return $"\n{body} \n{Choices}";
        }

        public QuestChoose(int id, string b, int m, string c, string[] _choices) : base(id, b, m, c)
        {
            Choices = new Answers(6, 4, _choices);
        }

        //public static void addQuest(QuestChoose Qa)
        //{
        //    //ChooseQuestions[counter] = Qa.body;
        //    //Console.WriteLine(counter);
        //    //Console.WriteLine(ChooseQuestions[counter]);
        //    //counter++;
        //}
        //public static void deleteQuest(QuestChoose Qa)
        //{
        //    //ChooseQuestions[Qa.questId - 1] = "";
        //    //Console.WriteLine("You have deleted the question");
        //}
        //public void addAnswer(string ans)
        //{

        //    //A.ChooseAns[this.questId - 1] = ans;
        //}
        //public string getAnswer()
        //{
        //    //return A.ChooseAns[this.questId - 1];
        //}
        //public void addChoices(string[] chs)
        //{
        //    for (int i = 0; i < choices.Length; i++)
        //    {
        //        choices[i] = chs[i];
        //    }
        //}
        //public void getChoices()
        //{
        //    for (int i = 0; i < choices.Length; i++)
        //    {
        //        Console.WriteLine(this.choices[i]);
        //    }
        //}

        //public void showQeustions()
        //{
        //    for(int i=0; i<10;i++) 
        //    {
        //        Console.WriteLine(CompltQuestions[i]);
        //    }
        //}

    }
}
