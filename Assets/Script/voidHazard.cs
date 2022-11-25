using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class voidHazard : MonoBehaviour
{

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // When player falls to pit (hense void trigger) the player object gets deleted
    // 24/11/2022: for some reason, the player object doesn't delete when contacting void
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player") 
        {
            Destroy(player.gameObject);
            print("You've feel into the abyss" + collision.gameObject.tag);
        }
    }
}
