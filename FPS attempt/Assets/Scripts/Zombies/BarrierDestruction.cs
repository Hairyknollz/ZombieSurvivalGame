using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class BarrierDestruction : MonoBehaviour {

    public Barriers theBarrier;
    //public ZombieAI TheZombie;
    public NavMeshAgent agent;

    public GameObject TheBarrier;
    public bool CanBreak;
    public bool Triggered;
    //public GameObject TheBarrier;

	// Use this for initialization
	void Start () {
        CanBreak = true;
        Triggered = false;
    }

    // Update is called once per frame
    void Update () {
		
	}

    private void OnTriggerStay(Collider other)
    {
        if(other.transform.tag == "ZombieBarricadeTrigger")
        {
            if (theBarrier.BarrierHealth > 0 && CanBreak == true)
            {
                Triggered = true;
                CanBreak = false;
                agent.GetComponent<NavMeshAgent>().speed = 0;
                theBarrier.BarrierHealth -= 1;
                StartCoroutine(BreakCooldown());
            }
            else if (theBarrier.BarrierHealth <= 0)
            {
                agent.GetComponent<NavMeshAgent>().speed = 1;
                TheBarrier.SetActive(false);
            }
        }
    }

    IEnumerator BreakCooldown()
    {
        yield return new WaitForSeconds(1);
        CanBreak = true;
    }

}
