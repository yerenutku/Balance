using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {
	public GameObject Player;
	CharacterStates CS;
	public bool rightrot=true;
	public int i=0;
	// Use this for initialization
	void Start () {
		CS = Player.GetComponent<CharacterStates> ();

	}
	
	// Update is called once per frame
	void Update () {
		i = 0;
		if (CS.activeAir) {
				
			i++;
		
		}
		if (CS.activeFire) {
			
			i++;
			
		}
		if (CS.activeStone) {
			
			i++;
			
		}
		if (CS.activeWater) {
			
			i++;
			
		}




		Vector3 playercor= Player.transform.position;

		playercor.z = transform.position.z;
		transform.position = playercor;

		Vector3 camerapo = transform.position;

		if (transform.position.x < -17) {
			camerapo.x=-17;
			transform.position=camerapo;
		}
		if (transform.position.x > 16) {
			camerapo.x=16;
			transform.position=camerapo;
		}
		if (transform.position.y > 22) {
			camerapo.y=22;
			transform.position=camerapo;
		}
		if (transform.position.y < -14) {
			camerapo.y=-14;
			transform.position=camerapo;
		}
		if (rightrot) {

						if (transform.eulerAngles.z < 15 || transform.eulerAngles.z>345) {
				
								transform.eulerAngles += new Vector3 (0, 0, 1) * Time.deltaTime * i;
						} else {
								rightrot = !rightrot;
								transform.eulerAngles -= new Vector3 (0, 0, 1) * Time.deltaTime * i;
						}
				} else {
			if (transform.eulerAngles.z > 345 || transform.eulerAngles.z < 15 ) {
				
				transform.eulerAngles -= new Vector3 (0, 0, 1) * Time.deltaTime * i*2;
			} else {
				rightrot = !rightrot;
				transform.eulerAngles += new Vector3 (0, 0, 1) * Time.deltaTime * i*2;
			}


		 if(transform.eulerAngles.z < 330 && transform.eulerAngles.z>30)
			{

				transform.eulerAngles=new Vector3(0,0,0);

			}
		}
	}
}
