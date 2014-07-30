using UnityEngine;
using System.Collections;

public class AIPatrol : MonoBehaviour {
	public GameObject leftWP;
	public GameObject rightWP;
	bool leftWPa=false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!leftWPa) {
			transform.position +=((leftWP.transform.position-transform.position).normalized*Time.deltaTime*3);
			if((leftWP.transform.position-transform.position).magnitude<0.5f)
			{
				leftWPa=!leftWPa;
			}
		} else {
			transform.position+=((rightWP.transform.position-transform.position).normalized*Time.deltaTime*3);
			if((rightWP.transform.position-transform.position).magnitude<0.5f)
			{
				leftWPa=!leftWPa;
			}
		}
		
		
	}
	void OnCollisionEnter2D(Collision2D other){
	if (other.transform.tag == "Player") {
			Debug.Log("çaptın öldün");		
		
		}
	
	}
}