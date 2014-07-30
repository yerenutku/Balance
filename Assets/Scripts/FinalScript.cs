using UnityEngine;
using System.Collections;

public class FinalScript : MonoBehaviour {
	GameObject C;
	Camera CM;
	SpriteRenderer SR;
	bool onetime=true;
	bool finished=false;
	// Use this for initialization
	void Start () {
		C=GameObject.FindGameObjectWithTag("MainCamera").gameObject;
		CM=C.GetComponent<Camera>();
		SR = GetComponent<SpriteRenderer> ();
			SR.enabled=false;




	}
	
	// Update is called once per frame
	void Update () {
	if (CM.i == 4&& onetime) {
			SR.enabled=true;
			onetime=false;
			finished=true;

		}
	}

	void OnTriggerEnter2D(Collider2D other){
		//	Debug.Log("girdi");
		if (other.transform.tag == "Player") {
			if(finished){


				Application.LoadLevel("fin");

			Debug.Log("bitti");
			}

		}}
}
