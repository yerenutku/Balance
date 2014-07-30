using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {
	public GameObject LeftTopMats;
	public GameObject LeftTopGross;
	//public GameObject Stairs;
	public GameObject LeftBotMats;
	public GameObject LeftBotGross;
	public GameObject RightTopPipe;
	public GameObject RightTopPipeOver;
	public GameObject RightTopGross;
	public GameObject RightBotMats;
	public GameObject RightBotGross;
	public GameObject PipeLeftHead;
	public GameObject PipeRightHead;
	public GameObject RightBotPipe;
	public GameObject PipeBotDownHead;
	public GameObject PipeBotRightHead;
	public GameObject border;
	public GameObject yatıkpipe;
	public GameObject ustpipe;
	// Use this for initialization
	void Start () {
		/* left start ***
		 * */
		PlaceSpiretesHorizantal (new Vector3(-1,-1,0) ,4, LeftTopMats);
		PlaceSpritesRectenguler (new Vector3 (-1, -1, 0), 4, 1, LeftTopMats);
		//lefttop zemin

		//PlaceSpiretesHorizantal (new Vector3(-30,1,0), 18, LeftTopMats);
		PlaceSpritesRectenguler (new Vector3 (-30, 1, 0), 4, 1, LeftTopGross);
		PlaceSpritesRectenguler (new Vector3 (-26, 1, 0), 2, 1, LeftTopMats);
		PlaceSpritesRectenguler (new Vector3 (-24, 1, 0), 6, 1, LeftTopGross);
		PlaceSpritesRectenguler (new Vector3 (-18, 1, 0), 12, 1, LeftTopMats);
		PlaceSpritesRectenguler (new Vector3 (-30, 0, 0), 24, 1, LeftTopMats);

		//lefttop ilk zıp
		//PlaceSpiretesHorizantal (new Vector3(-16,2,0), 11, LeftTopMats);
		PlaceSpritesRectenguler (new Vector3 (-13, 2, 0), 7, 1, LeftTopGross);
		//lefttop ikinci zıp

		PlaceSpritesRectenguler (new Vector3 (-18, 2, 0), 5, 4, LeftTopMats);
		PlaceSpritesRectenguler (new Vector3 (-18, 6, 0), 5, 1, LeftTopGross);

		//next to stairs
		PlaceSpritesRectenguler (new Vector3 (-26, 2, 0), 2, 9, LeftTopMats);
		PlaceSpritesRectenguler (new Vector3 (-26, 11, 0), 2, 1, LeftTopGross);

		//bottom starting
		//bottom first
		PlaceSpritesRectenguler (new Vector3 (-6, -5, 0), 4, 1, LeftBotGross);
		PlaceSpritesRectenguler (new Vector3 (-6, -6, 0), 4, 1, LeftBotMats);
		//bottom second
		PlaceSpritesRectenguler (new Vector3 (-15, -8, 0), 5, 1, LeftBotGross);
		PlaceSpritesRectenguler (new Vector3 (-15, -9, 0), 5, 2, LeftBotMats);

		//bottom third
		PlaceSpritesRectenguler (new Vector3 (-19, -9, 0), 3, 1, LeftBotGross);
		PlaceSpritesRectenguler (new Vector3 (-19, -10, 0), 3, 1, LeftBotMats);

		//bottom fourth trap!
		PlaceSpritesRectenguler (new Vector3 (-29, -13, 0), 4, 1, LeftBotGross);
		PlaceSpritesRectenguler (new Vector3 (-29, -14, 0), 4, 1, LeftBotMats);

		//bottom last
		PlaceSpritesRectenguler (new Vector3 (-21, -15, 0), 3, 1, LeftBotGross);
		PlaceSpritesRectenguler (new Vector3 (-21, -16, 0), 3, 1, LeftBotMats);
		//bottom ground
		PlaceSpritesRectenguler (new Vector3 (-27, -18, 0), 6, 1, LeftBotGross);
		PlaceSpritesRectenguler (new Vector3 (-27, -19, 0), 6, 1, LeftBotMats);
		/***left finish**
		 * **************
		 * ***right start***
		*/
		//right top pipe
		PlaceSpritesRectenguler (new Vector3 (7, 0, 0), 22, 1, yatıkpipe);
		//pipe head left
		//PlaceSpritesRectenguler (new Vector3 (6, 0, 0), 1, 1, PipeLeftHead);

		//right top pipe over
		PlaceSpritesRectenguler (new Vector3 (6, 1, 0), 22, 1, RightTopPipeOver);
		//right top pipe over jump 1
		PlaceSpritesRectenguler (new Vector3 (9, 2, 0), 2, 9, RightTopPipeOver);
		//Right Top gross over
		PlaceSpritesRectenguler (new Vector3 (9, 11, 0), 2, 1, RightTopGross);
	
		//right top pipe over jump 2
		PlaceSpritesRectenguler (new Vector3 (11, 2, 0), 2, 18, RightTopPipeOver);
		//Right Top gross over
		PlaceSpritesRectenguler (new Vector3 (11, 20, 0), 2, 1, RightTopGross);
		//block
		PlaceSpritesRectenguler (new Vector3 (18, 22, 0), 2, 11, RightTopGross);

		//Right Top pipe over jump 3 (far)
		PlaceSpritesRectenguler (new Vector3 (23, 2, 0), 2, 9, RightTopPipeOver);
		//Right Top gross over
		PlaceSpritesRectenguler (new Vector3 (23, 11, 0), 2, 1, RightTopGross);
		//Right Top pipe over jump 4
		PlaceSpritesRectenguler (new Vector3 (25, 2, 0), 2, 18, RightTopPipeOver);
		//Right Top gross over
		PlaceSpritesRectenguler (new Vector3 (25, 20, 0), 2, 1, RightTopGross);
		
		//right top pipe over jump 5
		PlaceSpritesRectenguler (new Vector3 (27, 2, 0), 1, 28, RightTopPipeOver);
		//Right Top gross over
		PlaceSpritesRectenguler (new Vector3 (27, 30, 0), 1, 1, RightTopGross);

		//right pipe higher
		PlaceSpritesRectenguler (new Vector3 (28, 1, 0), 1, 30, ustpipe);
		//pipe head top
		//PlaceSpritesRectenguler (new Vector3 (28, 31, 0), 1, 1, PipeRightHead);

		//right top finish
		//************

		//right bottom starting
		//first fall
		PlaceSpritesRectenguler (new Vector3 (4, -10, 0), 3, 1, RightBotGross);
		PlaceSpritesRectenguler (new Vector3 (4, -11, 0), 3, 1, RightBotMats);
		//second fall
		PlaceSpritesRectenguler (new Vector3 (3, -15, 0), 8, 1, RightBotGross);
		PlaceSpritesRectenguler (new Vector3 (3, -16, 0), 8, 1, RightBotMats);
		//first block
		PlaceSpritesRectenguler (new Vector3 (11, -3, 0), 2, 1, RightBotGross);
		PlaceSpritesRectenguler (new Vector3 (11, -16, 0), 2, 13, RightBotMats);
		//block over pipe
		PlaceSpritesRectenguler (new Vector3 (9.0f, -1.5f, 0.0f), 7, 1, yatıkpipe);
		//pipebotdownhead
		PlaceSpritesRectenguler (new Vector3 (9.0f, -2.5f, 0.0f), 1, 1, ustpipe);
		//PlaceSpritesRectenguler (new Vector3 (9.0f, -3.5f, 0.0f), 1, 1, PipeBotDownHead);
		//pipebotrighthead
		//PlaceSpritesRectenguler (new Vector3 (16.0f, -1.5f, 0.0f), 1, 1, PipeBotRightHead);
		//right to block
		PlaceSpritesRectenguler (new Vector3 (12, -15, 0), 16, 1, RightBotGross);
		PlaceSpritesRectenguler (new Vector3 (12, -16, 0), 16, 1, RightBotMats);
		// enemey platform
		PlaceSpritesRectenguler (new Vector3 (19, -9, 0), 6, 1, RightBotGross);
		PlaceSpritesRectenguler (new Vector3 (19, -10, 0), 6, 1, RightBotMats);
		//leftborder
		PlaceSpritesRectenguler (new Vector3 (-31, -22, 0), 1, 80, border);
		PlaceSpritesRectenguler (new Vector3 (29, -22, 0), 1, 80, border);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void PlaceSpiretesHorizantal(Vector3 startPos,int howMany,GameObject S)
	{
		for (int i=0; i<howMany; i++) {
			Instantiate(S,startPos+new Vector3(i,0,0),Quaternion.identity);	
		
		
		}

	}
	void PlaceSpiretesVertical(Vector3 startPos,int howMany,GameObject S)
	{
		for (int i=0; i<howMany; i++) {
			Instantiate(S,startPos+new Vector3(0,i,0),Quaternion.identity);	
			
			
		}
		
	}
	void PlaceSpritesRectenguler(Vector3 startPos,int witdh,int height,GameObject S)
	{
		for (int i=0; i<height;i++){

			PlaceSpiretesHorizantal(startPos+new Vector3(0,i,0),witdh,S);
			
			
		}


		}

}
