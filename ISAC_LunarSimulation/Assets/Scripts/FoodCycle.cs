using UnityEngine;
using System.Collections;

public class FoodCycle : MonoBehaviour {
    //Declarations
    public int stage;
    public GameMaster gm;
    public Sprite sprite0;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (stage == 0)
        {
            GetComponent<SpriteRenderer>().sprite = sprite0;
        }
        else if (stage == 1)
        {
            GetComponent<SpriteRenderer>().sprite = sprite1;
        }
        else if (stage == 2)
        {
            GetComponent<SpriteRenderer>().sprite = sprite2;
        }
        else if (stage == 3)
        {
            GetComponent<SpriteRenderer>().sprite = sprite3;
        }
	}

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player" && Input.GetKeyDown(KeyCode.F))
        {
            if (stage != 3)
            {
                stage++;
            }
            else
            {
                gm.food += 1;
                stage = 0;
            }
        }
    }
}
