using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
	class Program
	{
		static bool ok(int x)
		{
			if (x < 2)
			{
				return false;
			}
			for (int i = 2; i < x; i++)
			{
				if (x % i == 0)
				{
					return false;
				}
			}
			return true;
		}
		static void Main()
		{
			int n = int.Parse(Console.ReadLine());
			string[] a = Console.ReadLine().Split(' ');
			List<int> l = new List<int>();
			for (int i = 0; i < n; i++)
			{
				int now = int.Parse(a[i]);
				if (ok(now) == true)
				{
					l.Add(now);
				}
			}
			Console.WriteLine(l.Count);
			foreach (int i in l){
				Console.Write(i + " ");
			}
			Console.ReadKey();
		}
	}
}
