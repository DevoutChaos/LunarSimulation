using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    class Water : MonoBehaviour
    {
        public bool Broken;
        public int BrokeVal;
        System.Random rand = new System.Random();
        public GameMaster gm;
        public Sprite sprite0;
        public Sprite sprite1;


        void Start()
        {
        }

        void Update()
        {
            if (!Broken && gm.electricity > 0)
            {
                GetComponent<SpriteRenderer>().sprite = sprite0;
                gm.water = gm.water + 0.1f;
                gm.electricity -= 0.001f;
                var chance = rand.Next(1, 100);
                if (chance >= 99)
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
