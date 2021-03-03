using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class Score : MonoBehaviour
{
    // Start is called before the first frame update

    public static int PintCount = 0;
    float currentTime = 0f;
    public static float startingTime = 10f;
    public TextMeshProUGUI countdownText;
    public TextMeshProUGUI text;
    void Start()
    {
        currentTime = startingTime;
        PintCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("00");
        text.text = PintCount.ToString();
        End.score = PintCount;
        if(currentTime <= 0)
        {
            SceneManager.LoadScene("End");
            currentTime = 0;      
            
        }
    }
}
