using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimer : MonoBehaviour
{
    public float Time = 10.0f;
    float Frames = 0;

	void Update ()
    {
        ++Frames;

        if(Frames > Time * 60)
        {
            Destroy(gameObject);
        }
	}
}
