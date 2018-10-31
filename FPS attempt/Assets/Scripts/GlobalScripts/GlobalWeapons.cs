using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalWeapons : MonoBehaviour {

    public WeaponSelection weaponSelection;

    public GameObject MP5KMechanics;
    public GameObject MP5K;
    public GameObject UMP45Mechanics;
    public GameObject UMP45;
    public GameObject M9Mechanics;
    public GameObject M9;
    public string SecondaryWeapon;
    public string PrimaryWeapon1;
    public string PrimaryWeapon2;
    public string AcquiredWeapon;
    public string PrimaryWeaponSlot1;
    public string PrimaryWeaponSlot2;
    public string SecondaryWeaponSlot;

    // Use this for initialization
    void Start () {
        DeactivateWeapons();
        SecondaryWeapon = "M9";
        SecondaryWeaponSlot = "M9";
        weaponSelection.EquipSecondaryWeapon();
        PrimaryWeapon1 = "";
        PrimaryWeaponSlot1 = "";
        PrimaryWeapon2 = "";
        PrimaryWeaponSlot2 = "";
    }

    // Update is called once per frame
    void Update () {

        if(AcquiredWeapon == "MP5K")
        {
            
            if (PrimaryWeaponSlot1 == "")
            {
                PrimaryWeapon1 = "MP5K";
                PrimaryWeaponSlot1 = "MP5K";
                DeactivateWeapons();
                EquipMP5K();
                weaponSelection.DisplayActiveWeapon();
                AcquiredWeapon = "";
            }
            else if (PrimaryWeaponSlot2 == "")
            {
                PrimaryWeapon2 = "MP5K";
                PrimaryWeaponSlot2 = "MP5K";
                DeactivateWeapons();
                EquipMP5K();
                weaponSelection.DisplayActiveWeapon();
                AcquiredWeapon = "";
            }
        }
        else if (AcquiredWeapon == "UMP45")
        {
            if (PrimaryWeaponSlot1 == "")
            {
                PrimaryWeapon1 = "UMP45";
                PrimaryWeaponSlot1 = "UMP45";
                DeactivateWeapons();
                EquipUMP45();
                weaponSelection.DisplayActiveWeapon();
                AcquiredWeapon = "";
            }
            else if (PrimaryWeaponSlot2 == "")
            {
                PrimaryWeapon2 = "UMP45";
                PrimaryWeaponSlot2 = "UMP45";
                DeactivateWeapons();
                EquipUMP45();
                weaponSelection.DisplayActiveWeapon();
                AcquiredWeapon = "";
            }
        }
        else if (AcquiredWeapon == "M9")
        {
            SecondaryWeapon = "M9";
            SecondaryWeaponSlot = "M9";
            DeactivateWeapons();
            EquipM9();
            weaponSelection.DisplayActiveWeapon();
            AcquiredWeapon = "";
        }
    }

    public void DeactivateWeapons()
    {
        M9.SetActive(false);
        M9Mechanics.SetActive(false);
        MP5K.SetActive(false);
        MP5KMechanics.SetActive(false);
        UMP45.SetActive(false);
        UMP45Mechanics.SetActive(false);
    }

    public void EquipM9 ()
    {
        M9.SetActive(true);
        M9Mechanics.SetActive(true);
    }

    public void EquipMP5K ()
    {
        MP5K.SetActive(true);
        MP5KMechanics.SetActive(true);
    }

    public void EquipUMP45()
    {
        UMP45.SetActive(true);
        UMP45Mechanics.SetActive(true);
    }
}
