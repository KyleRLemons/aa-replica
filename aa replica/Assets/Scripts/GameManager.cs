using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Rotator rotator;
    public Spawner spawner;
    private bool gameHasEnded = false;
    public Animator animator;
    public bool ispaused = false;

    public GameObject canvas;
    public GameObject canvaspause;
    public void EndGame()
    {
        if (gameHasEnded)
        {
            return;
        }
        rotator.enabled = false;
        spawner.enabled = false;
        gameHasEnded = true;
        Debug.Log("End Game");
        animator.SetTrigger("EndGame");
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (ispaused)
            {
                Time.timeScale = 1;
                ispaused = false;
                canvaspause.SetActive(false);
                canvas.SetActive(true);
            }
            else if(ispaused == false)
            {
                Time.timeScale = 0;
                ispaused = true;
                canvas.SetActive(false);
                canvaspause.SetActive(true);
            }
        }
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene("End");
    }

    public void SaveButton()
    {
        PlayerPrefs.SetString("name", Score.PlayerName);

    }

}
