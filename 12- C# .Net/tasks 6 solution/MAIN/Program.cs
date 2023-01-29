namespace MAIN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuestTF q1 = new QuestTF(1, "abc?", 2);
            QuestTF q2 = new QuestTF(2, "xyz?", 2);
            QuestTF q3 = new QuestTF(3, "klm?", 2);

            QuestTF.addQuest(q1);
            QuestTF.addQuest(q2);
            QuestTF.addQuest(q3);

            q1.addAnswer("True");
            Console.WriteLine(q1);
            Console.WriteLine(q1.getAnswer());

            Console.WriteLine("////////////////////////////");

            QuestChoose q4 = new QuestChoose(1, "abc?", 2);
            QuestChoose q5 = new QuestChoose(2, "xyz?", 2);
            QuestChoose q6 = new QuestChoose(3, "klm?", 2);

            QuestChoose.addQuest(q4);
            QuestChoose.addQuest(q5);
            QuestChoose.addQuest(q6);

            q4.addAnswer("ans of q4");
            Console.WriteLine(q4.getAnswer());

            string[] choices = new string[4];
            choices[0] = "ans1";
            choices[1] = "ans2";
            choices[2] = "ans3";
            choices[3] = "ans4";
            Console.WriteLine("//////////////////////////");
            q4.addChoices(choices);
            Console.WriteLine("//////////////////////////");
            Console.WriteLine(q4);

            //QuestTF.deleteQuest(q3);
            ////Console.WriteLine(q4.getChoices());
            ////q1.showQeustions();
        }
    }
}