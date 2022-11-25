using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.UI;

public class ItemBehavior : MonoBehaviour
{
    private bool pickUpAllowed;
    public GameBehavior GameManager;
    // Use this for initialization
    void Start()
    {
        GameManager = GameObject.Find("Game_Manager").GetComponent<GameBehavior>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.E))
            PickUp();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Alan"))
        {
            pickUpAllowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Alan"))
        {
            pickUpAllowed = false;
        }
    }
    private void PickUp()
    {
        Destroy(gameObject);

        GameManager.Items += 1;

    }
}