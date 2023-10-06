using Packages.Rider.Editor.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class InimigoController : MonoBehaviour
{
    [SerializeField]
    private float _speed = -8f;
    private Rigidbody2D _rb2d;
    public GameObject prefabLaser;
    public Transform firePoint;
    public float fireRate = 2f;
    private float nextFireTime;
    private float esquerda = 0;
    private bool direcaodefinida = false;

    private void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
        FixedUpdate();
    }

    private void FixedUpdate()
    {


        _rb2d.MovePosition(_rb2d.position + new Vector2(esquerda, _speed) * Time.deltaTime);

        bool rdmValue = Random.value > 0.5f;

        Debug.Log(rdmValue);


        if (_rb2d.position.y <= 0)
        {
            print("TESTE");
            if (rdmValue==true && direcaodefinida== false)
            {
                //_rb2d.MovePosition(_rb2d.position + new Vector2(1, _speed) * Time.deltaTime);
                direcaodefinida = true;
                esquerda = 4;
                print("Direita");
            }
            if (rdmValue == false && direcaodefinida == false)
            {
                //_rb2d.MovePosition(_rb2d.position + new Vector2(-1, _speed) * Time.deltaTime);
                direcaodefinida = true;
                esquerda= -4;
                print("esquerda");
            }
        }

        if (_rb2d.position.x < -10 || _rb2d.position.x > 10 || _rb2d.position.y < -10)
        {
            Destroy(gameObject);
        }

        if (Time.time > nextFireTime)
        {
            Atirar();
            nextFireTime = Time.time + 1f / fireRate;
        }

        void Atirar()
        {

            Instantiate(prefabLaser, transform.position + new Vector3(0, -2, 0), transform.rotation);
        }



    }


}
