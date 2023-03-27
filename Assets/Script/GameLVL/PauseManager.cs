using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseManager : MonoBehaviour
{

    [SerializeField]
    private GameObject pausePnl;

    private void OnEnable()
    {
        Time.timeScale=0f;
    }

    private void OnDisable()
    {
        Time.timeScale = 1f;
    }

    public void PausePaneliKapat()
    {
        pausePnl.SetActive(false);
    }

    public void MenuyeDon()
    {
        SceneManager.LoadScene("MenuLevel");
    }

    public void OyundanCýk()
    {
        Application.Quit();
    }
}
