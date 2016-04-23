using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    //Declarations
    [Header("Set the player object here")]
    public Transform playerTransform;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 cameraPosition = new Vector2(playerTransform.position.x, playerTransform.position.y);
        transform.position = new Vector3(cameraPosition.x, cameraPosition.y, transform.position.z);
	}
}
