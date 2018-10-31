using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalRounds : MonoBehaviour {

    public GameObject RoundCounter;
    public GlobalZombie globalZombie;
    public int CurrentRound;


	// Use this for initialization
	void Start () {
        CurrentRound = 1;
        globalZombie.RoundLimit = 9;
	}
	
	// Update is called once per frame
	void Update () {
		if (globalZombie.RoundLimit <= 0)
        {
            CurrentRound += 1;
            RoundCounter.GetComponent<Text>().text = "" + CurrentRound;
            globalZombie.RoundLimit = 0.000058 * (CurrentRound * CurrentRound * CurrentRound) + 0.074032 * (CurrentRound * CurrentRound) + 0.718119 * +14.738699;
        }
	}

    //IEnumerator PlayAnim ()
    //{

    //    yield return new WaitForSeconds(1);
    //}
}
