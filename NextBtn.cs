﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextBtn : MonoBehaviour
{

    public void NextButton()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
        
        
    }
}
