using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject StartButton;
    public GameObject CreditsButton;
    public GameObject ExitButton;
    public GameObject StartArrow;
    public GameObject CreditsArrow;
    public GameObject ExitArrow;

    int Selected = 0;

    public void changeScene(string targetScene)
    {
        Debug.Log("Loading Scene");
        SceneManager.LoadScene(targetScene);
    }

    public void exitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
