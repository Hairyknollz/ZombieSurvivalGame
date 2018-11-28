using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MP5KDamage : MonoBehaviour {

    public MP5KGunFire MP5KGunFire;

    public int GunDamage;
    public int BaseGunDamage;
    public RaycastHit BulletHit;
    public GameObject BulletHole;
    public GameObject BloodParticles;

    // Use this for initialization
    void Start () {
        BaseGunDamage = 25;
        GunDamage = BaseGunDamage;
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    public void FireMP5K ()
    {
        if (MP5KGunFire.Firing == true)
        {
            RaycastHit Shot;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
            {
                    if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out BulletHit))
                    {
                        if (BulletHit.transform.tag == "Zombie")
                        {
                            Instantiate(BloodParticles, BulletHit.point, Quaternion.FromToRotation(Vector3.up, BulletHit.normal));
                        }
                        if (BulletHit.collider.tag == "ZombieHead")
                        {
                            GunDamage = GunDamage * 2;
                            Instantiate(BloodParticles, BulletHit.point, Quaternion.FromToRotation(Vector3.up, BulletHit.normal));
                        }
                        if (BulletHit.transform.tag == "Untagged")
                        {
                            Instantiate(BulletHole, BulletHit.point, Quaternion.FromToRotation(Vector3.up, BulletHit.normal));
                        }
                    }
                    Shot.transform.SendMessage("DealDamage", GunDamage, SendMessageOptions.DontRequireReceiver);
                    if (GunDamage > BaseGunDamage)
                    {
                        GunDamage = GunDamage / 2;
                    }
            }
        }
    }

}
