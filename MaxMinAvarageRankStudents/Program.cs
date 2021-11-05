using System;
using System.Collections.Generic;

namespace MaxMinAvarageRankStudents
{
    class Program
    {
        //Nhap ten lop: toan ly hoa => diem sinh vien
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            for(int i = 0; i < 4; i++)
            {
                Student st = new Student($"A{i}","ClassA",i,8,9);
                students.Add(st);
            }
            List<Student> myStudents = Rank(students);

            foreach(var item in myStudents)
            {
                Console.WriteLine($"Name {item.Name}   ---  Toan: {item.Toan} \t Ly: {item.Ly} \t Hoa: {item.Hoa}  \n DiemTB:  {item.Average}   ---   Rank: {item.Rank}");
            }

            Console.WriteLine();
            Console.WriteLine("---------------------------------");

            var myDic = Report(myStudents);
            Console.WriteLine($"A: {myDic["A"]}% \t B: {myDic["B"]}%   \t C: {myDic["C"]}% \t D: {myDic["D"]}%");

            Console.WriteLine();
            Console.WriteLine("--------------");
            var maxMin = MaxMinAverageScore(myStudents);

            Console.WriteLine($" {maxMin}");
            Console.ReadLine();
        }

        public static Dictionary<string,decimal> Report(List<Student> students)
        {
            var rank = Rank(students);
            int countA = 0;
            int countB = 0;
            int countC = 0;
            int countD = 0;

            for(int i = 0; i < rank.Count; i++)
            {
                if(rank[i].Rank == "A")
                {
                    countA += 1;
                }
                if(rank[i].Rank == "B")
                {
                    countB += 1;
                }
                if(rank[i].Rank == "C")
                {
                    countC += 1;
                }
                if(rank[i].Rank == "D")
                {
                    countD += 1;
                }
            }
            int studentCount = students.Count;

            decimal percentA = Math.Round((countA / (decimal)studentCount) * 100,3);
            decimal percentB = Math.Round((countB / (decimal)studentCount) * 100,3);
            decimal percentC = Math.Round((countC / (decimal)studentCount) * 100,3); ;
            decimal percentD = Math.Round((countD / (decimal)studentCount) * 100,3); ;

            Dictionary<string,decimal> myDic = new Dictionary<string,decimal>();
            myDic.Add("A",percentA);
            myDic.Add("B",percentB);
            myDic.Add("C",percentC);
            myDic.Add("D",percentD);

            return myDic;
        }
        public static Dictionary<string,double> MaxMinAverageScore(List<Student> students)
        {
            var averageStudentScore = new List<Student>();
            for(int i = 0; i < students.Count; i++)
            {
                double average = Average(students[i].Toan,students[i].Ly,students[i].Hoa);
                students[i].Average = average;
                averageStudentScore.Add(students[i]);
            }
            averageStudentScore.ToArray();

            for(int i = 0; i < length; i++)
            {

            }

            var myDic = new Dictionary<string,double>();
            myDic.Add(averageStudentScore[0].Name,averageStudentScore[0].Average);
            myDic.Add(averageStudentScore[averageStudentScore.Count].Name,averageStudentScore[averageStudentScore.Count].Average);
            return myDic;
        }

        public static List<Student> Rank(List<Student> students)
        {
            for(int i = 0; i < students.Count; i++)
            {
                double average = Average(students[i].Toan,students[i].Ly,students[i].Hoa);
                students[i].Average = average;
                if(average < 4)
                {
                    students[i].Rank = "D";
                }
                if(4 <= average && average < 6)
                {
                    students[i].Rank = "C";
                }
                if(6 <= average && average <= 7.5)
                {
                    students[i].Rank = "B";
                }
                if(average > 7.5)
                {
                    students[i].Rank = "A";
                }
            }
            return students;
        }


        public static double Average(double a,double b,double c)
        {
            return Math.Round(((a + b + c) / 3),3);
        }
    }


    public class Student
    {
        public string Name { get; set; }
        public string ClassName { get; set; }
        public double Toan { get; set; }
        public double Ly { get; set; }
        public double Hoa { get; set; }
        public string Rank { get; set; }
        public double Average { get; set; }
        public Student()
        {

        }
        public Student(string name,string className,double toan,double ly,double hoa)
        {
            Name = name;
            ClassName = className;
            Toan = toan;
            Ly = ly;
            Hoa = hoa;
        }
    }
}
