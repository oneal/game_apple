using UnityEngine;
using System.Collections;

public class Gusano : MonoBehaviour {
	private float speed=30f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (0, ((0 + Time.deltaTime)*speed), 0);
		if (transform.position.y > 30) {
			Destroy(this.gameObject);
		}
	}

	void OnCollisionEnter(Collision otro){
		
		
		if (otro.gameObject.tag == "Manzana") {
			Destroy(otro.gameObject);
			Movimiento.score= int.Parse( Movimiento.scoreGT.text );
			Movimiento.score += 100;
			Movimiento.scoreGT.text = Movimiento.score.ToString();
			
		}
	}
}
