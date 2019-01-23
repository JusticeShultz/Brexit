using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsCinematic : MonoBehaviour
{
    public float speed = 30f;
    void Update()
    {
        transform.localRotation *= Quaternion.AngleAxis(speed * Time.deltaTime, Vector3.up);
    }
}
