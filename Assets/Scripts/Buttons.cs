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

    int Selected = 1;
    float LastDelta = 0;

    private void Update()
    {
        if (PlayerNumber == 0) PlayerNumber = 1;

        if (Input.GetAxis("Vertical" + PlayerNumber) > 0.5 && LastDelta < 0.05 && LastDelta > -0.05)
        {
            Selected = Mathf.Clamp(++Selected, 1, 3);
        }

        if (Input.GetAxis("Vertical" + PlayerNumber) < -0.5 && LastDelta < 0.05 && LastDelta > -0.05)
        {
            Selected = Mathf.Clamp(--Selected, 1, 3);
        }

        LastDelta = Input.GetAxis("Vertical" + PlayerNumber);

        //print(Selected);

        StartArrow.GetComponent<Image>().enabled = (Selected == 1);
        CreditsArrow.GetComponent<Image>().enabled = (Selected == 2);
        ExitArrow.GetComponent<Image>().enabled = (Selected == 3);

        if (StartArrow.GetComponent<Image>().enabled)
        {
            StartButton.GetComponent<RectTransform>().position = Vector3.Lerp(StartButton.GetComponent<RectTransform>().position, new Vector3(264.3f, 328, 0), 0.1f);
            CreditsButton.GetComponent<RectTransform>().position = Vector3.Lerp(CreditsButton.GetComponent<RectTransform>().position, new Vector3(207, 239, 0), 0.1f);
            ExitButton.GetComponent<RectTransform>().position = Vector3.Lerp(ExitButton.GetComponent<RectTransform>().position, new Vector3(207, 150.6f, 0), 0.1f);

            if(Input.GetButtonDown("AButtonP1"))
            {
                changeScene("ReadyUp");
            }
        }

        if (CreditsArrow.GetComponent<Image>().enabled)
        {
            StartButton.GetComponent<RectTransform>().position = Vector3.Lerp(StartButton.GetComponent<RectTransform>().position, new Vector3(207, 328, 0), 0.1f);
            CreditsButton.GetComponent<RectTransform>().position = Vector3.Lerp(CreditsButton.GetComponent<RectTransform>().position, new Vector3(264.3f, 239, 0), 0.1f);
            ExitButton.GetComponent<RectTransform>().position = Vector3.Lerp(ExitButton.GetComponent<RectTransform>().position, new Vector3(207, 150.6f, 0), 0.1f);

            if (Input.GetButtonDown("AButtonP1"))
            {
                changeScene("Credits");
            }
        }

        if (ExitArrow.GetComponent<Image>().enabled)
        {
            StartButton.GetComponent<RectTransform>().position = Vector3.Lerp(StartButton.GetComponent<RectTransform>().position, new Vector3(207, 328, 0), 0.1f);
            CreditsButton.GetComponent<RectTransform>().position = Vector3.Lerp(CreditsButton.GetComponent<RectTransform>().position, new Vector3(207, 239, 0), 0.1f);
            ExitButton.GetComponent<RectTransform>().position = Vector3.Lerp(ExitButton.GetComponent<RectTransform>().position, new Vector3(264.3f, 150.6f, 0), 0.1f);

            if (Input.GetButtonDown("AButtonP1"))
            {
                exitGame();
            }
        }
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
