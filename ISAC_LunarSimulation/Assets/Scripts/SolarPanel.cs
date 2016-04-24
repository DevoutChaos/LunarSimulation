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
        [Header("Chance out of 10000 for breakage")]
        public int BreakChance = 9999;
        System.Random rand = new System.Random();
        public GameMaster gm;
        public Sprite sprite0;
        public Sprite sprite1;


        void Start()
        {

        }

        void Update()
        {
            if (!Broken)
            {
                GetComponent<SpriteRenderer>().sprite = sprite0;
                gm.electricity = gm.electricity + 0.01f;
                var chance = rand.Next(1, 10000);
                if (chance >= BreakChance)
                    Broken = true;
            }
            else if (Broken)
            {
                GetComponent<SpriteRenderer>().sprite = sprite1;
            }
                
        }

        void OnTriggerStay2D(Collider2D other)
        {
            if (other.tag == "Player" && Input.GetKeyDown(KeyCode.F) && Broken == true)
            {
                Debug.Log("Fixed Solar Panel");
                Broken = false;
            }
        }
    }
}
