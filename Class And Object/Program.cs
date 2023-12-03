using System;

namespace Class_And_Object
{
    class Program
    {
        int RollNo, age, standard;
        string name;
        public void SetStudent(int rollNumber, string name, int age, int standard)
        {
            this.RollNo = rollNumber;
            this.name = name;
            this.age = age;
            this.standard = standard;
        }
        public void GetStudent()
        {
            Console.WriteLine("Roll No is : {0}", this.RollNo);
            Console.WriteLine("Name is : {0}", this.name);
            Console.WriteLine("Age is : {0}", age);
            Console.WriteLine("Standard is : {0}", this.standard);
        }



        static void Main(string[] args)
        {
            Program Ali = new Program();
            Ali.SetStudent(1, "Ali", 22, 15);
            Ali.GetStudent();


            Console.WriteLine("-----------------");
            Program Bilal = new Program();
            Bilal.SetStudent(2, "Bilal", 24, 16);
            Bilal.GetStudent();
            Console.ReadLine();

        }
    }
}
