using UnityEngine;
using System.Collections;
using UnityEngine.AI;
public class walk : MonoBehaviour {
	public float timer;
	public int newTarget;
	public float speed;
	public NavMeshAgent nav;
	public Vector3 target;
	public Animator anim;

	void Start(){
		nav = gameObject.GetComponent<NavMeshAgent> ();
	}

	void Update(){
		timer += Time.deltaTime;
		if (timer >= newTarget) {
			newTargetwalk ();
			timer = 0;
		}
	}
	void newTargetwalk(){
		float myX = gameObject.transform.position.x;
		float myZ = gameObject.transform.position.z;
		float xPos = myX + Random.Range (myX-0.5f, myX +0.5f);
		float zPos = myX + Random.Range (myZ-0.5f, myZ +0.5f);
		target = new Vector3 (xPos,gameObject.transform.position.y,zPos);
		nav.SetDestination (target);
	}
}