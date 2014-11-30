using System.Linq;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class MenuPause : MonoBehaviour
{

	#region Attributs

		private bool isPaused = false; // Permet de savoir si le jeu est en pause ou non.

	#endregion
	
	#region Proprietes
	#endregion
	
	#region Constructeur
	#endregion
	
	#region Methodes
	
		void Start ()
		{
	
		}
	
	
		void Update ()
		{
				// Si le joueur appuis sur Echap alors la valeur de isPaused devient le contraire.
				if (Input.GetKeyDown (KeyCode.Escape))
						isPaused = !isPaused;


				if (isPaused)
						Time.timeScale = 0f; // Le temps s'arrete
		
		else
						Time.timeScale = 1.0f; // Le temps reprend


		}

		void OnGUI ()
		{
				if (isPaused) {
		
						// Si le bouton est présser alors isPaused devient faux donc le jeu reprend.
						if (GUI.Button (new Rect (Screen.width / 2 - 40, Screen.height / 2 - 20, 80, 40), "Continuer")) {
								isPaused = false;
						}

						// Si le bouton est présser alors on ferme completement le jeu ou charge la scene "Menu Principal
						// Dans le cas du bouton quitter il faut augmenter sa postion Y pour qu'il soit plus bas
						if (GUI.Button (new Rect (Screen.width / 2 - 40, Screen.height / 2 + 40, 80, 40), "Quitter")) {
								// Application.Quit(); 
								Application.LoadLevel (0); 

						}

				}
		}
	
	#endregion
}
