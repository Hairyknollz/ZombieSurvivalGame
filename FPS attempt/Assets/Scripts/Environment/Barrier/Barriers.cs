using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barriers : MonoBehaviour {

    public int BarrierHealth;
    public GameObject Barrier001;
    public GameObject Barrier002;
    public GameObject Barrier003;

    // Use this for initialization
    void Start () {
        BarrierHealth = 3;
	}
	
	// Update is called once per frame
	void Update () {
		if (BarrierHealth == 3)
        {
            Barrier001.SetActive(true);
            Barrier002.SetActive(true);
            Barrier003.SetActive(true);

        }
        if (BarrierHealth == 2)
        {
            Barrier001.SetActive(false);
            Barrier002.SetActive(true);
            Barrier003.SetActive(true);
        }
        if (BarrierHealth == 1)
        {
            Barrier001.SetActive(false);
            Barrier002.SetActive(false);
            Barrier003.SetActive(true);
        }
        if (BarrierHealth == 0)
        {
            Barrier001.SetActive(false);
            Barrier002.SetActive(false);
            Barrier003.SetActive(false);
        }
    }
}
