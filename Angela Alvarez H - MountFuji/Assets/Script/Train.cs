using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Train : MonoBehaviour {
	public float speedz;
	public float speedy;
	public float speedx;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate (speedx, speedy, speedz);
	}
}
