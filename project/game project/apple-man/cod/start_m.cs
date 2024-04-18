using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start_m : MonoBehaviour
{
    public void startgame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 

    }
    
    public void quitgame()
    {
        Application.Quit();
    }
    
    
    

    
    
    
    
    
}
