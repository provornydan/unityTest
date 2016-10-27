using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;
	private Rigidbody2D myRigidbody;
	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent<Rigidbody2D> (); 
	}
	 
	// Update is called once per frame
	void Update () {
		if(Input.GetAxisRaw ("Horizontal") > 0f)
		{
			myRigidbody.velocity = new Vector3(moveSpeed, 
		}  
	}
}
