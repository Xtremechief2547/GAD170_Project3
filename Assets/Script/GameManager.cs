using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public GameObject victoryText;
    public GameObject player;

    public void Start()
    {
        print("welcome, follow the light");
        print("'a,w,s,d' to move and 'space' to jump");
    }

    public void PlayerVictory()
    {
        victoryText.SetActive(true);
        player.GetComponent<PlayerMovement>().enabled = false;

    }
}
