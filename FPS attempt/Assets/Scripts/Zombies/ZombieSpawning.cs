using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalZombie : MonoBehaviour {

    public GameObject ThePlayer;
    public GameObject TheZombie;
    //public Vector3 SpawnPosition;
    public int ZombieCount;
    public double RoundLimit;
    public float PlaceX;
    public float PlaceY;

	// Use this for initialization
	void Start () {

        //RoundLimit = 9;
        //ZombieCount = 0;

        PlaceX = Random.Range(-25, 25);
        PlaceY = Random.Range(-25, 25);
        //TheZombie.transform.position = new Vector3(PlaceX, 0, PlaceY);
    }
	
	// Update is called once per frame
	void Update () {
		if (ZombieCount < 50)
        {
            if (ZombieCount < RoundLimit)
            {
                PlaceX = Random.Range(-5, 5);
                PlaceY = Random.Range(-5, 5);
                Vector3 SpawnPosition = new Vector3(PlaceX, 0, PlaceY);
                Instantiate(TheZombie, SpawnPosition, Quaternion.identity);
                StartCoroutine(WaitForNextSpawn());
            }
        }
	}

    IEnumerator WaitForNextSpawn ()
    {
        yield return new WaitForSeconds(2);
        TheZombie.transform.position = new Vector3(PlaceX, 0, PlaceY);
        ZombieCount += 1;
    }
}
