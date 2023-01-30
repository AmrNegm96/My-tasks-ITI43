using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAIN
{
    public class Questions
    {
        public int questId { get; set; }
        public string body { get; set; }
        public int mark { get; set; }

        public string CorrectAnswer { get; set; }


        public Questions(int _id, string _body, int _mark, string _correctAnswer)
        {
            questId = _id;
            body = _body;
            mark = _mark;
            CorrectAnswer = _correctAnswer;
        }

        public static void addQuest()
        {

        }
        public static void deleteQuest()
        {

        }
    }
}
