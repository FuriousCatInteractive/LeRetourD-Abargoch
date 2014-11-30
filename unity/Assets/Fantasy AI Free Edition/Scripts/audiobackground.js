#pragma strict


var isPlaying : boolean = false;
 var thisSound : AudioSource; 
 var myClips : Object[];

function Start(){ 
myClips = Resources.LoadAll("Assets/epic",AudioClip); 
}

function OnTriggerEnter(){
 if(isPlaying == false){ 
 isPlaying = true; audio.clip = myClips[Random.Range(0, myClips.Length)]; 
 audio.Play();
  }
   }

function OnTriggerExit(){
 if(isPlaying == true){
  isPlaying = false; audio.Stop();
   } 
   } 