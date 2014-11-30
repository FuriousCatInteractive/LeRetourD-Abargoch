using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {
	public int numberOfIA;
	public Transform spawnPoint;
	public Transform mob;

	// Use this for initialization
	void Start () {
		for(int i = 0; i<numberOfIA; ++i) {
			Instantiate (mob, spawnPoint.position, Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
}
