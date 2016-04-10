using UnityEngine;
using System.Collections;

public class Pajaro : MonoBehaviour {

	private float speed=30f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.Translate (((0 + Time.deltaTime) * speed), 0, 0);
		if (transform.position.x == 40) {
			Destroy (this.gameObject);
		}
		if(transform.position.x == -40){
			Destroy(this.gameObject);
		}

	}
}
