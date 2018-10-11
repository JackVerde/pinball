using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {

    public GameObject prefab;
    public KeyCode generateContinuously = KeyCode.B;
    public KeyCode generateOne = KeyCode.G;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(generateContinuously) || Input.GetKeyDown(generateOne))
        {
            generateBall();
        }
	}

    public void generateBall()
    {
        GameObject.Instantiate(prefab, transform.position, Quaternion.identity);
    }
}
