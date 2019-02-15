using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static bool ok(int x)
		{
			if (x < 2){
				return false;
			}
			for (int i = 2; i < x; i++){
				if (x % i == 0){
					return false;
				}
			}
			return true;
		}
		static void Main(string[] args)
		{
			StreamReader sr = new StreamReader(@"E:\abcdef\input.txt");
			string s = sr.ReadToEnd();
			string[] t = s.Split(' ');
			sr.Close();
			StreamWriter sw = new StreamWriter(@"E:\abcdef\output.txt");
			for(int i = 0; i < t.Length; i++){
				//Console.Write(t[i] + " ");
				int now = int.Parse(t[i]);
				if(ok(now)){
					sw.Write(now + " ");
				}
			}
			Console.ReadKey();
			sw.Close();
		}
	}
}
