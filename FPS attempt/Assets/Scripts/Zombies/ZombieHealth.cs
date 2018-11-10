using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class ZombieHealth : MonoBehaviour
{
    public GlobalRounds globalRounds;
    public GlobalScore globalScore;

    public int CurrentHealth;
    public GameObject TheZombie;
    public GameObject ScoreBoardKills;
    public NavMeshAgent agent;

    // Use this for initialization
    void Start()
    {
        CurrentHealth = 100;
    }

    void DealDamage(int GunDamage)
    {
        CurrentHealth -= GunDamage;
        GlobalScore.CurrentScore += 10;
        GlobalScore.TotalScore += 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentHealth <= 0)
        {
            TheZombie.GetComponent<ZombieAI>().enabled = false;
            agent.GetComponent<NavMeshAgent>().speed = 0;
            //TheZombie.GetComponent<Animation>().Play("Dying");
            TheZombie.GetComponent<CapsuleCollider>().enabled = false;
            GlobalScore.CurrentScore += 60;
            GlobalScore.TotalScore += 60;            
            globalRounds.CurrentZombiesAlive -= 1;
            globalRounds.ZombiesKilled += 1;
            globalRounds.TotalKills += 1;
            Destroy(gameObject);
            //StartCoroutine(EndZombie());

        }
    }

    //IEnumerator EndZombie()
    //{
    //    yield return new WaitForSeconds(3);
        
    //}

}
