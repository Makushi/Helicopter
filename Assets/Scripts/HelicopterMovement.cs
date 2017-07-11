using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	//<>
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) 
		{
			transform.Translate(Vector3.back);
		}
		if (Input.GetKey (KeyCode.S)) 
		{
			transform.Translate(Vector3.forward);
		}
		if (Input.GetKey(KeyCode.A)) 
		{
			transform.Rotate (Vector3.down);
		}
		if (Input.GetKey(KeyCode.D)) 
		{
			transform.Rotate (Vector3.up);
		}
		if (Input.GetKey(KeyCode.Space)) 
		{
			transform.Translate (Vector3.up);
		}
		if (Input.GetKey(KeyCode.C)) 
		{
			transform.Translate (Vector3.down);
		}
		/*if (Input.GetKey(KeyCode.F)) 
		{
			RaycastHit hit;

			if (Physics.Raycast(transform.position, transform.right ,out hit))
			{
				hit.rigidbody.AddForceAtPosition (transform.right * 10F, hit.point, ForceMode.Impulse);
			}	
		}*/
	}
}