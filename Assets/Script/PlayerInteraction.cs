using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteraction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //public void button()
    //{
        //if(Input.GetKeyDown("k"))

    //}

    public void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.name =="LocationTrigger")
        {
            EventBus.Current.lightsGoOnTrigger();
        }

        if(collider.gameObject.name =="BridgeTrigger")
        {
           transform.position = new Vector3(0.1419716f, 0.3571978f, 72.11f);
        }
    }
}