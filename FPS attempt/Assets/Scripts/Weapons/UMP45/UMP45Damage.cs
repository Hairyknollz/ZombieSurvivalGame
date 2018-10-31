using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UMP45Damage : MonoBehaviour {

    public UMP45GunFire UMP45GunFire;

    public int GunDamage;
    public int BaseGunDamage;
    public float TargetDistance;
    public int AllowedRange;
    public RaycastHit BulletHit;
    public GameObject BulletHole;
    public GameObject TheBlood;

    // Use this for initialization
    void Start () {
        BaseGunDamage = 25;
        GunDamage = BaseGunDamage;
        AllowedRange = 15;
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    public void FireUMP45()
    {
        if (UMP45GunFire.Firing == true)
        {
            RaycastHit Shot;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
            {
                TargetDistance = Shot.distance;
                if (TargetDistance <= AllowedRange)
                {
                    if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out BulletHit))
                    {
                        if (BulletHit.transform.tag == "Zombie")
                        {
                            Instantiate(TheBlood, BulletHit.point, Quaternion.FromToRotation(Vector3.up, BulletHit.normal));
                        }
                        if (BulletHit.collider.tag == "ZombieHead")
                        {
                            GunDamage = GunDamage * 2;
                            Instantiate(TheBlood, BulletHit.point, Quaternion.FromToRotation(Vector3.up, BulletHit.normal));
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

}
