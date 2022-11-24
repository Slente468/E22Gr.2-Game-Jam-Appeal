using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Charge_Changer : MonoBehaviour
{
    public int alanCharge;

    [SerializeField] TextMeshProUGUI charge_Text;
    List<string> charge_Type = new List<string>
    {
        "negative charge",
        "positive charge"
    };
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (alanCharge == 0)
        {
            charge_Text.text = charge_Type[0];
        }
        else
        {
            charge_Text.text = charge_Type[1];
        }
    }

}
