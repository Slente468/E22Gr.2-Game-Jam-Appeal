using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HankTheTank : MonoBehaviour
{
   //Code credit '2D Enemy Shooting Unity Tutorial' by MoreBBlakeyyy on Youtube
   public GameObject bullet;
   public Transform bulletPos;

   private float timer;
   private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        timer += Time.deltaTime;

        float distance = Vector2.Distance(transform.position, player.transform.position);
        Debug.Log(distance);

        if(distance < 15)
        {
            if(timer > 5)
            {
                timer = 0;
                shoot();
            }
        }

    void shoot()
    {
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
    }
}
}
    
