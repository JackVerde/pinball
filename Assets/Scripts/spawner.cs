using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {

    public GameObject prefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.B) || Input.GetKeyDown(KeyCode.Space))
        {
            generateBall();
        }
	}

    public void generateBall()
    {
        GameObject.Instantiate(prefab, transform.position, Quaternion.identity);
    }
}
