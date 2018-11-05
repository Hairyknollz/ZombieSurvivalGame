using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointActivation : MonoBehaviour {

    //public GlobalRounds globalRounds;

    public bool IsActive;
    public bool CanSpawnZombie;
    public GameObject TheZombie;
    public Vector3 SpawnPosition;

	// Use this for initialization
	void Start () {
        CanSpawnZombie = true;
	}

    // Update is called once per frame
    void Update () {
        if (IsActive == true && CanSpawnZombie == true)
        {
            SpawnZombie();
        }
	}

    void OnTriggerStay(Collider other)
    {
        if (other.transform.tag == "ZombieSpawnRadius")
        {
            IsActive = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "ZombieSpawnRadius")
        {
            IsActive = false;
        }
    }

    void SpawnZombie ()
    {
        CanSpawnZombie = false;
        SpawnPosition = new Vector3(this.transform.position.x, 0, this.transform.position.z);
        Instantiate(TheZombie, SpawnPosition, Quaternion.identity);
        //globalRounds.CurrentZombiesAlive += 1;
        StartCoroutine(StartSpawnCooldown());
    }

    IEnumerator StartSpawnCooldown ()
    {
        yield return new WaitForSeconds(3);
        CanSpawnZombie = true;
    }
}
