using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pin : MonoBehaviour
{

    public static float speed = 20f;
    public Rigidbody2D rb;
    private bool isPinned = false;
    public static int lives = 1;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!isPinned)
            rb.MovePosition(rb.position + Vector2.up * speed * Time.fixedDeltaTime);


    }
   
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Rotator"))
        {
            transform.SetParent(collider.transform);
            //Score.PinCount++;
            isPinned = true;
            Score.PintCount++;
        }
        else if (collider.CompareTag("Pin"))
        {
            
            if (lives <= 1)
            {
                
                FindObjectOfType<GameManager>().EndGame();
                

            }
            else
            {
                lives = lives - 1;

                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            
        }
    }
}
