namespace t2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
            Test t2 = new Test();

            t1.SetGrade(101, 85);
            t2.SetGrade(68, 84);

            Console.WriteLine(t1.GetAvg());
            Console.WriteLine(t2.GetAvg());
        }
    }
}
