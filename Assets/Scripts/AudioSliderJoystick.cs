using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AudioSliderJoystick : MonoBehaviour
{
    public GameObject slider;
    static float volume = 1.0f;

	void Update ()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "Settings")
        {
            slider = GameObject.Find("SOUNDSLIDER");
            slider.GetComponent<Slider>().value = volume;

            if (Input.GetAxis("Horizontal1") > 0.1)
            {
                volume = Mathf.Clamp(volume + 0.01f, 0, 1);
            }

            if (Input.GetAxis("Horizontal1") < -0.1)
            {
                volume = Mathf.Clamp(volume - 0.01f, 0, 1);
            }
        }

        GetComponent<AudioSource>().volume = volume;
    }
}
