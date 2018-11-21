using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class ButtonOptions : MonoBehaviour {

    public PauseGame pauseGame;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Level001 ()
    {
        SceneManager.LoadScene(2);
    }

    public void CreditsScene ()
    {
        SceneManager.LoadScene(3);
    }

    public void OptionsScene ()
    {
        SceneManager.LoadScene(5);
    }

    public void HowToPlayScene()
    {
        SceneManager.LoadScene(6);
    }

    public void MainMenuScene()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ResumeGame()
    {
        //Time.timeScale = 1;
        pauseGame.GamePaused = false;
        pauseGame.Player.GetComponent<FirstPersonController>().enabled = true;
        //Weapons.GetComponentInChildren<M9GunFire>().enabled = true;
        //Weapons.GetComponentInChildren<MP5KGunFire>().enabled = true;
        //Weapons.GetComponentInChildren<UMP45GunFire>().enabled = true;
        pauseGame.Weapons.SetActive(true);
        pauseGame.GunMechanics.SetActive(true);
        pauseGame.PauseMenu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
