using UnityEngine;
using System.Collections;

public class SavePoints : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
	//	Debug.Log("girdi");
	if (other.transform.tag == "Player") {
				
			CharacterControl CC=other.transform.GetComponent<CharacterControl>();
			CC.savepoint=transform.position;

		
		
		}
	
	}
}
