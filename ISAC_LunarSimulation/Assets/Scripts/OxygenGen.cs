using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    class Oxygen : MonoBehaviour
    {
        public bool Broken;
        public int BrokeVal;
        System.Random rand = new System.Random();
        public GameMaster gm;


        void Start()
        {
        }

        void Update()
        {
            if (!Broken)
            {
                gm.oxygen = gm.oxygen + 1;
                var chance = rand.Next(1, 100);
                if (chance >= 99)
                    Broken = true;
            }
                
        }
    }
}
