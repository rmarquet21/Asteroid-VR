using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnRandom : MonoBehaviour
{
    private Vector3 Min;
    private Vector3 Max;
    private float _xAxis;
    private float _yAxis;
    private float _zAxis; //If you need this, use it
    private Vector3 _randomPosition;
    public bool _canInstantiate;
    public float time = 5;
    public float timeRest = 5;
    public GameObject[] prefabs = new GameObject[1];

    private void Start()
    {
        SetRanges();
    }
    private void Update()
    {
        _xAxis = Random.Range(Min.x, Max.x);
        _yAxis = Random.Range(Min.y, Max.y);
        _zAxis = Random.Range(Min.z, Max.z);
        _randomPosition = new Vector3(_xAxis, _yAxis, _zAxis);
        time -= Time.deltaTime;
        if (time < 0) { InstantiateRandomObjects(); time = timeRest; }
    }
    //Here put the ranges where your object will appear, or put it in the inspector.
    private void SetRanges()
    {
        Min = new Vector3(-50, -50, -50); //Random value.
        Max = new Vector3(50, 50, 50); 
    }
    private void InstantiateRandomObjects()
    {
        if (_canInstantiate)
        {
            Instantiate(prefabs[Random.Range(0,prefabs.Length)], _randomPosition, Quaternion.identity);
        }

    }

}
