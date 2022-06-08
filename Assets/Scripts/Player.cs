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
		public Token firstToken;
		public Token secondToken;
		public Token thirdToken;
		public List<Card> ReservedCards;
		public bool IsTurn = false;
		public bool PlayedCard = false;
		public bool TookTokens = false;

		public int BlackCards;
        public int BlueCards;
        public int GreenCards;
        public int RedCards;
        public int WhiteCards;

        public Transform greenTokenSlot;
        public Transform blackTokenSlot;
        public Transform blueTokenSlot;
        public Transform redTokenSlot;
        public Transform whiteTokenSlot;
        public Transform goldTokenSlot;

		public float GreenOffset = 0;
		public float BlackOffset = 0;
		public float BlueOffset = 0;
		public float RedOffset = 0;
		public float WhiteOffset = 0;
		public float GoldOffset = 0;

		public Transform[] GreenCardSlots;
		public Transform[] BlackCardSlots;
		public Transform[] BlueCardSlots;
		public Transform[] RedCardSlots;
		public Transform[] WhiteCardSlots;

		public bool[] GreenCardSlotsAvailable;
		public bool[] BlackCardSlotsAvailable;
		public bool[] BlueCardSlotsAvailable;
		public bool[] RedCardSlotsAvailable;
		public bool[] WhiteCardSlotsAvailable;

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
			firstToken = null;
			secondToken = null;
			thirdToken = null;
		}
        private void Start()
        {
            gm = FindObjectOfType<GameManager>();
        }

        private void Update()
        {
		}

        public int GetTokenCount()
		{
			return BlackTokens + BlueTokens + RedTokens + GreenTokens + WhiteTokens + GoldTokens;
		}
    }
}
