using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
	public class Token
	{
		public int Value { get; set; }
		public string Color { get; set; }

		public Token(int value, string color)
		{
			Value = value;
			Color = color;
		}
	}
}
