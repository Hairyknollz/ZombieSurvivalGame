using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieFollow : MonoBehaviour {

    public HealthMonitor healthMonitor;
    public NavMeshAgent agent;

    public GameObject ThePlayer;
    public float TargetDistance;
    public float AllowedRange;
    public GameObject TheZombie;
    public GameObject BarrierStart;
    public int AttackTrigger;
    public RaycastHit Shot;
    public int IsAttacking;
    public GameObject ScreenFlash;
    public AudioSource Hurt001;
    public AudioSource Hurt002;
    public AudioSource Hurt003;
    public int PainSound;

    // Use this for initialization
    void Start () {
        //AllowedRange = 100;
        //agent.GetComponent<NavMeshAgent>().speed = 1;
    }

    // Update is called once per frame
    void Update () {
        transform.LookAt(ThePlayer.transform);
        if (Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), out Shot))
        {
            TargetDistance = Shot.distance;
            if (TargetDistance < AllowedRange)
            {
                agent.GetComponent<NavMeshAgent>().speed = 1;
                if (AttackTrigger == 0)
                {
                    TheZombie.GetComponent<Animation>().Play("Walking");
                    //transform.position = Vector3.MoveTowards(transform.position, ThePlayer.transform.position, EnemySpeed);
                    agent.SetDestination(ThePlayer.transform.position);
                }
            }
            else
            {
                agent.GetComponent<NavMeshAgent>().speed = 0;
                TheZombie.GetComponent<Animation>().Play("Idle");
            }
        }
        if (AttackTrigger == 1)
        {
            if (IsAttacking == 0)
            {
                StartCoroutine(EnemyDamage());
            }
            TheZombie.GetComponent<Animation>().Play("Attacking");
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "ZombieTrigger")
        {
            AttackTrigger = 1;
        }
    }

    void OnTriggerExit()
    {
        AttackTrigger = 0;
    }

    IEnumerator EnemyDamage()
    {
        IsAttacking = 1;
        
        if (healthMonitor.StalwartActive == false)
        {
            PainSound = Random.Range(1, 4);
            yield return new WaitForSeconds(0.9f);
            ScreenFlash.SetActive(true);
            HealthMonitor.PlayerHealth -= 20;
            if (PainSound == 1)
            {
                Hurt001.Play();
            }
            else if(PainSound == 2)
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
        IsAttacking = 0;
    }

}
