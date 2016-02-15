using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

	public GameObject Attack_Prefab;
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Fire1"))
		{
			Rigidbody clone;
			Camera cam = Camera.main;
			clone = Instantiate(Attack_Prefab, cam.transform.position, transform.rotation) as Rigidbody;
	
		}
	}
}
