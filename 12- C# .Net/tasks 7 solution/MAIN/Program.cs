namespace MAIN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject S1 = new Subject("math");
            Console.WriteLine("Please select practice or final");

            string choice = Console.ReadLine();

            if(choice=="practice")
            {
                PracticeExam E2 = new PracticeExam(1, 10, S1);
            }
            else
            {
                FinalExam E1 = new FinalExam(1, 10, S1);
            }
        }
    }
}