using UnityEngine;
using System.Collections;
using System;

public class Floor : MonoBehaviour {
	int layerMask=Convert.ToInt32("01111111", 2);
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collision2D coll){

		if (coll.transform.tag == "Player") {
				if(coll.transform.position.y>transform.position.y)
			{
				CharacterControl C=coll.transform.GetComponent<CharacterControl>();
				C.canJump=true;
//				Debug.Log(coll.transform.rigidbody2D.velocity.x);
			}
		
		}

	}

	void OnCollisionStay2D(Collision2D coll){

		if (coll.transform.tag == "Player") {


				CharacterControl C=coll.transform.GetComponent<CharacterControl>();

			RaycastHit2D[] hits=Physics2D.RaycastAll(coll.transform.position,Vector3.up*-1,1.0f,layerMask);
			RaycastHit2D[] hits2=Physics2D.RaycastAll(coll.transform.position+Vector3.right*0.5f,Vector2.up*-1,1.0f,layerMask);
			RaycastHit2D[] hits3=Physics2D.RaycastAll(coll.transform.position+Vector3.right*-1*0.5f,Vector2.up*-1,1.0f,layerMask);
			if(hits.Length>0||hits2.Length>0||hits3.Length>0)
			{
				C.canHorizantal=true;
			}
			else
			{
				C.canHorizantal=false;
			}
			
		}
	
	}

	void OnCollisionExit2D(Collision2D coll){

		if (coll.transform.tag == "Player") {
			
			
			CharacterControl C=coll.transform.GetComponent<CharacterControl>();
			C.canHorizantal=true;
			
			
		}
	
	}


}
