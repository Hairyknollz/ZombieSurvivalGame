using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalScore : MonoBehaviour {

    public GlobalRounds globalRounds;

    public static int CurrentScore;
    public static int TotalScore;
    public int InternalScore;
    public GameObject ScoreDisplay;
    public GameObject ScoreBoardTotalScore;
    public GameObject ScoreBoardCurrentScore;
    public GameObject ScoreBoardKills;


    // Use this for initialization
    void Start () {
        CurrentScore = 50000;
        TotalScore = TotalScore + CurrentScore;
    }

    // Update is called once per frame
    void Update () {
        InternalScore = CurrentScore;
        ScoreDisplay.GetComponent<Text>().text = "Score: " + CurrentScore;
        ScoreBoardCurrentScore.GetComponent<Text>().text = "Score: " + CurrentScore;
        ScoreBoardTotalScore.GetComponent<Text>().text = "" + TotalScore;
        ScoreBoardKills.GetComponent<Text>().text = "" + globalRounds.TotalKills;
    }

    //public void UpdateTotalScore()
    //{
    //    TotalScore = TotalScore + CurrentScore;
    //    ScoreBoardTotalScore.GetComponent<Text>().text = "" + TotalScore;
    //}
}
