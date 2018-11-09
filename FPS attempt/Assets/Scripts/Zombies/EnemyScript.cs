using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour {
    //public GlobalZombie globalZombie;

    public int EnemyHealth;
    public GameObject TheZombie;
    public NavMeshAgent agent;

	// Use this for initialization
	void Start () {
        EnemyHealth = 100;
	}

    void DealDamage(int GunDamage)
    {
        EnemyHealth -= GunDamage;
        GlobalScore.CurrentScore += 10;
    }

    // Update is called once per frame
    void Update () {
        if (EnemyHealth <= 0)
        {
            this.GetComponent<ZombieFollow>().enabled = false;
            agent.GetComponent<NavMeshAgent>().speed = 0;
            //TheZombie.GetComponent<Animation>().Play("Dying");
            //tartCoroutine(EndZombie());

        }
	}

    IEnumerator EndZombie()
    {
        yield return new WaitForSeconds(3);
        //globalZombie.ZombieCount -= 1;
        //globalZombie.RoundLimit -= 1;
        Destroy(gameObject);
    }

}
