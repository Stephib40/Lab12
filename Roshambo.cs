using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
	class Roshambo
	{
		private List<String> rosh;
		public Roshambo()
		{
			rosh = new List<string>();
			rosh.Add("Rock");
			rosh.Add("Paper");
			rosh.Add("Scissors");
		}

		public string GetRoshambo(int index)//alwyas going to put in index and get back a string
		{
			string ro = rosh[index];
			return ro;
		}
	}
}
