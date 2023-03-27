using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SonucManager : MonoBehaviour
{
    [SerializeField]
    private Text dogruAdetText,yanlýsAdetText,puanText;

    int topPuan, artýsMiktarý,yazdýrýlacakPuan;
    bool sureBittimi;

    

    private void Awake()
    {
        sureBittimi = true;
        
    }

    void Start()
    {
        StartCoroutine(ritmikArttýr());
        artýsMiktarý = 25;
        yazdýrýlacakPuan = 0;
    }

    public void SonuclarýYaz(int dogruSayisi,int yanlýsSayisi,int puan)
    {
        dogruAdetText.text = dogruSayisi.ToString();
        yanlýsAdetText.text=yanlýsSayisi.ToString() ;            
        topPuan = puan;      
    }

    IEnumerator ritmikArttýr()
    {
       
        while (sureBittimi)
        {
            yield return new WaitForSeconds(0.1f);          
            puanText.text=yazdýrýlacakPuan.ToString();
            yazdýrýlacakPuan += artýsMiktarý;

            if (yazdýrýlacakPuan>=topPuan)
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
