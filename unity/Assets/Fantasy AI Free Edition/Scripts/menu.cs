using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour
{
	
		void OnGUI ()
		{
				// Make a background box
				GUI.Box (new Rect (Screen.width / 2 - Screen.width / 6,
				 Screen.height / 2 - Screen.height / 8, 
				 Screen.width / 3,
				  Screen.height / 2), 
				  "Loader Menu");
		
				// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
				if (GUI.Button (new Rect (Screen.width / 2 - Screen.width / 8,
		                          Screen.height / 2 - Screen.height / 20 + 20, 
		                          Screen.width / 4,
		                          Screen.height / 10),
		                           "Play")) {
						Application.LoadLevel (1);
				}
		
				// Make the second button.
				if (GUI.Button (new Rect (Screen.width / 2 - Screen.width / 8,
		                          Screen.height / 2 + Screen.height / 20 + 3 * 20, 
		                          Screen.width / 4,
		                          Screen.height / 10),
		                           "Quit")) {
						Application.Quit ();
				}
				
				GUI.Box (new Rect (Screen.width / 2 - Screen.width / 4,
		                   Screen.height / 20, 
		                   Screen.width / 2,
		                   Screen.height / 7),
		                    "Le Retour d'Abaroch");
		}
}
