using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverController : MonoBehaviour {

    float originalX;
    public bool forward = true;
    public float translateBy = 4;
    public float speed = 1;

	// Use this for initialization
	void Start () {
        originalX = this.gameObject.transform.position.z - (forward ? 0 : -translateBy);
	}
	
	// Update is called once per frame
	void Update () {
        Transform trans = GetComponent<Transform>();
        if ((originalX < trans.position.z + translateBy) && forward)
        {
            trans.Translate(new Vector3((float)0.01*speed, 0, 0));
        } else
        {
            forward = false;
            trans.Translate(new Vector3((float)-0.01*speed, 0, 0));
        } 
        if (originalX < trans.position.z)
        {
            forward = true;
        }
        

        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0.1f, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(0, -0.1f, 0));
        }
    }
}
