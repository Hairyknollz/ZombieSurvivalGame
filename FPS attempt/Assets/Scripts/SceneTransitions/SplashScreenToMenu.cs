using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreenToMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(SplashScreenFade());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator SplashScreenFade ()
    {
        yield return new WaitForSeconds(5.5f);
        SceneManager.LoadScene(1);
    }

}
