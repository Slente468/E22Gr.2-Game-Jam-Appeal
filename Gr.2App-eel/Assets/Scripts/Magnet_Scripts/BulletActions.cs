using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletActions : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D rb;
    public float force;
    private float timer;

    //Script for managing Bullet movement

    public float magnetStrength = 5f;
    public int magnetDirection = 1; // 1 = atraction -1 = Repel
    public bool looseMagnet = true;
    public float distanceStr = 10f; //Strentgh, based on the distance.

    private Transform trans;
    private Rigidbody2D thisRb;
    private Transform magnetTrans;
    private bool magnetInZone;

     void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;
    }
    private void Awake()
    {
        trans = transform;
        thisRb = trans.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 10)
        {
            Destroy(gameObject); //destroys the bullet after 10 sec
        }
    }



    private void FixedUpdate() // notices if collision between player and some magnet takes palce. Moves player magnet.
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
    private void OnTriggerEnter2D(Collider2D other) //registretion of magnet in zone 
    {
        if (other.tag == "Player")
        {
            magnetTrans = other.transform;
            magnetInZone = true;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D other) // 
    {
        if (other.tag == "Player" && looseMagnet)
        {
            magnetInZone = false;
        }

    }
}
