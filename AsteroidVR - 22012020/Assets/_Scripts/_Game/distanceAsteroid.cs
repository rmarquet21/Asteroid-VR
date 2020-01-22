using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distanceAsteroid : MonoBehaviour
{
    private Vector3 asteroid;
    private void Update()
    {
        asteroid = transform.parent.position;
        float posCube = transform.position.y;

        transform.position = new Vector3(asteroid.x,asteroid.y/2,asteroid.z);
        transform.localScale = new Vector3(0.5f,asteroid.y,0.5f);

        transform.eulerAngles = new Vector3(0, 0, 0);

    }
}
