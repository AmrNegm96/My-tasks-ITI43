using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAIN
{
    internal class QuestTF : Questions
    {
        //static string[] TFQuestions = new string[3];

        //Answers A = new Answers();

        //static int counter = 0;

        public QuestTF(int id, string b, int m, string c) : base(id, b, m, c)
        {

        }
        public override string ToString()
        {
            return $"{body} \n" +
                   $"[True - False]";
        }
        //public static void addQuest(QuestTF Qa)
        //{
        //    //TFQuestions[counter] = Qa.body;
        //    //Console.WriteLine(counter);
        //    //Console.WriteLine(TFQuestions[counter]);
        //    //counter++;
        //}
        //public static void deleteQuest(QuestTF Qa)
        //{
        //    //TFQuestions[Qa.questId - 1] = "";
        //    //Console.WriteLine("You have deleted the question");
        //}
        //public void addAnswer(string ans)
        //{

        //    //A.TfAns[this.questId - 1] = ans;
        //}
        //public string getAnswer()
        //{
        //    return A.TfAns[this.questId - 1];
        //}
        //public void showQeustions()
        //{
        //    for(int i=0; i<10;i++) 
        //    {
        //        Console.WriteLine(TFQuestions[i]);
        //    }
        //}
    }
}
