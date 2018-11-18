using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOptions : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayGame ()
    {
        SceneManager.LoadScene(2);
    }

    public void CreditsScene ()
    {
        SceneManager.LoadScene(3);
    }

    public void OptionsScene ()
    {
        SceneManager.LoadScene(5);
    }

    public void HowToPlayScene()
    {
        SceneManager.LoadScene(6);
    }

    public void HTPToMainMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
