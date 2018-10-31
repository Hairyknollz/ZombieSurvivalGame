using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossAnimate : MonoBehaviour {

    public GameObject CrosshairUp;
    public GameObject CrosshairDown;
    public GameObject CrosshairLeft;
    public GameObject CrosshairRight;
    public GameObject CrosshairCentre;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GlobalAmmo.M9LoadedAmmo >= 1)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                CrosshairUp.GetComponent<Animator>().enabled = true;
                CrosshairDown.GetComponent<Animator>().enabled = true;
                CrosshairLeft.GetComponent<Animator>().enabled = true;
                CrosshairRight.GetComponent<Animator>().enabled = true;
                StartCoroutine(WaitingAnim());
            }
        }
    }

    IEnumerator WaitingAnim()
    {
        yield return new WaitForSeconds(0.1f);
        CrosshairUp.GetComponent<Animator>().enabled = false;
        CrosshairDown.GetComponent<Animator>().enabled = false;
        CrosshairLeft.GetComponent<Animator>().enabled = false;
        CrosshairRight.GetComponent<Animator>().enabled = false;
    }
}
