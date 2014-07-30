using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	public float startTime;
	public float currentTime;
	// Use this for initialization
	void Start () {
		startTime = Time.time;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if ((Time.time - startTime) > 4.0f) {
			Debug.Log("yok ol");
			Destroy(transform.gameObject);
			
		}
		
		
		if ((int)(transform.eulerAngles.z) == 180) {//sola
			
			transform.position+=Vector3.left*Time.deltaTime*10;
			
		} else {//sağa
			transform.position+=Vector3.right*Time.deltaTime*10;
		}
	}
	
	
	void OnTriggerEnter2D(Collider2D other){
		
		Debug.Log ("Trigger enter");
		if (other.transform.tag == "Enemy") {
			Debug.Log("enemye vurdu");
			
			Destroy(other.transform.gameObject);
			Destroy(transform.gameObject);
			
		}
		
		
	}
}