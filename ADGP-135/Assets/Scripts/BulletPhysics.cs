using UnityEngine;
using System.Collections;

public class BulletPhysics : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.up * speed; 
    }
}
