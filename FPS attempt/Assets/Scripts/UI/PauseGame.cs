using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PauseGame : MonoBehaviour {

    public bool GamePaused;
    public GameObject Player;
    public GameObject Weapons;
    public GameObject GunMechanics;
    public GameObject PauseMenu;

	// Use this for initialization
	void Start () {
        GamePaused = false;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetButtonDown("Cancel"))
        {
            if (GamePaused == false)
            {
                Time.timeScale = 0;
                GamePaused = true;
                Player.GetComponent<FirstPersonController>().enabled = false;
                //Weapons.GetComponentInChildren<M9GunFire>().enabled = false;
                //Weapons.GetComponentInChildren<MP5KGunFire>().enabled = false;
                //Weapons.GetComponentInChildren<UMP45GunFire>().enabled = false;
                Weapons.SetActive(false);
                GunMechanics.SetActive(false);
                PauseMenu.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else if (GamePaused == true)
            {
                Time.timeScale = 1;
                GamePaused = false;
                Player.GetComponent<FirstPersonController>().enabled = true;
                //Weapons.GetComponentInChildren<M9GunFire>().enabled = true;
                //Weapons.GetComponentInChildren<MP5KGunFire>().enabled = true;
                //Weapons.GetComponentInChildren<UMP45GunFire>().enabled = true;
                Weapons.SetActive(true);
                GunMechanics.SetActive(true);
                PauseMenu.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
	}
}
