using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponSelection : MonoBehaviour {

    public GlobalWeapons globalWeapons;

    public string activeWeapon;
    public string inactiveWeapon;
    public GameObject ActiveWeaponDisplay;
    public GameObject ActiveWeaponSilhouette;
    public GameObject UnactiveWeaponDisplay1;
    public GameObject UnactiveWeaponDisplay1Silhouette;
    public GameObject UnactiveWeaponDisplay2;
    public GameObject UnactiveWeaponDisplay2Silhouette;
    public Texture MP5KWeaponSilhouette;
    public Texture UMP45WeaponSilhouette;
    public Texture M9WeaponSilhouette;

    // Use this for initialization
    void Start () {
        activeWeapon = globalWeapons.SecondaryWeapon;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("SelectPrimaryWeapon1") && globalWeapons.PrimaryWeaponSlot1 != "")
        {
            EquipPrimaryWeapon1();
        }
        if (Input.GetButtonDown("SelectPrimaryWeapon2") && globalWeapons.PrimaryWeaponSlot2 != "")
        {
            EquipPrimaryWeapon2();
        }
        if (Input.GetButtonDown("SelectSecondaryWeapon") && globalWeapons.SecondaryWeaponSlot != "")
        {
            EquipSecondaryWeapon();
        }
    }

    public void EquipPrimaryWeapon1 ()
    {
        if (globalWeapons.PrimaryWeapon1 == "MP5K")
        {
            DisplayInactiveWeapon1();
            globalWeapons.DeactivateWeapons();
            globalWeapons.EquipMP5K();
            activeWeapon = "MP5K";
            DisplayActiveWeapon();
        }
        else if (globalWeapons.PrimaryWeapon1 == "UMP45")
        {
            DisplayInactiveWeapon1();
            globalWeapons.DeactivateWeapons();
            globalWeapons.EquipUMP45();
            activeWeapon = "UMP45";
            DisplayActiveWeapon();
        }

    }
    public void EquipPrimaryWeapon2()
    {
        if (globalWeapons.PrimaryWeapon2 == "MP5K")
        {
            DisplayInactiveWeapon1();
            globalWeapons.DeactivateWeapons();
            globalWeapons.EquipMP5K();
            activeWeapon = "MP5K";
            DisplayActiveWeapon();
        }
        else if (globalWeapons.PrimaryWeapon2 == "UMP45")
        {
            DisplayInactiveWeapon1();
            globalWeapons.DeactivateWeapons();
            globalWeapons.EquipUMP45();
            activeWeapon = "UMP45";
            DisplayActiveWeapon();
        }
    }
    public void EquipSecondaryWeapon()
    {
        if (globalWeapons.SecondaryWeapon == "M9")
        {
            DisplayInactiveWeapon1();
            globalWeapons.DeactivateWeapons();
            globalWeapons.EquipM9();
            activeWeapon = "M9";
            DisplayActiveWeapon();
        }
    }

    public void DisplayActiveWeapon ()
    {
        ActiveWeaponDisplay.SetActive(true);
        if (activeWeapon == "M9")
        {
            ActiveWeaponSilhouette.GetComponent<RawImage>().texture = M9WeaponSilhouette;
        }
        else if (activeWeapon == "MP5K")
        {
            ActiveWeaponSilhouette.GetComponent<RawImage>().texture = MP5KWeaponSilhouette;
        }
        else if (activeWeapon == "UMP45")
        {
            ActiveWeaponSilhouette.GetComponent<RawImage>().texture = UMP45WeaponSilhouette;
        }
    }

    public void DisplayInactiveWeapon1 ()
    {
        inactiveWeapon = activeWeapon;
        if (inactiveWeapon == "MP5K")
        {
            UnactiveWeaponDisplay1.SetActive(true);
            UnactiveWeaponDisplay1Silhouette.GetComponent<RawImage>().texture = MP5KWeaponSilhouette;
        }
        else if (inactiveWeapon == "UMP45")
        {
            UnactiveWeaponDisplay1.SetActive(true);
            UnactiveWeaponDisplay1Silhouette.GetComponent<RawImage>().texture = UMP45WeaponSilhouette;
        }
        else if (inactiveWeapon == "M9")
        {
            UnactiveWeaponDisplay1.SetActive(true);
            UnactiveWeaponDisplay1Silhouette.GetComponent<RawImage>().texture = M9WeaponSilhouette;
        }
    }
}
