using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UMP45Pickup : MonoBehaviour
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
        if (TheDistance <= 2 && globalWeapons.PrimaryWeapon1 != "UMP45" && globalWeapons.PrimaryWeapon2 != "UMP45")
        {
            TextDisplay.GetComponent<Text>().text = "Pickup UMP45 (1250 Score)";
        }
        else if (TheDistance <= 2 && globalWeapons.PrimaryWeapon1 == "UMP45" || TheDistance <= 2 && globalWeapons.PrimaryWeapon2 == "UMP45")
        {
            TextDisplay.GetComponent<Text>().text = "Pickup Ammo (500 Score)";
        }
        if (TheDistance <= 2 && Input.GetButtonDown("Action") && globalWeapons.PrimaryWeapon1 != "UMP45" && GlobalScore.CurrentScore >= 1250 || TheDistance <= 2 && Input.GetButtonDown("Action") && globalWeapons.PrimaryWeapon2 != "UMP45" && GlobalScore.CurrentScore >= 1250)
        {
            StartCoroutine(TakeUMP45());
            GlobalScore.CurrentScore -= 1250;
        }
        else if (TheDistance <= 2 && Input.GetButtonDown("Action") && globalWeapons.PrimaryWeapon1 == "UMP45" && GlobalScore.CurrentScore >= 500 && GlobalAmmo.UMP45ReserveAmmo < 240 && weaponSelection.activeWeapon == "UMP45" || TheDistance <= 2 && Input.GetButtonDown("Action") && globalWeapons.PrimaryWeapon2 == "UMP45" && GlobalScore.CurrentScore >= 500 && GlobalAmmo.UMP45ReserveAmmo < 240 && weaponSelection.activeWeapon == "UMP45")
        {
            GlobalAmmo.UMP45LoadedAmmo = 25;
            GlobalAmmo.UMP45ReserveAmmo = 200;
            GlobalScore.CurrentScore -= 500;
            PickUpAudio.Play();
        }
    }

    void OnMouseExit()
    {
        TextDisplay.GetComponent<Text>().text = "";
    }

    IEnumerator TakeUMP45()
    {
        PickUpAudio.Play();
        weaponSelection.DisplayInactiveWeapon1();
        globalWeapons.AcquiredWeapon = "UMP45";
        weaponSelection.activeWeapon = "UMP45";
        GlobalAmmo.UMP45LoadedAmmo = 25;
        GlobalAmmo.UMP45ReserveAmmo = 200;
        yield return new WaitForSeconds(0.1f);
    }
}