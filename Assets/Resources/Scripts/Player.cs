using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    public float moveSpeed;
    Vector3 positiveMovement;
    public float jumpForce;
    Vector3 jump;
    Rigidbody rBody;

	// Use this for initialization
	void Start () {
        positiveMovement = new Vector3(moveSpeed, 0, 0);
        jump = new Vector3(0, jumpForce, 0);
        rBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        rBody.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, rBody.velocity.y, 0);
        if (Input.GetButtonDown("Jump")) {
            rBody.AddForce(jump);
        }

	}
}
