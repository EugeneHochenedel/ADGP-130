using UnityEngine;
using System.Collections;

public class DestroyEnemy : MonoBehaviour {

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Enemy")
		{
			Destroy(col.gameObject);
			Destroy(gameObject);
		}
		else if(col.gameObject.tag == "Walls")
		{
			Destroy(gameObject);
		}
	}
}
