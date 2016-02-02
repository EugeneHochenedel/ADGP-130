using UnityEngine;
using System.Collections;

public class Controlss : MonoBehaviour {

	//public static CursorLockMode lockstate;
	public float Velocity;
	public float AimSensitivity;

	//float Yaw = 0.0f;
	float Roll = 0.0f;
	//public float PitchRange = 360.0f;

	// Use this for initialization
	void Start () {
		//Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}

	// Update is called once per frame
	void Update() {
		
		Roll = Input.GetAxis("Diagonal") * AimSensitivity / 2;
		Camera.main.transform.Rotate(0, 0, Roll);

		float Pitch = -Input.GetAxis("Mouse Y") * AimSensitivity;
		transform.Rotate(Pitch, 0, Roll);

		float Yaw = Input.GetAxis("Mouse X") * AimSensitivity;
		transform.Rotate(0, Yaw, Roll);

		float LongitudinalSpeed = Input.GetAxis("Vertical") * Velocity;
		float LateralSpeed = Input.GetAxis("Horizontal") * Velocity;
		float VerticalSpeed = Input.GetAxis("Jump") * Velocity;

		
		Vector3 speed = new Vector3(LateralSpeed, VerticalSpeed, LongitudinalSpeed);
		speed = transform.localRotation * speed;

		CharacterController cc = GetComponent<CharacterController>();
		cc.Move(speed);

		if(Camera.main.transform.localRotation.y >= 180/* && Camera.main.transform.localRotation.z == 180*/)
		{
			Vector3 changed = speed;
			changed = transform.localRotation * speed * -1;
			cc.Move(changed);
		}

	}
}