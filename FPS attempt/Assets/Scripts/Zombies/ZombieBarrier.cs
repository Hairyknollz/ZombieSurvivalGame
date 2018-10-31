using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieBarrier : MonoBehaviour {

    public int BarrierBoards;
    public ZombieFollow TheZombie;
    public GameObject Board001;
    public GameObject Board002;
    public GameObject Board003;
    public GameObject Board004;
    public GameObject Board005;
    public GameObject ThroughBarrier;



    // Use this for initialization
    void Start () {
        BarrierBoards = 5;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "zombie")
        {
            while (BarrierBoards > 0)
            {
                TheZombie.agent.GetComponent<NavMeshAgent>().speed = 0;
                StartCoroutine(PlayAnimation());
                BarrierBoards -= 1;
            }
            TheZombie.agent.GetComponent<NavMeshAgent>().speed = 1;
            TheZombie.agent.SetDestination(ThroughBarrier.transform.position);
        }
    }

    IEnumerator PlayAnimation ()
    {
        TheZombie.GetComponent<Animation>().Play("Attacking");
        yield return new WaitForSeconds(0.9f);
    }

}
