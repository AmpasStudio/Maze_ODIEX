using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cameraController : MonoBehaviour {
	public Transform vrCamera;
	public Transform subvrCamera;
    public Transform benda;
    public float toggleAngle = 30.0f;
    public float speed = .5f;
    public bool moveForward = false;
    private CharacterController cc;
	public Transform point;
	public GameObject berhasil;
    // Use this for initialization
    void Start () {
        cc = GetComponent<CharacterController>();
    }
	
	// Update is called once per frame
	void Update () {
		
		//benda.transform.position = benda.transform.position + vrCamera.transform.forward * speed * Time.deltaTime*translation;
		if (subvrCamera.eulerAngles.x >= toggleAngle && subvrCamera.eulerAngles.x < 90.0f) {
			moveForward = true;
		} else {
			float translation = Input.GetAxis ("Vertical");
			benda.transform.position = benda.transform.position + vrCamera.transform.forward * speed * Time.deltaTime*translation;
			Vector3 temp = transform.position;
			temp.y = 0.4126339f;
			benda.transform.position = temp;
            moveForward = false;
        }
		
        if (moveForward) {
			benda.transform.position = benda.transform.position + vrCamera.transform.forward * speed * Time.deltaTime;
			Vector3 temp = transform.position;
			temp.y = 0.4126339f;
			benda.transform.position = temp;
			//benda.transform.position = benda.transform.position + vrCamera.transform.forward * speed * Time.deltaTime*translation;
//            benda.transform.position = benda.transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
            //transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
        }
		float dist = Vector3.Distance(benda.position, point.position);
		//print (dist);
		if (dist < 3) {
			berhasil.SetActive (true);
			StartCoroutine (restart ());
		}
    }
	void FixedUpdate()

	{
		
	}
	IEnumerator restart(){
		yield return new WaitForSeconds (5f);
		Application.LoadLevel(Application.loadedLevel);
	}
}
