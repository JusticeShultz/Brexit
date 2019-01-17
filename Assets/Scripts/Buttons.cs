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

    [SerializeField] int PlayerNumber;

    int Selected = 0;
    float LastDelta = 0;

    private void Update()
    {
        if (PlayerNumber == 0) PlayerNumber = 1;

        if (Input.GetAxis("Vertical" + PlayerNumber) > 0.5 && LastDelta < 0.1)
        {
            Selected = Mathf.Clamp(++Selected, 1, 3);
        }

        if (Input.GetAxis("Vertical" + PlayerNumber) < -0.5 && LastDelta < 0.1)
        {
            Selected = Mathf.Clamp(--Selected, 1, 3);
        }

        LastDelta = Input.GetAxis("Vertical" + PlayerNumber);

        print(Selected);
    }

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
