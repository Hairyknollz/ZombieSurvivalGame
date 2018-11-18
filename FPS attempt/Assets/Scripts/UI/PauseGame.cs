using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PauseGame : MonoBehaviour {

    public bool GamePaused;
    public GameObject Player;

	// Use this for initialization
	void Start () {
        GamePaused = false;
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
                Cursor.visible = true;
            }
            else
            {
                Player.GetComponent<FirstPersonController>().enabled = true;
                GamePaused = false;
                Time.timeScale = 1;
            }
        }
	}
}
