using UnityEngine;
using System.Collections;

public class Enemy1Ctrl : MonoBehaviour
{
    public GameObject Target;
    public GameObject Bullet;
    public float speed;
    public float TimeBtwnShots;

    void Shoot()
    {
        //Spawning Bullet
        GameObject B = Instantiate(Bullet);
        B.transform.position = gameObject.transform.position;

        //Calculations
        Vector3 Force = (Target.transform.position - transform.position).normalized;

        //Applying the force
        B.GetComponent<Rigidbody>().AddForce(Force *speed * Time.deltaTime);
    }



    void Update()
    {
        if (TimeBtwnShots == Time.deltaTime)
        {
            Shoot();
        }
    }

}