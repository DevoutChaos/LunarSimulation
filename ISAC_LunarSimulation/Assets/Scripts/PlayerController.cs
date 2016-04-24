using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    //Declarations
    public float moveSpeed;
    bool canMove;
    bool inSpaceSuit;
    public bool SuitSwitchable;
    public bool blocked;
    public float counter;
    SpriteRenderer[] suits;
    Vector3 pos;
    Transform tr;

    // Use this for initialization
    void Start()
    {
        blocked = false;
        pos = transform.position;
        tr = transform;
        inSpaceSuit = false;
        suits = (SpriteRenderer[])GetComponentsInChildren<SpriteRenderer>(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && SuitSwitchable)
        {
            Debug.Log("Hello!!!");
            SwitchCostume();
        }

        if (Input.GetKey(KeyCode.W) && transform.position == pos)
        {
            counter = 0;
            blocked = false;
            pos += Vector3.up;
            pos.x = Mathf.Round(pos.x);
            pos.y = Mathf.Round(pos.y);
            pos.z = 0;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        if (Input.GetKey(KeyCode.A) && transform.position == pos)
        {
            counter = 0;
            blocked = false;
            pos += Vector3.left;
            pos.x = Mathf.Round(pos.x);
            pos.y = Mathf.Round(pos.y);
            pos.z = 0;
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }

        if (Input.GetKey(KeyCode.S) && transform.position == pos)
        {
            counter = 0;
            blocked = false;
            pos += Vector3.down;
            pos.x = Mathf.Round(pos.x);
            pos.y = Mathf.Round(pos.y);
            pos.z = 0;
            transform.rotation = Quaternion.Euler(0, 0, 180);
        }

        if (Input.GetKey(KeyCode.D) && transform.position == pos)
        {
            counter = 0;
            blocked = false;
            pos += Vector3.right;
            pos.x = Mathf.Round(pos.x);
            pos.y = Mathf.Round(pos.y);
            pos.z = 0;
            transform.rotation = Quaternion.Euler(0, 0, 270);
        }
        if (!blocked && transform.position != pos)
        {
            counter += Time.deltaTime * moveSpeed;
            transform.position = Vector2.MoveTowards(transform.position, pos, Time.deltaTime * moveSpeed);

            if (counter >= 1.1)
            {
                blocked = true;
            }
        }
        if (blocked)
        {
            pos = transform.position;
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "spaceSuitCollider")
        {
            SuitSwitchable = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "spaceSuitCollider")
        {
            SuitSwitchable = false;
        }
    }

    public void SwitchCostume()
    {
        if (!inSpaceSuit)
        {
            
            suits[0].enabled = false;
            suits[1].enabled = true;
            inSpaceSuit = true;
        }
        else
        {
            suits[0].enabled = true;
            suits[1].enabled = false;
            inSpaceSuit = false;
        }
    }
}
