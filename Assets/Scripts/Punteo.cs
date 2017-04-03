using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Punteo : MonoBehaviour {

	int punteo = 0;
	public Text texto;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void Incremento()
	{
		punteo = punteo + 10;
		texto.text = "Punteo: " + punteo;
	}

}
