using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoor002 : MonoBehaviour
{
    public GameObject TextDisplay;
    public GameObject TheDoorLeft;
    public GameObject TheDoorRight;
    public float TheDistance;

    // Use this for initialization
    void Start()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    // Update is called once per frame
    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if (TheDistance <= 2)
        {
            TextDisplay.GetComponent<Text>().text = "Open Door (500 Score)";
        }
        if (Input.GetButtonDown("Action") && GlobalScore.CurrentScore >= 500)
        {
            if (TheDistance <= 2)
            {
                StartCoroutine(OpenTheDoor());
                GlobalScore.CurrentScore -= 500;
            }
        }
    }

    void OnMouseExit()
    {
        TextDisplay.GetComponent<Text>().text = "";
    }

    IEnumerator OpenTheDoor()
    {
        TheDoorRight.GetComponent<Animation>().Play("Door002RightAnim");
        TheDoorLeft.GetComponent<Animation>().Play("Door002LeftAnim");
        this.GetComponent<BoxCollider>().enabled = false;
        yield return new WaitForSeconds(1);
        TheDoorRight.GetComponent<Animation>().Stop("Door002RightAnim");
        TheDoorLeft.GetComponent<Animation>().Stop("Door002LeftAnim");
    }

}