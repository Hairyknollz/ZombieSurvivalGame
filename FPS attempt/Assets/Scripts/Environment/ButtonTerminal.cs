using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTerminal : MonoBehaviour {

    //public OpenDoubleDoors openDoubleDoors;

    public GlobalButtonsPressed buttonsPressed;
    public GameObject ScreenPip001;
    public GameObject ScreenPip002;
    public GameObject ScreenPip003;
    public GameObject EscapeDoor;
    public GameObject Button;
    public GameObject InteractText;
    public float TheDistance;

    // Use this for initialization
    void Start () {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    // Update is called once per frame
    void Update () {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if (TheDistance <= 2)
        {
            InteractText.GetComponent<Text>().text = "Press Button (5000 Score)";
        }
        if (Input.GetButtonDown("Action") && GlobalScore.CurrentScore >= 5000 && buttonsPressed.ButtonPressed == false)
        {
            if (TheDistance <= 2)
            {
                buttonsPressed.ButtonsPressed += 1;
                buttonsPressed.ButtonPressed = true;
                StartCoroutine(PlayAnim());
                if (buttonsPressed.ButtonsPressed == 0)
                {
                    ScreenPip001.SetActive(false);
                    ScreenPip002.SetActive(false);
                    ScreenPip003.SetActive(false);
                    //buttonsPressed.ButtonPressed = false;
                    //GlobalScore.CurrentScore -= 5000;

                }
                else if (buttonsPressed.ButtonsPressed == 1)
                {
                    ScreenPip001.SetActive(true);
                    ScreenPip002.SetActive(false);
                    ScreenPip003.SetActive(false);
                    buttonsPressed.ButtonPressed = false;
                    GlobalScore.CurrentScore -= 5000;

                }
                else if (buttonsPressed.ButtonsPressed == 2)
                {
                    ScreenPip001.SetActive(true);
                    ScreenPip002.SetActive(true);
                    ScreenPip003.SetActive(false);
                    buttonsPressed.ButtonPressed = false;
                    GlobalScore.CurrentScore -= 5000;

                }
                else if (buttonsPressed.ButtonsPressed == 3)
                {
                    ScreenPip001.SetActive(true);
                    ScreenPip002.SetActive(true);
                    ScreenPip003.SetActive(true);
                    buttonsPressed.ButtonPressed = false;
                    GlobalScore.CurrentScore -= 5000;
                    //openDoubleDoors.StartCoroutine(open)
                }
            }
        }
    }

    void OnMouseExit()
    {
        InteractText.GetComponent<Text>().text = "";
    }


    IEnumerator PlayAnim ()
    {
        Button.GetComponent<Animation>().Play("TerminalButtonAnim");
        yield return new WaitForSeconds(0.05f);
    }

}
