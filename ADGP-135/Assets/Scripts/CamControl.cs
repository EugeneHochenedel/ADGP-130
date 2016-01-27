using UnityEngine;
using System.Collections;

public class CamControl : MonoBehaviour {

	public float rotateSpeed = 5;
	
	void Start()
	{
		
	}

	void LateUpdate()
	{
		float Yaw = Input.GetAxis("Mouse X") * rotateSpeed;
		transform.Rotate(0, Yaw, 0);

		float Pitch = Input.GetAxis("Mouse Y") * rotateSpeed;
		transform.Rotate(Pitch, 0, 0);

		float desiredYaw = transform.eulerAngles.y;
		Quaternion rotation = Quaternion.Euler(0, desiredYaw, 0);
		//transform.position = rotation;

		float desiredPitch = transform.eulerAngles.x;
		Quaternion rotation2 = Quaternion.Euler(desiredPitch, 0, 0);
		//transform.position = rotation2;

		//transform.LookAt(transform);
	}
}