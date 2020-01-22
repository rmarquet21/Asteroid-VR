using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundControl : MonoBehaviour
{

    
    // Update is called once per frame
    public void sonPlus(Slider slider)
    {
        slider.value += 0.005f;
    }

    public void sonMoins(Slider slider)
    {
        slider.value -= 0.005f;
    }
}
