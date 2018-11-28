using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MP5KReloading : MonoBehaviour {

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

        ClipCount = GlobalAmmo.MP5KLoadedAmmo;
        ReserveCount = GlobalAmmo.MP5KReserveAmmo;
        if (ReserveCount == 0)
        {
            MagSize = 0;
        }
        else
        {
            MagSize = 30 - ClipCount;
        }
    

        if (Input.GetButtonDown("Reload"))
        {
            if (MagSize >= 1)
            {
                if (ReserveCount <= MagSize)
                {
                    GlobalAmmo.MP5KLoadedAmmo += ReserveCount;
                    GlobalAmmo.MP5KReserveAmmo -= ReserveCount;
                    ReloadWeapon();
                }
                else
                {
                    GlobalAmmo.MP5KLoadedAmmo += MagSize;
                    GlobalAmmo.MP5KReserveAmmo -= MagSize;
                    ReloadWeapon();
                }
            }
            StartCoroutine(EnableScripts());
        }
    }

    IEnumerator EnableScripts()
    {
        yield return new WaitForSeconds(1.42f);
        GetComponent<MP5KGunFire>().enabled = true;
        CrossObject.SetActive(true);
        MechanicsObject.SetActive(true);
    }

    void ReloadWeapon()
    {
        GetComponent<MP5KGunFire>().enabled = false;
        CrossObject.SetActive(false);
        MechanicsObject.SetActive(false);
        ReloadSound.Play();
        GetComponent<Animation>().Play("MP5KReloadAnim");
    }
}
