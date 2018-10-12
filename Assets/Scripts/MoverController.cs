using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverController : MonoBehaviour {

    float originalX;
    public bool forward = true;
    public float translateBy = 4;
    public float speed = 1;

    public KeyCode moveUpKey = KeyCode.U;
    public KeyCode moveDownKey = KeyCode.J;

    // Use this for initialization
    void Start () {
        originalX = this.gameObject.transform.position.x - (forward ? 0 : -translateBy);
	}
	
	// Update is called once per frame
	void Update () {
        Transform trans = GetComponent<Transform>();
        //Debug.Log(originalX + translateBy);
        //Debug.Log(trans.position.x );
        if ((trans.position.x < originalX + translateBy) && forward)
        {
            trans.Translate(new Vector3((float)0.01*speed, 0, 0));
        } else
        {
            forward = false;
            trans.Translate(new Vector3((float)-0.01*speed, 0, 0));
        } 
        if (originalX > trans.position.x)
        {
            forward = true;
        }
        

        if(Input.GetKey(moveUpKey))
        {
            transform.Translate(new Vector3(0, 0.1f, 0));
        }
        if (Input.GetKey(moveDownKey))
        {
            transform.Translate(new Vector3(0, -0.1f, 0));
        }
    }
}
