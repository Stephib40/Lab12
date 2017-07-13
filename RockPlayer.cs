using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
	class RockPlayer : Player
	{
	
		string starks = (Console.ReadLine());//starks rock, only 
		string b = "Stark";

		public RockPlayer(string b)
			{
				starks = b;
			}

			public string GetName()//i am going to take the private variable and return it back 
			{
				return starks;//gurantee object knows how to manipulate the name 
			}

			public void SetName(string b)//set its 
			{
				starks = b;
			}

			public String GenerateRoshambo()
			{
				Roshambo r = new Roshambo();
				string result = r.GetRoshambo(0);
				return result;
			}
		
	}
}
