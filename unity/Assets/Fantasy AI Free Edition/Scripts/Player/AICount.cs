using UnityEngine;
using System.Collections;

public class AICount : MonoBehaviour
{
		// Use this for initialization
		void Start ()
		{
			PlayerController.TotalAICount = PlayerController.TotalAICount + 1;				
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
}
