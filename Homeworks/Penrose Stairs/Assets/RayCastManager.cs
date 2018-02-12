using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastManager : MonoBehaviour {
	Camera mainCamera;
	public float raycastDistance;
//	public float timer;
	float speed;

	// Use this for initialization
	void Start () {


		mainCamera = Camera.main;
		speed = 0.5f;
//		mainCamera.enabled = true;

	}
	
	// Update is called once per frame
	void Update () {

		Raycasting ();
		
	}
//
//
//	void RayCast(){
//
//		RayCastHit Hit;
//
//
//	}


	void Raycasting(){
		Vector3 fwd = GetComponentInChildren<Camera> ().transform.TransformDirection (Vector3.forward);
		RaycastHit hit = new RaycastHit ();

		if(Physics.Raycast(transform.position, fwd, out hit, raycastDistance)){
			
//			Debug.Log ("hit object: " + hit.collider.gameObject.name);
			hit.collider.gameObject.GetComponent<Renderer> ().material.color = Color.red;


			Debug.Log( hit.collider.gameObject.GetComponent<stepBehavior>().stepPosition);





		}	
	}
}

