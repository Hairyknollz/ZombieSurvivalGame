using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinToMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(WaitForCredits());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator WaitForCredits ()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(1);
    }

}
