using UnityEngine;
using System.Collections;

public class Manzana : MonoBehaviour {
	public float limit=-15f;
	private GUIText scoreGT;


	//public GameObject applePrefab;
	// Use this for initialization
	void Start () {


		//contador = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < limit) {
			Destroy(this.gameObject);
			Vidas.vidas-=1;
			if (Vidas.vidas == 0) {
				Application.LoadLevel("escena_menu");
				Vidas.vidas=3;
				if (Movimiento.score>Record.score){
					Record.score=Movimiento.score;
				}

			}
		}
	}


}
