using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GoalController : MonoBehaviour {

	public Text text;
	public int gameScore;
	public GameObject points;
	public DragAndMove player;
	
	public int  numOfpoints;

	// Use this for initialization
	void Start () {
		gameScore = 0;
		player = (DragAndMove) FindObjectOfType(typeof(DragAndMove));
		numOfpoints = points.transform.childCount;
	}
	
	void LateUpdate () {
		bool finish = false;
		if (gameScore == numOfpoints) {
			text.text = "You win!\n\nPress enter to restart";
			finish = true;
		} else if (!player.trapped) {
			text.text = "Score: " + gameScore.ToString();
		} else {
			player.trapped=false;
			player.transform.position = new Vector3 (0,0.800000012f,-40) ;
			//player.transform.rotation = new Vector3 (0,0,0);
		

			
			text.text = " u need start from here";
			//text.text = "You loose!\n\nPress enter to restart";
			//finish = true;
		}
		if (finish && Input.GetKeyDown (KeyCode.Return)) {
			Application.LoadLevel(0);
		}
	}
}
