using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    class SolarPanel : MonoBehaviour
    {
        public bool Broken { get; set; }
        public int BrokeVal { get; set; }
        System.Random rand = new System.Random();
        public GameMaster gm { get; set; }


        void Start()
        {
        }

        void Update()
        {
            if (!Broken)
            {
                gm.electricity = gm.electricity + 1;
                var chance = rand.Next(1, 100);
                if (chance >= 99)
                    Broken = true;
            }
                
        }
    }
}
