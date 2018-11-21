using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalHealth : MonoBehaviour {

    public static int PlayerHealth;
    //public int InternalHealth;
    //public GameObject HealthDisplay;

	// Use this for initialization
	void Start () {
        PlayerHealth = 100;
	}
	
	// Update is called once per frame
	void Update () {
        //InternalHealth = PlayerHealth;
        //HealthDisplay.GetComponent<Text>().text = "Health: " + PlayerHealth;
        if (PlayerHealth <= 0)
        {
            SceneManager.LoadScene(4);
        }

    }
}
