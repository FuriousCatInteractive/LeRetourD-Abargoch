using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {
	public static int numberOfIA = 80;
	public Transform spawnPoint;
	public Transform mob;
	public static bool enaNewWave = true;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(enaNewWave == true) {
			for(int i = 0; i<numberOfIA; ++i) {
				Instantiate (mob, spawnPoint.position, Quaternion.identity);
			}
			enaNewWave = false;
		}
	}
}
