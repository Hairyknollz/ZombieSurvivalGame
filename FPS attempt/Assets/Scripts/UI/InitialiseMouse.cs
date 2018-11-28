using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialiseMouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (PlayerPrefs.GetInt("p_fov") < 60)
        {
            PlayerPrefs.SetInt("p_fov", 60);
        }
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
