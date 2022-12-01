using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public HPBar hpBar;
    float hpValue = 100f;
    float hpMax = 100f; 

    // Respawn Point
    private Transform spawnPoint;
    private Transform playerPos;

    public bool poisoned = false;
    public bool healed = false;
    public bool pit = false;

    // Start is called before the first frame update
    void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
        spawnPoint = GameObject.FindGameObjectWithTag("Respawn").transform;
    }

    // respawn variable
    public void PlayerTakeDamage(float damage)
    {
        if(hpValue <= 0) {
            hpValue = hpMax;
            playerPos.position = new Vector3(spawnPoint.position.x, spawnPoint.position.y, spawnPoint.position.z);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(healed == true)
        {
            heal(0.1f);
        }
        
        if(poisoned == true)
        {
            takeDamage(0.05f);
        }   

        if(pit == true)
        {
            pitfall(100f);
        }
    }

    void pitfall(float damage)
        {
            hpValue -= damage;
            hpBar.SetValue(hpValue);
        }
    void takeDamage(float damage) 
        {
            hpValue -= damage;
            hpBar.SetValue(hpValue);
        }

    void heal(float healing) 
        {
            hpValue += healing;
            hpBar.SetValue(hpValue);
        }
}
