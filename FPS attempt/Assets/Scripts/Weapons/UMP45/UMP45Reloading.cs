using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UMP45Reloading : MonoBehaviour {

    public AudioSource ReloadSound;
    public GameObject CrossObject;
    public GameObject MechanicsObject;
    public int ClipCount;
    public int ReserveCount;
    public int MagSize;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        ClipCount = GlobalAmmo.UMP45LoadedAmmo;
        ReserveCount = GlobalAmmo.UMP45ReserveAmmo;
        if (ReserveCount == 0)
        {
            MagSize = 0;
        }
        else
        {
            MagSize = 25 - ClipCount;
        }
    

        if (Input.GetButtonDown("Reload"))
        {
            if (MagSize >= 1)
            {
                if (ReserveCount <= MagSize)
                {
                    GlobalAmmo.UMP45LoadedAmmo += ReserveCount;
                    GlobalAmmo.UMP45ReserveAmmo -= ReserveCount;
                    ReloadWeapon();
                }
                else
                {
                    GlobalAmmo.UMP45LoadedAmmo += MagSize;
                    GlobalAmmo.UMP45ReserveAmmo -= MagSize;
                    ReloadWeapon();
                }
            }
            StartCoroutine(EnableScripts());
        }
    }

    IEnumerator EnableScripts()
    {
        yield return new WaitForSeconds(1.42f);
        GetComponent<UMP45GunFire>().enabled = true;
        CrossObject.SetActive(true);
        MechanicsObject.SetActive(true);
    }

    void ReloadWeapon()
    {
        GetComponent<UMP45GunFire>().enabled = false;
        CrossObject.SetActive(false);
        MechanicsObject.SetActive(false);
        ReloadSound.Play();
        GetComponent<Animation>().Play("UMP45ReloadAnim");
    }
}
