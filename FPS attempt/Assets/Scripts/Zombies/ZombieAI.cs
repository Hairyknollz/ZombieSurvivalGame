using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieAI : MonoBehaviour
{
    public NavMeshAgent agent;
    public HealthMonitor healthMonitor;

    public GameObject ThePlayer;
    public GameObject TheZombie;
    public RaycastHit Shot;
    public bool CanAttack;
    public bool IsAttacking;
    public GameObject ScreenFlash;
    public AudioSource Hurt001;
    public AudioSource Hurt002;
    public AudioSource Hurt003;
    public int PainSound;

    // Use this for initialization
    void Start()
    {
        CanAttack = false;
        IsAttacking = false;
        agent.GetComponent<NavMeshAgent>().speed = 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(ThePlayer.transform);            
        //agent.GetComponent<NavMeshAgent>().speed = 1.35f;
        if (CanAttack == false)
        {
            //TheZombie.GetComponent<Animation>().Play("walk");
            agent.SetDestination(ThePlayer.transform.position);
            agent.GetComponent<NavMeshAgent>().speed = 1.5f;
        }

        if (CanAttack == true)
        {
            if (IsAttacking == false)
            {
                StartCoroutine(Attack());
            }
            agent.GetComponent<NavMeshAgent>().speed = 0;
            //TheZombie.GetComponent<Animation>().Play("attack");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "ZombieTrigger")
        {
            CanAttack = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "ZombieTrigger")
        {
            CanAttack = false;
        }
    }

    IEnumerator Attack()
    {
        IsAttacking = true;

        if (healthMonitor.StalwartActive == false)
        {
            PainSound = Random.Range(1, 4);
            yield return new WaitForSeconds(0.9f);
            ScreenFlash.SetActive(true);
            GlobalHealth.PlayerHealth -= 20;
            if (PainSound == 1)
            {
                Hurt001.Play();
            }
            else if (PainSound == 2)
            {
                Hurt002.Play();
            }
            else if (PainSound == 3)
            {
                Hurt003.Play();
            }
            yield return new WaitForSeconds(0.05f);
            ScreenFlash.SetActive(false);
        }
        else if (healthMonitor.StalwartActive == true)
        {
            yield return new WaitForSeconds(0.9f);
            healthMonitor.CurrentArmour -= 1;
        }
        yield return new WaitForSeconds(1);
        IsAttacking = false;
    }
}