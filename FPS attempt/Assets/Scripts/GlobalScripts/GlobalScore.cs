using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalScore : MonoBehaviour {

    public static int CurrentScore;
    public int InternalScore;
    public GameObject ScoreDisplay;

	// Use this for initialization
	void Start () {
        CurrentScore = 50000;
	}
	
	// Update is called once per frame
	void Update () {
        InternalScore = CurrentScore;
        ScoreDisplay.GetComponent<Text>().text = "Score: " + CurrentScore;
    }
}
