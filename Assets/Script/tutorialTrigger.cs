using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        print("welcome, follow the light");
        print("'a,w,s,d' to move and 'space' to jump");
    }
}
