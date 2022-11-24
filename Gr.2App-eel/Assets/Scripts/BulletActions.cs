using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletActions : MonoBehaviour
{

    //Script for managing Bullet movement

    public float magnetStrength = 5f;
    public int magnetDirection = 1; // 1 = atraction -1 = Repel
    public bool looseMagnet = true;
    public float distanceStr = 10f; //Strentgh, based on the distance.

    private Transform trans;
    private Rigidbody2D thisRb;
    private Transform magnetTrans;
    private bool magnetInZone;

    private void Awake()
    {
        trans = transform;
        thisRb = trans.GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        if (magnetInZone)
        {
            Vector2 directionToMagnet = magnetTrans.position - trans.position;
            float distance = Vector2.Distance(magnetTrans.position, trans.position);
            float magnetDistanceStr = (distanceStr/ distance) * magnetStrength;

            thisRb.AddForce(magnetDistanceStr * (directionToMagnet * magnetDirection),
                ForceMode2D.Force);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Magnet")
        {
            magnetTrans = other.transform;
            magnetInZone = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Magnet" && looseMagnet)
        {
            magnetInZone = false;
        }

    }
}
