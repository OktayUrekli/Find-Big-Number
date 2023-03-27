using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeriSayimManager : MonoBehaviour
{
    [SerializeField]
    private GameObject GeriSayimObj;

    [SerializeField]
    private Text GeriSayimTxt;

    GameManager gameManager;

    public void Awake()
    {
        gameManager=Object.FindObjectOfType<GameManager>();
    }

    void Start()
    {
        StartCoroutine(GeriSayRoutine());
    }

    IEnumerator GeriSayRoutine()
    {
        
        yield return new WaitForSeconds(0.7f) ;
        GeriSayimTxt.text = "Oyun Baþladý";
        gameManager.oyunaBasla();
    }
    
}
