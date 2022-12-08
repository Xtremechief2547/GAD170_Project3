using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLightController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        EventBus.Current.lightsGoOn += turnLightOn;
        EventBus.Current.lightsGoOff += turnLightOff;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void turnLightOn() {
        gameObject.GetComponent<Light>().enabled = true;
    }

    private void turnLightOff() {
        gameObject.GetComponent<Light>().enabled = false;
    }
}