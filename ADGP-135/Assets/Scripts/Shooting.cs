using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

	public GameObject Attack_Prefab;
	public float BulletVelocity;

	public float bulletRate;
	private float nextBullet = 0.0F;


	void FireFirst()
	{
		
		GameObject UserProjectile = Instantiate(Attack_Prefab);
		UserProjectile.transform.position = gameObject.transform.position + new Vector3(0, 0.55f, 2);
		//UserProjectile.transform.rotation = Camera.main.transform.rotation;

		Rigidbody ShotBody;
		ShotBody = UserProjectile.GetComponent<Rigidbody>();
		ShotBody.transform.position = Camera.main.transform.position;
		ShotBody.AddForce(gameObject.transform.forward * BulletVelocity, ForceMode.Force);

	}

	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Fire1") && Time.time > nextBullet)
		{
			nextBullet = Time.time + bulletRate;
			FireFirst();
		}
	}
}