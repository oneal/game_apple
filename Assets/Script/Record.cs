﻿using UnityEngine;
using System.Collections;

public class Record : MonoBehaviour {
	static public int score = 0;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		GUIText gt = this.GetComponent<GUIText>();
		gt.text = "Record: "+score;
	}
}
