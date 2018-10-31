using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M9GunFire : MonoBehaviour {

    public GameObject MuzzleFlash;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            if (GlobalAmmo.M9LoadedAmmo >= 1)
            {
                AudioSource M9Sound = GetComponent<AudioSource>();
                M9Sound.Play();
                MuzzleFlash.SetActive(true);
                StartCoroutine(MuzzleOff());
                GetComponent<Animation>().Play("M9FiringAnim");

                GlobalAmmo.M9LoadedAmmo -= 1;
            }
        }
    }

    IEnumerator MuzzleOff()
    {
        yield return new WaitForSeconds(0.1f);
        MuzzleFlash.SetActive(false);
    }
}
