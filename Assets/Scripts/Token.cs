using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
	public class Token : MonoBehaviour
    {
        public GameManager gm;
        public int Value;
        public Colors.Color Color;
        public int NumberLeftGreen;
		public int NumberLeftWhite;
		public int NumberLeftRed;
		public int NumberLeftBlue;
		public int NumberLeftBlack;
		public int NumberLeftGold;

		public Player InPossession;
        public bool Available;
		public Counter Counter;
        private void Start()
        {
            gm = FindObjectOfType<GameManager>();
        }

        private void Update()
        {
			
		}

        private void OnMouseOver()
        {
            if (Input.GetMouseButtonDown(0) && Available && !gm.GetPlayer().TookTokens && !gm.GetPlayer().PlayedCard) 
            {
				switch (Color)
				{
					case Colors.Color.Green:
						if (CheckFirstToken(Colors.Color.Green))
							break;
						if (CheckSecondToken(Colors.Color.Green))
							break;
						CheckThirdToken(Colors.Color.Green);
						break;
					
                    case Colors.Color.Black:
						if (CheckFirstToken(Colors.Color.Black))
							break;
						if (CheckSecondToken(Colors.Color.Black))
							break;
						CheckThirdToken(Colors.Color.Black);
						break;
					
					case Colors.Color.Blue:
						if (CheckFirstToken(Colors.Color.Blue))
							break;
						if (CheckSecondToken(Colors.Color.Blue))
							break;
						CheckThirdToken(Colors.Color.Blue);
						
						break;
					
					case Colors.Color.Gold:
						if (CheckFirstToken(Colors.Color.Gold))
							break;
						if (CheckSecondToken(Colors.Color.Gold))
							break;
						CheckThirdToken(Colors.Color.Gold);
						
						break;

					case Colors.Color.Red:
						if (CheckFirstToken(Colors.Color.Red))
							break;
						if (CheckSecondToken(Colors.Color.Red))
							break;
						CheckThirdToken(Colors.Color.Red);
						break;

					case Colors.Color.White:
						if (CheckFirstToken(Colors.Color.White))
							break;
						if (CheckSecondToken(Colors.Color.White))
							break;
						CheckThirdToken(Colors.Color.White);
						break;
				}
			}
        }

		private void GetNumberOfTokens()
		{
			foreach (var token in gm.GreenTokens.Where(token => token.Available))
			{
				NumberLeftGreen++;
			}

			foreach (var token in gm.BlackTokens.Where(token => token.Available))
			{
				NumberLeftBlack++;
			}
			foreach (var token in gm.BlueTokens.Where(token => token.Available))
			{
				NumberLeftBlue++;
			}

			foreach (var token in gm.WhiteTokens.Where(token => token.Available))
			{
				NumberLeftWhite++;
			}
			foreach (var token in gm.RedTokens.Where(token => token.Available))
			{
				NumberLeftRed++;
			}
			foreach (var token in gm.GoldTokens.Where(token => token.Available))
			{
				NumberLeftGold++;
			}
        }
		
		private bool CheckFirstToken(Colors.Color tokenColor)
		{
			switch (tokenColor)
			{
				case Colors.Color.Green:
					if (gm.GetPlayer().firstToken == null && gm.GetPlayer().GetTokenCount() < 10)
					{
						gm.GetPlayer().GreenTokens++;
						int greenIndex = gm.FirstAvailableToken(Colors.Color.Green);
						gm.GreenTokens[greenIndex].transform.position = gm.GetPlayer().greenTokenSlot.position + new Vector3(gm.GetPlayer().GreenOffset, 0, 0);
						gm.GreenTokens[greenIndex].InPossession = gm.GetPlayer();
						gm.GreenTokens[greenIndex].Available = false;
						gm.GetPlayer().GreenOffset += (float)0.3;
						gm.GetPlayer().firstToken = this;
						return true;
					}

					break;
				
				case Colors.Color.Black:
					if (gm.GetPlayer().firstToken == null && gm.GetPlayer().GetTokenCount() < 10)
					{
						gm.GetPlayer().BlackTokens++;
						int blackIndex = gm.FirstAvailableToken(Colors.Color.Black);
						gm.BlackTokens[blackIndex].transform.position = gm.GetPlayer().blackTokenSlot.position + new Vector3(gm.GetPlayer().BlackOffset, 0, 0);
						gm.BlackTokens[blackIndex].InPossession = gm.GetPlayer();
						gm.BlackTokens[blackIndex].Available = false;
						gm.GetPlayer().BlackOffset += (float)0.3;
						gm.GetPlayer().firstToken = this;
						return true;
					}
					
					break;
				
				case Colors.Color.Blue:
					if (gm.GetPlayer().firstToken == null && gm.GetPlayer().GetTokenCount() < 10)
					{
						gm.GetPlayer().BlueTokens++;
						int blueIndex = gm.FirstAvailableToken(Colors.Color.Blue);
						gm.BlueTokens[blueIndex].transform.position = gm.GetPlayer().blueTokenSlot.position + new Vector3(gm.GetPlayer().BlueOffset, 0, 0);
						gm.BlueTokens[blueIndex].InPossession = gm.GetPlayer();
						gm.BlueTokens[blueIndex].Available = false;
						gm.GetPlayer().BlueOffset += (float)0.3;
						gm.GetPlayer().firstToken = this;
						return true;
					}
					break;

				case Colors.Color.Gold:
					if (gm.GetPlayer().firstToken == null && gm.GetPlayer().GetTokenCount() < 10)
					{
						gm.GetPlayer().GoldTokens++;
						int goldIndex = gm.FirstAvailableToken(Colors.Color.Gold);
						gm.GoldTokens[goldIndex].transform.position = gm.GetPlayer().goldTokenSlot.position + new Vector3(gm.GetPlayer().GoldOffset, 0, 0);
						gm.GoldTokens[goldIndex].InPossession = gm.GetPlayer();
						gm.GoldTokens[goldIndex].Available = false;
						gm.GetPlayer().GoldOffset += (float)0.3;
						gm.GetPlayer().firstToken = this;
						return true;
					}
					break;
				
				case Colors.Color.Red:
					if (gm.GetPlayer().firstToken == null && gm.GetPlayer().GetTokenCount() < 10)
					{
						gm.GetPlayer().RedTokens++;
						int redIndex = gm.FirstAvailableToken(Colors.Color.Red);
						gm.RedTokens[redIndex].transform.position = gm.GetPlayer().redTokenSlot.position + new Vector3(gm.GetPlayer().RedOffset, 0, 0);
						gm.RedTokens[redIndex].InPossession = gm.GetPlayer();
						gm.RedTokens[redIndex].Available = false;
						gm.GetPlayer().RedOffset += (float)0.3;
						gm.GetPlayer().firstToken = this;
						return true;
					}
					break;
				
				case Colors.Color.White:
					if (gm.GetPlayer().firstToken == null && gm.GetPlayer().GetTokenCount() < 10)
					{
						gm.GetPlayer().WhiteTokens++;
						int whiteIndex = gm.FirstAvailableToken(Colors.Color.White);
						gm.WhiteTokens[whiteIndex].transform.position = gm.GetPlayer().whiteTokenSlot.position + new Vector3(gm.GetPlayer().WhiteOffset, 0, 0);
						gm.WhiteTokens[whiteIndex].InPossession = gm.GetPlayer();
						gm.WhiteTokens[whiteIndex].Available = false;
						gm.GetPlayer().WhiteOffset += (float)0.3;
						gm.GetPlayer().firstToken = this;
						return true;
					}
					break;
			}

			return false;
		}

		private bool CheckSecondToken(Colors.Color tokenColor)
		{
			switch (tokenColor)
			{
				case Colors.Color.Green:
					if (gm.GetPlayer().secondToken == null && gm.GetPlayer().GetTokenCount() < 10)
					{
						// For the player to take 2 of the same kind tokens there needs to be 4 or more of the same kind tokens left
						if (gm.GetPlayer().firstToken.Color == Color && gm.AllAvailableTokens(gm.GreenTokens) >= 4)
						{
							gm.GetPlayer().GreenTokens++;
							int greenIndex = gm.FirstAvailableToken(Colors.Color.Green);
							gm.GreenTokens[greenIndex].transform.position = gm.GetPlayer().greenTokenSlot.position + new Vector3(gm.GetPlayer().GreenOffset, 0, 0);
							gm.GreenTokens[greenIndex].InPossession = gm.GetPlayer();
							gm.GreenTokens[greenIndex].Available = false;
							gm.GetPlayer().GreenOffset += (float)0.3;
							gm.GetPlayer().secondToken = this;
							gm.GetPlayer().TookTokens = true;
							return true;
						}

						if (gm.GetPlayer().firstToken.Color != Color)
						{
							gm.GetPlayer().GreenTokens++;
							int greenIndex = gm.FirstAvailableToken(Colors.Color.Green);
							gm.GreenTokens[greenIndex].transform.position = gm.GetPlayer().greenTokenSlot.position + new Vector3(gm.GetPlayer().GreenOffset, 0, 0);
							gm.GreenTokens[greenIndex].InPossession = gm.GetPlayer();
							gm.GreenTokens[greenIndex].Available = false;
							gm.GetPlayer().GreenOffset += (float)0.3;
							gm.GetPlayer().secondToken = this;
							return true;
						}
					}
					break;
				
				case Colors.Color.Black:
					if (gm.GetPlayer().secondToken == null && gm.GetPlayer().GetTokenCount() < 10)
					{
						// For the player to take 2 of the same kind tokens there needs to be 4 or more of the same kind tokens left
						if (gm.GetPlayer().firstToken.Color == Color && gm.AllAvailableTokens(gm.BlackTokens) >= 4)
						{
							gm.GetPlayer().BlackTokens++;
							int blackIndex = gm.FirstAvailableToken(Colors.Color.Black);
							gm.BlackTokens[blackIndex].transform.position = gm.GetPlayer().blackTokenSlot.position + new Vector3(gm.GetPlayer().BlackOffset, 0, 0);
							gm.BlackTokens[blackIndex].InPossession = gm.GetPlayer();
							gm.BlackTokens[blackIndex].Available = false;
							gm.GetPlayer().BlackOffset += (float)0.3;
							gm.GetPlayer().secondToken = this;
							gm.GetPlayer().TookTokens = true;
							return true;
						}

						if (gm.GetPlayer().firstToken.Color != Color)
						{
							gm.GetPlayer().BlackTokens++;
							int blackIndex = gm.FirstAvailableToken(Colors.Color.Black);
							gm.BlackTokens[blackIndex].transform.position = gm.GetPlayer().blackTokenSlot.position + new Vector3(gm.GetPlayer().BlackOffset, 0, 0);
							gm.BlackTokens[blackIndex].InPossession = gm.GetPlayer();
							gm.BlackTokens[blackIndex].Available = false;
							gm.GetPlayer().BlackOffset += (float)0.3;
							gm.GetPlayer().secondToken = this;
							return true;
						}
					}
					break;
				
				case Colors.Color.Blue:
					if (gm.GetPlayer().secondToken == null && (gm.GetPlayer().GetTokenCount() < 10))
					{
						if (gm.GetPlayer().firstToken.Color == Color && gm.AllAvailableTokens(gm.BlueTokens) >= 4)
						{
							gm.GetPlayer().BlueTokens++;
							int blueIndex = gm.FirstAvailableToken(Colors.Color.Blue);
							gm.BlueTokens[blueIndex].transform.position = gm.GetPlayer().blueTokenSlot.position + new Vector3(gm.GetPlayer().BlueOffset, 0, 0);
							gm.BlueTokens[blueIndex].InPossession = gm.GetPlayer();
							gm.BlueTokens[blueIndex].Available = false;
							gm.GetPlayer().BlueOffset += (float) 0.3;
							gm.GetPlayer().secondToken = this;
							gm.GetPlayer().TookTokens = true;
							return true;
						}

						if (gm.GetPlayer().firstToken.Color != Color)
						{
							gm.GetPlayer().BlueTokens++;
							int blueIndex = gm.FirstAvailableToken(Colors.Color.Blue);
							gm.BlueTokens[blueIndex].transform.position = gm.GetPlayer().blueTokenSlot.position + new Vector3(gm.GetPlayer().BlueOffset, 0, 0);
							gm.BlueTokens[blueIndex].InPossession = gm.GetPlayer();
							gm.BlueTokens[blueIndex].Available = false;
							gm.GetPlayer().BlueOffset += (float)0.3;
							gm.GetPlayer().secondToken = this;
							return true;
						}
					}
					break;
				
				case Colors.Color.Gold:
					if (gm.GetPlayer().secondToken == null && gm.GetPlayer().GetTokenCount() < 10)
					{
						if (gm.GetPlayer().firstToken.Color == Color && gm.AllAvailableTokens(gm.GoldTokens) >= 4)
						{
							gm.GetPlayer().GoldTokens++;
							int goldIndex = gm.FirstAvailableToken(Colors.Color.Gold);
							gm.GoldTokens[goldIndex].transform.position = gm.GetPlayer().goldTokenSlot.position + new Vector3(gm.GetPlayer().GoldOffset, 0, 0);
							gm.GoldTokens[goldIndex].InPossession = gm.GetPlayer();
							gm.GoldTokens[goldIndex].Available = false;
							gm.GetPlayer().GoldOffset += (float)0.3;
							gm.GetPlayer().secondToken = this;
							gm.GetPlayer().TookTokens = true;
							return true;
						}

						if (gm.GetPlayer().firstToken.Color != Color)
						{
							gm.GetPlayer().GoldTokens++;
							int goldIndex = gm.FirstAvailableToken(Colors.Color.Gold);
							gm.GoldTokens[goldIndex].transform.position = gm.GetPlayer().goldTokenSlot.position + new Vector3(gm.GetPlayer().GoldOffset, 0, 0);
							gm.GoldTokens[goldIndex].InPossession = gm.GetPlayer();
							gm.GoldTokens[goldIndex].Available = false;
							gm.GetPlayer().GoldOffset += (float) 0.3;
							gm.GetPlayer().secondToken = this;
							return true;
						}
					}
					break;
				
				case Colors.Color.Red:
					if (gm.GetPlayer().secondToken == null && gm.GetPlayer().GetTokenCount() < 10)
					{
						if (gm.GetPlayer().firstToken.Color == Color && gm.AllAvailableTokens(gm.RedTokens) >= 4)
						{
							gm.GetPlayer().RedTokens++;
							int redIndex = gm.FirstAvailableToken(Colors.Color.Red);
							gm.RedTokens[redIndex].transform.position = gm.GetPlayer().redTokenSlot.position + new Vector3(gm.GetPlayer().RedOffset, 0, 0);
							gm.RedTokens[redIndex].InPossession = gm.GetPlayer();
							gm.RedTokens[redIndex].Available = false;
							gm.GetPlayer().RedOffset += (float)0.3;
							gm.GetPlayer().secondToken = this;
							gm.GetPlayer().TookTokens = true;
							return true;
						}

						if (gm.GetPlayer().firstToken.Color != Color)
						{
							gm.GetPlayer().RedTokens++;
							int redIndex = gm.FirstAvailableToken(Colors.Color.Red);
							gm.RedTokens[redIndex].transform.position = gm.GetPlayer().redTokenSlot.position + new Vector3(gm.GetPlayer().RedOffset, 0, 0);
							gm.RedTokens[redIndex].InPossession = gm.GetPlayer();
							gm.RedTokens[redIndex].Available = false;
							gm.GetPlayer().RedOffset += (float) 0.3;
							gm.GetPlayer().secondToken = this;
							return true;
						}
					}
					break;
				
				case Colors.Color.White:
					if (gm.GetPlayer().secondToken == null && gm.GetPlayer().GetTokenCount() < 10)
					{
						if (gm.GetPlayer().firstToken.Color == Color && gm.AllAvailableTokens(gm.WhiteTokens) >= 4)
						{
							gm.GetPlayer().WhiteTokens++;
							int whiteIndex = gm.FirstAvailableToken(Colors.Color.White);
							gm.WhiteTokens[whiteIndex].transform.position = gm.GetPlayer().whiteTokenSlot.position + new Vector3(gm.GetPlayer().WhiteOffset, 0, 0);
							gm.WhiteTokens[whiteIndex].InPossession = gm.GetPlayer();
							gm.WhiteTokens[whiteIndex].Available = false;
							gm.GetPlayer().WhiteOffset += (float)0.3;
							gm.GetPlayer().secondToken = this;
							gm.GetPlayer().TookTokens = true;
							return true;
						}

						if (gm.GetPlayer().firstToken.Color != Color)
						{
							gm.GetPlayer().WhiteTokens++;
							int whiteIndex = gm.FirstAvailableToken(Colors.Color.White);
							gm.WhiteTokens[whiteIndex].transform.position = gm.GetPlayer().whiteTokenSlot.position + new Vector3(gm.GetPlayer().WhiteOffset, 0, 0);
							gm.WhiteTokens[whiteIndex].InPossession = gm.GetPlayer();
							gm.WhiteTokens[whiteIndex].Available = false;
							gm.GetPlayer().WhiteOffset += (float) 0.3;
							gm.GetPlayer().secondToken = this;
							return true;
						}
					}
					break;
			}

			return false;
		}

		private void CheckThirdToken(Colors.Color tokenColor)
		{
			switch (tokenColor)
			{
				case Colors.Color.Green:
					if (gm.GetPlayer().thirdToken == null && (gm.GetPlayer().firstToken.Color != Colors.Color.Green &&
							gm.GetPlayer().secondToken.Color != Colors.Color.Green) && gm.GetPlayer().GetTokenCount() < 10)
					{
						gm.GetPlayer().GreenTokens++;
						int greenIndex = gm.FirstAvailableToken(Colors.Color.Green);
						gm.GreenTokens[greenIndex].transform.position = gm.GetPlayer().greenTokenSlot.position + new Vector3(gm.GetPlayer().GreenOffset, 0, 0);
						gm.GreenTokens[greenIndex].InPossession = gm.GetPlayer();
						gm.GreenTokens[greenIndex].Available = false;
						gm.GetPlayer().GreenOffset += (float)0.3;
						gm.GetPlayer().thirdToken = this;
						gm.GetPlayer().TookTokens = true;
					}
					else
					{
						Debug.Log("Cant get another green token");
					}
					break;
				
				case Colors.Color.Black:
					if (gm.GetPlayer().thirdToken == null && (gm.GetPlayer().firstToken.Color != Colors.Color.Black &&
							gm.GetPlayer().secondToken.Color != Colors.Color.Black) && gm.GetPlayer().GetTokenCount() < 10)
					{
						gm.GetPlayer().BlackTokens++;
						int blackIndex = gm.FirstAvailableToken(Colors.Color.Black);
						gm.BlackTokens[blackIndex].transform.position = gm.GetPlayer().blackTokenSlot.position + new Vector3(gm.GetPlayer().BlackOffset, 0, 0);
						gm.BlackTokens[blackIndex].InPossession = gm.GetPlayer();
						gm.BlackTokens[blackIndex].Available = false;
						gm.GetPlayer().BlackOffset += (float)0.3;
						gm.GetPlayer().thirdToken = this;
						gm.GetPlayer().TookTokens = true;
					}

					else
					{
						Debug.Log("Cant get another black token");
					}
					break;
				
				case Colors.Color.Blue:
					if (gm.GetPlayer().thirdToken == null && (gm.GetPlayer().firstToken.Color != Colors.Color.Blue && gm.GetPlayer().secondToken.Color != Colors.Color.Blue)
						&& (gm.GetPlayer().GetTokenCount() < 10))
					{
						gm.GetPlayer().BlueTokens++;
						int blueIndex = gm.FirstAvailableToken(Colors.Color.Blue);
						gm.BlueTokens[blueIndex].transform.position = gm.GetPlayer().blueTokenSlot.position + new Vector3(gm.GetPlayer().BlueOffset, 0, 0);
						gm.BlueTokens[blueIndex].InPossession = gm.GetPlayer();
						gm.BlueTokens[blueIndex].Available = false;
						gm.GetPlayer().BlueOffset += (float)0.3;
						gm.GetPlayer().thirdToken = this;
						gm.GetPlayer().TookTokens = true;
					}

					else
					{
						Debug.Log("Cant get another blue token");
					}
					break;
				
				case Colors.Color.Gold:
					if (gm.GetPlayer().thirdToken == null && (gm.GetPlayer().firstToken.Color != Colors.Color.Gold && gm.GetPlayer().secondToken.Color != Colors.Color.Gold)
						&& (gm.GetPlayer().GetTokenCount() < 10))
					{
						gm.GetPlayer().GoldTokens++;
						int goldIndex = gm.FirstAvailableToken(Colors.Color.Gold);
						gm.GoldTokens[goldIndex].transform.position = gm.GetPlayer().goldTokenSlot.position + new Vector3(gm.GetPlayer().GoldOffset, 0, 0);
						gm.GoldTokens[goldIndex].InPossession = gm.GetPlayer();
						gm.GoldTokens[goldIndex].Available = false;
						gm.GetPlayer().GoldOffset += (float)0.3;
						gm.GetPlayer().thirdToken = this;
						gm.GetPlayer().TookTokens = true;
					}
					else
					{
						Debug.Log("Cant get another gold token");
					}
					break;
				
				case Colors.Color.Red:
					if (gm.GetPlayer().thirdToken == null && (gm.GetPlayer().firstToken.Color != Colors.Color.Red &&
							gm.GetPlayer().secondToken.Color != Colors.Color.Red) && (gm.GetPlayer().GetTokenCount() < 10))
					{
						gm.GetPlayer().RedTokens++;
						int redIndex = gm.FirstAvailableToken(Colors.Color.Red);
						gm.RedTokens[redIndex].transform.position = gm.GetPlayer().redTokenSlot.position + new Vector3(gm.GetPlayer().RedOffset, 0, 0);
						gm.RedTokens[redIndex].InPossession = gm.GetPlayer();
						gm.RedTokens[redIndex].Available = false;
						gm.GetPlayer().RedOffset += (float)0.3;
						gm.GetPlayer().thirdToken = this;
						gm.GetPlayer().TookTokens = true;
					}
					else
					{
						Debug.Log("Cant get another red token");
					}

					break;
				
				case Colors.Color.White:
					if (gm.GetPlayer().thirdToken == null && (gm.GetPlayer().firstToken.Color != Colors.Color.White &&
							gm.GetPlayer().secondToken.Color != Colors.Color.White) && (gm.GetPlayer().GetTokenCount() < 10))
					{
						gm.GetPlayer().WhiteTokens++;
						int whiteIndex = gm.FirstAvailableToken(Colors.Color.White);
						gm.WhiteTokens[whiteIndex].transform.position = gm.GetPlayer().whiteTokenSlot.position + new Vector3(gm.GetPlayer().WhiteOffset, 0, 0);
						gm.WhiteTokens[whiteIndex].InPossession = gm.GetPlayer();
						gm.WhiteTokens[whiteIndex].Available = false;
						gm.GetPlayer().WhiteOffset += (float)0.3;
						gm.GetPlayer().thirdToken = this;
						gm.GetPlayer().TookTokens = true;
					}
					else
					{
						Debug.Log("Cant get another white token");
					}
					break;
			}
		}

	}
}
