 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	#region Variables
	#region Private

	private float cameraAngle = 0f;
	private float speed = 1.5f;
	[SerializeField] private Vector3 cameraOffset = new Vector3 (0, 0, 0);

	#endregion
	#region Public

	/// <summary>
	/// Ref to the player gameobject
	/// </summary>
	public GameObject player;

	#endregion
	#endregion

	#region Built-In Methods
	void Start () {
		
	}
	
	void Update () {
		CameraPosSet();

	}	
	#endregion

	#region Class Specific

	/// <summary>
	/// Sets the position of the camera
	/// </summary>
	private void CameraPosSet(){
		Vector3 newPos;
		//transform.position = newPos = player.transform.position + cameraOffset;
		RotateView();
	}

	/// <summary>
	/// Rotates the camera when you hold Q or E
	/// </summary>
	private void RotateView(){
		
		//If holding Q or E rotate the camera based on mouse movement.

		bool EPressed = Input.GetKey (KeyCode.E);
		bool QPressed = Input.GetKey (KeyCode.Q);

		if (QPressed) {
			Rot (speed);
		}else if(EPressed) {
			Rot(-speed);
		}

		transform.LookAt (player.transform.position);

	}

	private void Rot(float speed){
		transform.RotateAround(player.transform.position, Vector3.up, speed);
	}

	#endregion
}
