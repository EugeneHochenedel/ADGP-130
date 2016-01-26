using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour
{
    public float speed = 1f
        ;
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed * 4 * Time.deltaTime, 0.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(speed * -4 * Time.deltaTime, 0.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0.0f, 0.0f, speed * 4 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0.0f, 0.0f, speed * -4 * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(new Vector3(0, 0, -180) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(new Vector3(0, 0, 180) * Time.deltaTime);
        }
    }
}

