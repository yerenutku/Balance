using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class CharacterControl : MonoBehaviour
{




	public AudioClip fireSound;
	public AudioClip waterSound;
	public AudioClip  stoneSound;
	public AudioClip airSound;
	public AudioClip switchSound;

	
	public Vector3 savepoint=new Vector3(0,1,0 ); 
	float startFireTime=0;
	bool startFire=false;
	int characterStateCache=0;
	public float upMultiplier = 14.0f;
	public float horizantalMultiplier = 350.0f;
	//float jumpThreshold=-0.5f;
	public bool canJump = true;
	public float horizantalSpeed;
	public bool canHorizantal = true;
	public float fallingSpeedLimit = -16.8f;
	public float maxSpeed = 2.0f;
	int layerMask = Convert.ToInt32 ("01111111", 2);
	public Queue<Vector3> Route;
	public Vector3 target;
	public bool finishedPipe=false;
	public	bool startedPipe=false;
	public int whichSide=1;//0 for left , 1 for right
	//Movement States
	//0-->normal
	//1-->Stairs//implemented later
	//3-->Pipe
	public	int movementState = 0;
	CharacterStates CS;
	public GameObject FireBullet;
	Vector3 InverseRot = new Vector3 (0, 180, 0);
	Animator A;
	// Use this for initialization
	void Awake ()
	{
	}
	
	void Start ()



	{	
		A = GetComponent<Animator> ();
		finishedPipe=false;
		Route = new Queue<Vector3> ();
		fallingSpeedLimit = -16.8f;
		upMultiplier = 14.0f;
		CS = GetComponent<CharacterStates> ();
		target = transform.position;
		
	}
	
	// Update is called once per frame
	void Update ()
	{

		rigidbody2D.gravityScale=2;
		rigidbody2D.isKinematic=false;
		
		if (startFire) {
			
			if(Time.time-startFireTime>0.5f)
			{
				startFire=false;
				
				
			}
			
		}
		
		if (movementState == 0) {
			
			
			
			Route = new Queue<Vector3> ();
			if (Input.GetKeyDown (KeyCode.Space) ) {
				if(canJump){

					Vector2 cor = rigidbody2D.velocity;
					cor.y = upMultiplier;
					//Debug.Log(rigidbody2D.velocity);
					rigidbody2D.velocity = cor;
					//Debug.Log(rigidbody2D.velocity);
					
					
					//rigidbody2D.AddForce(Vector2.up*upMultiplier);
					
					canJump = false;
					horizantalSpeed = rigidbody2D.velocity.x;
					
				}
				
			}

			if(Input.GetKey (KeyCode.LeftArrow)||Input.GetKey (KeyCode.RightArrow)){

			if (Input.GetKey (KeyCode.LeftArrow) && canHorizantal) {

				transform.rotation=Quaternion.Euler (InverseRot);
				if(CS.State==0)
				{
					A.SetInteger("behaviour",0);
				}
				else if(CS.State==1)
				{
					A.SetInteger("behaviour",1);
				}
				else if(CS.State==2)
				{
					A.SetInteger("behaviour",2);
				}
				else if(CS.State==3)
				{
					A.SetInteger("behaviour",3);
				}
				else if(CS.State==4)
				{
					A.SetInteger("behaviour",4);
				}


				whichSide=0;
				rigidbody2D.AddForce (Vector2.right * -1 * horizantalMultiplier);
				//Debug.Log("Left Arrow Click");
				
			}
			
			if (Input.GetKey (KeyCode.RightArrow) && canHorizantal) {
				transform.rotation=Quaternion.identity;
				if(CS.State==0)
				{
					A.SetInteger("behaviour",0);
				}
				else if(CS.State==1)
				{
					A.SetInteger("behaviour",1);
				}
				else if(CS.State==2)
				{
					A.SetInteger("behaviour",2);
				}
				else if(CS.State==3)
				{
					A.SetInteger("behaviour",3);
				}
				else if(CS.State==4)
				{
					A.SetInteger("behaviour",4);
				}

				whichSide=1;
				
				rigidbody2D.AddForce (Vector2.right * horizantalMultiplier);
				//Debug.Log("Right Arrow Click");
			}
			}
			else if (rigidbody2D.velocity.y == 0) {




				if (CS.State == 0) {
					A.SetInteger ("behaviour", 5);
				} else if (CS.State == 1) {
					A.SetInteger ("behaviour",6);
				} else if (CS.State == 2) {
					A.SetInteger ("behaviour", 7);
				} else if (CS.State == 3) {
					A.SetInteger ("behaviour", 8);
				} else if (CS.State == 4) {
					A.SetInteger ("behaviour", 9);
				}
			}
			if (rigidbody2D.velocity.x > maxSpeed) {
				Vector2 cor = rigidbody2D.velocity;
				cor.x = maxSpeed;
				rigidbody2D.velocity = cor;
				
			}
			if (rigidbody2D.velocity.x < -maxSpeed) {
				Vector2 cor = rigidbody2D.velocity;
				cor.x = -maxSpeed;
				rigidbody2D.velocity = cor;
				
			}
			
			if (Physics2D.Raycast (transform.position, Vector2.up * -1, 1.5f, layerMask)) {
				//	Debug.Log("ray değdi");
				//			Debug.Log(rigidbody2D.velocity.y);
				//Debug.Log(rigidbody2D.velocity.y);
				if (rigidbody2D.velocity.y < fallingSpeedLimit) {
						

					transform.position=savepoint;	
					rigidbody2D.velocity=Vector2.zero;
				}
			}
			
			
			
			if (Input.GetKeyDown (KeyCode.S)) {//stone 
				if (CS.State == 1) {
					CS.StateDefault ();
				} else {
					CS.SetStone ();
				}
			}
			
			if (Input.GetKeyDown (KeyCode.W)) {//air
				if (CS.State == 2) {
					CS.StateDefault ();
				} else {
					CS.SetAir ();
				}
				
				
				
			}
			if (Input.GetKeyDown (KeyCode.A)) {//water
				if (CS.State == 3) {
					CS.StateDefault ();
				} else {
					CS.SetWater ();
				}
				
				
				
			}
			if (Input.GetKeyDown (KeyCode.D)) {//fire
				if (CS.State == 4) {
					CS.StateDefault ();
				} else {
					CS.SetFire ();
				}
				
			
				
			}
			Vector3 pos = transform.position;
			pos.z = -5;
			transform.position = pos;
		} else if (movementState == 1) {
		} else if (movementState == 2) {
			
			
			
		} else if (movementState == 4) {//pipe kayması
			CS.State=5;
			rigidbody2D.gravityScale=0;
			rigidbody2D.isKinematic=true;
			Vector3 pos = transform.position;
			pos.z = 0;
			transform.position = pos;
			
			if(startedPipe)
			{
				
				target=Route.Dequeue();
				startedPipe=false;
				
				
				
				
			}
			Vector3 veloc=target-transform.position;
			Debug.DrawLine(transform.position,transform.position+veloc,Color.red);
			if(!finishedPipe)
			{
				
				if((transform.position-target).magnitude<0.2f)
				{
					if(Route.Count>0)
					{
						target=Route.Dequeue();
					}
					else
					{
						finishedPipe=true;
						
						movementState=0;
						//CS.State=3;
						
					}
					
					
				}
				else
				{
					veloc.Normalize();
					transform.position+=veloc*Time.deltaTime*10;
				}
			}
			
			
			
		}
		
		
		
		if(Input.GetKeyDown(KeyCode.LeftControl)&& CS.State==4)
		{
			Debug.Log("Fire");
			
			if(!startFire)
				
				
			{
				startFire=true;
				startFireTime=Time.time;
				if(whichSide==1)
				{
					Instantiate(FireBullet, transform.position,Quaternion.identity);
				}
				else
				{
					Vector3 rot= new Vector3(0,0,180);
					Instantiate(FireBullet, transform.position,Quaternion.Euler(rot));
				}
				//fire will be here
			}
			
		}

		if (rigidbody2D.velocity.y > 0) {
						if (CS.State == 0) {
								A.SetInteger ("behaviour", 10);
						} else if (CS.State == 1) {
								A.SetInteger ("behaviour", 11);
						} else if (CS.State == 2) {
								A.SetInteger ("behaviour", 12);
						} else if (CS.State == 3) {
								A.SetInteger ("behaviour", 13);
						} else if (CS.State == 4) {
								A.SetInteger ("behaviour", 14);
						}
		
		
		
				} else if (rigidbody2D.velocity.y < 0) {
						if (CS.State == 0) {
								A.SetInteger ("behaviour", 15);
						} else if (CS.State == 1) {
								A.SetInteger ("behaviour", 16);
						} else if (CS.State == 2) {
								A.SetInteger ("behaviour", 17);
						} else if (CS.State == 3) {
								A.SetInteger ("behaviour", 18);
						} else if (CS.State == 4) {
								A.SetInteger ("behaviour", 19);
						}

				} 

		if (transform.position.y < -60) {
			transform.position=savepoint;		
		
		
		}
		
		//Debug.Log (rigidbody2D.velocity.y);

		
		
	}
	
	
	
	
}