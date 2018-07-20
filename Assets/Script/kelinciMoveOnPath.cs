using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kelinciMoveOnPath : MonoBehaviour {
	public EditorPath pathToFollow;
	public int CurrentWayPointID = 0;
	public float speed;
	public float reachDIstance;
	public float rotationSpeed = 5.0f;
	public string patName;
	Vector3 last_position;
	Vector3 current_position;
	// Use this for initialization
	void Start () {
		reachDIstance = 0.1f;
		last_position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
		float distance = Vector3.Distance (pathToFollow.path_objs[CurrentWayPointID].position, transform.position);

		transform.position = Vector3.MoveTowards (transform.position, pathToFollow.path_objs [CurrentWayPointID].position, Time.deltaTime*speed);
		if (CurrentWayPointID != 0) {
			var rotation = Quaternion.LookRotation (pathToFollow.path_objs [CurrentWayPointID].position - transform.position);
			transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * rotationSpeed);
		}
		if (distance <= reachDIstance) {
			CurrentWayPointID++;
		}
		if (CurrentWayPointID >= pathToFollow.path_objs.Count) {
			CurrentWayPointID=0;
		}
	}

}
