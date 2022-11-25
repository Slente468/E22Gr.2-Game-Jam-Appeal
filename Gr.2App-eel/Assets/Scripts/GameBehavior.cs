using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;


public class GameBehavior : MonoBehaviour
{
    private int _itemsCollected = 0;

    public int MaxItems = 4;

    public TMP_Text ItemText;
    public TMP_Text ProgressText;

    public Button WinButton;

    void Start()
    {
        //ItemText.text += _itemsCollected;
    }
    public int Items
    {
        
        get 
        { 
            return _itemsCollected; 
        }
        
        set
        {
            _itemsCollected = value;
            //ItemText.text = "Parts collected" + Items;

            if(_itemsCollected >= MaxItems)
            {
                //ProgressText.text = "U collected all the parts";

                WinButton.gameObject.SetActive(true);

                Time.timeScale = 0f;
            }
            else
            {
                ProgressText.text = "Parts left" + (MaxItems - _itemsCollected);
            }
        }
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
    }
}
