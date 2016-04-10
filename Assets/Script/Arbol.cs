using UnityEngine;
using System.Collections;

public class Arbol : MonoBehaviour {
	public GameObject applePrefabRoja;
	public GameObject applePrefabVerde;
	public float secondsBetweenAppleDrops=1f;
	public float leftAndRightEdge=10f;
	public float speed=1f;
	public float changedirection=0.1f;
	private float tiempoInici;

	// Use this for initialization
	void Start () {

		InvokeRepeating ("DropApple", 2f, secondsBetweenAppleDrops);
	}

	void DropApple(){

		float valoraleat = Random.value;

		if (valoraleat < 0.15f) {
			GameObject appleVerde = Instantiate (applePrefabVerde) as GameObject;
			appleVerde.transform.position = GameObject.FindGameObjectWithTag("Arbol").transform.position;
		} else {
			GameObject appleRoja = Instantiate (applePrefabRoja) as GameObject;
			appleRoja.transform.position = GameObject.FindGameObjectWithTag("Arbol").transform.position;
		}

		
	
		//Debug.Log (apple.transform.position + " " + GameObject.FindGameObjectWithTag("Arbol").transform.position);
	}
	
	// Update is called once per frame
	void Update () {
		tiempoInici += Time.deltaTime;
		if (tiempoInici > 5) {
			if(speed<0){
				speed-=Time.deltaTime;
				secondsBetweenAppleDrops-=Time.deltaTime;

			}else{
				speed+=Time.deltaTime;
				secondsBetweenAppleDrops-=Time.deltaTime;

			}

		}
		if(tiempoInici>15){
			tiempoInici=Time.timeScale;

		}


		Vector3 posicion = transform.position;
		posicion.x += speed * Time.deltaTime;
		transform.position = posicion;
		if (posicion.x < -leftAndRightEdge) {
			speed = Mathf.Abs (speed);
		}else if( posicion.x>leftAndRightEdge){
			speed =-Mathf.Abs(speed);
		}

	}

	void FixedUpdate(){
		if (Random.value < changedirection) {
			speed *= -1;	

		}
	}
}
