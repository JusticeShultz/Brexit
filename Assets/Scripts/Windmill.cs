using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Windmill : MonoBehaviour {

    Transform transform = GetComponent<Transform>();

	// Use this for initialization
	/*void Start () {
		
	}*/
	
	void Update ()
    {
        transform.Rotate(Vector3.right * Time.deltaTime);
    }
}
