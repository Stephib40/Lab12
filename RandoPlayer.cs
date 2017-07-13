using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
	class RandoPlayer
	{
		private string name;
		Random rando;
		string a = "Lannisters";

		public RandoPlayer(string a, Random r)
		{
			//name = a;
			rando = r;
		}

		public string GenerateRoshambo()
		{
			int pick = rando.Next(0, 3);//0 is the min 3 is the max. can be 0 or up to 3  
			Roshambo r = new Roshambo();
			string result = r.GetRoshambo(pick);
			return result;
		}

		public string GetName()
		{
			return name;
		}

		public void SetName(string n)
		{
			name = n;
		}
	}
}
