using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour {

	//修改後
	//public IntVariable score;

	private Text mScoreText;

	// Use this for initialization
	void Awake() {
		mScoreText = transform.Find ("ScoreText").GetComponentInChildren<Text> ();
	}

	// Update is called once per frame
	void Update () {
		//修改前
		mScoreText.text = "Score: " + Demo02_Logic.score;

		//修改後
		// mScoreText.text = "Score: " + score.value;
	}
}
