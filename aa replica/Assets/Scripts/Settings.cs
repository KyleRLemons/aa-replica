using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using System;
using TMPro;

public class Settings : MonoBehaviour

    
{

   
    public TMP_InputField inputfieldname;
    public Slider sliderRotator;
    public TMP_InputField inputfieldSeconds;
    public Slider pinspeedSlider;
    public TMP_Dropdown dropdown;
    // Start is called before the first frame update
    void Start()
    {
        inputfieldname.text = PlayerPrefs.GetString("name");
        sliderRotator.value = PlayerPrefs.GetFloat("rotatorspeed");
        inputfieldSeconds.text = PlayerPrefs.GetString("seconds");
        pinspeedSlider.value = PlayerPrefs.GetFloat("pinspeed");
        dropdown.value = PlayerPrefs.GetInt("lives");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (EventSystem.current.IsPointerOverGameObject())
            {
                return;

            }
            else
            {
                SceneManager.LoadScene("MainLevel");
            }
            
        }

    }

    public void Slider(float val)
    {
        Rotator.speed = val;
    }
    public void TimerBox(string val)
    {
        int result = Int32.Parse(val);
        Score.startingTime = result;
    }

    public void NameTextBox(string val)
    {
        Score.PlayerName = val;
    }

    public void PinSlider(float val)
    {
        pin.speed = val;
    }

    public void LivesDropDown(int val)
    {
        if (val == 0)
        {
            pin.lives = 1;
        }
        else if (val == 1)
        {
            pin.lives = 2;
        }
        else if (val == 2)
        {
            pin.lives = 3;
        }
    }


    public void SaveButton()
    {
        PlayerPrefs.SetString("name", inputfieldname.text) ;
        PlayerPrefs.SetFloat("pinspeed", pinspeedSlider.value);
        PlayerPrefs.SetFloat("rotatorspeed", sliderRotator.value);
        PlayerPrefs.SetString("seconds", inputfieldSeconds.text);
        PlayerPrefs.SetInt("lives", dropdown.value);


    }
}
