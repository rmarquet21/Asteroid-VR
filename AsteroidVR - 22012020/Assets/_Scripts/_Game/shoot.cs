using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class shoot : MonoBehaviour
{
    public SteamVR_Action_Boolean shootAction;
    public SteamVR_Input_Sources handType;

    public float bulletSpeed = 10;
    public Rigidbody bullet;

    private bool canFire = true;
    public float fireRate = 0.05f;
    public float nextFire = 0.0f;

    IEnumerator Fire()
    {
        canFire = false;
        Rigidbody bulletClone = (Rigidbody)Instantiate(bullet, transform.position, transform.rotation);
        bulletClone.velocity = transform.forward * bulletSpeed;
        yield return new WaitForSeconds(fireRate);
        canFire = true;
    }

    void FixedUpdate()
    {
        if (shootAction.GetLastState(handType))
        {
            //  nextFire = Time.time + fireRate;
            if (canFire)
            {
                StartCoroutine(Fire());
            }
        }

    }

    public float BulletSpeed { set => bulletSpeed = value; }
}
