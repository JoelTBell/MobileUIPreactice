using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBeahvior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          if (PauseScreenBehavior.paused)
        {
        return;
        }
    }

    /// <summary>
    /// FixedUpdate is called at a fixed framerate and is a prime place
    /// to put
    /// Anything based on time.
    /// </summary>
    void FixedUpdate()
    {
 // If the game is paused, don't do anything
        if (PauseScreenBehavior.paused)
        {
        return;
        }

    }
}
