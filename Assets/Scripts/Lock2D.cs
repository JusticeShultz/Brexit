using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock2D : MonoBehaviour {
    // Update is called once per frame
    float zOffset;
    void Start() {
        zOffset = transform.position.z;
    }
	void Update () {
		transform.position = new Vector3(transform.position.x,transform.position.y,zOffset);
	}
}
