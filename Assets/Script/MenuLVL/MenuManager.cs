using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuManager : MonoBehaviour
{
    

    private void Start()
    {
            
    }


    public void OyunaBasla()
    {
        SceneManager.LoadScene("GameLevel");
    }
}
