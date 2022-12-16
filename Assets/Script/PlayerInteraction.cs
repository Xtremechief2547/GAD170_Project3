using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteraction : MonoBehaviour
{
    public bool endgame = false;
    public bool pit = false;
    public GameObject gameManager;
    public HPBar hpBar;
    public float playerHealth = 100f;
    private bool buttonpress = false;

    public void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.name =="LocationTrigger")
        {
            EventBus.Current.lightsGoOnTrigger();
        }

        if(collider.gameObject.name =="BridgeTrigger")
        {
            buttonpress = true;
            
        }

        if(collider.gameObject.name == "PyramidTrigger")
        {
            endgame = true;
        }
    
        if(collider.gameObject.tag == "Respawn")
        {
            EventBus.Current.ReloadScene();
        }

    
    }

    public void OnDestroy() 
    {
        EventBus.Current.SetHealth(playerHealth);
    }

    public void Start() 
    {
        playerHealth = EventBus.Current.ReturnHealth();
        
    }

    void Update()
    {
        if(Input.GetKeyDown("k") && endgame == true)
        {
            gameManager.GetComponent<GameManager>().PlayerVictory();
        }

        if(Input.GetKeyDown("k") && buttonpress == true)
        {
            //transform.position = new Vector3(0.1419716f, 0.3571978f, 72.11f);
            gameManager.GetComponent<GameManager>().BridgeInteract();
        }

        // this will cause a update script feature problem
        //if(collider.gameObject.tag == "Spike")
        //{
           //playerHealth -= 25;
        //}

    }
}