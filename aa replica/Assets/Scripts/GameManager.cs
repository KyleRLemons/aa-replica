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
        
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene("End");
    }
}
