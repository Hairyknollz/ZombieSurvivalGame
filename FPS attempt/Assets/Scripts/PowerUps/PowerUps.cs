using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour {

    public string PowerUp;
    public AudioSource StalwartHammer;
    public HealthMonitor healthMonitor;
    public GameObject PowerUpDisplay;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Stalwart" && healthMonitor.StalwartActive == false)
        {
            PowerUp = "Stalwart";
            //StartCoroutine(PlayAudio());
            healthMonitor.StalwartActive = true;
            healthMonitor.CurrentArmour = 3;
            Destroy(other.gameObject);
            StartCoroutine(PlayAudio());
            StartCoroutine(PlayAnim());
        }
        if (other.transform.tag == "MaxAmmo")
        {
            PowerUp = "MaxAmmo";
            StartCoroutine(PlayAudio());
            GlobalAmmo.M9LoadedAmmo = 15;
            GlobalAmmo.M9ReserveAmmo = 120;
            GlobalAmmo.MP5KLoadedAmmo = 30;
            GlobalAmmo.MP5KReserveAmmo = 240;
            GlobalAmmo.UMP45LoadedAmmo = 25;
            GlobalAmmo.UMP45ReserveAmmo = 200;
            Destroy(other.gameObject);
            StartCoroutine(PlayAnim());
        }
    }

    IEnumerator PlayAudio ()
    {
        StalwartHammer.Play();
        yield return new WaitForSeconds(0.8f);
        StalwartHammer.GetComponent<AudioSource>().volume = 0.65f;
        StalwartHammer.Play();
        yield return new WaitForSeconds(0.8f);
        StalwartHammer.GetComponent<AudioSource>().volume = 1;
        StalwartHammer.Play();
    }

    IEnumerator PlayAnim()
    {
        PowerUpDisplay.SetActive(true);
        PowerUpDisplay.GetComponent<Animation>().Play("StalwartDisplayAnim");
        yield return new WaitForSeconds(5);
        PowerUpDisplay.SetActive(false);
    }
}
