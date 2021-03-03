using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using System;
public class Settings : MonoBehaviour

    
{
    // Start is called before the first frame update
    void Start()
    {
        
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
}
