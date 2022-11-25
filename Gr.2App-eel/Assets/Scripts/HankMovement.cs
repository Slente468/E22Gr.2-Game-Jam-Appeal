using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HankMovement : MonoBehaviour
{
    public float speed;
    protected Rigidbody2D rb;
    public Vector2 direction;



    protected virtual void Start()
    {
        Debug.Log("Enemy Controller start");
        rb = gameObject.GetComponent<Rigidbody2D>();

        if (rb == null)
        {
            Debug.LogError("There is no Rigidbody on the object");
        }

    }
    private void FixedUpdate()
    {

        rb.MovePosition((Vector2)transform.position + direction * speed * Time.fixedDeltaTime);
        
       

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 surfaceNormal = collision.contacts[0].normal;

        float surfaceDot = Mathf.Abs(Vector2.Dot(surfaceNormal, Vector2.right));

       
        {
            direction = -direction;
        }


    }




}
