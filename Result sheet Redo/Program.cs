using System;
using static System.Net.WebRequestMethods;

namespace Result_sheet_Redo
{
    class Program
    {
        static void Main(string[] args)
        {
           Background Use = new Background();
            Console.WriteLine(Use.NewScores());

            
            Console.WriteLine("Process Completed!");
        }
    }
}
