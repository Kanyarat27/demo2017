﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

	public Rigidbody rg;
	public float speed;
	public TextMesh txtBall;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void DoJump(){
		rg.velocity = new Vector3(0,speed,0);
	}
	int countcollosion = 0;
	void OnCollisionEnter(Collision collision){
		Debug.LogFormat ("collision is {0}", collision.gameObject.tag);
		if (collision.gameObject.tag == "floor") {
			countcollosion++;
			txtBall.text = "Floor : " + countcollosion.ToString ();
		}
	}
}
