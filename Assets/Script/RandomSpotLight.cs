using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpotLight : MonoBehaviour
{
     //Spawn this object
     public float maxTime = 5f;
     public float minTime = 2f;
 
     //current time
     private float time;
 
     //The time to spawn the object
     private float triggerTimer;
 
     void Start(){
         SetRandomTime();
         time = minTime;
     }
 
     void FixedUpdate(){
 
         //Counts up
         time += Time.deltaTime;
 
         //Check if its the right time to spawn the object
         if(time >= triggerTimer){
             TriggerTimerEvent();
             SetRandomTime();
         }
 
     }
 
 
     //Spawns the object and resets the time
     void TriggerTimerEvent(){
         time = minTime;
         EventBus.Current.lightsGoOffTrigger();
     }
       
     //Sets the random time between minTime and maxTime
     void SetRandomTime(){
         triggerTimer = Random.Range(minTime, maxTime);
     }

    
}
