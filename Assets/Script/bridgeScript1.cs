using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bridgeScript1 : MonoBehaviour
{
    public Transform Spawnpoint;
    public Rigidbody Prefab;

    //Summons bridge object via trigger
    void OnTriggerEnter()
    {
        Rigidbody RigidPrefab;
        RigidPrefab = Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation)as Rigidbody;
    }
}
