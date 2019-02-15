using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Student
	{
		private string name, id;
		private int year;
		public Student(string s, string t){
			name = s;
			id = t;
			year = 2018;
		}
		public string getnm(){ 
			return name;
		}
		public string getid(){ 
			return id;
		}
		public int get(){
			return year;
		}
		public void up(){
			year++;
		}
		static void Main(string[] args){
			Student Me = new Student("Albert", "18BD119021");
			Console.WriteLine(Me.getnm() + " " + Me.getid());
			Me.up();
			Console.WriteLine(Me.get());
			Console.ReadKey();
		}	
	}
}
