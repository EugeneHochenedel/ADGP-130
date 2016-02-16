using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

	public GameObject Attack_Prefab;
	public GameObject Alt_Prefab;
	public float BulletVelocity;

	//Used for controling the rate at which the player launches projectiles
	public float bulletRate;
	private float nextBullet = 0.0F;

	//Function for primary attack
	void FireFirst()
	{
		
		GameObject UserProjectile = Instantiate(Attack_Prefab);
		UserProjectile.transform.position = gameObject.transform.position + new Vector3(0, 0.55f, 2);
		UserProjectile.transform.rotation = Camera.main.transform.rotation;

		Rigidbody ShotBody;
		ShotBody = UserProjectile.GetComponent<Rigidbody>();
		ShotBody.transform.position = Camera.main.transform.position;
		ShotBody.AddForce(gameObject.transform.forward * BulletVelocity, ForceMode.Force);

	}

	void FireSecond()
	{
		GameObject UserMissile = Instantiate(Alt_Prefab);
		UserMissile.transform.position = gameObject.transform.position + new Vector3(0, 0.55f, 3);
		//UserMissile.transform.rotation = Camera.main.transform.rotation;
		UserMissile.transform.localRotation = Quaternion.Euler(90, 0, 0);

		Rigidbody MissileBody;
		MissileBody = UserMissile.GetComponent<Rigidbody>();
		MissileBody.transform.position = Camera.main.transform.position;
		//MissileBody.transform.rotation = Quaternion.Euler(90, Camera.main.transform.rotation.y, Camera.main.transform.rotation.z);
		MissileBody.AddForce(gameObject.transform.forward * BulletVelocity, ForceMode.Force);
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Fire1") && Time.time > nextBullet)
		{
			//Limits how often the FireFirst function is called while "Fire1" is held.
			nextBullet = Time.time + bulletRate;
			FireFirst();
		}

		if(Input.GetButtonDown("Fire2") && Time.time > nextBullet)
		{
			nextBullet = Time.time + bulletRate;
			FireSecond();
		}
	}
}