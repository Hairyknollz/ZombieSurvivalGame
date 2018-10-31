using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHoleDecay : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(WaitForDeath());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator WaitForDeath ()
    {
        yield return new WaitForSeconds(60);
        Destroy(gameObject);
    }
}
