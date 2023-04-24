using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
    public GameObject g;
	public GameObject player;
	public static int gameScore;
	public float speed;
	public float h = 2;
	public float camera_distance=5;

	// private float radioOffset, fullOffset, sideAngle, verticalAngle,
	// 	          startingSideAngle, startingMouseX,
	//               startingVerticalAngle, startingMouseY;
	private bool movingCamera;

	void Start () {
		// Vector3 offset = transform.position - player.transform.position;
		// // radioOffset = Mathf.Sqrt(offset.x * offset.x + offset.z * offset.z);
		// // fullOffset = Mathf.Sqrt (radioOffset * radioOffset + offset.y * offset.y);
		// // sideAngle = Mathf.PI;
		// // verticalAngle = Mathf.Asin(offset.y / fullOffset);
		// gameScore = 0;
		// movingCamera = false;
	}

	// void Update () {
	// 	if (Input.GetMouseButtonDown(1)) {
	// 		movingCamera = true;
	// 		// startingSideAngle = sideAngle;
	// 		// startingVerticalAngle = verticalAngle;
	// 		// startingMouseX = Input.mousePosition.x;
	// 		// startingMouseY = Input.mousePosition.y;
	// 	}
	// 	if (movingCamera) {
	// 		sideAngle = startingSideAngle + (Input.mousePosition.x - startingMouseX) * speed;
	// 		verticalAngle = startingVerticalAngle - (Input.mousePosition.y - startingMouseY) * speed / 2;
	// 	}
	// 	if (movingCamera && Input.GetMouseButtonUp(1)) {
	// 		movingCamera = false;
	// 	}
	// }

	void LateUpdate () {
		var v3T = player.transform.position - g.transform.position ;
		
		
           transform.position = player.transform.position + v3T.normalized  * camera_distance;;
		   transform.position= new Vector3(transform.position.x,transform.position.y+1.5f,transform.position.z);
		 
			
		transform.LookAt(player.transform.position);
	  
		
	}
}
