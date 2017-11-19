using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

	#region Variables
	#region Private
	[SerializeField] private float playerSpeed = 0.2f;
	[SerializeField] private float playerVelInc = 0.05f;
	[SerializeField] private float playerVelDec = 0.05f;

	#endregion
	#region Public

	public Vector3 playerVelocity = new Vector3(0,0,0);
	public GameObject player;

	#endregion
	#endregion

	#region Built-In Methods
	void Start () {
		player = gameObject;

	}

	void Update () {
		Movement ();
		UpdatePosition ();
	}	
	#endregion

	#region Class Specific

	private void UpdatePosition(){
		
		player.transform.Translate (playerVelocity);

	}

	private void Movement(){
		Vector3 upwards = Camera.main.transform.forward * playerSpeed * playerVelInc;
		Vector3 right = Camera.main.transform.right * playerSpeed * playerVelInc;
		float temp;
		upwards.y = temp = 0f;
		right.y = temp;


		if (Input.GetKey (KeyCode.W)) {
			playerVelocity = playerVelocity + upwards;
		}

		if (Input.GetKey (KeyCode.S)) {
			playerVelocity = playerVelocity - upwards;
		}

		if (Input.GetKey (KeyCode.A)) {
			playerVelocity = playerVelocity - right;
		}

		if (Input.GetKey (KeyCode.D)) {
			playerVelocity = playerVelocity + right;
		}


		//passivly decrease speed
		float px = playerVelocity.x; //player x
		float py = playerVelocity.y; //player y
		float pz = playerVelocity.z; //player z

		px = Mathf.Lerp (px, 0, playerVelDec);
		py = Mathf.Lerp (py, 0, playerVelDec);
		pz = Mathf.Lerp (pz, 0, playerVelDec);

		playerVelocity = new Vector3 (px, py, pz);


	}

	#endregion
}
