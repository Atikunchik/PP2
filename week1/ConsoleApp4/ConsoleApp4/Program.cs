using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			char[][] a = new char[n][];
			for(int i = 0; i < n; i++){
				a[i] = new char[3 * (i + 1)];
				for(int j = 0; j < 3 * (i + 1); j++){
					if (j % 3 == 1)
						a[i][j] = '[';
					if (j % 3 == 2)
						a[i][j] = '*';
					if (j % 3 == 0)
						a[i][j] = ']';
				}
			}
			for(int i = 0; i < n; i++){
				for (int j = 0; j < 3 * (i + 1); j++)
					Console.Write(a[i][j]);
				Console.WriteLine();	
			}
			Console.ReadKey();
		}
	}
}
