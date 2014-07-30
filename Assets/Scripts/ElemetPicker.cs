using UnityEngine;
using System.Collections;

public class ElemetPicker : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.transform.tag == "Player") {
			CharacterStates CS=other.transform.GetComponent<CharacterStates>();
			if(transform.gameObject.name=="air")
			{
				CS.activeAir=true;
				CS.SetAir();

			}
			if(transform.gameObject.name=="stone")
			{
				CS.activeStone=true;
				CS.SetStone();
				
			}
			if(transform.gameObject.name=="water")
			{
				CS.activeWater=true;
				CS.SetWater();
				
			}
			if(transform.gameObject.name=="fire")
			{
				CS.activeFire=true;
				CS.SetFire();
				
			}

			Destroy(transform.gameObject);
		
		
		
		}


	}
}
