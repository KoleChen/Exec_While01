using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int i = 1;
			int answer = 0;
			while (true)
			{
				answer += i;
				if (answer >= 105)
					break;
				i++;
			}

			Console.WriteLine(i);
		}
	}
}
