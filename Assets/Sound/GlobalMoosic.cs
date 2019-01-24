using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalMoosic : MonoBehaviour
{
	void Start ()
    {
        SceneManager.LoadScene("MainMenu");
        DontDestroyOnLoad(this);
    }
}
