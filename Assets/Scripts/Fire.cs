using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.DrawRay (transform.position, transform.forward * 200f);
		if (Input.GetKey(KeyCode.F)) 
		{
			Debug.DrawRay (transform.position, transform.forward * 200f);
			RaycastHit hit;

			if (Physics.Raycast(transform.position, transform.forward ,out hit))
			{
				hit.rigidbody.AddForceAtPosition (transform.forward * 10F, hit.point, ForceMode.Impulse);
			}	
		}
	}
}
