using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int start = 0;
			int end = 300;
			while (start <= end)
			{
				start++;
				if (300 % start == 0)
				{
					Console.WriteLine(start);
				}
			}
		}
	}
}
