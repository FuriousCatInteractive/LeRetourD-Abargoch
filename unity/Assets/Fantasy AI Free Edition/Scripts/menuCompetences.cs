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
		int largeur = Screen.width/12;
		int hauteur = Screen.height/8;
		int ecartX = Screen.width/ 16;
		int ecartY = Screen.height/20;
		int offsetX = Screen.width/4;
		int offsetY = Screen.height / 8 + 2*ecartY;
		//title box
		GUI.Box (new Rect (Screen.width / 4, //pos largeur
		                   Screen.height / 20, //pos hauteur
		                   Screen.width / 2, //largeur
		                   Screen.height / 8), //hauteur
		         "Skills\n\n Points de competences restants : "+nbPointLeft);
		
		/*********************HEAL Tree************************/
		/*													  */
		/*													  */
		/******************************************************/			
		GUI.Box (new Rect (offsetX + 0*(largeur+ecartX),
		                   offsetY + 0*(hauteur+ecartY), 
		                   largeur,
		                   hauteur),
		         "Heal Zone");
		
		GUI.Box (new Rect (offsetX + 1*(largeur+ecartX),
		                   offsetY + 0*(hauteur+ecartY), 
		                   largeur,
		                   hauteur),
		         "niv. 2 H");
		
		GUI.Box (new Rect (offsetX + 2*(largeur+ecartX),
		                   offsetY + 0*(hauteur+ecartY), 
		                   largeur,
		                   hauteur),
		         "niv. 3 H");
		
		GUI.Box (new Rect (offsetX + 3*(largeur+ecartX), 
		                   offsetY + 0*(hauteur+ecartY), 
		                   largeur,
		                   hauteur),
		         "niv. 4 H");
		
		//Buttons
		if(nbPointLeft != 0 && healRank==0){ 
			if(GUI.Button (new Rect (offsetX + 0*(largeur+ecartX),
			                         offsetY + 0*(hauteur+ecartY), 
			                         largeur,
			                         hauteur),
			               "+1"))
			{
				nbPointLeft--;
				healRank++;
			}
		}
		
		if(nbPointLeft != 0 && healRank==1){
			if(GUI.Button (new Rect (offsetX + 1*(largeur+ecartX),
			                         offsetY + 0*(hauteur+ecartY), 
			                         largeur ,
			                         hauteur),
			               "+1"))
			{
				nbPointLeft--;
				healRank++;
			}
		}
		
		if(nbPointLeft != 0 && healRank==2){
			if(GUI.Button (new Rect (offsetX + 2*(largeur+ecartX),
			                         offsetY + 0*(hauteur+ecartY), 
			                         largeur ,
			                         hauteur),
			               "+1"))
			{
				nbPointLeft--;
				healRank++;
			}
		}
		
		if(nbPointLeft != 0 && healRank==3){
			if(GUI.Button (new Rect (offsetX + 3*(largeur+ecartX), 
			                         offsetY + 0*(hauteur+ecartY), 
			                         largeur ,
			                         hauteur),
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
		
		GUI.Box (new Rect (offsetX + 0*(largeur+ecartX),
		                   offsetY + 1*(hauteur+ecartY), 
		                   largeur,
		                   hauteur),
		         "Damage Zone");
		
		GUI.Box (new Rect (offsetX + 1*(largeur+ecartX),
		                   offsetY + 1*(hauteur+ecartY), 
		                   largeur,
		                   hauteur),
		         "niv. 2 Dmg");
		
		GUI.Box (new Rect (offsetX + 2*(largeur+ecartX),
		                   offsetY + 1*(hauteur+ecartY), 
		                   largeur,
		                   hauteur),
		         "niv. 3 Dmg");
		
		GUI.Box (new Rect (offsetX + 3*(largeur+ecartX),
		                   offsetY + 1*(hauteur+ecartY), 
		                   largeur,
		                   hauteur),
		         "niv. 4 Dmg");
		
		//Buttons
		if(nbPointLeft != 0 && dmgRank==0){
			if(GUI.Button (new Rect (offsetX + 0*(largeur+ecartX),
			                         offsetY + 1*(hauteur+ecartY), 
			                         largeur,
			                         hauteur),
			               "+1"))
			{
				nbPointLeft--;
				dmgRank++;
			}
		}
		
		if(nbPointLeft != 0 && dmgRank==1){
			if(GUI.Button (new Rect (offsetX + 1*(largeur+ecartX),
			                         offsetY + 1*(hauteur+ecartY), 
			                         largeur,
			                         hauteur),
			               "+1"))
			{
				nbPointLeft--;
				dmgRank++;
			}
		}
		
		if(nbPointLeft != 0 && dmgRank==2){
			if(GUI.Button (new Rect (offsetX + 2*(largeur+ecartX),
			                         offsetY + 1*(hauteur+ecartY), 
			                         largeur,
			                         hauteur),
			               "+1"))
			{
				nbPointLeft--;
				dmgRank++;
			}
		}
		
		if(nbPointLeft != 0 && dmgRank==3){
			if(GUI.Button (new Rect (offsetX + 3*(largeur+ecartX),
			                         offsetY + 1*(hauteur+ecartY), 
			                         largeur,
			                         hauteur),
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
		GUI.Box (new Rect (offsetX + 0*(largeur+ecartX),
		                   offsetY + 2*(hauteur+ecartY), 
		                   largeur,
		                   hauteur),
		         "Attack Buff Zone");
		
		GUI.Box (new Rect (offsetX + 1*(largeur+ecartX),
		                   offsetY + 2*(hauteur+ecartY), 
		                   largeur,
		                   hauteur),
		         "niv. 2 AtkB");
		
		GUI.Box (new Rect (offsetX + 2*(largeur+ecartX),
		                   offsetY + 2*(hauteur+ecartY), 
		                   largeur,
		                   hauteur),
		         "niv. 3 AtkB");
		
		GUI.Box (new Rect (offsetX + 3*(largeur+ecartX),
		                   offsetY + 2*(hauteur+ecartY), 
		                   largeur,
		                   hauteur),
		         "niv. 4 AtkB");
		
		//buttons
		if(nbPointLeft != 0 && atkBRank==0){
			if(GUI.Button (new Rect(offsetX + 0*(largeur+ecartX),
			                        offsetY + 2*(hauteur+ecartY), 
			                        largeur,
			                        hauteur),
			               "+1"))
			{
				nbPointLeft--;
				atkBRank++;
			}
		}
		
		if (nbPointLeft != 0 && atkBRank == 1) {
			if(GUI.Button (new Rect (offsetX + 1*(largeur+ecartX),
			                         offsetY + 2*(hauteur+ecartY), 
			                         largeur,
			                         hauteur),
			               "+1"))
			{
				nbPointLeft--;
				atkBRank++;
			}
		}
		
		if (nbPointLeft != 0 && atkBRank == 2) {
			if(GUI.Button (new Rect (offsetX + 2*(largeur+ecartX),
			                         offsetY + 2*(hauteur+ecartY), 
			                         largeur,
			                         hauteur),
			               "+1"))
			{
				nbPointLeft--;
				atkBRank++;
			}
		}
		
		if(nbPointLeft != 0 && atkBRank==3){
			if(GUI.Button (new Rect (offsetX + 3*(largeur+ecartX),
			                         offsetY + 2*(hauteur+ecartY), 
			                         largeur,
			                         hauteur),
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
		GUI.Box(new Rect (offsetX + 0*(largeur+ecartX),
		                  offsetY + 3*(hauteur+ecartY), 
		                  largeur,
		                  hauteur),
		        "Slow Zone");
		
		
		GUI.Box (new Rect (offsetX + 1*(largeur+ecartX),
		                   offsetY + 3*(hauteur+ecartY), 
		                   largeur,
		                   hauteur),
		         "niv. 2 Slow");
		
		
		GUI.Box (new Rect (offsetX + 2*(largeur+ecartX),
		                   offsetY + 3*(hauteur+ecartY), 
		                   largeur,
		                   hauteur),
		         "niv. 3 Slow");
		
		
		GUI.Box (new Rect (offsetX + 3*(largeur+ecartX),
		                   offsetY + 3*(hauteur+ecartY), 
		                   largeur,
		                   hauteur),
		         "niv. 4 Slow");
		
		//buttons
		if(nbPointLeft != 0 && slowRank==0){
			if(GUI.Button (new Rect (offsetX + 0*(largeur+ecartX),
			                         offsetY + 3*(hauteur+ecartY), 
			                         largeur,
			                         hauteur),
			               "+1"))
			{
				nbPointLeft--;
				slowRank++;
			}
		}
		
		if(nbPointLeft != 0 && slowRank==1){
			if(GUI.Button (new Rect (offsetX + 1*(largeur+ecartX),
			                         offsetY + 3*(hauteur+ecartY), 
			                         largeur,
			                         hauteur),
			               "+1"))
			{
				nbPointLeft--;
				slowRank++;
			}
		}
		
		if(nbPointLeft != 0 && slowRank==2){
			if(GUI.Button (new Rect (offsetX + 2*(largeur+ecartX),
			                         offsetY + 3*(hauteur+ecartY), 
			                         largeur,
			                         hauteur),
			               "+1"))
			{
				nbPointLeft--;
				slowRank++;
			}
		}
		
		if(nbPointLeft != 0 && slowRank==3){		
			if(GUI.Button (new Rect (offsetX + 3*(largeur+ecartX),
			                         offsetY + 3*(hauteur+ecartY), 
			                         largeur,
			                         hauteur),
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
		                          Screen.height - Screen.height / 20-20, 
		                          Screen.width / 4,
		                          Screen.height /20),
		                "Resume")) {
			Application.LoadLevel (1);
		}
		
		
	}//fin de OnGUI
	
}
