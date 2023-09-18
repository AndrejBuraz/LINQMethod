using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQMethod
{
    internal class Program
    {

		public class Student
		{

			public int StudentID { get; set; }
			public string StudentName { get; set; }
		}

		static void Main(string[] args)
        {
				// Student collection
				List<Student> studentList = new List<Student>() {
				new Student() { StudentID = 1, StudentName = "John" } ,
				new Student() { StudentID = 2, StudentName = "Moin" } ,
				new Student() { StudentID = 3, StudentName = "Bill" } ,
				new Student() { StudentID = 4, StudentName = "Ram" } ,
				new Student() { StudentID = 5, StudentName = "Ron"  }
			};

			// upit i izvršavanje upita
			var selectResult = studentList.Select(student => student.StudentName);


				foreach (var student in studentList)
				{
					Console.WriteLine(student.StudentName);
				}

				Console.ReadKey();
			}
    }
}
