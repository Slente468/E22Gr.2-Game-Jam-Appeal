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
   private float timer_1;
   private float timer_2;
   private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void FixedUpdate()
    {
        timer_1 += Time.deltaTime;
        timer_2 += Time.deltaTime;

        float distance = Vector2.Distance(transform.position, player.transform.position);
        Debug.Log(distance);

        if(distance < 30)
        {
            if(timer_1 > 1)
            {
                timer_1 = 0;
                shoot();
            }
        }

        if(distance < 30)
        {
            if(timer_2 > 5)
            {
                timer_2 = 0;
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
    
