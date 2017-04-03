using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barras : MonoBehaviour {
	public Punteo x;
	int reinicio;
	public Transform explosion;
	public Punteo punteo;
	// Use this for initialization
	void Start () {
		//x = GameObject.FindWithTag("Texto").GetComponent<Punteo>();
		reinicio = 28;
		punteo = GameObject.FindWithTag ("punteo").GetComponent<Punteo> ();
	}
	
	// Update is called once per frame
	void Update () {


	}

	void OnCollisionEnter2D(Collision2D col){

		if(col.gameObject.name == "bola" || col.gameObject.name == "bola(Clone)"){
			punteo.Incremento ();
			Destroy (this.gameObject);
			reinicio--;
			Instantiate (explosion, transform.position, explosion.rotation);
		//	x.Incremento();

		}

	}
}
