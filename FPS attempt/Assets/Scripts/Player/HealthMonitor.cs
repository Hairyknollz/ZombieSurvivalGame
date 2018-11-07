using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthMonitor : MonoBehaviour {

    public GameObject Health001;
    public GameObject Health002;
    public GameObject Health003;
    public GameObject Health004;
    public GameObject Health005;
    public GameObject ArmourPip001;
    public GameObject ArmourPip002;
    public GameObject ArmourPip003;
    public int CurrentHealth;
    public int CurrentArmour;
    public GameObject ArmourDisplay;
    public bool StalwartActive;

    // Use this for initialization
    void Start () {
        StalwartActive = false;
	}
	
	// Update is called once per frame
	void Update () {
        CurrentHealth = GlobalHealth.PlayerHealth;
        if (StalwartActive == false)
        {
            if (CurrentHealth == 80)
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
            if (CurrentHealth == 60)
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
            if (CurrentHealth == 40)
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
            if (CurrentHealth == 20)
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
            if (CurrentHealth == 00)
            {
                if (Health001.transform.localScale.y <= 0.0f)
                {
                    Health001.SetActive(false);
                }
                else
                {
                    Health001.transform.localScale -= new Vector3(0.0f, 0.05f, 0.0f);
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
