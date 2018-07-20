using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalsControl2 : MonoBehaviour {

    public Transform vrCamera;
    public float toggleAngle = 25.0f;
    public float speed = 2.0f;
    public bool moveForward = false;


    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f) {
            moveForward = true;
        }
        else {
            moveForward = false;
        }

        if (moveForward) {
            vrCamera.transform.position = vrCamera.transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
        }
    }
}
