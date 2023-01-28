using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetAction : MonoBehaviour
{   // Code inspired by Rescpect Studios
    // script for managing magnet movement

    public Vector2 newPosition; // Target location
    

    private Transform trans; // The transform of this object

    private void Awake()
    {
        trans = transform;
    }

    private void Update()
    {
        // This sets the location to newPosition like a snap.
        trans.position = Vector2.Lerp(trans.position, newPosition, Time.deltaTime * 1.5f);
        
        if (Mathf.Abs(newPosition.x - trans.position.x) < 0.05)
            trans.position = newPosition;
    }

 
   
}
