using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioSlider : MonoBehaviour {

    public AudioSource music;
    public Slider audioSlider;

    public void Start()
    {
        audioSlider.value = (audioSlider.value / 2);
    }
    public void onValueChanged()
    {
        music.volume = audioSlider.value;
    }
}
