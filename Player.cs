using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
	class Player
	{
		interface PlayerA
		{
			
			string GetName();//accessor. instance variable in the object for name. will return the name. 
			//output
			void SetName(String n);//only for setting the name
			//input
			String GenerateRoshambo();

			//interface is saying all the children are going to do each of these
		}
	}
}
