using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalADS : MonoBehaviour {

    public WeaponSelection weaponSelection;

    public GameObject M9;
    public GameObject MP5K;
    public GameObject UMP45;
    public GameObject Crosshair;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (weaponSelection.activeWeapon == "M9")
        {
            if (Input.GetButtonDown("AimDownSights"))
            {
                StartCoroutine(StartM9ADS());
                Crosshair.SetActive(false);
            }
            else if (Input.GetButtonUp("AimDownSights"))
            {
                StartCoroutine(EndM9ADS());
                Crosshair.SetActive(true);
            }
        }else if (weaponSelection.activeWeapon == "MP5K")
        {
            if (Input.GetButtonDown("AimDownSights"))
            {
                StartCoroutine(StartMP5KADS());
                Crosshair.SetActive(false);
            }
            else if (Input.GetButtonUp("AimDownSights"))
            {
                StartCoroutine(EndMP5KADS());
                Crosshair.SetActive(true);
            }
        }
        else if (weaponSelection.activeWeapon == "UMP45")
        {
            if (Input.GetButtonDown("AimDownSights"))
            {
                StartCoroutine(StartUMP45ADS());
                Crosshair.SetActive(false);
            }
            else if (Input.GetButtonUp("AimDownSights"))
            {
                StartCoroutine(EndUMP45ADS());
                Crosshair.SetActive(true);
            }
        }
        //if (Input.GetButtonUp("AimDownSights"))
        //{
        //    StartCoroutine(EndADS());
        //    Crosshair.SetActive(true);
        //}
	}

    IEnumerator StartM9ADS ()
    {
        M9.GetComponent<Animation>().Play("M9ADSAnim");
        yield return new WaitForSeconds(0.6f);
        M9.GetComponent<Animation>().Stop("M9ADSAnim");
    }
    IEnumerator EndM9ADS()
    {
        M9.GetComponent<Animation>().Play("M9ADSStopAnim");
        yield return new WaitForSeconds(0.6f);
        M9.GetComponent<Animation>().Stop("M9ADSStopAnim");
    }
    IEnumerator StartMP5KADS()
    {
        MP5K.GetComponent<Animation>().Play("MP5KADSAnim");
        yield return new WaitForSeconds(1);
        MP5K.GetComponent<Animation>().Stop("MP5KADSAnim");
    }
    IEnumerator EndMP5KADS()
    {
        MP5K.GetComponent<Animation>().Play("MP5KADSStopAnim");
        yield return new WaitForSeconds(1);
        MP5K.GetComponent<Animation>().Stop("MP5KADSStopAnim");
    }
    IEnumerator StartUMP45ADS()
    {
        UMP45.GetComponent<Animation>().Play("UMP45ADSAnim");
        yield return new WaitForSeconds(1);
        UMP45.GetComponent<Animation>().Stop("UMP45ADSAnim");
    }
    IEnumerator EndUMP45ADS()
    {
        UMP45.GetComponent<Animation>().Play("UMP45ADSStopAnim");
        yield return new WaitForSeconds(1);
        UMP45.GetComponent<Animation>().Stop("UMP45ADSStopAnim");
    }
}
