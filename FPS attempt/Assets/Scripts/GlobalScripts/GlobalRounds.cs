using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalRounds : MonoBehaviour {

    public GameObject RoundCounter;
    public GlobalZombie globalZombie;
    public int CurrentRound;
    public int CurrentZombiesAlive;
    public int MaxZombiesAtOnce;
    public double ZombiesPerRound;
    public double KillsToNextRound;


    // Use this for initialization
    void Start () {
        CurrentRound = 1;
        ZombiesPerRound = 10 * 1.2;
        CurrentZombiesAlive = 0;
        MaxZombiesAtOnce = 50;
        KillsToNextRound = ZombiesPerRound;
        //globalZombie.RoundLimit = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (KillsToNextRound == 0)
        {
            CurrentRound += 1;
            RoundCounter.GetComponent<Text>().text = "" + CurrentRound;
            StartNextRound();
        }

        //if (CurrentZombiesAlive <= ZombiesPerRound)
        //{
        //    CurrentRound += 1;
        //    RoundCounter.GetComponent<Text>().text = "" + CurrentRound;
        //    ZombiesPerRound = ZombiesPerRound * 1.2;
        //}
    }

    void StartNextRound()
    {

    }

    //IEnumerator PlayAnim ()
    //{

    //    yield return new WaitForSeconds(1);
    //}
}
