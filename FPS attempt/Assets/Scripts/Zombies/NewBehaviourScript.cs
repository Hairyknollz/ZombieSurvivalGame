using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public GameObject spawnPoint;
    public GameObject Worm;
    public Vector3 SpawnPosition;
    public bool CanSpawnWorm;
    public int SpawnRate;

	// Use this for initialization
	void Start () {
        CanSpawnWorm = true;
	}
	
	// Update is called once per frame 
	void Update () {
		if(CanSpawnWorm == true)
        {
            SpawnWorm();
        }
	}

    void SpawnWorm()
    {
        CanSpawnWorm = false;
        SpawnRate = Random.Range(1, 6);
        SpawnPosition = new Vector3(this.transform.position.x, this.transform.position.y, 0);
        Instantiate(Worm, SpawnPosition, Quaternion.identity);
        StartCoroutine(StartSpawnCooldown());
    }

    IEnumerator StartSpawnCooldown()
    {
        yield return new WaitForSeconds(SpawnRate);
        CanSpawnWorm = true;
    }

}
