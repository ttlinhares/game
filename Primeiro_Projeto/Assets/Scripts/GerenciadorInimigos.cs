using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorInimigos : MonoBehaviour
{
    [SerializeField]
    private GameObject prefabInimigo;
    private GameObject prefabLaser;

    [SerializeField]
    private float maxTime = 1;
    private float shotTime = 0.5f;
    private float timeIcre = 0;

    void Update()
    {
        timeIcre += Time.deltaTime;
        if(timeIcre >= maxTime)
        {
            var x = Random.Range(-9f, 9f);
            Instantiate(prefabInimigo, new Vector2(x, 6.3f), transform.rotation);
            
            timeIcre = 0;


        }
    }
}
