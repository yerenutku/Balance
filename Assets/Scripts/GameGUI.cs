using UnityEngine;
using System.Collections;

public class GameGUI : MonoBehaviour {
	public GUIStyle GS;
	CharacterStates CS;
	Rect stateAreas=new Rect(Screen.width/20,Screen.height/5*4-Screen.height/20,Screen.width/5,Screen.height/5);
	Rect waterIcon=new Rect(0,((Screen.height/5)/8)*3,Screen.width/20,Screen.height/20);
	Rect airIcon=new Rect(((Screen.width/5)/8)*3,(Screen.height/5)/16,Screen.width/20,Screen.height/20);
	Rect stoneIcon=new Rect(((Screen.width/5)/8)*3,((Screen.height/5)/16)*7,Screen.width/20,Screen.height/20);
	Rect fireIcon=new Rect(((Screen.width/5)/4)*3,((Screen.height/5)/8)*3,Screen.width/20,Screen.height/20);

	public Texture WD;
	public Texture FD;public Texture SD;public Texture AD;
	public Texture WA;
	public Texture FA;public Texture SA;public Texture AA;
	// Use this for initialization
	void Start () {
		CS = GetComponent<CharacterStates> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnGUI()
	{
		//GUI.Box(stateAreas,"Ana");
		GUI.BeginGroup (stateAreas);

		if(CS.State==3)
		GUI.Box (waterIcon,WA,GS);
		else
			GUI.Box (waterIcon,WD);
		if(CS.State==2)
		GUI.Box (airIcon,AA,GS);
		else
			GUI.Box (airIcon,AD);

		if(CS.State==1)
		GUI.Box (stoneIcon, SA,GS);
		else
			GUI.Box (stoneIcon,SD);
		if(CS.State==4)
		GUI.Box (fireIcon, FA);
		else
			GUI.Box (fireIcon,FD);
		
		GUI.EndGroup ();
		
		
	}
}