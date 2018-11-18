using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UMP45GunFire : MonoBehaviour {

    public UMP45Damage gunDamage;

    public GameObject MuzzleFlash;
    public bool Firing;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire1"))
        {
            if (GlobalAmmo.UMP45LoadedAmmo >= 1)
            {
                if (Firing == false)
                {
                    StartCoroutine(UMP45Fire());
                }
            }
        }
	}

    IEnumerator UMP45Fire()
    {
        Firing = true;
        GlobalAmmo.UMP45LoadedAmmo -= 1;
        gunDamage.FireUMP45();
        AudioSource UMP45Sound = GetComponent<AudioSource>();
        UMP45Sound.Play();
        MuzzleFlash.SetActive(true);
        StartCoroutine(MuzzleFlashOff());
        GetComponent<Animation>().Play("UMP45FiringAnim");
        yield return new WaitForSeconds(0.115f);
        Firing = false;
    }

    IEnumerator MuzzleFlashOff()
    {
        yield return new WaitForSeconds(0.115f);
        MuzzleFlash.SetActive(false);
    }
}
