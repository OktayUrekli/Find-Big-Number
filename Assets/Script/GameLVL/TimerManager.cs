using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    GameManager gameManager;

    [SerializeField]
    private Text sureText;
    
    int kalansure;
    bool sureSayilsinmi;

    private void Awake()
    {
        gameManager= Object.FindObjectOfType<GameManager>();
    }

    void Start()
    {
        kalansure = 30;
        sureSayilsinmi = true;
    }

   public void SureyiBaslat()
    {
        StartCoroutine(SureTimerRoutine());
    }

    IEnumerator SureTimerRoutine()
    {
        while (sureSayilsinmi)
        {
            
            sureText.text = kalansure.ToString();
            yield return new WaitForSeconds(1f);
            kalansure--;
            if (kalansure<0)
            {
                sureSayilsinmi = false;
            }
            
        }
        if (sureSayilsinmi==false)
        {
            gameManager.oyunbitti();
        }
       
       

       
    }
    
}
