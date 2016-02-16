using UnityEngine;
using System.Collections;

public class Enemy1Ctrl : MonoBehaviour
{
    public GameObject Bullet;
    public float speed;

    void Shoot()
    {
  
        GameObject B = Instantiate(Bullet);

        B.transform.position = gameObject.transform.position;

        B.GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * speed);
    }



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

}