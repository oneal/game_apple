using UnityEngine;
using System.Collections;

public class Pajaroiz : MonoBehaviour {
	
	private float speed=30f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (((0-Time.deltaTime)*speed),0, 0);	
		
	}
}
