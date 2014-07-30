using UnityEngine;
using System.Collections;

public class CharacterStates : MonoBehaviour {
	//Character States
	
	//0--->idle
	//1--->Stone
	//2--->Air
	//3--->Water
	//4--->Fire
	
	public int State=0;

public	bool activeStone=false;
	public	bool activeAir=false;
	public	bool activeWater=false;
	public	bool activeFire=false;

	CharacterControl CC;
	AudioSource AS;
	
	// Use this for initialization
	void Start () {
		CC = GetComponent<CharacterControl> ();
		AS = GetComponent<AudioSource> ();
		StateDefault ();
	}
	
	// Update is called once per frame
	void Update () {
		if (State == 1) {
				
			if(AS.clip==CC.switchSound && !AS.isPlaying)
			{
				AS.clip=CC.stoneSound;
				AS.loop=true;
				AS.Play();


			}
		
		}
		if (State == 2) {
			
			if(AS.clip==CC.switchSound && !AS.isPlaying)
			{
				AS.clip=CC.airSound;
				AS.loop=true;
				AS.Play();
				
				
			}
			
		}
		if (State == 3) {
			
			if(AS.clip==CC.switchSound && !AS.isPlaying)
			{
				AS.clip=CC.waterSound;
				AS.loop=true;
				AS.Play();
				
				
			}
			
		}
		if (State == 4) {
			
			if(AS.clip==CC.switchSound && !AS.isPlaying)
			{
				AS.clip=CC.fireSound;
				AS.loop=true;
				AS.Play();
				
				
			}
			
		}
	}
	
	public	void StateDefault()
	{
		AS.Stop ();
		AS.clip = CC.switchSound;
		AS.loop = false;
		AS.Play ();
		Debug.Log("Setted idle");
		State=0;
		CC.upMultiplier = 15.0f;
		CC.horizantalMultiplier = 350.0f;
		CC.fallingSpeedLimit = -16.8f;
		CC.maxSpeed = 2.0f;
		
		
	}
	
	public	void SetStone()
	{
		if (activeStone) {

						StateDefault ();



						Debug.Log ("Setted Stone");
		
		
						State = 1;
						CC.fallingSpeedLimit = -100000.0f;
		
						CC.upMultiplier = 10.0f;
						Vector3 cor = rigidbody2D.velocity;
						cor.y = -20.0f;
						rigidbody2D.velocity = cor;
						CC.horizantalMultiplier = 100.0f;
				}
		
	}
	public	void SetAir()
	{
		if (activeAir) {

						StateDefault ();

						Debug.Log ("Setted Air");
		
		
						State = 2;
						CC.upMultiplier *= Mathf.Sqrt (2.0f);
				}
	}
	
	public void SetWater()
	{
		if (activeWater) {
						StateDefault ();
						Debug.Log ("Setted Water");
						State = 3;
				}
		
	}
	public void SetFire()
	{
		if (activeFire) {
						StateDefault ();
						Debug.Log ("Setted Fire");
						State = 4;
				}
		
		
	}
}