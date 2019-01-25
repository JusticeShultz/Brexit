using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoLoad : MonoBehaviour
{
    public GameObject Sound;
    int Frame = 0;

    void Update ()
    {
        ++Frame;
        
        if(Frame >= 200)
        {
            Sound.SetActive(true);
        }
	}
}
