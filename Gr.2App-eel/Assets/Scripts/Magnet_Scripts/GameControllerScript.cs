using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{
    public GameObject Bullet;

    private Rigidbody2D BulletRb;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Input.mousePosition;

            Vector2 instancePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            Instantiate(Bullet, instancePosition, Quaternion.identity);

        }
    }
}
