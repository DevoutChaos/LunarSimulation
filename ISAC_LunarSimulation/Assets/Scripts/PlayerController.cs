using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    //Declarations
    public float moveSpeed;
    bool canMove;
    Vector3 pos;
    Transform tr;

	// Use this for initialization
	void Start () {
        pos = transform.position;
        tr = transform;
	}
	
	// Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && transform.position == pos)
        {
            pos += Vector3.up;
        }

        if (Input.GetKey(KeyCode.A) && transform.position == pos)
        {
            pos += Vector3.left;
        }

        if (Input.GetKey(KeyCode.S) && transform.position == pos)
        {
            pos += Vector3.down;
        }

        if (Input.GetKey(KeyCode.D) && transform.position == pos)
        {
            pos += Vector3.right;
        }

        transform.position = Vector2.MoveTowards(transform.position, pos, Time.deltaTime * moveSpeed);
    }
}
