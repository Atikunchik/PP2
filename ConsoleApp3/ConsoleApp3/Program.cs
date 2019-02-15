using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			string[] a = Console.ReadLine().Split(' ');
			int[] b = new int[2 * n];
			for(int i = 0; i < n; i++){
				b[2 * i] = b[2 * i + 1] = int.Parse(a[i]);
			}
			for(int i = 0; i < 2 * n; i++){
				Console.WriteLine(b[i] + ' ');
			}
		}
	}
}
