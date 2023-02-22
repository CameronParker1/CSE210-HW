using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning04 World!");

        Assignment a1 = new Assignment("Jane Smith", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        Console.WriteLine(" ");

        MathAssignment a2 = new MathAssignment("Blake Johnson", "Division", "8.4", "10-25");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        Console.WriteLine(" ");

        WritingAssignment a3 = new WritingAssignment("Sally Jensen", "American History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    
    }
}