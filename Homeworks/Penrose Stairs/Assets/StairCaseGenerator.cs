using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairCaseGenerator : MonoBehaviour {

	public GameObject myStairCase;

	// Use this for initialization
	void Start () {
		GameObject.Instantiate (myStairCase, Vector3.zero, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
//		myStairCase.update ();

	}
}
