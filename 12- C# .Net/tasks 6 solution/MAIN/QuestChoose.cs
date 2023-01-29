using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAIN
{
    internal class QuestChoose : Questions
    {
        static string[] ChooseQuestions = new string[3];
        Answers A = new Answers();
        static int counter = 0;
        public string[] choices = new string[4];
        public override string ToString()
        {
            return $"{body} \n" +
                   $"({choices[0]} , {choices[1]} , {choices[2]} , {choices[3]})";

        }
        public QuestChoose(int id, string b, int m) : base(id, b, m)
        {

        }
        public static void addQuest(QuestChoose Qa)
        {
            ChooseQuestions[counter] = Qa.body;
            Console.WriteLine(counter);
            Console.WriteLine(ChooseQuestions[counter]);
            counter++;
        }
        public static void deleteQuest(QuestChoose Qa)
        {
            ChooseQuestions[Qa.questId - 1] = "";
            Console.WriteLine("You have deleted the question");
        }
        public void addChoices(string[] chs)
        {
            for (int i = 0; i < choices.Length; i++)
            {
                choices[i] = chs[i];
            }
        }
        public void addAnswer(string ans)
        {

            A.ChooseAns[this.questId - 1] = ans;
        }
        public string getAnswer()
        {
            return A.ChooseAns[this.questId - 1];
        }
        public void getChoices()
        {
            for (int i = 0; i < choices.Length; i++)
            {
                Console.WriteLine(this.choices[i]);
            }
        }
        
        //public void showQeustions()
        //{
        //    for(int i=0; i<10;i++) 
        //    {
        //        Console.WriteLine(CompltQuestions[i]);
        //    }
        //}
        
    }
}
