using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
	public class Player
	{
		public string Name { get; set; }
		public int Points { get; set; }

		public Player(string name, int points)
		{
			Name = name;
			Points = points;
		}
	}
}
