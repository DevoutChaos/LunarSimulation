using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    class SolarPanel : MonoBehaviour
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
                gm.electricity = gm.electricity + 0.01f;
                var chance = rand.Next(1, 10000);
                if (chance >= 9999)
                    Broken = true;
            }
                
        }
    }
}
