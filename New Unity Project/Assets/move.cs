using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	bool isMoving;
	Vector3 cameraDirection;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		cameraDirection = Camera.main.transform.forward;
		if (Cardboard.SDK.Triggered) {
			Input.GetKey(KeyCode.E);
			isMoving = !isMoving;



		}


	
	}

	void FixedUpdate(){

		if (isMoving) {
			GetComponent<Rigidbody>().AddRelativeForce(new Vector3 (cameraDirection.x,0, cameraDirection.z) * 500);
		
			isMoving = !isMoving;
		
		}

	}
}
