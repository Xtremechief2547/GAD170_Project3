using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventBus : MonoBehaviour {

    private static EventBus _current;

    public static EventBus Current { get { return _current; } }

    public event Action lightsGoOn;
    public event Action lightsGoOff;
    public GameObject player;

    float newHp;

    private void Awake()
    {
        if (_current != null && _current != this)
        {
            Destroy(this.gameObject);
        } else {
            _current = this;

            DontDestroyOnLoad(gameObject);
        }
    }

    public void lightsGoOnTrigger()
    {
        lightsGoOn();
    }

    public void lightsGoOffTrigger()
    {
        lightsGoOff();
    }

    public void SetHealth(float playerHealth)
    {
        newHp = playerHealth;
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public float ReturnHealth()
    {
        return newHp;
    }
    
    

}