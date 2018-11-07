using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawning : MonoBehaviour {

    public GameObject ThePlayer;
    public GameObject TheZombie;
    public int MaxZombies;
    public double ZombiesPerRound;
    public float PlaceX;
    public float PlaceY;

	// Use this for initialization
	void Start () {
        MaxZombies = 0;
    }
	
	// Update is called once per frame
	void Update () {
		if (MaxZombies < 50)
        {
            if (MaxZombies < ZombiesPerRound)
            {
                MaxZombies += 1;
                StartCoroutine(SpawnZombie());
            }
        }
	}

    IEnumerator SpawnZombie ()
    {
        PlaceX = Random.Range(-5, 5);
        PlaceY = Random.Range(-5, 5);
        Vector3 SpawnPosition = new Vector3(PlaceX, 0, PlaceY);
        TheZombie.transform.position = new Vector3(PlaceX, 0, PlaceY);
        Instantiate(TheZombie, SpawnPosition, Quaternion.identity);
        yield return new WaitForSeconds(2);
        
    }
}
