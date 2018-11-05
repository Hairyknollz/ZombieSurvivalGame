using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthMonitor : MonoBehaviour {

    public GameObject Health001;
    public GameObject Health002;
    public GameObject Health003;
    public GameObject Health004;
    public GameObject Health005;
    public GameObject ArmourPip001;
    public GameObject ArmourPip002;
    public GameObject ArmourPip003;
    public static int PlayerHealth;
    public int CurrentArmour;
    public GameObject ArmourDisplay;
    public bool StalwartActive;

    // Use this for initialization
    void Start () {
        StalwartActive = false;
        PlayerHealth = 100;
    }
	
	// Update is called once per frame
	void Update () {
        
        if (StalwartActive == false)
        {
            if (PlayerHealth == 80)
            {
                if (Health005.transform.localScale.y <= 0.0f)
                {
                    Health005.SetActive(false);
                }
                else
                {
                    Health005.transform.localScale -= new Vector3(0.0f, 0.05f, 0.0f);
                }
            }
            if (PlayerHealth == 60)
            {
                if (Health004.transform.localScale.y <= 0.0f)
                {
                    Health004.SetActive(false);
                }
                else
                {
                    Health004.transform.localScale -= new Vector3(0.0f, 0.05f, 0.0f);
                }
            }
            if (PlayerHealth == 40)
            {
                if (Health003.transform.localScale.y <= 0.0f)
                {
                    Health003.SetActive(false);
                }
                else
                {
                    Health003.transform.localScale -= new Vector3(0.0f, 0.05f, 0.0f);
                }
            }
            if (PlayerHealth == 20)
            {
                if (Health002.transform.localScale.y <= 0.0f)
                {
                    Health002.SetActive(false);
                }
                else
                {
                    Health002.transform.localScale -= new Vector3(0.0f, 0.05f, 0.0f);
                }
            }
            if (PlayerHealth == 00)
            {
                if (Health001.transform.localScale.y <= 0.0f)
                {
                    Health001.SetActive(false);
                }
                else
                {
                    Health001.transform.localScale -= new Vector3(0.0f, 0.05f, 0.0f);
                    SceneManager.LoadScene(4);
                }
            }
        }
        else if (StalwartActive == true)
        {
            ArmourDisplay.SetActive(true);
            if (CurrentArmour == 2)
            {
                if (ArmourPip003.transform.localScale.y <= 0.0f)
                {
                    ArmourPip003.SetActive(false);
                }
                else
                {
                    ArmourPip003.transform.localScale -= new Vector3(0.0f, 0.05f, 0.0f);
                }
            }
            if (CurrentArmour == 1)
            {
                if (ArmourPip002.transform.localScale.y <= 0.0f)
                {
                    ArmourPip002.SetActive(false);
                }
                else
                {
                    ArmourPip002.transform.localScale -= new Vector3(0.0f, 0.05f, 0.0f);
                }
            }
            if (CurrentArmour == 0)
            {
                if (ArmourPip001.transform.localScale.y <= 0.0f)
                {
                    ArmourPip001.SetActive(false);
                    StalwartActive = false;
                    ArmourDisplay.SetActive(false);
                }
                else
                {
                    ArmourPip001.transform.localScale -= new Vector3(0.0f, 0.05f, 0.0f);
                }
            }
        }
    }
}
