using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAIN
{
    internal class Answers
    {
        public int Q_Id { get; set; }
        public int No_Of_Choices { get; set; }
        public string[] Choices { get; set; }

        public Answers(int _QId, int _NoOfChoices, string[] _Choices)
        {
            No_Of_Choices = _NoOfChoices;
            Choices = new string[No_Of_Choices];
            Q_Id = _QId;
            for (int i = 0; i < Choices.Length; i++)
            {
                Choices[i] = _Choices[i];
            }
        }
        public override string ToString()
        {
            string choices = "";
            for (int i = 0; i < Choices.Length; i++)
            {
                choices += $"{Choices[i]}\n";
            }
            return choices;
        }
    }
}
