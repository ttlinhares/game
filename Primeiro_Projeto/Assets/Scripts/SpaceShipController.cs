using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : MonoBehaviour
{
    private float _speedX = 5f;
    private float _speedY = 5f;

    public GameObject prefabLaser;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(-0.01f,0,0);
        //transform.Rotate(0,0,0.01f);
        /*Debug.Log("Pressionando a tecla A: " + Input.GetKey(KeyCode.A));
        Debug.Log($"Teclar a tecla B: {Input.GetKeyDown(KeyCode.B)}");
        Debug.Log($"Soltar a tecla C: {Input.GetKeyUp(KeyCode.C)}");
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, _speedY, 0);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -_speedY, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(_speedX, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-_speedX, 0, 0);
        }
        Debug.Log($"Horizontal: {Input.GetAxis("Horizontal")}");*/

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        print($"H: {h}");
        print($"V: {v}");

        transform.Translate(h*_speedX*Time.deltaTime,v*_speedY* Time.deltaTime, 0);

        Instantiate(prefabLaser, transform.position + new Vector3(0,1,0), transform.rotation);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        //Destroy(other.gameObject);
    }

    void OnCollisionStay2D(Collision2D other)
    {
        print("A colisão está acontecendo: stay");
    }

    void OnCollisionExit2D(Collision2D other)
    {
        print("A colisão deixou de acontecer: exit");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        print("Trigger enter!");
    }
}
