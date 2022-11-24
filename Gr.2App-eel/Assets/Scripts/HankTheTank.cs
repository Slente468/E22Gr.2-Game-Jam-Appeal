using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HankTheTank : MonoBehaviour
{
   //Code credit '2D Enemy Shooting Unity Tutorial' by MoreBBlakeyyy on Youtube
   public GameObject bullet_1;
   public GameObject bullet_2;
   public Transform bulletPos_1;
   public Transform bulletPos_2;
   private float timer;
   private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void FixedUpdate()
    {
        timer += Time.deltaTime;

        float distance = Vector2.Distance(transform.position, player.transform.position);
     

        if(distance < 30)
        {
            if(timer > 1)
            {
                timer = 0;
                shoot();
            }
        }

        if(distance < 30)
        {
            if(timer > 5)
            {
                timer = 0;
                fire();
            }
        }

    void shoot()
    {
        Instantiate(bullet_1, bulletPos_1.position, Quaternion.identity);
        
    }

    void fire()
    {
         Instantiate(bullet_2, bulletPos_2.position, Quaternion.identity);
    }
}
}
    
