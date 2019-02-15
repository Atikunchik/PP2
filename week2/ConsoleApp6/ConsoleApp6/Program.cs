using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp6
{
	class Program
	{
		static void Main(string[] args)
		{
			StreamReader sr = new StreamReader(@"E:\abcdef\input.txt");
			string s = sr.ReadToEnd();
			for(int i = 0; i <= s.Length / 2; i++){
				if(s[i] != s[s.Length - i - 1]){
					Console.Write("NO");
					Console.ReadKey();
					return;
				}
			}
			sr.Close();
			Console.Write("YES");
			Console.ReadKey();
		}
	}
}
