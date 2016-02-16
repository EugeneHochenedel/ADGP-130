using UnityEngine;
using System.Collections;

public class Controlss : MonoBehaviour {

	//public GameObject Attack_Prefab;

	//Used for the movement speed of the player
	public float Velocity;

	//Used for the movement speed of the camera
	public float AimSensitivity;

	// Use this for initialization
	void Start () {
		//Hides the cursor and locks it to the screen while the game is being played.
		Cursor.lockState = CursorLockMode.Locked;
	}

	// Update is called once per frame
	void Update() {
		
		//Allows the user to rotate the Player gameObject about the Z-Axis using 'Q' & 'E'
		//The Diagonal was added to the Input Manager in the Project Settings, to allow for the shift along the Z-Axis
		float Roll = Input.GetAxis("Diagonal") * AimSensitivity / 2;
		Camera.main.transform.localRotation = Quaternion.Euler(Roll, 0, 0);

		//Allows the user to rotate the Player gameObject around the X-Axis by moving the mouse/cursor along the Y-Axis
		float Pitch = -Input.GetAxis("Mouse Y") * AimSensitivity;
		transform.Rotate(Pitch, 0, Roll); //Returns rotation along the Y-Axis and compensates for rotation on the Z-Axis

		//Allows the user to rotate the Player gameObject around the Y-Axis by moving the mouse/cursor along the X-Axis
		float Yaw = Input.GetAxis("Mouse X") * AimSensitivity;
		transform.Rotate(0, Yaw, Roll);

		//All movement seems to be relative to the rotation of the Player gameObject
		//Allows for movement of the Player gameObject using 'W' & 'S' or the 'up' and 'down' arrowkeys
		float LongitudinalSpeed = Input.GetAxis("Vertical") * Velocity;
		//Allows for movement of the Player gameObject using 'A' & 'D' or the 'left' & 'right' arrowkeys
		float LateralSpeed = Input.GetAxis("Horizontal") * Velocity;
		//Allows for movement of the Player gameObject using 'left shift' & 'space'
		float VerticalSpeed = Input.GetAxis("Jump") * Velocity;

		
		Vector3 speed = new Vector3(LateralSpeed, VerticalSpeed, LongitudinalSpeed);
		speed = transform.localRotation * speed;

		CharacterController playerMotion = GetComponent<CharacterController>();
		playerMotion.Move(speed);
	}
}