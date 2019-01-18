using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreOtherPlayersCollider : MonoBehaviour
{
    public GameObject Obj1;
    public GameObject Obj2;

    // Use this for initialization
    void Start ()
    {
        Physics.IgnoreCollision(Obj1.GetComponent<Collider>(), Obj2.GetComponent<Collider>());
    }
	
	/*// Update is called once per frame
	void Update () {
		
	}*/
}
