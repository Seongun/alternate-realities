using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stairWayBehavior : MonoBehaviour {
	
	public int numSteps;
	//determine the x and z coordinates of this particular stairway's platform.
	/*
	     x,z
	0:  (0,0) -> (0,1)  (increment z)
	1:  (0,1) -> (1,1)  (increment x)
	2:  (1,1) -> (1,0)  (decrement z)
	3:  (1,0) -> (0,0)  (decrement x) 

	*/

	public int stairWayNumber;
//	public int stepSize;
	public GameObject stairStep;
	//we will determine later if we need this separately.
	public GameObject stairPlatform;
	GameObject[] stairSteps;

	int[,] nextStep = new int[,] { { 0, 1 }, { 1, 0 }, { 0, -1 }, { -1, 0 } };
	int[] startingXZ;

	// Use this for initialization
	void Start () {
		Debug.Log ("three");

		
		stairSteps = new GameObject[numSteps+1];
		startingXZ= new int[] {stairWayNumber>1?numSteps:0, stairWayNumber==1 || stairWayNumber==2 ?numSteps:0 };



		//generate the starting platform for this stairway




		//generate steps for this stairway
		for (int i = 0; i < numSteps; i++) {

			stairSteps[i] = GameObject.Instantiate (stairStep, 
				new Vector3( startingXZ[0]+ nextStep[stairWayNumber,0] * i , 0, startingXZ[1] + nextStep[stairWayNumber,1] * i ), 
				Quaternion.identity);

		}


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
