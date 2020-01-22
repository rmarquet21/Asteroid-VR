using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetVolume : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider slider;
    public string nameVolume;


    void Start()
    {
        slider.value = PlayerPrefs.GetFloat(nameVolume, 0.75f);
    }

    public void SetLevel()
    {
        float sliderValue = slider.value;
        mixer.SetFloat(nameVolume, Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat(nameVolume, sliderValue);
    }

}