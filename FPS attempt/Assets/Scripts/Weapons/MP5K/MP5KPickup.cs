using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MP5KPickup : MonoBehaviour
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
        if (TheDistance <= 2 && globalWeapons.PrimaryWeapon1 != "MP5K" && globalWeapons.PrimaryWeapon2 != "MP5K")
        {
            TextDisplay.GetComponent<Text>().text = "Pickup MP5K (1250 Score)";
        }
        else if (TheDistance <= 2 && globalWeapons.PrimaryWeapon1 == "MP5K" || TheDistance <= 2 && globalWeapons.PrimaryWeapon2 == "MP5K")
        {
            TextDisplay.GetComponent<Text>().text = "Pickup Ammo (500 Score)";
        }
        if (TheDistance <= 2 && Input.GetButtonDown("Action") && globalWeapons.PrimaryWeapon1 != "MP5K" && GlobalScore.CurrentScore >= 1250 || TheDistance <= 2 && Input.GetButtonDown("Action") && globalWeapons.PrimaryWeapon2 != "MP5K" && GlobalScore.CurrentScore >= 1250)
        {
                StartCoroutine(TakeMP5K());
                GlobalScore.CurrentScore -= 1250;
        }
        else if (TheDistance <= 2 && Input.GetButtonDown("Action") && globalWeapons.PrimaryWeapon1 == "MP5K" && GlobalScore.CurrentScore >= 500 && GlobalAmmo.MP5KReserveAmmo < 240 && weaponSelection.activeWeapon == "MP5K" || TheDistance <= 2 && Input.GetButtonDown("Action") && globalWeapons.PrimaryWeapon2 == "MP5K" && GlobalScore.CurrentScore >= 500 && GlobalAmmo.MP5KReserveAmmo < 240 && weaponSelection.activeWeapon == "MP5K")
        {
            GlobalAmmo.MP5KLoadedAmmo = 30;
            GlobalAmmo.MP5KReserveAmmo = 240;
            GlobalScore.CurrentScore -= 500;
            PickUpAudio.Play();
        }
    }

    void OnMouseExit()
    {
        TextDisplay.GetComponent<Text>().text = "";
    }

    IEnumerator TakeMP5K()
    {
        PickUpAudio.Play();
        weaponSelection.DisplayInactiveWeapon1();
        globalWeapons.AcquiredWeapon = "MP5K";
        weaponSelection.activeWeapon = "MP5K";
        GlobalAmmo.MP5KLoadedAmmo = 30;
        GlobalAmmo.MP5KReserveAmmo = 240;
        yield return new WaitForSeconds(0.1f);
    }
}