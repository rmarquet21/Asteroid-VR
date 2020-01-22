using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty : MonoBehaviour
{

    private float time = 0f;
    public GameObject gravite;
    private gravité grav;
    public GameObject lazer;

    private void Start()
    {
        Time.timeScale = 1f;

        grav =  gravite.GetComponent<gravité>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if(time > 45 && gameObject.GetComponent<spawnRandom>().timeRest > 1)
        {
            grav.m_ForceGravitionelle += 100000;
            gameObject.GetComponent<spawnRandom>().timeRest -= 0.5f;
            time = 0f;
        }

       // Debug.Log("Temps = " + time);
       // Debug.Log("Difficulté = " + gameObject.GetComponent<spawnRandom>().timeRest);
    }
}
