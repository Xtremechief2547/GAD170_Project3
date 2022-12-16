using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public GameObject victoryText;
    public GameObject player;
    public GameObject Bridge;

    public void Start()
    {
        print("welcome, follow the light");
        print("'a,w,s,d' to move, 'space' to jump and 'k' to touch stuff");
    }

    public void PlayerVictory()
    {
        victoryText.SetActive(true);
        player.GetComponent<PlayerMovement>().enabled = false;
    }

    public void BridgeInteract()
    {
        Bridge.SetActive(true);
        transform.position = new Vector3(0.1419716f, 0.3571978f, 72.11f);
    }
}
