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
        public int NumberLeft;
        private void Start()
        {
            gm = FindObjectOfType<GameManager>();
        }

        private void Update()
        {
            if(NumberLeft == 0)
                gameObject.SetActive(false);
        }

        private void OnMouseOver()
        {
            if (Input.GetMouseButtonDown(0))
            {
                switch (Color)
                {
                    case Colors.Color.Green:
                        if (NumberLeft > 0)
                        {
                            gm.player1.GreenTokens++;
                            NumberLeft--;
                        }

                        break;
                    case Colors.Color.Black:
                        if (NumberLeft > 0)
                        {
                            gm.player1.BlackTokens++;
                            NumberLeft--;
                        }

                        break;
                    case Colors.Color.Blue:
                        if (NumberLeft > 0)
                        {
                            gm.player1.BlueTokens++;
                            NumberLeft--;
                        }

                        break;
                    case Colors.Color.Gold:
                        if (NumberLeft > 0)
                        {
                            gm.player1.GoldTokens++;
                            NumberLeft--;
                        }

                        break;
                    case Colors.Color.Red:
                        if (NumberLeft > 0)
                        {
                            gm.player1.RedTokens++;
                            NumberLeft--;
                        }

                        break;
                    case Colors.Color.White:
                        if (NumberLeft > 0)
                        {
                            gm.player1.WhiteTokens++;
                            NumberLeft--;
                        }

                        break;
                }
            }
        }
    }
}
