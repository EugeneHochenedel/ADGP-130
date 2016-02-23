using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

	public GameObject Attack_Prefab;
	public GameObject Alt_Prefab;
	public float BulletVelocity;

	//Used for controling the rate at which the player launches projectiles
	public float bulletRate;
	private float nextBullet = 0.0F;
	public float missileRate;
	private float nextMissile = 0.0F;

	//Function for primary attack
	void FireFirst()
	{

		GameObject userProjectile = (GameObject)Instantiate(Attack_Prefab, Camera.main.transform.position + Camera.main.transform.forward, transform.rotation);

		userProjectile.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * BulletVelocity, ForceMode.Force);

		Destroy(userProjectile, 4.0f);
	}

	void FireSecond()
	{

		GameObject userMissile = (GameObject)Instantiate(Alt_Prefab, Camera.main.transform.position + Camera.main.transform.forward, Camera.main.transform.rotation);
		userMissile.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * BulletVelocity, ForceMode.Force);
		Destroy(userMissile, 5.0f);
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Fire1") && Time.time > nextBullet)
		{
			//Limits how often the FireFirst function is called while "Fire1" is held.
			nextBullet = Time.time + bulletRate;
			FireFirst();
		}

		if(Input.GetButton("Fire2") && Time.time > nextMissile)
		{
			nextMissile = Time.time + missileRate;
			FireSecond();
		}
	}
}