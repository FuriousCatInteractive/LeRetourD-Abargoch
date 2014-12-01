using UnityEngine;
using System.Collections;



public class menuAchatPieges : MonoBehaviour {
	
	Texture2D HealButton;
	
	int nbGoldLeft = 0;
	int nbHealZone = 0;
	int nbAtkBZone =0;
	int nbDmgZone = 0;
	int nbSlowZone = 0;
	
	void Start ()
	{
		setGoldLeft (200);
	}
	
	private void setGoldLeft(int goldToAdd){
		nbGoldLeft+=goldToAdd;
	}
	
	void OnGUI ()
	{
		//title box
		GUI.Box (new Rect (Screen.width / 4, //pos largeur
		                   Screen.height / 20, //pos hauteur
		                   Screen.width / 2, //largeur
		                   Screen.height / 7), //hauteur
		         "Skills\n\n Or restant : "+nbGoldLeft);
		
		/*********************HEAL Buy************************/
		/*													  */
		/*													  */
		/******************************************************/			
	
		GUI.Box (new Rect (Screen.width / 8 + Screen.width / 30 + 340,
		                   Screen.height / 4 + Screen.height / 15 - 50, 
		                   120,
		                   100),
		         "Heal Zone \n\n" + nbHealZone);

		//Buttons
		if(nbHealZone >= 1){ 
			if(GUI.Button (new Rect (Screen.width / 8 + Screen.width / 30 +120,
			                         Screen.height / 4 + Screen.height / 15 -50, 
			                         120,
			                         100),
			               "Vendre \n\n +100G"))
			{
				nbGoldLeft+=100;
				nbHealZone--;
			}
		}
		
		if(nbGoldLeft >= 100){
			if(GUI.Button (new Rect (Screen.width / 8 + Screen.width / 30 + 560,
			                         Screen.height / 4 + Screen.height / 15 -50, 
			                         120 ,
			                         100),
			               "Acheter \n\n -100G"))
			{
				nbGoldLeft-=100;
				nbHealZone++;
			}
		}
		
		/*********************DMG Buy************************/
		/*													  */
		/*													  */
		/******************************************************/	
		
	
		
		GUI.Box (new Rect (Screen.width / 8 + Screen.width / 30 + 340,
		                   Screen.height / 4 + Screen.height / 15 + 70, 
		                   120,
		                   100),
		         "Damage Zone \n\n" +nbDmgZone);

		
		//Buttons
		if(nbDmgZone >= 1){
			if(GUI.Button (new Rect (Screen.width / 8 + Screen.width / 30 +120,
			                         Screen.height / 4 + Screen.height / 15 + 70, 
			                         120,
			                         100),
			               "Vendre \n\n +100G"))
			{
				nbGoldLeft+=100;
				nbDmgZone--;
			}
		}
		
		if(nbGoldLeft >= 100){
			if(GUI.Button (new Rect (Screen.width / 8 + Screen.width / 30 +560,
			                         Screen.height / 4 + Screen.height / 15 + 70, 
			                         120,
			                         100),
			               "Acheter \n\n -100G"))
			{
				nbGoldLeft-=100;
				nbDmgZone++;
			}
		}

		/*********************AtkBuff Tree************************/
		/*													  */
		/*													  */
		/******************************************************/	

		
		GUI.Box (new Rect (Screen.width / 8 + Screen.width / 30 + 340,
		                   Screen.height / 4 + Screen.height / 15 + 190, 
		                   120,
		                   100),
		         "Attack Buff Zone \n\n"+nbAtkBZone);
		

	
		//buttons
		if(nbAtkBZone >= 1){
			if(GUI.Button (new Rect (Screen.width / 8 + Screen.width / 30 +120,
			                         Screen.height / 4 + Screen.height / 15 + 190, 
			                         120,
			                         100),
			               "Vendre \n\n +100G"))
			{
				nbGoldLeft+=100;
				nbAtkBZone--;
			}
		}
		
		if (nbGoldLeft >= 100) {
			if(GUI.Button (new Rect (Screen.width / 8 + Screen.width / 30 + 560,
			                         Screen.height / 4 + Screen.height / 15 + 190, 
			                         120,
			                         100),
			               "Acheter \n\n -100G"))
			{
				nbGoldLeft-=100;
				nbAtkBZone++;
			}
		}
		
		/*********************Slow Tree************************/
		/*													  */
		/*													  */
		/******************************************************/	

		
		
		GUI.Box (new Rect (Screen.width / 8 + Screen.width / 30+340,
		                   Screen.height / 4 + Screen.height / 15 +310, 
		                   120,
		                   100),
		         "Slow Zone \n\n"+nbSlowZone);
		

		//buttons
		if(nbSlowZone >= 1){
			if(GUI.Button (new Rect (Screen.width / 8 + Screen.width / 30 +120,
			                         Screen.height / 4 + Screen.height / 15 +310, 
			                         120,
			                         100),
			               "Vendre \n\n +100G"))
			{
				nbGoldLeft+=100;
				nbSlowZone--;
			}
		}
		
		if(nbGoldLeft >= 100){
			if(GUI.Button (new Rect (Screen.width / 8 + Screen.width / 30+560,
			                         Screen.height / 4 + Screen.height / 15 +310, 
			                         120,
			                         100),
			               "Acheter \n\n -100G"))
			{
				nbGoldLeft-=100;
				nbSlowZone++;
			}
		}
		
		/*********************Quit Button**********************/
		/*													  */
		/*													  */
		/******************************************************/	
		if (GUI.Button (new Rect (Screen.width / 2 - Screen.width / 8,
		                          Screen.height / 2 + Screen.height / 20 + 260, 
		                          Screen.width / 4,
		                          Screen.height /20),
		                "Resume")) {
			Application.Quit ();
		}
		
		
	}//fin de OnGUI
	
}
