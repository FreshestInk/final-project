using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class KYLE : MonoBehaviour
{
    public InputField inp;
  
    public void PlayGame()
    {
        if(inp.text == "KYLE")
        { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        
        }
       
    }
}
