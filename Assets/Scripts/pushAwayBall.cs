using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushAwayBall : MonoBehaviour {

	public void OnCollisionEnter (Collision pallina) {
        if (pallina.collider.name.Contains ("pallina")) {
            var force = pallina.transform.position - transform.position;
            force.Normalize ();
            pallina.gameObject.GetComponent<Rigidbody>().AddForce (force * Random.Range (800, 1500));
        }
    } //OnTriggerEnter
}
