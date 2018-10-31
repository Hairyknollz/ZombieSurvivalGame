using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAmmo : MonoBehaviour {

    public WeaponSelection weaponSelection;

    public static int MP5KReserveAmmo;
    public int InternalMP5KReserveAmmo;
    public GameObject MP5KReserveAmmoDisplay;

    public static int MP5KLoadedAmmo;
    public int InternalMP5KLoadedAmmo;
    public GameObject MP5KLoadedAmmoDisplay;

    public static int UMP45ReserveAmmo;
    public int InternalUMP45ReserveAmmo;
    public GameObject UMP45ReserveAmmoDisplay;

    public static int UMP45LoadedAmmo;
    public int InternalUMP45LoadedAmmo;
    public GameObject UMP45LoadedAmmoDisplay;

    public static int M9ReserveAmmo;
    public int InternalM9ReserveAmmo;
    public GameObject M9ReserveAmmoDisplay;

    public static int M9LoadedAmmo;
    public int InternalM9LoadedAmmo;
    public GameObject M9LoadedAmmoDisplay;



    // Use this for initialization
    void Start () {
        MP5KReserveAmmo = 0;
        MP5KLoadedAmmo = 0;
        UMP45ReserveAmmo = 0;
        UMP45LoadedAmmo = 0;
        M9ReserveAmmo = 30;
        M9LoadedAmmo = 15;
    }

    // Update is called once per frame
    void Update () {

        InternalMP5KLoadedAmmo = MP5KLoadedAmmo;
        InternalMP5KReserveAmmo = MP5KReserveAmmo;
        InternalUMP45LoadedAmmo = UMP45LoadedAmmo;
        InternalUMP45ReserveAmmo = UMP45ReserveAmmo;
        InternalM9LoadedAmmo = M9LoadedAmmo;
        InternalM9ReserveAmmo = M9ReserveAmmo;

        DisplayAmmoCounters();
    }

    void DisplayAmmoCounters ()
    {
        if (weaponSelection.activeWeapon == "MP5K")
        {
            MP5KReserveAmmoDisplay.GetComponent<Text>().text = "" + MP5KReserveAmmo;
            MP5KLoadedAmmoDisplay.GetComponent<Text>().text = "" + MP5KLoadedAmmo;
        }
        else if (weaponSelection.activeWeapon == "UMP45")
        {
            UMP45ReserveAmmoDisplay.GetComponent<Text>().text = "" + UMP45ReserveAmmo;
            UMP45LoadedAmmoDisplay.GetComponent<Text>().text = "" + UMP45LoadedAmmo;
        }
        else if (weaponSelection.activeWeapon == "M9")
        {
            M9ReserveAmmoDisplay.GetComponent<Text>().text = "" + M9ReserveAmmo;
            M9LoadedAmmoDisplay.GetComponent<Text>().text = "" + M9LoadedAmmo;
        }
    }

}
