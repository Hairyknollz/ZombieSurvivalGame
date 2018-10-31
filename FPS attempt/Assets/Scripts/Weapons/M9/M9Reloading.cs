using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M9Reloading : MonoBehaviour {

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

        ClipCount = GlobalAmmo.M9LoadedAmmo;
        ReserveCount = GlobalAmmo.M9ReserveAmmo;
        if (ReserveCount == 0)
        {
            MagSize = 0;
        }
        else
        {
            MagSize = 15 - ClipCount;
        }
    

        if (Input.GetButtonDown("Reload"))
        {
            if (MagSize >= 1)
            {
                if (ReserveCount <= MagSize)
                {
                    GlobalAmmo.M9LoadedAmmo += ReserveCount;
                    GlobalAmmo.M9ReserveAmmo -= ReserveCount;
                    ActionReload();
                }
                else
                {
                    GlobalAmmo.M9LoadedAmmo += MagSize;
                    GlobalAmmo.M9ReserveAmmo -= MagSize;
                    ActionReload();
                }

            }
        }
        StartCoroutine(EnableScripts());
    }

    IEnumerator EnableScripts()
    {
        yield return new WaitForSeconds(1.2f);
        GetComponent<M9GunFire>().enabled = true;
        CrossObject.SetActive(true);
        MechanicsObject.SetActive(true);
    }

    void ActionReload()
    {
        GetComponent<M9GunFire>().enabled = false;
        CrossObject.SetActive(false);
        MechanicsObject.SetActive(false);
        ReloadSound.Play();
        GetComponent<Animation>().Play("M9ReloadAnim");
    }
}
