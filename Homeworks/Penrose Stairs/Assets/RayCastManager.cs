using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastManager : MonoBehaviour {
	public float speed;
	public float raycastDistance;
//	public float timer;

	// Use this for initialization
	void Start () {
		speed = 2.0f;



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
			
			hit.collider.gameObject.GetComponent<Renderer> ().material.color = Color.red;
			transform.position = Vector3.Lerp(transform.position, new Vector3 (hit.collider.gameObject.transform.position.x, hit.collider.gameObject.transform.position.y + 2.0f, hit.collider.gameObject.transform.position.z), Time.deltaTime * speed);
		
		}	
	}
}

