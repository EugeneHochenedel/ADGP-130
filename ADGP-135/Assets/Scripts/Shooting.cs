using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {


	public GameObject Attack_Prefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Fire1"))
		{
			Instantiate(Attack_Prefab, transform.position, transform.rotation);
		}
	}
}
