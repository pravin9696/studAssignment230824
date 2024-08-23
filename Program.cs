using System.Security.Principal;

namespace studAssignment230824
{
    class test
    {
        public void print()
        {
            Console.WriteLine("Csharp:");
        }
    }
    class Student
    {
        int roll;
        string name;
        int[] sub;
        int totalMarks;
        float per;
        string Grades;
        public Student(int r,string nm)
        {
            roll = r;
            name = nm;
        }
        public void setSubMarks(int[] s)//parameter
        {
            sub = s;
           
        }
        public void calculatePer()
        {
            totalMarks = 0;
            for (int i = 0; i < sub.Length; i++)
            {
               totalMarks=totalMarks+sub[i];
            }
           per = (totalMarks)/6.0f;
        }
        public void checkGrades()
        { //here we need to check grades means per>75 && per<=100 then student in distinction if per>60 
          //&& per <= 75 then in first division if per >= 50 && per <= 60 then second division and if per > 40 &&
          //per <= 50 then in third division and if per < 40 then student failed
            Grades = "";
            
            if (per>75 && per<=100) //105     T  || F
            {
                Grades = "Distiction";
            }
            else if (per>60 && per<=75)
            {
                Grades = "first division";
            }
            else if (per > 50 && per <= 60)
            {
                Grades = "second division";
            }
            else if (per > 40 && per <= 50)
            {
                Grades = "third division";
            }
            else
            {
                Grades = "failed";
            }

        }
        public void showDetails()
        {
            Console.WriteLine("\nStudent Details :");
            Console.WriteLine($"Roll = {roll}\n Name= {name}");
            for (int i = 0; i < sub.Length; i++)
            {
                Console.Write($"sub[{i+1}]={sub[i]}\t");
            }
            Console.WriteLine($"\nPer={per}\n Grade={Grades}");
        }
    }
     
    internal class Program
    {
       
        static void Main(string[] args)
        {
            //int[] sb = new int[6] { 41,53,34,54,65,78};
            //Student s = new Student(1,"rajesh");
            //s.setSubMarks(sb);//sb is argument
            //s.calculatePer();
            //s.checkGrades();
            //s.showDetails();
            test t = null;
            t.print();
            Console.ReadLine();
        }
    }
}
