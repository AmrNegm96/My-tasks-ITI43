using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAIN
{
    internal class AnswersList<T> : List<T>
    {
        public List<Answers> AnsList { get; }

        public AnswersList()
        {
            AnsList = new List<Answers>();
        }

        public new void Add(Answers _ans)
        {
            AnsList.Add(_ans);
        }

        public new void Remove(Answers _ans)
        {
            AnsList.Remove(_ans);
        }

        public void ShowAnswerList()
        {
            for(int i=0; i< AnsList.Count; i++)
            {
                Console.WriteLine(AnsList[i]);
            }
        }
    }
}
