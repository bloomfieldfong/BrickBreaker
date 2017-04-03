using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour {
	Vector2 jugador;
	float   factorVel;
	public GameObject bola;
	int vida;


	// Use this for initialization
	void Start () {
		jugador = new Vector2(0.0f,0.0f);
		factorVel = 9.0f;	
		vida = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
		jugador.x = 0;

		if (Input.GetKey (KeyCode.LeftArrow)) {
			jugador.x = -1*factorVel * Time.deltaTime;
			transform.Translate (jugador);
		}
		if (Input.GetKey(KeyCode.RightArrow) ){
			jugador.x = factorVel * Time.deltaTime;
			transform.Translate(jugador);	
		} 

		if (Input.GetKey (KeyCode.R)) {
			Vector3 posIni = GameObject.Find("plato").transform.position;
			Instantiate(bola, transform.position, Quaternion.identity);
	
			vida++;
			if (vida == 1) {
				Destroy (GameObject.Find ("vida1"));
			}
			if (vida == 2) {
				Destroy(GameObject.Find("vida2"));
			}
			if (vida == 3) {
				Destroy(GameObject.Find("vida3"));
				gameOver ();
			}

		}



	}

	void gameOver(){
			Application.LoadLevel (0);
	}

}
