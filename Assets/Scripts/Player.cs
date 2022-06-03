using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class Player : MonoBehaviour
    {
        public GameManager gm;
        public string Name;
        public int Points;
        public int BlackTokens;
        public int BlueTokens;
        public int GreenTokens;
        public int RedTokens;
        public int WhiteTokens;
        public int GoldTokens;
        public List<Card> ReservedCards;

        public int BlackCards;
        public int BlueCards;
        public int GreenCards;
        public int RedCards;
        public int WhiteCards;

        public Player()
        {

        }

        public Player(string name, int points, int blackTokens, int blueTokens, int greenTokens, int redTokens,
            int whiteTokens, int goldTokens, int blackCards, int blueCards, int greenCards, int redCards, int whiteCards)
        {
            Name = name;
            Points = points;
            BlackTokens = blackTokens;
            BlueTokens = blueTokens;
            GreenTokens = greenTokens;
            RedTokens = redTokens;
            WhiteTokens = whiteTokens;
            GoldTokens = goldTokens;
            BlackCards = blackCards;
            BlueCards = blueCards;
            GreenCards = greenCards;
            RedCards = redCards;
            WhiteCards = whiteCards;
        }
        private void Start()
        {
            gm = FindObjectOfType<GameManager>();
        }

        private void Update()
        {

        }
    }
}
