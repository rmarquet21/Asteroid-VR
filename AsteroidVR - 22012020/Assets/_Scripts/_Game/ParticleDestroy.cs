using UnityEngine;
using System.Collections;

public class ParticleDestroy : MonoBehaviour
{
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(GetComponent<ParticleSystem>().main.duration);
        Destroy(gameObject);
    }
}
