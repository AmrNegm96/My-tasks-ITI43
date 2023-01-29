using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAIN
{
    class Questions
    {
        public int questId { get; set; }
        public string body { get; set; }
        public int mark { get; set; }

        public Questions(int _id, string _body, int _mark)
        {
            questId = _id;
            body = _body;
            mark = _mark;
        }

        public static void addQuest()
        {

        }
        public static void deleteQuest(int id)
        {

        }
    }
}
