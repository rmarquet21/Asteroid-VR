using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vie : MonoBehaviour
{
    public int vie;
    public GameObject gameOver;
    public GameObject laser;

    private void Update()
    {
        if(vie == 0)
        {
            gameOver.SetActive(true);
            Time.timeScale = 0f;
            laser.SetActive(true);

        }
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer.Equals(10))
        {
            vie -= 1;
        }
    }
}
