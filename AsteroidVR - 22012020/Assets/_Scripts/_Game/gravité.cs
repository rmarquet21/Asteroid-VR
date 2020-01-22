using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Attire tout objet ayant une Rigidbody vers celui-ci.
/// La GameObject doit avoir une SphereCollider avec isTrigger = true.
/// La GameObject doit avoir une GameObject avec un autre SphereCollider.
/// Pour élargir la région gravitationnelle, changer le rayon de la SphereCollider [isTrigger = true]
/// Denis Labrecque, Décembre 2018
/// Attribution 4.0 International
/// </summary>
public class gravité : MonoBehaviour
{
    public float m_ForceGravitionelle = 30.0f;
    private SphereCollider m_RegionGravitionelle; // Région dans laquelle tout GameObject avec Rigidbody sera attiré vers la planète
    private SphereCollider m_Terre; // SphereCollider qui représente la surface de la planète
    private float m_DistanceDattraction;

    void Awake()
    {
        m_RegionGravitionelle = GetComponent<SphereCollider>();
        m_RegionGravitionelle.isTrigger = true;
        m_Terre = GetComponentInChildren<SphereCollider>();
        m_DistanceDattraction = m_RegionGravitionelle.radius - m_Terre.radius;
    }

    /// <summary>
    /// Les calculs gravitationnels se font ici.
    /// </summary>
    /// <param name="other">Collider de l'objet qui est entré dans la région gravitationnelle.</param>
    void OnTriggerEnter(Collider other)
    {
        int layer = other.gameObject.layer;
        if (layer == 10)
        {
            if (other.attachedRigidbody)
            {
                float intensite = Vector3.Distance(transform.position, other.transform.position) / m_RegionGravitionelle.radius;

                other.attachedRigidbody.AddForce((transform.position - other.transform.position) * intensite * m_ForceGravitionelle * Time.deltaTime);

                Debug.DrawRay(other.transform.position, transform.position - other.transform.position);
            }
        }
    }

}
