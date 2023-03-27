using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SonucManager : MonoBehaviour
{
    [SerializeField]
    private Text dogruAdetText,yanl�sAdetText,puanText;

    int topPuan, art�sMiktar�,yazd�r�lacakPuan;
    bool sureBittimi;

    

    private void Awake()
    {
        sureBittimi = true;
        
    }

    void Start()
    {
        StartCoroutine(ritmikArtt�r());
        art�sMiktar� = 25;
        yazd�r�lacakPuan = 0;
    }

    public void Sonuclar�Yaz(int dogruSayisi,int yanl�sSayisi,int puan)
    {
        dogruAdetText.text = dogruSayisi.ToString();
        yanl�sAdetText.text=yanl�sSayisi.ToString() ;            
        topPuan = puan;      
    }

    IEnumerator ritmikArtt�r()
    {
       
        while (sureBittimi)
        {
            yield return new WaitForSeconds(0.1f);          
            puanText.text=yazd�r�lacakPuan.ToString();
            yazd�r�lacakPuan += art�sMiktar�;

            if (yazd�r�lacakPuan>=topPuan)
            {
                sureBittimi = false;
            }
        }
    }

    public void AnaMenuyeDon()
    {
        SceneManager.LoadScene("MenuLevel");
    }

    public void TekrarOyna()
    {
        SceneManager.LoadScene("GameLevel");
    }


}
