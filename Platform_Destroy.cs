using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class platform_killer : MonoBehaviour
{
      void OnCollisionEnter2D (Collision2D col)
     {
         
         if(col.gameObject.name == "player")
         {
            Destroy(col.gameObject); 
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            
            
         }
     }
 }
