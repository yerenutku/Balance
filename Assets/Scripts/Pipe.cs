using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Pipe : MonoBehaviour {
	public Transform endCoordinate;
	public Transform pathCoordinate1;
	public Transform pathCoordinate2;
	public Transform pathCoordinate3;
	public Transform pathCoordinate4;
	public GameObject player;
	Queue <Vector3> route;
	
	// Use this for initialization
	void Start () {
		
		route=new Queue<Vector3>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log ("Değdik");
		if (other.transform.tag == "Player" ) {
			player=other.transform.gameObject;
			CharacterStates CS=other.transform.GetComponent<CharacterStates>();
			CharacterControl CC=other.transform.GetComponent<CharacterControl>();
			if(CS.State!=0){
				if(CS.State==3)
				{
					
					
					CC.transform.position=transform.position;
					StartPipeMove();
					CC.finishedPipe=false;
					
					
					
					CC.movementState=4;
					
				}}
			
		}
		
		
		
	}
	
	void OnTriggerExit2D(Collider2D other)
	{
		Debug.Log("çıktık");
		if (other.transform.tag == "Player") {
			CharacterStates CS = other.transform.GetComponent<CharacterStates> ();
			CharacterControl CC = other.transform.GetComponent<CharacterControl> ();
			if (CC.movementState == 0&&CS.State==5) {
				CS.State = 3;
			}
		}
	}
	
	void StartPipeMove()
	{
		route.Clear ();
		CharacterControl CC = player.GetComponent<CharacterControl> ();
		if (pathCoordinate1 != null) {
			route.Enqueue (pathCoordinate1.position);
		}
		if (pathCoordinate2 != null) {
			route.Enqueue (pathCoordinate2.position);
		}
		if (pathCoordinate3 != null) {
			route.Enqueue (pathCoordinate3.position);
		}
		if (pathCoordinate4 != null) {
			route.Enqueue (pathCoordinate4.position);
		}
		
		route.Enqueue (endCoordinate.transform.position);
		
		CC.Route.Clear ();
		
		CC.Route = route;
		CC.startedPipe = true;
		
	}
	
	
	
}