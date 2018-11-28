using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RevolverPickup : MonoBehaviour
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
            TextDisplay.GetComponent<Text>().text = "Pickup the Revolver";
        }
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 2)
            {
                StartCoroutine(TakeRevolver());
            }
        }
    }

    void OnMouseExit()
    {
        TextDisplay.GetComponent<Text>().text = "";
    }

    IEnumerator TakeRevolver()
    {
        PickUpAudio.Play();
        weaponSelection.DisplayInactiveWeapon1();
        globalWeapons.AcquiredWeapon = "Revolver";
        //globalWeapons.SecondaryWeapon = "M9";
        weaponSelection.activeWeapon = "Revolver";
        GlobalAmmo.RevolverLoadedAmmo = 6;
        GlobalAmmo.RevolverLoadedAmmo = 72;
        yield return new WaitForSeconds(0.1f);
    }
}