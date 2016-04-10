using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour {

	public float speed=10f;

	static public GUIText scoreGT;
	static public GUIText vidasGT;
	static public int score;

	public GameObject gusanoPrefab;

	// Use this for initialization
	void Start () {

		//GameObject scoreGO = ;
		scoreGT = GameObject.FindGameObjectWithTag("Puntuacion").GetComponent<GUIText>();
		scoreGT.text = "0";
		//vidasGT = GameObject.FindGameObjectWithTag("vidas").GetComponent<GUIText>();


		/*for(int i=0;i<3;i++){
			GameObject cesta = Instantiate (cestaPrefab) as GameObject;
			cesta.transform.position=new Vector3(0,(i*2),0);

		}*/
	}
	
	// Update is called once per frame
	void Update () {

			/*float dx = Input.GetAxis ("Horizontal") * speed * Time.deltaTime;
			Vector3 posicion = new Vector3 (dx, 0f, 0f);
		
			GameObject.FindGameObjectWithTag ("Cesta1").transform.Translate (dx, 0f, 0f);
			GameObject.FindGameObjectWithTag ("Cesta2").transform.Translate (dx, 0f, 0f);
			GameObject.FindGameObjectWithTag ("Cesta3").transform.Translate (dx, 0f, 0f);*/

			Vector3 mousePos2D = Input.mousePosition;
			Vector3 mousePos3D = Camera.main.ScreenToWorldPoint (mousePos2D);
			
			Vector3 pos = this.transform.position;
			pos.x = mousePos3D.x;
			if (pos.x >= -20 && pos.x <= 20) {
				this.transform.position = pos;
			}
			if (Input.GetMouseButtonDown (0)) {
				Instantiate(gusanoPrefab, GameObject.FindGameObjectWithTag ("Cestas").transform.position, Quaternion.identity);
			}
			
	}


	void OnMouseDown(){
		//gusano.transform.position=GameObject.FindGameObjectWithTag ("Cesta1").transform.position;
	}

	void OnCollisionEnter(Collision otro){


		if (otro.gameObject.tag == "Manzana") {
			Destroy(otro.gameObject);
			score = int.Parse( scoreGT.text );
			score += 100;
			scoreGT.text = score.ToString();

			
		}else if(otro.gameObject.tag == "ManzanaVerde"){
			Destroy(otro.gameObject);
			//Cesta.borrarCesta();
			Vidas.vidas-=1;
			if (Vidas.vidas == 0) {
				Application.LoadLevel("escena_menu");
				Vidas.vidas=3;
				if (score>Record.score){
					Record.score=score;
				}
			}

		}
	}
	
	/*void OnTriggerEnter(Collider otro){
		if (otro.gameObject.tag == "Manzana") {
			int score = int.Parse( scoreGT.text );
			score += 100;
			scoreGT.text = score.ToString();
			Debug.Log (scoreGT.text);
		}
		
	}*/



	/*public static int getCestas(){
		return cestas;		
	}

	public static void setCestas(int cesta){
		cestas = cesta;
	}

	public static void eliminarCestas() {
		cestas--;
	}*/
}