using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudy
{

	class Student
	{
		public int rollNo{ get; set; }
		public String name { get; set; }
		public DateTime dateOfBirth { get; set; }

		public  static string CollegeName = "MIT";
		public Student(int rollNo, String name, DateTime dateOfBirth)
		{
			this.rollNo = rollNo;
			this.name = name;
			this.dateOfBirth = dateOfBirth;
		}
	}

	class Info
	{
		public static void display(Student student)
		{
			Console.WriteLine(student.rollNo + " " + student.name + " " + (student.dateOfBirth).ToString("dd/MM/yyyy"));
		}
	}










	class App
    {
		public static void Scenario1()
		{
			Student student1 = new Student(1, "Mana", Convert.ToDateTime("12/12/2019"));
			Student student2 = new Student(2, "Vivi", Convert.ToDateTime("01/02/2017"));
			Student student3 = new Student(3, "Renuka", Convert.ToDateTime("14/05/2020"));

			Info info = new Info();
			Info.display(student1);
			Info.display(student2);
			Info.display(student3);
			
		}

		public static void Scenario2()
		{
			Student[] students = new Student[3];
			students[0] = new Student(1, "Mana", Convert.ToDateTime("12/12/2019"));
			students[1] = new Student(2, "Vivi", Convert.ToDateTime("01/02/2017"));
			students[2] = new Student(3, "Renuka", Convert.ToDateTime("14/05/2020"));
			foreach (Student su in students)
			{
				Info.display(su);
			}
			
		}

		public static void Scenario3()
		{
			Console.WriteLine("Enter number of students : ");
			int n = Convert.ToInt32(Console.ReadLine());
			Student[] students = new Student[n];
			for (int i = 0; i < students.Length; i++)
			{
				Console.WriteLine("Enter roll no,name and date of birth");
				int rollno = Convert.ToInt32(Console.ReadLine());
				String name = Console.ReadLine();
				DateTime date = DateTime.Parse(Console.ReadLine());
				students[i] = new Student(rollno, name, date);
			}
			foreach (Student su in students)
			{
				Info.display(su);
			}
			
		}



	}

	class StudentDb
    {
    }
}
