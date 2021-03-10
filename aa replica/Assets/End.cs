using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using TMPro;

public class End : MonoBehaviour
{
    public TextMeshProUGUI scoretext;

    public static int score;
    // Start is called before the first frame update
    void Start()
    {
        
        scoretext.text = Score.PlayerName + "'s score: " + score;

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
                SceneManager.LoadScene("Intro");
            }

        }
    }

    public void Quit()
    {
        Application.Quit();
        
    }
}
