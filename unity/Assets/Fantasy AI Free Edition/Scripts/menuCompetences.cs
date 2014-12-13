using UnityEngine;
using System.Collections;



public class menuCompetences : MonoBehaviour {

	Texture2D HealButton;

	int nbPointLeft = 0;
	int healRank = 0;
	int atkBRank =0;
	int dmgRank = 0;
	int slowRank = 0;

	void Start ()
	{
		setPointLeft (2);
	}

	private void setPointLeft(int pointsToAdd){
		nbPointLeft += pointsToAdd;
	}

	void OnGUI ()
	{
		//title box
		GUI.Box (new Rect (Screen.width / 4, //pos largeur
		                   Screen.height / 20, //pos hauteur
		                   Screen.width / 2, //largeur
		                   Screen.height / 7), //hauteur
		         "Skills\n\n Points de competences restants : "+nbPointLeft);

		/*********************HEAL Tree************************/
		/*													  */
		/*													  */
		/******************************************************/			
		GUI.Box (new Rect (Screen.width / 8 + Screen.width / 30,
		                   Screen.height / 4 + Screen.height / 15 - 50, 
		                   120,
		                   100),
		         		   "Heal Zone");
		
		GUI.Box (new Rect (Screen.width / 8 + Screen.width / 30 + 220,
		                   Screen.height / 4 + Screen.height / 15 - 50, 
		                   120,
		                   100),
		                   "niv. 2 H");
		
		GUI.Box (new Rect (Screen.width / 8 + Screen.width / 30 + 440,
		                   Screen.height / 4 + Screen.height / 15 - 50, 
		                   120,
		                   100),
		         		   "niv. 3 H");
		
		GUI.Box (new Rect (Screen.width / 8 + Screen.width / 30 + 660, 
		                   Screen.height / 4 + Screen.height / 15 - 50, 
		                   120,
		                   100),
		                   "niv. 4 H");

		//Buttons
		if(nbPointLeft != 0 && healRank==0){ 
			if(GUI.Button (new Rect (Screen.width / 8 + Screen.width / 30,
		                          Screen.height / 4 + Screen.height / 15 -50, 
		                          120,
		                          100),
		                		  "+1"))
			{
				nbPointLeft--;
				healRank++;
			}
		}

		if(nbPointLeft != 0 && healRank==1){
			if(GUI.Button (new Rect (Screen.width / 8 + Screen.width / 30 + 220,
		                          Screen.height / 4 + Screen.height / 15 -50, 
		                          120 ,
		                          100),
			           			  "+1"))
			{
				nbPointLeft--;
				healRank++;
			}
		}

		if(nbPointLeft != 0 && healRank==2){
				if(GUI.Button (new Rect (Screen.width / 8 + Screen.width / 30 + 440,
		                          Screen.height / 4 + Screen.height / 15 -50, 
		                          120 ,
		                          100),
			            		  "+1"))
			{
				nbPointLeft--;
				healRank++;
			}
		}

		if(nbPointLeft != 0 && healRank==3){
					if(GUI.Button (new Rect (Screen.width / 8 + Screen.width / 30+ 660, 
		                          Screen.height / 4 + Screen.height / 15 -50, 
		                          120 ,
		                          100),
			            		  "+1"))
			{
				nbPointLeft--;
				healRank++;
			}
		}

		/*********************DMG Tree************************/
		/*													  */
		/*													  */
		/******************************************************/	

		GUI.Box (new Rect (Screen.width / 8 + Screen.width / 30,
		                          Screen.height / 4 + Screen.height / 15 + 70, 
		                          120,
		                          100),
		                "Damage Zone");
		
		GUI.Box (new Rect (Screen.width / 8 + Screen.width / 30 + 220,
		                          Screen.height / 4 + Screen.height / 15 + 70, 
		                          120,
		                          100),
		                "niv. 2 Dmg");
		
		GUI.Box (new Rect (Screen.width / 8 + Screen.width / 30 +440,
		                          Screen.height / 4 + Screen.height / 15 + 70, 
		                          120,
		                          100),
		                "niv. 3 Dmg");
		
		GUI.Box (new Rect (Screen.width / 8 + Screen.width / 30 +660,
		                          Screen.height / 4 + Screen.height / 15 + 70, 
		                          120,
		                          100),
		                "niv. 4 Dmg");

		//Buttons
		if(nbPointLeft != 0 && dmgRank==0){
			if(GUI.Button (new Rect (Screen.width / 8 + Screen.width / 30,
		                          Screen.height / 4 + Screen.height / 15 + 70, 
		                          120,
		                          100),
			            		  "+1"))
			{
				nbPointLeft--;
				dmgRank++;
			}
		}
		
		if(nbPointLeft != 0 && dmgRank==1){
			if(GUI.Button (new Rect (Screen.width / 8 + Screen.width / 30 + 220,
		                          Screen.height / 4 + Screen.height / 15 + 70, 
		                          120,
		                          100),
			           			  "+1"))
			{
				nbPointLeft--;
				dmgRank++;
			}
		}
		
		if(nbPointLeft != 0 && dmgRank==2){
			if(GUI.Button (new Rect (Screen.width / 8 + Screen.width / 30 +440,
		                          Screen.height / 4 + Screen.height / 15 + 70, 
		                          120,
		                          100),
			           			  "+1"))
			{
				nbPointLeft--;
				dmgRank++;
			}
		}
		
		if(nbPointLeft != 0 && dmgRank==3){
			if(GUI.Button (new Rect (Screen.width / 8 + Screen.width / 30 +660,
		                          Screen.height / 4 + Screen.height / 15 + 70, 
		                          120,
		                          100),
			            		  "+1"))
			{
				nbPointLeft--;
				dmgRank++;
			}
		}

		/*********************AtkBuff Tree************************/
		/*													  */
		/*													  */
		/******************************************************/	
		GUI.Box (new Rect (Screen.width / 8 + Screen.width / 30,
		                          Screen.height / 4 + Screen.height / 15 + 190, 
		                          120,
		                          100),
		         "Attack Buff Zone");

		GUI.Box (new Rect (Screen.width / 8 + Screen.width / 30 + 220,
		                          Screen.height / 4 + Screen.height / 15 + 190, 
		                          120,
		                          100),
		            "niv. 2 AtkB");
				
		GUI.Box (new Rect (Screen.width / 8 + Screen.width / 30 + 440,
		                          Screen.height / 4 + Screen.height / 15 + 190, 
		                          120,
		                          100),
		         "niv. 3 AtkB");
		
		GUI.Box (new Rect (Screen.width / 8 + Screen.width / 30 + 660,
		                          Screen.height / 4 + Screen.height / 15 + 190, 
		                          120,
		                          100),
		         "niv. 4 AtkB");

		//buttons
		if(nbPointLeft != 0 && atkBRank==0){
			if(GUI.Button (new Rect (Screen.width / 8 + Screen.width / 30,
		                          Screen.height / 4 + Screen.height / 15 + 190, 
		                          120,
		                          100),
		            			  "+1"))
			{
				nbPointLeft--;
				atkBRank++;
			}
		}

		if (nbPointLeft != 0 && atkBRank == 1) {
											if(GUI.Button (new Rect (Screen.width / 8 + Screen.width / 30 + 220,
		                          Screen.height / 4 + Screen.height / 15 + 190, 
		                          120,
		                          100),
			 		              "+1"))
			{
				nbPointLeft--;
				atkBRank++;
			}
		}

		if (nbPointLeft != 0 && atkBRank == 2) {
												if(GUI.Button (new Rect (Screen.width / 8 + Screen.width / 30 + 440,
		                          Screen.height / 4 + Screen.height / 15 + 190, 
		                          120,
		                          100),
			            		  "+1"))
			{
				nbPointLeft--;
				atkBRank++;
			}
		}

		if(nbPointLeft != 0 && atkBRank==3){
													if(GUI.Button (new Rect (Screen.width / 8 + Screen.width / 30+660,
		                          Screen.height / 4 + Screen.height / 15 + 190, 
		                          120,
		                          100),
			            		  "+1"))
			{
				nbPointLeft--;
				atkBRank++;
			}
		}

		/*********************Slow Tree************************/
		/*													  */
		/*													  */
		/******************************************************/	
		GUI.Box(new Rect (Screen.width / 8 + Screen.width / 30,
		                          Screen.height / 4 + Screen.height / 15 +310, 
		                          120,
		                          100),
		                "Slow Zone");

		
		GUI.Box (new Rect (Screen.width / 8 + Screen.width / 30+220,
		                          Screen.height / 4 + Screen.height / 15 +310, 
		                          120,
		                          100),
		                "niv. 2 Slow");

		
		GUI.Box (new Rect (Screen.width / 8 + Screen.width / 30+440,
		                          Screen.height / 4 + Screen.height / 15 +310, 
		                          120,
		                          100),
		                "niv. 3 Slow");

		
		GUI.Box (new Rect (Screen.width / 8 + Screen.width / 30+660,
		                          Screen.height / 4 + Screen.height / 15 +310, 
		                          120,
		                          100),
		                "niv. 4 Slow");

		//buttons
		if(nbPointLeft != 0 && slowRank==0){
			if(GUI.Button (new Rect (Screen.width / 8 + Screen.width / 30,
		                          Screen.height / 4 + Screen.height / 15 +310, 
		                          120,
		                          100),
			           			  "+1"))
			{
				nbPointLeft--;
				slowRank++;
			}
		}
		
		if(nbPointLeft != 0 && slowRank==1){
			if(GUI.Button (new Rect (Screen.width / 8 + Screen.width / 30+220,
		                          Screen.height / 4 + Screen.height / 15 +310, 
		                          120,
		                          100),
			        		      "+1"))
			{
				nbPointLeft--;
				slowRank++;
			}
		}

		if(nbPointLeft != 0 && slowRank==2){
			if(GUI.Button (new Rect (Screen.width / 8 + Screen.width / 30+440,
		                          Screen.height / 4 + Screen.height / 15 +310, 
		                          120,
		                          100),
			         		      "+1"))
			{
				nbPointLeft--;
				slowRank++;
			}
		}
		
		if(nbPointLeft != 0 && slowRank==3){		
			if(GUI.Button (new Rect (Screen.width / 8 + Screen.width / 30+660,
		                          Screen.height / 4 + Screen.height / 15 +310, 
		                          120,
		                          100),
			        		      "+1"))
			{
				nbPointLeft--;
				slowRank++;
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
			Application.LoadLevel (1);
		}


	}//fin de OnGUI

}
