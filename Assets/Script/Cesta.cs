using UnityEngine;
using System.Collections;

public class Cesta : MonoBehaviour {
	public GameObject cestaPrefab;
	public GameObject pajaroder;
	public GameObject pajaroiz;
	// Use this for initialization
	void Start () {
		//Instantiate (gusanoPrefab);
		InvokeRepeating ("obtenerpajaroder", 4f, 5);
		InvokeRepeating ("obtenerpajaroiz", 8f, 8);
		//for(int i=0;i<3;i++){
			GameObject cesta = Instantiate (cestaPrefab) as GameObject;
			cesta.transform.position=new Vector3(0,0,0);
			cesta.tag="Cestas";

		//}
	}




	/*public static void borrarCesta(){
		//Destroy(GameObject.FindGameObjectWithTag("Cesta"+(Movimiento.getCestas())));
		Movimiento.eliminarCestas();
		if(Movimiento.getCestas()==0){
			Movimiento.setCestas(3);
			if (Movimiento.score > Record.score) {
				Record.score = Movimiento.score;
			}
			Application.LoadLevel("escena_menu");

		}
	}*/

	void obtenerpajaroder(){
		float valoraleat = Random.value;
		float valoraleatposy= Random.Range(10,28);
		//Debug.Log (valoraleat);
		//if (valoraleat > 0f && valoraleat <= 1f) {
		Instantiate (pajaroder,new Vector3(-60,valoraleatposy,0),Quaternion.identity);


	}
	void obtenerpajaroiz(){
		float valoraleat = Random.value;
		float valoraleatposy= Random.Range(9,26);
		//Debug.Log (valoraleat);
		//if (valoraleat > 0f && valoraleat <= 1f) {
		Quaternion rotacion = Quaternion.Euler(new Vector3(0,-180,0));
		Instantiate (pajaroiz,new Vector3(60,valoraleatposy,0),rotacion);
		
		
	}
	// Update is called once per frame
	void Update () {
				
	}
	
}
