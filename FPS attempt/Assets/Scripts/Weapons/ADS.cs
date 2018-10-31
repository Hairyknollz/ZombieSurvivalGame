using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADS : MonoBehaviour {

    public GameObject Weapon;
    public GameObject Crosshair;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("AimDownSights"))
        {
            StartCoroutine(StartADS());
            Crosshair.SetActive(false);
        }else if (Input.GetButtonUp("AimDownSights"))
        {
            StartCoroutine(EndADS());
            Crosshair.SetActive(true);
        }
        //if (Input.GetButtonUp("AimDownSights"))
        //{
        //    StartCoroutine(EndADS());
        //    Crosshair.SetActive(true);
        //}
	}

    IEnumerator StartADS ()
    {
        Weapon.GetComponent<Animation>().Play("M9ADSAnim");
        yield return new WaitForSeconds(0.6f);
        Weapon.GetComponent<Animation>().Stop("M9ADSAnim");
    }
    IEnumerator EndADS()
    {
        Weapon.GetComponent<Animation>().Play("M9ADSStopAnim");
        yield return new WaitForSeconds(0.6f);
        Weapon.GetComponent<Animation>().Stop("M9ADSStopAnim");
    }
}
