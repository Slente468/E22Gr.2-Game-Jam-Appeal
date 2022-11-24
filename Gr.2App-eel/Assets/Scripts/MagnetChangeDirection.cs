 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetChangeDirection : MonoBehaviour
{
    public Vector2 magnetDirection;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Magnet")
            other.GetComponent<MagnetAction>().newPosition = magnetDirection;
    }
}
