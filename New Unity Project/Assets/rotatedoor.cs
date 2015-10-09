using UnityEngine;
using System.Collections;

public class rotatedoor : MonoBehaviour {

	// Use this for initialization
    bool door;
     float  x,y,z;
 
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        var dist = Vector3.Distance(Camera.main.transform.position, transform.position);
        if (dist < 1)
        {
            if (Input.GetKeyDown("e"))
            {



                transform.rotation = Quaternion.Euler(0 , 0, 0);
                print("space key was pressed");
            }
        }

       
	
	}
   
}
