using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour {
    public AudioSource AmmoSound;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            AmmoSound.Play();
            GlobalAmmo.M9ReserveAmmo += 30;
            GlobalAmmo.MP5KReserveAmmo += 30;
            this.gameObject.SetActive(false);
        }
    }
}
