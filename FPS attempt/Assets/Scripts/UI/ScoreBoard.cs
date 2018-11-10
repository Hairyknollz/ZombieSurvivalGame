using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour {

    public GameObject Scoreboard;
    public GameObject HealthDisplay;
    public GameObject Crosshair;
    public GameObject AmmoDisplay;
    public GameObject RoundDisplay;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Scoreboard"))
        {
            Scoreboard.SetActive(true);
            HealthDisplay.SetActive(false);
            Crosshair.SetActive(false);
            AmmoDisplay.SetActive(false);
            RoundDisplay.SetActive(false);
        }
        else
        {
            Scoreboard.SetActive(false);
            HealthDisplay.SetActive(true);
            Crosshair.SetActive(true);
            AmmoDisplay.SetActive(true);
            RoundDisplay.SetActive(true);
        }
	}
}
