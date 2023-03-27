using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DairelerManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] dairelerDizisi;


    void Start()
    {
        DaireleriKapat();
    }

    void Update()
    {
        
    }

    public void DaireleriKapat()
    {
        foreach (GameObject daireler in dairelerDizisi)
        {
            daireler.GetComponent<RectTransform>().localScale = Vector3.zero;
        }
    }

    public void DaireScaleAc(int hangiDaire)
    {
        dairelerDizisi[hangiDaire].GetComponent<RectTransform>().localScale = Vector3.one;

        if (hangiDaire % 5 == 0)
        {
            DaireleriKapat();
        }
    }

}
