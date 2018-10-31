using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieHealth : MonoBehaviour
{
    public GlobalZombie globalZombie;

    public int CurrentHealth;
    public GameObject TheZombie;
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
            StartCoroutine(EndZombie());

        }
    }

    IEnumerator EndZombie()
    {
        yield return new WaitForSeconds(3);
        GlobalScore.CurrentScore += 60;
        globalZombie.ZombieCount -= 1;
        globalZombie.RoundLimit -= 1;
        Destroy(gameObject);
    }

}
