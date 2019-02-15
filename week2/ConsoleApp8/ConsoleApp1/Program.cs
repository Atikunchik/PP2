using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Task3
{
	class Program
	{
		static void Print(FileSystemInfo dir, int d){
			if (dir == null){
				return;
			}
			string s = new string('\t', d) + dir.Name;
			Console.WriteLine(s);
			if (dir.GetType() == typeof(DirectoryInfo)){
				foreach (var i in (dir as DirectoryInfo).GetFileSystemInfos()){
					Print(i, d + 1);
				}
			}
		}
		static void Main(string[] args)
		{
			DirectoryInfo dir = new DirectoryInfo(@"E:\desu");
			Print(dir, 0);
			Console.ReadKey();
		}
	}
}