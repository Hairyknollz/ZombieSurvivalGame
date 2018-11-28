using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevolverGunFire : MonoBehaviour {

    public GameObject MuzzleFlash;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            if (GlobalAmmo.RevolverLoadedAmmo >= 1)
            {
                AudioSource RevolverSound = GetComponent<AudioSource>();
                RevolverSound.Play();
                MuzzleFlash.SetActive(true);
                StartCoroutine(MuzzleOff());
                GetComponent<Animation>().Play("RevolverFiringAnim");
                GlobalAmmo.RevolverLoadedAmmo -= 1;
            }
        }
    }

    IEnumerator MuzzleOff()
    {
        yield return new WaitForSeconds(0.1f);
        MuzzleFlash.SetActive(false);
    }
}
