using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class LaserPrefab1 : MonoBehaviour
{

    private float _speedY = -15f;
    

    private Rigidbody2D _rb2d;
    
    void Start()
    {
        Destroy(this.gameObject, 0.7f);
        _rb2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rb2d.MovePosition(_rb2d.position+new Vector2(0, _speedY)*Time.deltaTime);   
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            SpaceShipController.score++;
            SpaceShipController.textoScore.text= "Score:" + SpaceShipController.score;

        }
    }
}
