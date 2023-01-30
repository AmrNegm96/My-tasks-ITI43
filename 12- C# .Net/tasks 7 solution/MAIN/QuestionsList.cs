using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAIN
{
    internal class QuestionsList : List<Questions>
    {
        public List<Questions> Quest_List { get; }

        public QuestionsList()
        {
            Quest_List = new List<Questions>();
        }
        public void newAdd(Questions Qa)
        {
           
            ////if (Qa.GetType() == typeof(QuestTF))
            ////{
                
            ////}
            ////else if (Qa.GetType() == typeof(QuestChoose))
            ////{
            ////    folder = @"C:\Temp\";
            ////    fileName = "Questions2.txt";
            ////    fullPath = folder + fileName;
            ////}

            string folder = @"C:\Temp\";
            string fileName = "Questions.txt";
            string fullPath = folder + fileName;
            this.Add(Qa);
            string[] Questions = new string[this.Count];

            for (int i = 0; i < this.Count; i++)
            {
                Questions[i] = this[i].ToString();

            }
            File.WriteAllLines(fullPath, Questions);
        }
        public static void ShowQuestions(List<Questions> Qs)
        {
            string folder = "";
            string fileName = "";
            string fullPath = "";

            folder = @"C:\Temp\";
            fileName = "Questions.txt";
            fullPath = folder + fileName;

            //if (Qs[0].GetType() == typeof(QuestTF))
            //{
                
            //}
            //else if (Qs[0].GetType() == typeof(QuestChoose))
            //{
            //    folder = @"C:\Temp\";
            //    fileName = "Questions2.txt";
            //    fullPath = folder + fileName;
            //}

            string readText = File.ReadAllText(fullPath);
            Console.WriteLine(readText);
        }
    }
}
