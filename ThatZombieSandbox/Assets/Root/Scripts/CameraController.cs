using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	#region Variables
	#region Private



	#endregion
	#region Public



	#endregion
	#endregion

	#region Built-In Methods
	void Start () {
		
	}
	
	void Update () {
		
		RotateView();
	}	
	#endregion

	#region Class Specific

	/// <summary>
	/// Sets the position of the camera
	/// </summary>
	private void CameraPosSet(){

	}

	/// <summary>
	/// Rotates the camera when you hold RMB
	/// </summary>
	private void RotateView(){
		
		//If holding RMB rotate the camera based on mouse movement.

		if(Input.GetMouseButton(1)){

		}
	}

	#endregion
}
