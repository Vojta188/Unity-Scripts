using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class CountdownTimer : MonoBehaviour
{
    
    public GameObject playWindow;
    float currentTime = 0f;
    float startingTime = 60f;
    
    


    [SerializeField] Text CountdownText;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        CountdownText.text = currentTime.ToString("0");

        if(currentTime <= 0)
        {
            playWindow.SetActive(true);
            Time.timeScale = 0;

            
            
            
            
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
