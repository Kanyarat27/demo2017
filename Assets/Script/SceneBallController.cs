using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneBallController : MonoBehaviour {

	// Use this for initialization
	public Text txtScore;
	public Text txtAttack;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	int score = 0;
	int attack = 10;
	public void DoPushButton(){
		score++;
		attack += 2;
		txtScore.text = "Score :" + score.ToString ();
		txtAttack.text = "Attack :" + attack.ToString ();
	}
	public void DoChangScene(){
		SceneManager.LoadScene (0);
	}
}
