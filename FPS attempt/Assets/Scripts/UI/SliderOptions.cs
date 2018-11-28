using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SliderOptions : MonoBehaviour {

    public static float PlayerFOV;
    public Slider FOVSlider;
    public Text CurrentFOVValue;

	// Use this for initialization
	void Start () {
        FOVSlider.value = PlayerPrefs.GetInt("p_fov");
    }

    // Update is called once per frame
    void Update () {
		
	}



    public void setFOV ()
    {
        PlayerFOV = FOVSlider.value;
        PlayerPrefs.SetInt("p_fov", (Mathf.RoundToInt(PlayerFOV)));
        CurrentFOVValue.GetComponent<Text>().text = "" + (Mathf.RoundToInt(PlayerFOV));
    }

}
