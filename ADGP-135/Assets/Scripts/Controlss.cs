using UnityEngine;
using System.Collections;

public class Controlss : MonoBehaviour {

	public float Velocity;
	public float AimSensitivity;

	float Pitch = 0.0f;
	//public float PitchRange;

	// Use this for initialization
	void Start () {
		Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {

		float Yaw = Input.GetAxis("Mouse X") * AimSensitivity;
		transform.Rotate(0, Yaw, 0);

		Pitch -= Input.GetAxis("Mouse Y") * AimSensitivity;
		
		Camera.main.transform.localRotation = Quaternion.Euler(Pitch, 0, 0);

		float LongitudinalSpeed = Input.GetAxis("Vertical") * Velocity;
		float LateralSpeed = Input.GetAxis("Horizontal") * Velocity;
		float VerticalSpeed = Input.GetAxis("Jump") * Velocity;

		Vector3 speed = new Vector3(LateralSpeed, VerticalSpeed, LongitudinalSpeed);
		speed = transform.rotation * speed;

		CharacterController cc = GetComponent<CharacterController>();

		cc.Move(speed);
	}
}
