using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp10
{
	class Program
	{
		static void Main(string[] args)
		{
			var f = File.Create(@"E:\desu\here.txt");
			f.Close();
			File.Copy(@"E:\desu\here.txt", @"E:\cociin\here.txt");
			File.Delete(@"E:\desu\here.txt");
		}
	}
}
