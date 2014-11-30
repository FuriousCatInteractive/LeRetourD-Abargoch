using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
		public float movespeed = 4;
		public float DefaultDamage = 60;
		public float Damage = 60;
		public bool atkBuff = false;
		public Transform Cam;
		public float CamHeight = 10;
		public float CamHeightPushback = 5;
		public AnimationClip Run;
		public AnimationClip Idle;
		public AnimationClip Attack;
		public AnimationClip die;
		public float AttackSpeed = 0.7f;
		public double buffTime = 10;
		private bool kill;
		public bool dead;
		private bool playd;
		private float atime;
		private bool dealdamage;
		static public int TotalAICount = 80;
		static public int vieTour;
		public bool YouWon;
		private bool w;
		private double buffDelta;
		private bool lockTime = false;
		static public bool enaUsePower = true;
	
		public Vector3 For;
		public List<Transform> KillList;
		public int directionPlayer;

		public GUIStyle barre_comp;
		public GUIStyle heal_zone;
		public GUIStyle dmg_zone;
		public GUIStyle buffatk_zone;
		public GUIStyle slow_zone;

		public Transform healZonePrefab;
		public Transform dmgZonePrefab;
		public Transform buffatkZonePrefab;
		public Transform slowZonePrefab;
	
		// Use this for initialization
		void Start ()
		{
				if (Cam)
						Cam.parent = null;
		
				w = true;
				playd = true;
				vieTour = 10;
				directionPlayer = -90;
				buffDelta = Time.time;
	
		}
	
		// Update is called once per frame
		void Update ()
		{

				//
				if (lockTime == false && atkBuff == true) {
						lockTime = true;
						buffDelta = Time.time;
				}
				
				if (atkBuff == false) {
						Damage = DefaultDamage;
				} else if (Time.time - buffDelta > buffTime && atkBuff == true) {
						atkBuff = false;
						lockTime = false;
				}

				

				//Victory
				if (w) {
						if (TotalAICount <= 0) {
								YouWon = true;
								w = false;
						}
				}
		
		
				Health php = (Health)GetComponent ("Health");
				if (php) {
						if (php.CurrentHealth <= 0)
								dead = true;
				}
		
				//DEATH
				if (dead) {
						if (playd) {
								animation.CrossFade (die.name, 0.15f);	
						}
						playd = false;
			
				} else {
		
						For.y = 270;
						//CAMERA POSITION
						Vector3 ch = transform.position;
						ch.y = transform.position.y + CamHeight;
						ch.x = transform.position.x + CamHeightPushback;
		
						Cam.transform.position = ch;
						if (Input.GetKeyUp (KeyCode.Space)) {
								dealdamage = true;
								kill = true;	
						}
						
						if (enaUsePower) {
								//Utilisation competences
								if (Input.GetKeyUp (KeyCode.Z)) {
										Vector3 posZone = GetPosZone ();
										Transform healZone = (Transform)Instantiate (healZonePrefab, posZone, Quaternion.identity);
								}

								if (Input.GetKeyUp (KeyCode.X)) {
										Vector3 posZone = GetPosZone ();
										Transform healZone = (Transform)Instantiate (dmgZonePrefab, posZone, Quaternion.identity);
								}

								if (Input.GetKeyUp (KeyCode.C)) {
										Vector3 posZone = GetPosZone ();
										Transform healZone = (Transform)Instantiate (buffatkZonePrefab, posZone, Quaternion.identity);
								}

								if (Input.GetKeyUp (KeyCode.V)) {
										Vector3 posZone = GetPosZone ();
										Transform healZone = (Transform)Instantiate (slowZonePrefab, posZone, Quaternion.identity);
								}
						}

					
		
						//LETS DO SOME KILLIN!
						if (kill) {
								atime += Time.deltaTime;
								animation [Attack.name].speed = animation [Attack.name].length / AttackSpeed;
								animation.CrossFade (Attack.name, 0.15f);
			
								if (atime >= AttackSpeed * 0.35f & atime <= AttackSpeed * 0.48f) {
										if (KillList.Count > 0 & dealdamage) {
												int ls = KillList.Count;
												for (int i = 0; i < ls; i++) {
														Health hp = (Health)KillList [i].transform.GetComponent ("Health");
							
														hp.CurrentHealth = hp.CurrentHealth - Damage;
														if (hp.Dead) {
														} else if (hp.CurrentHealth <= 0)
																TotalAICount = TotalAICount - 1;
												}
												dealdamage = false;
										}
								}
			
								if (atime >= AttackSpeed) {
										kill = false;
										atime = 0;
								}
						} else {
								//RUN ANIMATION IF ANY ARROW KEYS ARE PRESSED
								if (Input.GetKey (KeyCode.UpArrow) | Input.GetKey (KeyCode.DownArrow) | Input.GetKey (KeyCode.RightArrow) | Input.GetKey (KeyCode.LeftArrow)) {
	
										animation.CrossFade (Run.name, 0.15f);	
								} else {
										animation.CrossFade (Idle.name, 0.15f);		
								}
						}
						//MOVEMENT
						if (Input.GetKey (KeyCode.UpArrow)) {
								transform.position += transform.forward * +movespeed * Time.deltaTime;
								Cam.transform.position += transform.forward * +(movespeed) * Time.deltaTime;
								transform.rotation = Quaternion.Euler (0, -90, 0);
								directionPlayer = -90;
	
						} else {
		
								if (Input.GetKey (KeyCode.DownArrow)) {
										transform.rotation = Quaternion.Euler (0, 90, 0);
										transform.position += transform.forward * +movespeed * Time.deltaTime;
										Cam.transform.position += transform.forward * +(movespeed) * Time.deltaTime;
										directionPlayer = 90;
				
								} else {
		
										if (Input.GetKey (KeyCode.RightArrow)) {
												transform.rotation = Quaternion.Euler (0, 0, 0);
												transform.position += transform.forward * +movespeed * Time.deltaTime;
												Cam.transform.position += transform.forward * +(movespeed) * Time.deltaTime;
												directionPlayer = 0;
		
										}
		
		
										if (Input.GetKey (KeyCode.LeftArrow)) {
												transform.rotation = Quaternion.Euler (0, -180, 0);
												transform.position += transform.forward * +movespeed * Time.deltaTime;
												Cam.transform.position += transform.forward * +(movespeed) * Time.deltaTime;
												directionPlayer = -180;
		
										}
								}
						}
				}
		}
	
		void OnTriggerEnter (Collider other)
		{
				//ADD AIS TO LIST TO INFLICT DAMAGE IF IN RANGE
				Health AI = (Health)other.transform.GetComponent ("Health");
				if (AI) {
						KillList.Add (other.transform);
			
				}
		}
	
		void OnTriggerExit (Collider other)
		{
				//REMOVE FROM LIST WHEN OUT OF RANGE
				Health AI = (Health)other.transform.GetComponent ("Health");
				if (AI) {
						KillList.Remove (other.transform);
			
				}
		}

		private Vector3 GetPosZone ()
		{
				Vector3 posZone = transform.position;
				if (directionPlayer == 90) {
						posZone.x = posZone.x + 2;
				} else if (directionPlayer == -90) {
						posZone.x = posZone.x - 2;
				} else if (directionPlayer == 0) {
						posZone.z = posZone.z + 2;
				}
				if (directionPlayer == -180) {
						posZone.z = posZone.z - 2;
				}
		
				return posZone;
		}
		
		void OnGUI ()
		{
				//HEALTH BAR AND AI COUNT
				Health php = (Health)GetComponent ("Health");
				if (php) {
						float hpp = php.CurrentHealth;
						GUI.Button (new Rect (0, 30, 300, 26), "Health: " + hpp);
				}
				GUI.Button (new Rect (0, 60, 300, 26), "Evil Skellies Left: " + TotalAICount);
				GUI.Button (new Rect (0, 90, 300, 26), "vie tour : " + vieTour);
				
				//Skill bar
				GUI.Box (new Rect (Screen.width / 2 - 178, Screen.height - 91, 345, 91), "", barre_comp);
				GUI.Box (new Rect (Screen.width / 2 - 160, Screen.height - 70, 70, 66), "", heal_zone);
				GUI.Box (new Rect (Screen.width / 2 - 80, Screen.height - 70, 70, 66), "", dmg_zone);
				GUI.Box (new Rect (Screen.width / 2, Screen.height - 70, 70, 66), "", buffatk_zone);
				GUI.Box (new Rect (Screen.width / 2 + 80, Screen.height - 70, 70, 66), "", slow_zone);

				//YOU WON!
				if (YouWon) {
						GUI.Box (new Rect (Screen.width / 2 - 150, Screen.height / 2 - 100, 300, 200), "Congratulations!  You have defeated all the Evil Skellies!");
						if (GUI.Button (new Rect (Screen.width / 2 - 60, Screen.height / 2 - 50, 120, 26), "Continue to level 2")) {
								YouWon = false;
								Application.LoadLevel (2);
						}
				}
				if (vieTour <= 0 || php.CurrentHealth <= 0) {
						GUI.Box (new Rect (Screen.width / 2 - 150, Screen.height / 2 - 100, 300, 200), "Game Over!");
						if (GUI.Button (new Rect (Screen.width / 2 - 60, Screen.height / 2 - 50, 120, 26), "restart level")) {
								
								Application.LoadLevel (1);
						}
				}
		
		}
	
}
