using UnityEngine;
using System.Collections;

public class triger_box_goal : MonoBehaviour {

	public Transform Player;
	public int vieTour;

	// Use this for initialization
	void Start () {
		vieTour = 10;
		//
	}
	
	// Update is called once per frame
	void Update () {
		//GUI.Button(new Rect(0, 90, 300, 26), "vie tour : "+vieTour);
	}

	void OnTriggerEnter ( Collider other ) {
		Debug.Log ("collision");
				//if (other.tag == "mob") {	
				//}
		PlayerController.vieTour--;
		}

	void OnTriggerExit( Collider other ) {
		Debug.Log ("a pu collision");
	}
}
