using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalRounds : MonoBehaviour {

    public GameObject RoundCounter;
    //public GlobalZombie globalZombie;
    public int CurrentRound;
    public int CurrentZombiesAlive;
    public int MaxZombiesAtOnce;
    public double ZombiesThisRound;
    public int ZombiesKilled;
    public bool SpawnPointsActive;


    // Use this for initialization
    void Start () {
        MaxZombiesAtOnce = 50;
        CurrentRound = 1;
        ZombiesThisRound = 10;
        SpawnPointsActive = false;
        StartNextRound();
	}
	
	// Update is called once per frame
	void Update () {
        if (CurrentZombiesAlive != MaxZombiesAtOnce && CurrentZombiesAlive != ZombiesThisRound)
        {
            SpawnPointsActive = true;
        }
        else
        {
            SpawnPointsActive = false;
        }
        if (ZombiesKilled == ZombiesThisRound)
        {
            CurrentRound += 1;
            ZombiesThisRound = ZombiesThisRound + 8;
            ZombiesKilled = 0;
            RoundCounter.GetComponent<Text>().text = "" + CurrentRound;
            //StartNextRound();
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
