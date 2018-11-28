using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenEscapeDoors : MonoBehaviour
{
    public GlobalButtonsPressed globalButtonsPressed;

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
        if (TheDistance <= 2 && globalButtonsPressed.ButtonsPressed < 3)
        {
            TextDisplay.GetComponent<Text>().text = "Opened elsewhere";
        }
        if (globalButtonsPressed.ButtonsPressed == 3)
        {
                StartCoroutine(OpenTheDoor());
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
        GetComponent<BoxCollider>().enabled = false;
        yield return new WaitForSeconds(1);
        TheDoorRight.GetComponent<Animation>().Stop("Door002RightAnim");
        TheDoorLeft.GetComponent<Animation>().Stop("Door002LeftAnim");
    }

}