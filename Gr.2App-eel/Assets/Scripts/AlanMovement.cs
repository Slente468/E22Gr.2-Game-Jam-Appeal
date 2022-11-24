using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AlanMovement : MonoBehaviour
{
    

    [SerializeField] TextMeshProUGUI charge_Text;
    List<string> charge_Type = new List<string>
    {
        "negative charge",
        "positive charge"
    }; 
     

    public float movmentSpeed;
    // refrencing Rigidbody 2D, aka making a space to add it onto the code.
    public Rigidbody2D rb;

    private Vector2 moveDirction;

    public int alanCharge;  // false = neative charge
    //public int isCharged = 1;

    // Update is called once per frame

     void Start()
    {
        GetComponent<Rigidbody2D>();
        GetComponent<BulletActions>();
        
    }
    void Update()
    {
        MoveInputs();
        ChargeChange();


    }
    private void FixedUpdate()
    {
        // this is for the physics calculations ect. becuase FixedUpdates are called a bestemt amount of time pr. update loop vs. Update that's
        // once pr. frame
        Mov();
    }
    void MoveInputs() // to be called every frame, to check movement
    {
        float h_Input = Input.GetAxisRaw("Horizontal");
        float v_Input = Input.GetAxisRaw("Vertical");

        // normalize make the dirational movment to 1 instead of the 1.4 ish. it was on at defualt 
        moveDirction = new Vector2(h_Input, v_Input).normalized;
    }
    void Mov() // the science calculations to Alan's movement
    {
        rb.velocity = new Vector2(moveDirction.x * movmentSpeed, moveDirction.y * movmentSpeed);
    }

    void ChargeChange()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //can change alancharge between 0 / 1 - negative or positiv charge. 
        {
            if (alanCharge == 0)
            {
                alanCharge = 1;
                
            }
            else
            {
                
                
                

            }
            Debug.Log(alanCharge);
        }
    } 
  }
