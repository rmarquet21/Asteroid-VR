using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject,10);
    }

    private void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(this.gameObject.name + "->" + gameObject.GetComponent<Rigidbody>().velocity.sqrMagnitude + "("+ collision.gameObject.name + ")");

        if (collision.gameObject.layer.Equals(10) && (gameObject.GetComponent<Rigidbody>().velocity.sqrMagnitude > 900))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.layer.Equals(11))
        {
            this.gameObject.GetComponent<Rigidbody>().velocity = transform.forward * 2;
        }
    }
}
