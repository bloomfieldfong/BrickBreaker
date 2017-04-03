using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Bola : MonoBehaviour
{

    bool start = false;
    int vida;

    // Use this for initialization
    void Start()
    {
        //	GetComponent<Rigidbody2D> ().AddForce (transform.up * 250);
        vida = 0;

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) && start == false)
        {
            transform.SetParent(null);
            GetComponent<Rigidbody2D>().isKinematic = false;

            GetComponent<Rigidbody2D>().AddForce(transform.up * 250);
            GetComponent<Rigidbody2D>().AddForce(transform.right * 250);
            start = true;

        }

    }
    //Cuando toque las paredes se destruira la bola
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.name == "abajo")
        {
            Destroy(this.gameObject);



        }

    }
}
