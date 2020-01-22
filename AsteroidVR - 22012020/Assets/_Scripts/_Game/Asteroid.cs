using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    private int vie = 10;
    public Transform explosion;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Collider>().enabled = false;        
        gameObject.GetComponent<Collider>().enabled = true;
    }

    private void FixedUpdate()
    {
        if (vie < 0)
        {
            countScore.score += 100;
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 11)
        {
            Destroy(gameObject);
        }
        else if (collision.gameObject.layer == 9)
        {
            vie -= 1;
        }
        else if (collision.gameObject.name == "vie")
        {
            Destroy(gameObject);
        }

    }

    private void OnDestroy()
    {
        Instantiate(explosion,transform.position, Quaternion.identity);
    }
}
