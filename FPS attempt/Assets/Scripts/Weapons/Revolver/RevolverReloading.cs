using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevolverReloading : MonoBehaviour {

    public AudioSource ReloadSound;
    public GameObject CrossObject;
    public GameObject MechanicsObject;
    public int ClipCount;
    public int ReserveCount;
    public int MagSize;

    // Use this for initialization
    void Start() {
        MagSize = 0;
    }

    // Update is called once per frame
    void Update() {

        ClipCount = GlobalAmmo.RevolverLoadedAmmo;
        ReserveCount = GlobalAmmo.RevolverReserveAmmo;
        if (ReserveCount == 0)
        {
            MagSize = 0;
        }
        else
        {
            MagSize = 6 - ClipCount;
        }
    

        if (Input.GetButtonDown("Reload"))
        {
            if (MagSize >= 1)
            {
                if (ReserveCount <= MagSize)
                {
                    GlobalAmmo.RevolverLoadedAmmo += ReserveCount;
                    GlobalAmmo.RevolverReserveAmmo -= ReserveCount;
                    ActionReload();
                }
                else
                {
                    GlobalAmmo.RevolverLoadedAmmo += MagSize;
                    GlobalAmmo.RevolverReserveAmmo -= MagSize;
                    ActionReload();
                }
                StartCoroutine(EnableScripts());
            }
        }
    }

    IEnumerator EnableScripts()
    {
        yield return new WaitForSeconds(1.2f);
        GetComponent<RevolverGunFire>().enabled = true;
        CrossObject.SetActive(true);
        MechanicsObject.SetActive(true);
    }

    void ActionReload()
    {
        GetComponent<RevolverGunFire>().enabled = false;
        CrossObject.SetActive(false);
        MechanicsObject.SetActive(false);
        ReloadSound.Play();
        GetComponent<Animation>().Play("RevolverReloadAnim");
    }
}
