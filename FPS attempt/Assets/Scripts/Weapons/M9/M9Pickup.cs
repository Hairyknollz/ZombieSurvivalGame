using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class M9Pickup : MonoBehaviour
{

    public GlobalWeapons globalWeapons;
    public WeaponSelection weaponSelection;

    public float TheDistance;
    public GameObject TextDisplay;
    public GameObject PlayerGun;
    public AudioSource PickUpAudio;
    public GameObject WeaponMechanics;

    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if (TheDistance <= 2)
        {
            TextDisplay.GetComponent<Text>().text = "Pickup the M9";
        }
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 2)
            {
                StartCoroutine(TakeM9());
            }
        }
    }

    void OnMouseExit()
    {
        TextDisplay.GetComponent<Text>().text = "";
    }

    IEnumerator TakeM9()
    {
        PickUpAudio.Play();
        weaponSelection.DisplayInactiveWeapon1();
        globalWeapons.AcquiredWeapon = "M9";
        //globalWeapons.SecondaryWeapon = "M9";
        weaponSelection.activeWeapon = "M9";
        GlobalAmmo.M9LoadedAmmo = 15;
        GlobalAmmo.M9LoadedAmmo = 120;
        yield return new WaitForSeconds(0.1f);
    }
}