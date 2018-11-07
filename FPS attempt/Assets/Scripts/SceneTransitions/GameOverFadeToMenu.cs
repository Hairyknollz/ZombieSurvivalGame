using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverFadeOut : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(FadeToMenu());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator FadeToMenu ()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }

}
