using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Result_sheet_Redo
{
    class Background
    {
        public string Names { get; set; }
        public int Marks { get; set; }


        public bool NewScores()
        {
            var Fscores = @"C:\Users\Ewuji O. John\source\repos\Result sheet Redo\Student_Results\StudentResult.txt";
            
            var path2 = @"C:\Users\Ewuji O. John\source\repos\Result sheet Redo\Student_Results\NewStudentResult.txt";
            
            //string[] lines = File.ReadAllLines(path2);

            foreach (var line in File.ReadAllLines(Fscores))
            {
                Console.WriteLine($" { line}");
                string[] str = line.Split(" - ");
                
                Names = (str[0]);
                Marks = int.Parse((str[1]));
                if (Marks <= 50)
                {
                    var newScore = Marks + 10;
                    var newStr = $"{Names} - {newScore}";
                    File.AppendAllLines(path2, new String[] { newStr });
                    Console.WriteLine($" { newStr}");
                }

                else
                {
                    var newScore = Marks + 5;
                    var newStr = $"{Names} - {newScore}";
                    File.AppendAllLines(path2, new String[] { newStr });
                    Console.WriteLine($" { newStr}");
                }

            }
            return true;
            
        }

        

    }
}
