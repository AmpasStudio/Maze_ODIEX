using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pertanyaan : MonoBehaviour {
	public GameObject pemain;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	/*
	void Update () {
		float dist = Vector3.Distance(pemain.transform.position, transform.position);
		print("Distance to other: " + dist);
		if (dist < 0.5f) {
			GameObject hide = transform.Find ("Hide").gameObject;
			hide.SetActive (true);
		} else {
			GameObject hide = transform.Find ("Hide").gameObject;
			hide.SetActive (false);
		}
	}*/
}
