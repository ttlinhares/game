using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserPrefab : MonoBehaviour
{

    private float _speedY = 15f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(0,_speedY * Time.deltaTime,0);
    }
}
