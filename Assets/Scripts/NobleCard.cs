using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
	public class NobleCard : Card
	{
		public int BlackCardCost { get; set; }
		public int WhiteCardCost { get; set; }
		public int RedCardCost { get; set; }
		public int GreenCardCost { get; set; }
		public int BlueCardCost { get; set; }
		public int Points { get; set; }


		public NobleCard(int points, int blackCardCost, int whiteCardCost, int redCardCost, int greenCardCost, int blueCardCost)
		{
			Points = points;
			BlackCardCost = blackCardCost;
			WhiteCardCost = whiteCardCost;
			RedCardCost = redCardCost;
			GreenCardCost = greenCardCost;
			BlueCardCost = blueCardCost;
		}
	}
}
