using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MP5KGunFire : MonoBehaviour {

    public MP5KDamage gunDamage;

    public GameObject MuzzleFlash;
    public bool Firing;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire1"))
        {
            if (GlobalAmmo.MP5KLoadedAmmo >= 1)
            {
                if (Firing == false)
                {
                    StartCoroutine(MP5KFire());
                }
            }
        }
	}

    IEnumerator MP5KFire()
    {
        Firing = true;
        GlobalAmmo.MP5KLoadedAmmo -= 1;
        gunDamage.FireMP5K();
        AudioSource MP5KSound = GetComponent<AudioSource>();
        MP5KSound.Play();
        MuzzleFlash.SetActive(true);
        StartCoroutine(MuzzleFlashOff());
        GetComponent<Animation>().Play("MP5KFiringAnim");
        yield return new WaitForSeconds(0.1f);
        Firing = false;
    }

    IEnumerator MuzzleFlashOff()
    {
        yield return new WaitForSeconds(0.1f);
        MuzzleFlash.SetActive(false);
    }
}
